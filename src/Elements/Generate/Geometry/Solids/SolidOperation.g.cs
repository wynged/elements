//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.27.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Geometry.Solids
{
    #pragma warning disable // Disable all warnings

    /// <summary>A solid operation.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class SolidOperation 
    {
        [Newtonsoft.Json.JsonConstructor]
        public SolidOperation(bool @isVoid)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SolidOperation>();
            if(validator != null)
            {
                validator.Validate(new object[]{ @isVoid});
            }
        
            this.IsVoid = @isVoid;
        }
    
        /// <summary>Is the solid operation a void operation?</summary>
        [Newtonsoft.Json.JsonProperty("IsVoid", Required = Newtonsoft.Json.Required.Always)]
        public bool IsVoid { get; set; } = false;
    
    
    }
}