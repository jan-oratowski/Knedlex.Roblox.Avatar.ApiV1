/*
 * Avatar Api v1
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Knedlex.Roblox.Avatar.ApiV1.Client.OpenAPIDateConverter;

namespace Knedlex.Roblox.Avatar.ApiV1.Model
{
    /// <summary>
    /// A slim model for user outfits
    /// </summary>
    [DataContract(Name = "Roblox.Api.Avatar.Models.OutfitModel")]
    public partial class RobloxApiAvatarModelsOutfitModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobloxApiAvatarModelsOutfitModel" /> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="name">The name.</param>
        /// <param name="isEditable">Whether the outfit can be modified by the user.</param>
        public RobloxApiAvatarModelsOutfitModel(long id = default(long), string name = default(string), bool isEditable = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.IsEditable = isEditable;
        }

        /// <summary>
        /// The id
        /// </summary>
        /// <value>The id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        /// <value>The name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether the outfit can be modified by the user
        /// </summary>
        /// <value>Whether the outfit can be modified by the user</value>
        [DataMember(Name = "isEditable", EmitDefaultValue = true)]
        public bool IsEditable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RobloxApiAvatarModelsOutfitModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsEditable: ").Append(IsEditable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}