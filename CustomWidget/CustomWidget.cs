using System;
using System.Collections.Generic;
using System.Xml.Linq;

using Composite.Functions;
using Composite.Functions.Plugins.WidgetFunctionProvider;
using Composite.C1Console.Security;
using Composite.Core.Xml;
using Composite.C1Console.Elements;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using Microsoft.Practices.ObjectBuilder;

namespace CustomWidget
{
    [ConfigurationElementType(typeof(MyWidgetFunctionProviderData))]
    class MyWidgetFunctionProvider : IWidgetFunctionProvider, IDynamicTypeWidgetFunctionProvider
    {
        // Called by the system to provide you with an object you can use to
        // Notify the system about ad hoc introduction of new widget functions
        // Not used in this sample.
        public WidgetFunctionNotifier WidgetFunctionNotifier
        {
            set { }
        }
        public IEnumerable<IWidgetFunction> Functions
        {
            get
            {
                // Return just one widget function here.
                yield return new SampleWidgetFunction();
            }
        }

        public IEnumerable<IWidgetFunction> DynamicTypeDependentFunctions
        {
            get { yield break; }
        }

    }

    [Assembler(typeof(MyWidgetFunctionProviderAssembler))]
    public class MyWidgetFunctionProviderData : WidgetFunctionProviderData
    {
        // No custom configuration in this sample...
    }

    public sealed class MyWidgetFunctionProviderAssembler
        : IAssembler<IWidgetFunctionProvider, WidgetFunctionProviderData>
    {
        public IWidgetFunctionProvider Assemble(IBuilderContext context,
            WidgetFunctionProviderData objectConfiguration, IConfigurationSource configurationSource,
            ConfigurationReflectionCache reflectionCache)
        {
            return new MyWidgetFunctionProvider();
        }
    }

    /// <summary>
    /// This class is a concrete windget function, returned by the provider.
    /// </summary>
    public class SampleWidgetFunction : IWidgetFunction
    {
        // Called by the system when Form UI Control markup is required from this widget function.
        // The parameters contain your "widget configuration". You can define your parameters using
        // the ParameterProfiles properties below.
        public XElement GetWidgetMarkup(ParameterList parameters, string label,
            HelpDefinition helpDefinition, string bindingSourceName)
        {
            return new XElement(Namespaces.BindingFormsStdUiControls10 + "DateTimeSelector",
                new XAttribute("Label", label),
                new XAttribute("Help", helpDefinition.HelpText),
                    new XElement(Namespaces.BindingForms10 + "bind",
                        new XAttribute("source", bindingSourceName)));
        }

        public string Name
        {
            get { return "SampleWidgetFunction"; }
        }

        public string Namespace
        {
            get { return "Sample.Widget.Namespace"; }
        }

        // This sample widget can handle string data
        public Type ReturnType
        {
            get { return typeof(string); }
        }

        public string Description
        {
            get { return "This is the description of the sample widget from our sample provider"; }
        }

        // No prameters used in this sample
        public IEnumerable<ParameterProfile> ParameterProfiles
        {
            get { yield break; }
        }

        // This returns a "security ID" for this widget function.
        // It permissions are attached to this widget function the object returned here is used to
        // identify those settings.
        public EntityToken EntityToken
        {
            get { return new SampleWidgetFunctionEntityToken(this.Name); }
        }
    }

    /// <summary>
    /// This class describes the sample widget functions "entity token" - an artifact 
    /// used to identify data and elements in the security system.
    /// </summary>
    [SecurityAncestorProvider(typeof(NoAncestorSecurityAncestorProvider))]
    public class SampleWidgetFunctionEntityToken : EntityToken
    {
        private string _id;

        internal SampleWidgetFunctionEntityToken(string id)
        {
            _id = id;
        }

        public override string Id { get { return _id; } }
        public override string Source { get { return ""; } }
        public override string Type { get { return ""; } }

        // Responsible for serializing the state of this EntityToken as a string
        public override string Serialize()
        {
            return _id;
        }

        // Respinsible for deserializing the string return by the serializer above
        public static EntityToken Deserialize(string serializedEntityToken)
        {
            return new SampleWidgetFunctionEntityToken(serializedEntityToken);
        }
    }

    internal sealed class NoAncestorSecurityAncestorProvider : ISecurityAncestorProvider
    {
        public IEnumerable<EntityToken> GetParents(EntityToken entityToken)
        {
            yield return AttachingPoint.PerspectivesRoot.EntityToken;
        }
    }
}