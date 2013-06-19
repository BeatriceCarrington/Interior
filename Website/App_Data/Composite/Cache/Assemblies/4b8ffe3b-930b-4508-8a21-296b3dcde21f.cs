namespace Rain {
    
    
    [Composite.Data.AutoUpdatebleAttribute()]
    [Composite.Data.DataScopeAttribute("public")]
    [Composite.Data.RelevantToUserTypeAttribute("Developer")]
    [Composite.Data.CodeGeneratedAttribute()]
    [Composite.Data.Hierarchy.DataAncestorProviderAttribute(typeof(Composite.Data.Hierarchy.DataAncestorProviders.NoAncestorDataAncestorProvider))]
    [Composite.Data.ImmutableTypeIdAttribute("4b8ffe3b-930b-4508-8a21-296b3dcde21f")]
    [Composite.Core.WebClient.Renderings.Data.KeyTemplatedXhtmlRendererAttribute(Composite.Core.WebClient.Renderings.Data.XhtmlRenderingType.Embedable, "<span>{label}</span>")]
    [Composite.Data.KeyPropertyNameAttribute("Id")]
    [Composite.Data.TitleAttribute("Clients")]
    [Composite.Data.LabelPropertyNameAttribute("Title")]
    public interface Clients : Composite.Data.IData {
        
        [Composite.Data.ImmutableFieldIdAttribute("60c2efee-da44-4323-9519-6a88b37e3e38")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function name=\"Composite.Utils.Guid.NewGuid\" xmlns:f=\"http://www.composite.net" +
            "/ns/function/1.0\" />")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(-1)]
        System.Guid Id {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("d2decdbd-a551-4502-8626-3571d360e0e5")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 64)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(0)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 64)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Title {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("5c848944-937a-48ec-ab7b-94b0fac406ae")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 2048)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(1)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 2048)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        [Composite.Data.ForeignKeyAttribute("Composite.Data.Types.IImageFile,Composite", AllowCascadeDeletes=true, NullReferenceValue=null)]
        string Image {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("b0d39580-9d10-47bf-b4f6-6badf45d9855")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 2048)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(2)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 2048)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        [Composite.Data.ForeignKeyAttribute("Composite.Data.Types.IMediaFileFolder,Composite", AllowCascadeDeletes=true, NullReferenceValue=null)]
        string Gallery {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("025cce3f-5de6-4f6a-bbf2-362e63c865b6")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function xmlns:f=\"http://www.composite.net/ns/function/1.0\" name=\"Composite.Co" +
            "nstant.XhtmlDocument\"><f:param name=\"Constant\"><html xmlns=\"http://www.w3.org/19" +
            "99/xhtml\"><head /><body /></html></f:param></f:function>")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.LargeString)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(3)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Content {
            get;
            set;
        }
    }
}
