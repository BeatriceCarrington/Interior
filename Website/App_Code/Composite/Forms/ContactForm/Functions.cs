﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.Configuration;
using System.Xml.Linq;
using System.Collections;
using Composite.Core;
using Composite.Data;
using Composite.Core.WebClient.Captcha;
using System.Text.RegularExpressions;
using System.Net.Mail;
using Composite.Data.DynamicTypes;
using Composite.Core.Types;
using Composite.Data.Types;

namespace Composite.Forms.ContactForm
{
    public class Functions
    {
        public const string EmailPattern = @"^[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+(?:[A-Za-z]{2}|com|org|net|gov|mil|biz|info|mobi|name|aero|jobs|museum|coop|pro)\b$";
        public Functions()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static IEnumerable<XElement> Send(string fromName, string fromEmail, string toEmail, string messageSubject, string message, string company, string website, string address, string phonenumber, string captcha, string captchaEncryptedValue, bool useCaptcha, Guid emailTemplateId)
        {
            bool isSmtpConfigured = IsSmtpConfigured();
            var catpchaIsValid = useCaptcha ? Captcha.IsValid(captcha, captchaEncryptedValue) : true;
            var currentPageId = SitemapNavigator.CurrentPageId;

            #region SubmittedData
            yield return new XElement("SubmittedData",
                                new XAttribute("Fieldname", "fromName"),
                                new XAttribute("Value", fromName));
            yield return new XElement("SubmittedData",
                            new XAttribute("Fieldname", "fromEmail"),
                            new XAttribute("Value", fromEmail));
            yield return new XElement("SubmittedData",
                            new XAttribute("Fieldname", "toEmail"),
                            new XAttribute("Value", toEmail));
            yield return new XElement("SubmittedData",
                            new XAttribute("Fieldname", "messageSubject"),
                            new XAttribute("Value", messageSubject));
            yield return new XElement("SubmittedData",
                            new XAttribute("Fieldname", "message"),
                            new XAttribute("Value", message));
            yield return new XElement("SubmittedData",
                            new XAttribute("Fieldname", "company"),
                            new XAttribute("Value", company));
            yield return new XElement("SubmittedData",
                            new XAttribute("Fieldname", "website"),
                            new XAttribute("Value", website));
            yield return new XElement("SubmittedData",
                            new XAttribute("Fieldname", "address"),
                            new XAttribute("Value", address));
            yield return new XElement("SubmittedData",
                            new XAttribute("Fieldname", "phonenumber"),
                            new XAttribute("Value", phonenumber));
            #endregion

            #region Check Errors
            if (!isSmtpConfigured || !catpchaIsValid || string.IsNullOrEmpty(fromName) || string.IsNullOrEmpty(message) || !Regex.IsMatch(fromEmail, EmailPattern, RegexOptions.IgnoreCase))
            {
                var errorText = new Hashtable();

                if (!isSmtpConfigured)
                {
                    errorText.Add("missingSMTP", GetLocalized("ContactForm", "missingSMTP"));
                }

                if (string.IsNullOrEmpty(fromName))
                {
                    errorText.Add("fromName", GetLocalized("ContactForm", "emptyFromNameError"));
                }
                if (string.IsNullOrEmpty(message))
                {
                    errorText.Add("message", GetLocalized("ContactForm", "emptyMessageError"));
                }

                if (!Regex.IsMatch(fromEmail, EmailPattern, RegexOptions.IgnoreCase))
                {
                    errorText.Add("fromEmail", GetLocalized("ContactForm", "incorrectEmailError"));
                }

                if (!catpchaIsValid)
                {
                    errorText.Add("captcha", GetLocalized("ContactForm", "incorrectCaptchaError"));
                }

                foreach (string key in errorText.Keys)
                {
                    yield return new XElement("Error",
                                 new XAttribute("Fieldname", key),
                                 new XAttribute("ErrorDescription", errorText[key].ToString()));
                }
            }
            #endregion

            #region Save data and send Email
            else
            {
                using (var conn = new DataConnection())
                {
                    const string treeId = "Composite.Forms.ContactForm.xml";
                    if (!conn.Get<IDataItemTreeAttachmentPoint>().Any(p => p.KeyValue == currentPageId.ToString() && p.TreeId == treeId))
                    {
                        var tree = conn.CreateNew<IDataItemTreeAttachmentPoint>();
                        tree.Id = Guid.NewGuid();
                        tree.TreeId = treeId;
                        tree.Position = "Top";
                        tree.KeyValue = currentPageId.ToString();
                        tree.InterfaceType = typeof(IPage).ToString();
                        conn.Add(tree);
                    }

                    var newContactFormData = conn.CreateNew<ContactFormData>();
                    newContactFormData.Id = Guid.NewGuid();
                    newContactFormData.PageId = SitemapNavigator.CurrentPageId;
                    newContactFormData.Name = fromName;
                    newContactFormData.Email = fromEmail;
                    newContactFormData.Subject = messageSubject;
                    newContactFormData.Message = message;
                    newContactFormData.IP = HttpContext.Current.Request.UserHostName;
                    newContactFormData.Date = DateTime.Now;
                    newContactFormData.Company = company;
                    newContactFormData.Website = website;
                    newContactFormData.Address = address;
                    newContactFormData.PhoneNumber = phonenumber;

                    conn.Add(newContactFormData);

                    #region Send Email
                    // Get Email template and fill it with item fields values.
                    var emailTemplate = conn.Get<EmailTemplate>().SingleOrDefault(e => e.Id == emailTemplateId);
                    if (emailTemplate != null)
                    {
                        try
                        {
                            XDocument document = ResolveFields(newContactFormData, emailTemplate);
                            var subject = string.Format("{0}: {1}", emailTemplate.Subject, (messageSubject != string.Empty ? messageSubject : fromName));
                            SendEmail(fromName, fromEmail, "", toEmail, subject, document.ToString());
                        }
                        catch (Exception ex)
                        {
                            Log.LogError("Composite.Forms.ContactForm", ex);
                        }
                    }
                    else
                    {
                        Log.LogInformation("Composite.Forms.ContactForm", "Email was not sent because of EmailTemplate was not found.");
                    }
                    #endregion
                }
            }
            #endregion
        }

