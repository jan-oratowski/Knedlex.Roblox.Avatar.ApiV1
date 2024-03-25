# Knedlex.Roblox.Avatar.ApiV1.Model.RobloxApiAvatarModelsAvatarRulesModel
A model containing details about avatar-related business rules

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlayerAvatarTypes** | **List&lt;RobloxApiAvatarModelsAvatarRulesModel.PlayerAvatarTypesEnum&gt;** | The avatar type | [optional] 
**Scales** | [**Dictionary&lt;string, RobloxApiAvatarModelsScaleRulesModel&gt;**](RobloxApiAvatarModelsScaleRulesModel.md) | The scales | [optional] 
**WearableAssetTypes** | [**List&lt;RobloxApiAvatarModelsAssetTypeRulesModel&gt;**](RobloxApiAvatarModelsAssetTypeRulesModel.md) | The assets worn on the character | [optional] 
**AccessoryRefinementTypes** | **List&lt;RobloxApiAvatarModelsAvatarRulesModel.AccessoryRefinementTypesEnum&gt;** | The list of asset types for Accessory Refinement. | [optional] 
**AccessoryRefinementLowerBounds** | [**RobloxApiAvatarModelsAvatarRulesModelAccessoryRefinementLowerBounds**](RobloxApiAvatarModelsAvatarRulesModelAccessoryRefinementLowerBounds.md) |  | [optional] 
**AccessoryRefinementUpperBounds** | [**RobloxApiAvatarModelsAvatarRulesModelAccessoryRefinementLowerBounds**](RobloxApiAvatarModelsAvatarRulesModelAccessoryRefinementLowerBounds.md) |  | [optional] 
**BodyColorsPalette** | [**List&lt;RobloxApiAvatarModelsBodyColorModel&gt;**](RobloxApiAvatarModelsBodyColorModel.md) | The full set of usable body colors | [optional] 
**BasicBodyColorsPalette** | [**List&lt;RobloxApiAvatarModelsBodyColorModel&gt;**](RobloxApiAvatarModelsBodyColorModel.md) | The basic set of body colors | [optional] 
**MinimumDeltaEBodyColorDifference** | **double** | The minimum Delta-E difference in body colors  for default clothing not to be applied | [optional] 
**ProportionsAndBodyTypeEnabledForUser** | **bool** | Whether proportion and bodyType scales are allowed to be set by the authenticated user | [optional] 
**DefaultClothingAssetLists** | [**RobloxApiAvatarModelsDefaultClothingAssets**](RobloxApiAvatarModelsDefaultClothingAssets.md) |  | [optional] 
**BundlesEnabledForUser** | **bool** | Whether or not bundles are enabled for the specific user | [optional] 
**EmotesEnabledForUser** | **bool** | Whether or not emotes are enabled | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

