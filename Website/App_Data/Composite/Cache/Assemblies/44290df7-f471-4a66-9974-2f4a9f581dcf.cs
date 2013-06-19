namespace Rain.Catalog {
    
    
    [Composite.Data.AutoUpdatebleAttribute()]
    [Composite.Data.DataScopeAttribute("public")]
    [Composite.Data.RelevantToUserTypeAttribute("Developer")]
    [Composite.Data.CodeGeneratedAttribute()]
    [Composite.Data.Hierarchy.DataAncestorProviderAttribute(typeof(Composite.Data.Hierarchy.DataAncestorProviders.NoAncestorDataAncestorProvider))]
    [Composite.Data.ImmutableTypeIdAttribute("44290df7-f471-4a66-9974-2f4a9f581dcf")]
    [Composite.Core.WebClient.Renderings.Data.KeyTemplatedXhtmlRendererAttribute(Composite.Core.WebClient.Renderings.Data.XhtmlRenderingType.Embedable, "<span>{label}</span>")]
    [Composite.Data.KeyPropertyNameAttribute("Id")]
    [Composite.Data.TitleAttribute("Catalogs")]
    [Composite.Data.LabelPropertyNameAttribute("Title")]
    public interface Catalogs : Composite.Data.IData {
        
        [Composite.Data.ImmutableFieldIdAttribute("2c91cc34-e16a-4de4-91ee-f4e1df356311")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function name=\"Composite.Utils.Guid.NewGuid\" xmlns:f=\"http://www.composite.net" +
            "/ns/function/1.0\" />")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(-1)]
        System.Guid Id {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("86256130-5148-4256-94f2-b132b367af2d")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 64)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(0)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 64)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Title {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("b25aeb42-65c1-4663-95b6-ec666bc5bbf3")]
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
        
        [Composite.Data.ImmutableFieldIdAttribute("d9d5e330-9f1d-48de-b05d-b6116ec63859")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function xmlns:f=\"http://www.composite.net/ns/function/1.0\" name=\"Composite.Co" +
            "nstant.XhtmlDocument\"><f:param name=\"Constant\"><html xmlns=\"http://www.w3.org/19" +
            "99/xhtml\"><head /><body /></html></f:param></f:function>")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.LargeString)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(2)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Content {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("15559663-b610-46d6-a3bc-d04b39be8bde")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 2048)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(3)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 2048)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        [Composite.Data.ForeignKeyAttribute("Composite.Data.Types.IMediaFileFolder,Composite", AllowCascadeDeletes=true, NullReferenceValue=null)]
        string Gallery {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("005d5b04-d8d3-4825-b2e4-04dea36ff207")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.Validation.Validators.GuidNotEmptyAttribute()]
        [Composite.Data.FieldPositionAttribute(4)]
        [Composite.Data.DefaultFieldGuidValueAttribute("00000000-0000-0000-0000-000000000000")]
        [Composite.Data.ForeignKeyAttribute("Rain.Catalog.RootCatalogs", AllowCascadeDeletes=true, NullReferenceValue="{00000000-0000-0000-0000-000000000000}")]
        [Composite.Data.GroupByPriorityAttribute(1)]
        System.Guid RootCatalog {
            get;
            set;
        }
    }
}
