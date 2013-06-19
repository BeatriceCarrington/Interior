namespace Rain.Catalog {
    
    
    [Composite.Data.AutoUpdatebleAttribute()]
    [Composite.Data.DataScopeAttribute("public")]
    [Composite.Data.RelevantToUserTypeAttribute("Developer")]
    [Composite.Data.CodeGeneratedAttribute()]
    [Composite.Data.Hierarchy.DataAncestorProviderAttribute(typeof(Composite.Data.Hierarchy.DataAncestorProviders.NoAncestorDataAncestorProvider))]
    [Composite.Data.ImmutableTypeIdAttribute("5b695989-f1d5-4ccc-acac-eb946f69dab2")]
    [Composite.Core.WebClient.Renderings.Data.KeyTemplatedXhtmlRendererAttribute(Composite.Core.WebClient.Renderings.Data.XhtmlRenderingType.Embedable, "<span>{label}</span>")]
    [Composite.Data.KeyPropertyNameAttribute("Id")]
    [Composite.Data.TitleAttribute("RootCatalogs")]
    [Composite.Data.LabelPropertyNameAttribute("Title")]
    public interface RootCatalogs : Composite.Data.IData {
        
        [Composite.Data.ImmutableFieldIdAttribute("5563aa3e-bca5-435c-86bf-77fa13eaa030")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function name=\"Composite.Utils.Guid.NewGuid\" xmlns:f=\"http://www.composite.net" +
            "/ns/function/1.0\" />")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(-1)]
        System.Guid Id {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("75823bdd-1e57-4f5f-a948-93291bb12367")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 64)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(0)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 64)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Title {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("821bf235-720a-4b42-9c65-b6d357a93d30")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Integer)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(1)]
        [Composite.Data.Validation.Validators.IntegerRangeValidatorAttribute(-2147483648, 2147483647)]
        [Composite.Data.DefaultFieldIntValueAttribute(0)]
        [Composite.Data.TreeOrderingAttribute(1)]
        int Order {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("cdcda89a-4dd8-4c09-aa2a-f60b0f0490a2")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function xmlns:f=\"http://www.composite.net/ns/function/1.0\" name=\"Composite.Co" +
            "nstant.XhtmlDocument\"><f:param name=\"Constant\"><html xmlns=\"http://www.w3.org/19" +
            "99/xhtml\"><head /><body /></html></f:param></f:function>")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.LargeString)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(2)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Desc {
            get;
            set;
        }
    }
}
