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
    /// A model containing website metadata for avatars
    /// </summary>
    [DataContract(Name = "Roblox.Api.Avatar.Models.AvatarMetadataModel")]
    public partial class RobloxApiAvatarModelsAvatarMetadataModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobloxApiAvatarModelsAvatarMetadataModel" /> class.
        /// </summary>
        /// <param name="enableDefaultClothingMessage">Whether or not to show the Default Clothing message.</param>
        /// <param name="isAvatarScaleEmbeddedInTab">Whether or not the Scales is embedded in the tab.</param>
        /// <param name="isBodyTypeScaleOutOfTab">Whether or not the Boby Type scale is embedded in the tab.</param>
        /// <param name="scaleHeightIncrement">How much the height scaler should increment by.</param>
        /// <param name="scaleWidthIncrement">How much the width scaler should increment by.</param>
        /// <param name="scaleHeadIncrement">How much the head scaler should increment by.</param>
        /// <param name="scaleProportionIncrement">How much the proportion scaler should increment by.</param>
        /// <param name="scaleBodyTypeIncrement">How much the body type scaler should increment by.</param>
        /// <param name="supportProportionAndBodyType">Whether or not to support proportion and body type.</param>
        /// <param name="showDefaultClothingMessageOnPageLoad">Whether or not to show the default clothing message when the page loads.</param>
        /// <param name="areThreeDeeThumbsEnabled">Whether or not 3D thumbnails are shown.</param>
        /// <param name="isAvatarWearingApiCallsLockingOnFrontendEnabled">Does the frontend lock avatar editor input until the wearing call returns.</param>
        /// <param name="isOutfitHandlingOnFrontendEnabled">Does the frontend lock avatar editor input until the wearing call returns.</param>
        /// <param name="isJustinUiChangesEnabled">Determines whether a bunch of UI improvements are released.</param>
        /// <param name="isCategoryReorgEnabled">Determines whether Category Reorg is released.</param>
        /// <param name="lCEnabledInEditorAndCatalog">Flag for both web UI and App, name is fixed due to sharing, do not change.</param>
        /// <param name="isLCCompletelyEnabled">Useful for the time between enabling Jackets for most users and  all LC types for everyone, meanwhile Soothsayers need all types  at all times.</param>
        public RobloxApiAvatarModelsAvatarMetadataModel(bool enableDefaultClothingMessage = default(bool), bool isAvatarScaleEmbeddedInTab = default(bool), bool isBodyTypeScaleOutOfTab = default(bool), double scaleHeightIncrement = default(double), double scaleWidthIncrement = default(double), double scaleHeadIncrement = default(double), double scaleProportionIncrement = default(double), double scaleBodyTypeIncrement = default(double), bool supportProportionAndBodyType = default(bool), bool showDefaultClothingMessageOnPageLoad = default(bool), bool areThreeDeeThumbsEnabled = default(bool), bool isAvatarWearingApiCallsLockingOnFrontendEnabled = default(bool), bool isOutfitHandlingOnFrontendEnabled = default(bool), bool isJustinUiChangesEnabled = default(bool), bool isCategoryReorgEnabled = default(bool), bool lCEnabledInEditorAndCatalog = default(bool), bool isLCCompletelyEnabled = default(bool))
        {
            this.EnableDefaultClothingMessage = enableDefaultClothingMessage;
            this.IsAvatarScaleEmbeddedInTab = isAvatarScaleEmbeddedInTab;
            this.IsBodyTypeScaleOutOfTab = isBodyTypeScaleOutOfTab;
            this.ScaleHeightIncrement = scaleHeightIncrement;
            this.ScaleWidthIncrement = scaleWidthIncrement;
            this.ScaleHeadIncrement = scaleHeadIncrement;
            this.ScaleProportionIncrement = scaleProportionIncrement;
            this.ScaleBodyTypeIncrement = scaleBodyTypeIncrement;
            this.SupportProportionAndBodyType = supportProportionAndBodyType;
            this.ShowDefaultClothingMessageOnPageLoad = showDefaultClothingMessageOnPageLoad;
            this.AreThreeDeeThumbsEnabled = areThreeDeeThumbsEnabled;
            this.IsAvatarWearingApiCallsLockingOnFrontendEnabled = isAvatarWearingApiCallsLockingOnFrontendEnabled;
            this.IsOutfitHandlingOnFrontendEnabled = isOutfitHandlingOnFrontendEnabled;
            this.IsJustinUiChangesEnabled = isJustinUiChangesEnabled;
            this.IsCategoryReorgEnabled = isCategoryReorgEnabled;
            this.LCEnabledInEditorAndCatalog = lCEnabledInEditorAndCatalog;
            this.IsLCCompletelyEnabled = isLCCompletelyEnabled;
        }

        /// <summary>
        /// Whether or not to show the Default Clothing message
        /// </summary>
        /// <value>Whether or not to show the Default Clothing message</value>
        [DataMember(Name = "enableDefaultClothingMessage", EmitDefaultValue = true)]
        public bool EnableDefaultClothingMessage { get; set; }

        /// <summary>
        /// Whether or not the Scales is embedded in the tab
        /// </summary>
        /// <value>Whether or not the Scales is embedded in the tab</value>
        [DataMember(Name = "isAvatarScaleEmbeddedInTab", EmitDefaultValue = true)]
        public bool IsAvatarScaleEmbeddedInTab { get; set; }

        /// <summary>
        /// Whether or not the Boby Type scale is embedded in the tab
        /// </summary>
        /// <value>Whether or not the Boby Type scale is embedded in the tab</value>
        [DataMember(Name = "isBodyTypeScaleOutOfTab", EmitDefaultValue = true)]
        public bool IsBodyTypeScaleOutOfTab { get; set; }

        /// <summary>
        /// How much the height scaler should increment by
        /// </summary>
        /// <value>How much the height scaler should increment by</value>
        [DataMember(Name = "scaleHeightIncrement", EmitDefaultValue = false)]
        public double ScaleHeightIncrement { get; set; }

        /// <summary>
        /// How much the width scaler should increment by
        /// </summary>
        /// <value>How much the width scaler should increment by</value>
        [DataMember(Name = "scaleWidthIncrement", EmitDefaultValue = false)]
        public double ScaleWidthIncrement { get; set; }

        /// <summary>
        /// How much the head scaler should increment by
        /// </summary>
        /// <value>How much the head scaler should increment by</value>
        [DataMember(Name = "scaleHeadIncrement", EmitDefaultValue = false)]
        public double ScaleHeadIncrement { get; set; }

        /// <summary>
        /// How much the proportion scaler should increment by
        /// </summary>
        /// <value>How much the proportion scaler should increment by</value>
        [DataMember(Name = "scaleProportionIncrement", EmitDefaultValue = false)]
        public double ScaleProportionIncrement { get; set; }

        /// <summary>
        /// How much the body type scaler should increment by
        /// </summary>
        /// <value>How much the body type scaler should increment by</value>
        [DataMember(Name = "scaleBodyTypeIncrement", EmitDefaultValue = false)]
        public double ScaleBodyTypeIncrement { get; set; }

        /// <summary>
        /// Whether or not to support proportion and body type
        /// </summary>
        /// <value>Whether or not to support proportion and body type</value>
        [DataMember(Name = "supportProportionAndBodyType", EmitDefaultValue = true)]
        public bool SupportProportionAndBodyType { get; set; }

        /// <summary>
        /// Whether or not to show the default clothing message when the page loads
        /// </summary>
        /// <value>Whether or not to show the default clothing message when the page loads</value>
        [DataMember(Name = "showDefaultClothingMessageOnPageLoad", EmitDefaultValue = true)]
        public bool ShowDefaultClothingMessageOnPageLoad { get; set; }

        /// <summary>
        /// Whether or not 3D thumbnails are shown
        /// </summary>
        /// <value>Whether or not 3D thumbnails are shown</value>
        [DataMember(Name = "areThreeDeeThumbsEnabled", EmitDefaultValue = true)]
        public bool AreThreeDeeThumbsEnabled { get; set; }

        /// <summary>
        /// Does the frontend lock avatar editor input until the wearing call returns
        /// </summary>
        /// <value>Does the frontend lock avatar editor input until the wearing call returns</value>
        [DataMember(Name = "isAvatarWearingApiCallsLockingOnFrontendEnabled", EmitDefaultValue = true)]
        public bool IsAvatarWearingApiCallsLockingOnFrontendEnabled { get; set; }

        /// <summary>
        /// Does the frontend lock avatar editor input until the wearing call returns
        /// </summary>
        /// <value>Does the frontend lock avatar editor input until the wearing call returns</value>
        [DataMember(Name = "isOutfitHandlingOnFrontendEnabled", EmitDefaultValue = true)]
        public bool IsOutfitHandlingOnFrontendEnabled { get; set; }

        /// <summary>
        /// Determines whether a bunch of UI improvements are released
        /// </summary>
        /// <value>Determines whether a bunch of UI improvements are released</value>
        [DataMember(Name = "isJustinUiChangesEnabled", EmitDefaultValue = true)]
        public bool IsJustinUiChangesEnabled { get; set; }

        /// <summary>
        /// Determines whether Category Reorg is released
        /// </summary>
        /// <value>Determines whether Category Reorg is released</value>
        [DataMember(Name = "isCategoryReorgEnabled", EmitDefaultValue = true)]
        public bool IsCategoryReorgEnabled { get; set; }

        /// <summary>
        /// Flag for both web UI and App, name is fixed due to sharing, do not change
        /// </summary>
        /// <value>Flag for both web UI and App, name is fixed due to sharing, do not change</value>
        [DataMember(Name = "LCEnabledInEditorAndCatalog", EmitDefaultValue = true)]
        public bool LCEnabledInEditorAndCatalog { get; set; }

        /// <summary>
        /// Useful for the time between enabling Jackets for most users and  all LC types for everyone, meanwhile Soothsayers need all types  at all times
        /// </summary>
        /// <value>Useful for the time between enabling Jackets for most users and  all LC types for everyone, meanwhile Soothsayers need all types  at all times</value>
        [DataMember(Name = "isLCCompletelyEnabled", EmitDefaultValue = true)]
        public bool IsLCCompletelyEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RobloxApiAvatarModelsAvatarMetadataModel {\n");
            sb.Append("  EnableDefaultClothingMessage: ").Append(EnableDefaultClothingMessage).Append("\n");
            sb.Append("  IsAvatarScaleEmbeddedInTab: ").Append(IsAvatarScaleEmbeddedInTab).Append("\n");
            sb.Append("  IsBodyTypeScaleOutOfTab: ").Append(IsBodyTypeScaleOutOfTab).Append("\n");
            sb.Append("  ScaleHeightIncrement: ").Append(ScaleHeightIncrement).Append("\n");
            sb.Append("  ScaleWidthIncrement: ").Append(ScaleWidthIncrement).Append("\n");
            sb.Append("  ScaleHeadIncrement: ").Append(ScaleHeadIncrement).Append("\n");
            sb.Append("  ScaleProportionIncrement: ").Append(ScaleProportionIncrement).Append("\n");
            sb.Append("  ScaleBodyTypeIncrement: ").Append(ScaleBodyTypeIncrement).Append("\n");
            sb.Append("  SupportProportionAndBodyType: ").Append(SupportProportionAndBodyType).Append("\n");
            sb.Append("  ShowDefaultClothingMessageOnPageLoad: ").Append(ShowDefaultClothingMessageOnPageLoad).Append("\n");
            sb.Append("  AreThreeDeeThumbsEnabled: ").Append(AreThreeDeeThumbsEnabled).Append("\n");
            sb.Append("  IsAvatarWearingApiCallsLockingOnFrontendEnabled: ").Append(IsAvatarWearingApiCallsLockingOnFrontendEnabled).Append("\n");
            sb.Append("  IsOutfitHandlingOnFrontendEnabled: ").Append(IsOutfitHandlingOnFrontendEnabled).Append("\n");
            sb.Append("  IsJustinUiChangesEnabled: ").Append(IsJustinUiChangesEnabled).Append("\n");
            sb.Append("  IsCategoryReorgEnabled: ").Append(IsCategoryReorgEnabled).Append("\n");
            sb.Append("  LCEnabledInEditorAndCatalog: ").Append(LCEnabledInEditorAndCatalog).Append("\n");
            sb.Append("  IsLCCompletelyEnabled: ").Append(IsLCCompletelyEnabled).Append("\n");
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
