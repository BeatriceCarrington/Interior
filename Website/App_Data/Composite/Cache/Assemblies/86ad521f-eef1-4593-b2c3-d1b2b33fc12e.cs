namespace Content {
    
    
    [Composite.Data.AutoUpdatebleAttribute()]
    [Composite.Data.DataScopeAttribute("public")]
    [Composite.Data.RelevantToUserTypeAttribute("Developer")]
    [Composite.Data.CodeGeneratedAttribute()]
    [Composite.Data.Hierarchy.DataAncestorProviderAttribute(typeof(Composite.Data.Hierarchy.DataAncestorProviders.NoAncestorDataAncestorProvider))]
    [Composite.Data.ImmutableTypeIdAttribute("86ad521f-eef1-4593-b2c3-d1b2b33fc12e")]
    [Composite.Core.WebClient.Renderings.Data.KeyTemplatedXhtmlRendererAttribute(Composite.Core.WebClient.Renderings.Data.XhtmlRenderingType.Embedable, "<span>{label}</span>")]
    [Composite.Data.KeyPropertyNameAttribute("Id")]
    [Composite.Data.TitleAttribute("Content Spots")]
    [Composite.Data.LabelPropertyNameAttribute("Title")]
    [Composite.Data.PublishProcessControllerTypeAttribute(typeof(Composite.Data.ProcessControlled.ProcessControllers.GenericPublishProcessController.GenericPublishProcessController))]
    [Composite.Data.CachingAttribute(Composite.Data.CachingType.Full)]
    public interface ContentSpot : Composite.Data.IData, Composite.Data.ProcessControlled.IPublishControlled, Composite.Data.ProcessControlled.IProcessControlled {
        
        [Composite.Data.ImmutableFieldIdAttribute("0529b299-b2a2-424d-8e16-065d70571ad3")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function name=\"Composite.Utils.Guid.NewGuid\" xmlns:f=\"http://www.composite.net" +
            "/ns/function/1.0\" />")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(-1)]
        System.Guid Id {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("c68429ed-74c3-4ad6-afee-b6364f80f224")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 64)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(0)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 64)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Title {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("c3056b59-3982-47ee-8d3a-e41436552d78")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.LargeString)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(1)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Content {
            get;
            set;
        }
    }
}
