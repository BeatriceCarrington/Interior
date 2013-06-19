namespace Rain {
    
    
    [Composite.Data.AutoUpdatebleAttribute()]
    [Composite.Data.DataScopeAttribute("public")]
    [Composite.Data.RelevantToUserTypeAttribute("Developer")]
    [Composite.Data.CodeGeneratedAttribute()]
    [Composite.Data.Hierarchy.DataAncestorProviderAttribute(typeof(Composite.Data.Hierarchy.DataAncestorProviders.NoAncestorDataAncestorProvider))]
    [Composite.Data.ImmutableTypeIdAttribute("e93807b4-55b7-4008-904c-868f2d998811")]
    [Composite.Core.WebClient.Renderings.Data.KeyTemplatedXhtmlRendererAttribute(Composite.Core.WebClient.Renderings.Data.XhtmlRenderingType.Embedable, "<span>{label}</span>")]
    [Composite.Data.KeyPropertyNameAttribute("Id")]
    [Composite.Data.TitleAttribute("Gallery")]
    [Composite.Data.LabelPropertyNameAttribute("Title")]
    public interface Gallery : Composite.Data.IData {
        
        [Composite.Data.ImmutableFieldIdAttribute("a30f82cd-530c-49d9-b535-ab482752a20a")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function name=\"Composite.Utils.Guid.NewGuid\" xmlns:f=\"http://www.composite.net" +
            "/ns/function/1.0\" />")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(-1)]
        System.Guid Id {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("6a31321c-c622-483b-b6da-7c496fc1037c")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 64)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(0)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 64)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Title {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("b49fcc03-4d73-47d1-bdc0-1a6657175796")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function xmlns:f=\"http://www.composite.net/ns/function/1.0\" name=\"Composite.Co" +
            "nstant.XhtmlDocument\"><f:param name=\"Constant\"><html xmlns=\"http://www.w3.org/19" +
            "99/xhtml\"><head /><body /></html></f:param></f:function>")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.LargeString)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(1)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Desc {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("8fe6a26a-08d2-4beb-bf81-c11ceac773d5")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 2048)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(2)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 2048)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        [Composite.Data.ForeignKeyAttribute("Composite.Data.Types.IImageFile,Composite", AllowCascadeDeletes=true, NullReferenceValue=null)]
        string Image {
            get;
            set;
        }
    }
}