        // This function is used in form markup ~\App_Data\Composite\DynamicTypeForms\Composite\Forms\ContactForm\EmailTemplate.xml to get embeded fileds in content editor
        public static Type GetEmbedableFieldsTypes()
        {
            return typeof(ContactFormData);
        }

        private static void SendEmail(string fromName, string fromEmail, string toName, string toEmail, string subject, string body)
        {
            MailMessage mailMessage = new MailMessage();
            var from = new MailAddress(fromEmail, fromName);
            var to = new MailAddress(toEmail, toName);
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = subject;
            mailMessage.To.Add(to);
            mailMessage.From = from;
            var smtp = new SmtpClient();
            smtp.Send(mailMessage);
        }

        private static XDocument ResolveFields(ContactFormData dataItem, EmailTemplate emailTemplate)
        {
            XDocument document = XDocument.Parse(emailTemplate.Template);
            Type interfaceType = typeof(Composite.Forms.ContactFormData);
            var properties = interfaceType.GetPropertiesRecursively();

            List<DynamicTypeMarkupServices.FieldReferenceDefinition> references =
                    DynamicTypeMarkupServices.GetFieldReferenceDefinitions(document, "Composite.Forms.ContactFormData").ToList();
            if (references.Count() == 0)
            {
                references = DynamicTypeMarkupServices.GetFieldReferenceDefinitions(document, "DynamicType:Composite.Forms.ContactFormData").ToList();
            }
            foreach (DynamicTypeMarkupServices.FieldReferenceDefinition reference in references)
            {
                var pr = properties.Find(p => p.Name == reference.FieldName);
                if (pr != null)
                {
                    var prValue = pr.GetValue(dataItem, null).ToString().Replace(Environment.NewLine, "<br/>");
                    XElement xl = XElement.Parse(String.Format("<span>{0}</span>", prValue));
                    reference.FieldReferenceElement.ReplaceWith(xl);
                }
            }
            return document;
        }

        public static string GetLocalized(string resourceName, string key)
        {
            var ro = HttpContext.GetGlobalResourceObject(resourceName, key);
            return ro == null ? string.Empty : ro.ToString();
        }

        public static bool IsSmtpConfigured()
        {
            Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
            var settings = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");
            return (settings.Smtp.DeliveryMethod.ToString() == "Network" && settings.Smtp.Network.Host == null) ? false : true;
        }
    }
}