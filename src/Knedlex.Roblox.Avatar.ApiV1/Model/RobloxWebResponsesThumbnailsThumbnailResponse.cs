/*
 * Thumbnails Api v1
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
    /// RobloxWebResponsesThumbnailsThumbnailResponse
    /// </summary>
    [DataContract(Name = "Roblox.Web.Responses.Thumbnails.ThumbnailResponse")]
    public partial class RobloxWebResponsesThumbnailsThumbnailResponse : IValidatableObject
    {
        /// <summary>
        ///  [&#39;Error&#39; &#x3D; 0, &#39;Completed&#39; &#x3D; 1, &#39;InReview&#39; &#x3D; 2, &#39;Pending&#39; &#x3D; 3, &#39;Blocked&#39; &#x3D; 4, &#39;TemporarilyUnavailable&#39; &#x3D; 5]
        /// </summary>
        /// <value> [&#39;Error&#39; &#x3D; 0, &#39;Completed&#39; &#x3D; 1, &#39;InReview&#39; &#x3D; 2, &#39;Pending&#39; &#x3D; 3, &#39;Blocked&#39; &#x3D; 4, &#39;TemporarilyUnavailable&#39; &#x3D; 5]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 1,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 2,

            /// <summary>
            /// Enum InReview for value: InReview
            /// </summary>
            [EnumMember(Value = "InReview")]
            InReview = 3,

            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 4,

            /// <summary>
            /// Enum Blocked for value: Blocked
            /// </summary>
            [EnumMember(Value = "Blocked")]
            Blocked = 5,

            /// <summary>
            /// Enum TemporarilyUnavailable for value: TemporarilyUnavailable
            /// </summary>
            [EnumMember(Value = "TemporarilyUnavailable")]
            TemporarilyUnavailable = 6
        }


        /// <summary>
        ///  [&#39;Error&#39; &#x3D; 0, &#39;Completed&#39; &#x3D; 1, &#39;InReview&#39; &#x3D; 2, &#39;Pending&#39; &#x3D; 3, &#39;Blocked&#39; &#x3D; 4, &#39;TemporarilyUnavailable&#39; &#x3D; 5]
        /// </summary>
        /// <value> [&#39;Error&#39; &#x3D; 0, &#39;Completed&#39; &#x3D; 1, &#39;InReview&#39; &#x3D; 2, &#39;Pending&#39; &#x3D; 3, &#39;Blocked&#39; &#x3D; 4, &#39;TemporarilyUnavailable&#39; &#x3D; 5]</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobloxWebResponsesThumbnailsThumbnailResponse" /> class.
        /// </summary>
        /// <param name="targetId">targetId.</param>
        /// <param name="state"> [&#39;Error&#39; &#x3D; 0, &#39;Completed&#39; &#x3D; 1, &#39;InReview&#39; &#x3D; 2, &#39;Pending&#39; &#x3D; 3, &#39;Blocked&#39; &#x3D; 4, &#39;TemporarilyUnavailable&#39; &#x3D; 5].</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="varVersion">varVersion.</param>
        public RobloxWebResponsesThumbnailsThumbnailResponse(long targetId = default(long), StateEnum? state = default(StateEnum?), string imageUrl = default(string), string varVersion = default(string))
        {
            this.TargetId = targetId;
            this.State = state;
            this.ImageUrl = imageUrl;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        [DataMember(Name = "targetId", EmitDefaultValue = false)]
        public long TargetId { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RobloxWebResponsesThumbnailsThumbnailResponse {\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
