namespace Rain {
    
    
    [Composite.Data.AutoUpdatebleAttribute()]
    [Composite.Data.DataScopeAttribute("public")]
    [Composite.Data.RelevantToUserTypeAttribute("Developer")]
    [Composite.Data.CodeGeneratedAttribute()]
    [Composite.Data.Hierarchy.DataAncestorProviderAttribute(typeof(Composite.Data.Hierarchy.DataAncestorProviders.NoAncestorDataAncestorProvider))]
    [Composite.Data.ImmutableTypeIdAttribute("80674a84-d25e-4523-8e0d-bf78d13cbad6")]
    [Composite.Core.WebClient.Renderings.Data.KeyTemplatedXhtmlRendererAttribute(Composite.Core.WebClient.Renderings.Data.XhtmlRenderingType.Embedable, "<span>{label}</span>")]
    [Composite.Data.KeyPropertyNameAttribute("Id")]
    [Composite.Data.TitleAttribute("Services")]
    [Composite.Data.LabelPropertyNameAttribute("Title")]
    public interface Services : Composite.Data.IData {
        
        [Composite.Data.ImmutableFieldIdAttribute("4e58131b-a04e-4f06-a869-4da9cfda1a15")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function name=\"Composite.Utils.Guid.NewGuid\" xmlns:f=\"http://www.composite.net" +
            "/ns/function/1.0\" />")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(-1)]
        System.Guid Id {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("64fce79f-72dc-49a1-94f0-027ed7b24273")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 64)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(0)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 64)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Title {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("574ee8b9-3fd5-4fb0-a935-29037b9eb8e4")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.LargeString)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(1)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Desc {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("3cb103f8-7a95-499f-9576-ff905f8abc3b")]
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
        
        [Composite.Data.ImmutableFieldIdAttribute("eaa9135b-ff78-40da-91b3-f65009433bbd")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Integer)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(3)]
        [Composite.Data.Validation.Validators.IntegerRangeValidatorAttribute(-2147483648, 2147483647)]
        [Composite.Data.DefaultFieldIntValueAttribute(0)]
        int Order {
            get;
            set;
        }
    }
}
