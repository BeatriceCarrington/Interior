namespace Rain {
    
    
    [Composite.Data.AutoUpdatebleAttribute()]
    [Composite.Data.DataScopeAttribute("public")]
    [Composite.Data.RelevantToUserTypeAttribute("Developer")]
    [Composite.Data.CodeGeneratedAttribute()]
    [Composite.Data.Hierarchy.DataAncestorProviderAttribute(typeof(Composite.Data.Hierarchy.DataAncestorProviders.NoAncestorDataAncestorProvider))]
    [Composite.Data.ImmutableTypeIdAttribute("cfeae905-38b3-43f9-8079-b2ebb348a693")]
    [Composite.Core.WebClient.Renderings.Data.KeyTemplatedXhtmlRendererAttribute(Composite.Core.WebClient.Renderings.Data.XhtmlRenderingType.Embedable, "<span>{label}</span>")]
    [Composite.Data.TitleAttribute("aaa")]
    [Composite.Data.LabelPropertyNameAttribute("bbb")]
    public interface aaa : Composite.Data.IData, Composite.Data.ProcessControlled.ILocalizedControlled, Composite.Data.ProcessControlled.IProcessControlled, Composite.Data.IPageData, Composite.Data.IPageMetaData, Composite.Data.ProcessControlled.IPublishControlled {
        
        [Composite.Data.ImmutableFieldIdAttribute("5d60aaf9-8cc0-4953-ba8c-83fe59fafdec")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 64)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(0)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 64)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string bbb {
            get;
            set;
        }
    }
}
