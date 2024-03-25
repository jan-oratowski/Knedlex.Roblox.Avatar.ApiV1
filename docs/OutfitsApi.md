# Knedlex.Roblox.Avatar.ApiV1.Api.OutfitsApi

All URIs are relative to *https://avatar.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1OutfitsCreatePost**](OutfitsApi.md#v1outfitscreatepost) | **POST** /v1/outfits/create | Creates a new outfit. |
| [**V1OutfitsUserOutfitIdDeletePost**](OutfitsApi.md#v1outfitsuseroutfitiddeletepost) | **POST** /v1/outfits/{userOutfitId}/delete | Deletes the outfit |
| [**V1OutfitsUserOutfitIdDetailsGet**](OutfitsApi.md#v1outfitsuseroutfitiddetailsget) | **GET** /v1/outfits/{userOutfitId}/details |  |
| [**V1OutfitsUserOutfitIdPatch**](OutfitsApi.md#v1outfitsuseroutfitidpatch) | **PATCH** /v1/outfits/{userOutfitId} | Updates the contents of an outfit. Deprecated. There are no calls to this API |
| [**V1OutfitsUserOutfitIdUpdatePost**](OutfitsApi.md#v1outfitsuseroutfitidupdatepost) | **POST** /v1/outfits/{userOutfitId}/update | Updates the contents of the outfit. Deprecated. There are no calls to this API |
| [**V1OutfitsUserOutfitIdWearPost**](OutfitsApi.md#v1outfitsuseroutfitidwearpost) | **POST** /v1/outfits/{userOutfitId}/wear | Wears the outfit |

<a id="v1outfitscreatepost"></a>
# **V1OutfitsCreatePost**
> RobloxApiAvatarModelsAvatarApiSuccessResponse V1OutfitsCreatePost (RobloxApiAvatarModelsOutfitUpdateModelV1 outfitUpdateModel)

Creates a new outfit.

Fails if any of the assetIds are not owned by the user, or not wearable types.  The name property of the request is optional as one will be auto-generated when the request has a null name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1OutfitsCreatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new OutfitsApi(config);
            var outfitUpdateModel = new RobloxApiAvatarModelsOutfitUpdateModelV1(); // RobloxApiAvatarModelsOutfitUpdateModelV1 | The new outfit

            try
            {
                // Creates a new outfit.
                RobloxApiAvatarModelsAvatarApiSuccessResponse result = apiInstance.V1OutfitsCreatePost(outfitUpdateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutfitsApi.V1OutfitsCreatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OutfitsCreatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new outfit.
    ApiResponse<RobloxApiAvatarModelsAvatarApiSuccessResponse> response = apiInstance.V1OutfitsCreatePostWithHttpInfo(outfitUpdateModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutfitsApi.V1OutfitsCreatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outfitUpdateModel** | [**RobloxApiAvatarModelsOutfitUpdateModelV1**](RobloxApiAvatarModelsOutfitUpdateModelV1.md) | The new outfit |  |

### Return type

[**RobloxApiAvatarModelsAvatarApiSuccessResponse**](RobloxApiAvatarModelsAvatarApiSuccessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 3: Body colors must be valid BrickColor IDs  4: Invalid outfit name  5: Asset is not wearable by you and was not added to the outfit  7: Invalid Player Avatar Type. Valid types are R6 and R15  8: Invalid assetIds |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  1: You already have the maximum number of outfits |  -  |
| **500** | 6: An error occurred while creating the outfit |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1outfitsuseroutfitiddeletepost"></a>
# **V1OutfitsUserOutfitIdDeletePost**
> RobloxApiAvatarModelsAvatarApiSuccessResponse V1OutfitsUserOutfitIdDeletePost (long userOutfitId)

Deletes the outfit

You are only allowed to delete outfits you created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1OutfitsUserOutfitIdDeletePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new OutfitsApi(config);
            var userOutfitId = 789L;  // long | The user outfit id

            try
            {
                // Deletes the outfit
                RobloxApiAvatarModelsAvatarApiSuccessResponse result = apiInstance.V1OutfitsUserOutfitIdDeletePost(userOutfitId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdDeletePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OutfitsUserOutfitIdDeletePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the outfit
    ApiResponse<RobloxApiAvatarModelsAvatarApiSuccessResponse> response = apiInstance.V1OutfitsUserOutfitIdDeletePostWithHttpInfo(userOutfitId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdDeletePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userOutfitId** | **long** | The user outfit id |  |

### Return type

[**RobloxApiAvatarModelsAvatarApiSuccessResponse**](RobloxApiAvatarModelsAvatarApiSuccessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: The specified userOutfitId is invalid! |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  2: You don&#39;t have permission to delete this outfit. |  -  |
| **500** | 3: An error occurred while deleting the outfit. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1outfitsuseroutfitiddetailsget"></a>
# **V1OutfitsUserOutfitIdDetailsGet**
> RobloxApiAvatarModelsOutfitDetailsModel V1OutfitsUserOutfitIdDetailsGet (long userOutfitId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1OutfitsUserOutfitIdDetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new OutfitsApi(config);
            var userOutfitId = 789L;  // long | 

            try
            {
                RobloxApiAvatarModelsOutfitDetailsModel result = apiInstance.V1OutfitsUserOutfitIdDetailsGet(userOutfitId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OutfitsUserOutfitIdDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RobloxApiAvatarModelsOutfitDetailsModel> response = apiInstance.V1OutfitsUserOutfitIdDetailsGetWithHttpInfo(userOutfitId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdDetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userOutfitId** | **long** |  |  |

### Return type

[**RobloxApiAvatarModelsOutfitDetailsModel**](RobloxApiAvatarModelsOutfitDetailsModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: The specified userOutfitId is invalid.  2: The outfit for the specified userOutfit is invalid. |  -  |
| **403** | 3: The requester does not have access to the details for the given user outfit. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1outfitsuseroutfitidpatch"></a>
# **V1OutfitsUserOutfitIdPatch**
> RobloxApiAvatarModelsOutfitModel V1OutfitsUserOutfitIdPatch (long userOutfitId, RobloxApiAvatarModelsOutfitUpdateModelV1 outfitUpdateModel)

Updates the contents of an outfit. Deprecated. There are no calls to this API

Fails if the user does not own any of the assetIds or if they are not wearable asset types. Accepts partial updates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1OutfitsUserOutfitIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new OutfitsApi(config);
            var userOutfitId = 789L;  // long | The user outfit id.
            var outfitUpdateModel = new RobloxApiAvatarModelsOutfitUpdateModelV1(); // RobloxApiAvatarModelsOutfitUpdateModelV1 | The updated outfit

            try
            {
                // Updates the contents of an outfit. Deprecated. There are no calls to this API
                RobloxApiAvatarModelsOutfitModel result = apiInstance.V1OutfitsUserOutfitIdPatch(userOutfitId, outfitUpdateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OutfitsUserOutfitIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the contents of an outfit. Deprecated. There are no calls to this API
    ApiResponse<RobloxApiAvatarModelsOutfitModel> response = apiInstance.V1OutfitsUserOutfitIdPatchWithHttpInfo(userOutfitId, outfitUpdateModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userOutfitId** | **long** | The user outfit id. |  |
| **outfitUpdateModel** | [**RobloxApiAvatarModelsOutfitUpdateModelV1**](RobloxApiAvatarModelsOutfitUpdateModelV1.md) | The updated outfit |  |

### Return type

[**RobloxApiAvatarModelsOutfitModel**](RobloxApiAvatarModelsOutfitModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: The specified userOutfit does not exist!  1: Must provide both assetIds and bodyColors in to update outfit contents.  3: Body colors must be valid BrickColor IDs  4: Invalid outfit name  5: Asset is not wearable by you  8: Invalid Player Avatar Type. Valid types are R6 and R15 |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  2: You don&#39;t have permission to update this outfit. |  -  |
| **500** | 6: An error occurred while trying to update the outfit |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1outfitsuseroutfitidupdatepost"></a>
# **V1OutfitsUserOutfitIdUpdatePost**
> RobloxApiAvatarModelsAvatarApiSuccessResponse V1OutfitsUserOutfitIdUpdatePost (long userOutfitId, RobloxApiAvatarModelsOutfitUpdateModelV1 outfitUpdateModel)

Updates the contents of the outfit. Deprecated. There are no calls to this API

Fails if the user does not own any of the assetIds or if they are not wearable asset types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1OutfitsUserOutfitIdUpdatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new OutfitsApi(config);
            var userOutfitId = 789L;  // long | The user outfit id.
            var outfitUpdateModel = new RobloxApiAvatarModelsOutfitUpdateModelV1(); // RobloxApiAvatarModelsOutfitUpdateModelV1 | The updated outfit

            try
            {
                // Updates the contents of the outfit. Deprecated. There are no calls to this API
                RobloxApiAvatarModelsAvatarApiSuccessResponse result = apiInstance.V1OutfitsUserOutfitIdUpdatePost(userOutfitId, outfitUpdateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdUpdatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OutfitsUserOutfitIdUpdatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the contents of the outfit. Deprecated. There are no calls to this API
    ApiResponse<RobloxApiAvatarModelsAvatarApiSuccessResponse> response = apiInstance.V1OutfitsUserOutfitIdUpdatePostWithHttpInfo(userOutfitId, outfitUpdateModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdUpdatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userOutfitId** | **long** | The user outfit id. |  |
| **outfitUpdateModel** | [**RobloxApiAvatarModelsOutfitUpdateModelV1**](RobloxApiAvatarModelsOutfitUpdateModelV1.md) | The updated outfit |  |

### Return type

[**RobloxApiAvatarModelsAvatarApiSuccessResponse**](RobloxApiAvatarModelsAvatarApiSuccessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: The specified userOutfit does not exist!  3: Body colors must be valid BrickColor IDs  4: Invalid outfit name  5: Asset is not wearable by you  7: Invalid assetIds  8: Invalid Player Avatar Type. Valid types are R6 and R15 |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  2: You don&#39;t have permission to update this outfit. |  -  |
| **500** | 6: An error occurred while trying to update the outfit |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1outfitsuseroutfitidwearpost"></a>
# **V1OutfitsUserOutfitIdWearPost**
> RobloxApiAvatarModelsWearResponseModel V1OutfitsUserOutfitIdWearPost (long userOutfitId)

Wears the outfit

Applies the outfit's appearance to your avatar  If the user no longer owns one or more of the assets, invalidAssetIds will be populated with the unwearable assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1OutfitsUserOutfitIdWearPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new OutfitsApi(config);
            var userOutfitId = 789L;  // long | The user outfit id

            try
            {
                // Wears the outfit
                RobloxApiAvatarModelsWearResponseModel result = apiInstance.V1OutfitsUserOutfitIdWearPost(userOutfitId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdWearPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OutfitsUserOutfitIdWearPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wears the outfit
    ApiResponse<RobloxApiAvatarModelsWearResponseModel> response = apiInstance.V1OutfitsUserOutfitIdWearPostWithHttpInfo(userOutfitId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutfitsApi.V1OutfitsUserOutfitIdWearPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userOutfitId** | **long** | The user outfit id |  |

### Return type

[**RobloxApiAvatarModelsWearResponseModel**](RobloxApiAvatarModelsWearResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: The specified userOutfitId is invalid! |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  2: You don&#39;t have permission to wear this outfit! |  -  |
| **429** | 3: The flood limit has been exceeded! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

