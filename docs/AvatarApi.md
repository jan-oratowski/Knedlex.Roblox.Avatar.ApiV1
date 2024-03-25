# Knedlex.Roblox.Avatar.ApiV1.Api.AvatarApi

All URIs are relative to *https://avatar.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AvatarAssetsAssetIdRemovePost**](AvatarApi.md#v1avatarassetsassetidremovepost) | **POST** /v1/avatar/assets/{assetId}/remove | Removes the asset from the authenticated user&#39;s avatar. |
| [**V1AvatarAssetsAssetIdWearPost**](AvatarApi.md#v1avatarassetsassetidwearpost) | **POST** /v1/avatar/assets/{assetId}/wear | Puts the asset on the authenticated user&#39;s avatar.  - Flagged as obsolete, does not support layered clothing meta params |
| [**V1AvatarGet**](AvatarApi.md#v1avatarget) | **GET** /v1/avatar | Returns details about the authenticated user&#39;s avatar |
| [**V1AvatarMetadataGet**](AvatarApi.md#v1avatarmetadataget) | **GET** /v1/avatar/metadata | Returns metadata used by the avatar page of the website |
| [**V1AvatarRedrawThumbnailPost**](AvatarApi.md#v1avatarredrawthumbnailpost) | **POST** /v1/avatar/redraw-thumbnail | Requests the authenticated user&#39;s thumbnail be redrawn |
| [**V1AvatarRulesGet**](AvatarApi.md#v1avatarrulesget) | **GET** /v1/avatar-rules | Returns the business rules related to avatars |
| [**V1AvatarSetBodyColorsPost**](AvatarApi.md#v1avatarsetbodycolorspost) | **POST** /v1/avatar/set-body-colors | Sets the authenticated user&#39;s body colors |
| [**V1AvatarSetPlayerAvatarTypePost**](AvatarApi.md#v1avatarsetplayeravatartypepost) | **POST** /v1/avatar/set-player-avatar-type | Sets the authenticated user&#39;s player avatar type (e.g. R6 or R15). |
| [**V1AvatarSetScalesPost**](AvatarApi.md#v1avatarsetscalespost) | **POST** /v1/avatar/set-scales | Sets the authenticated user&#39;s scales |
| [**V1AvatarSetWearingAssetsPost**](AvatarApi.md#v1avatarsetwearingassetspost) | **POST** /v1/avatar/set-wearing-assets | Sets the avatar&#39;s current assets to the list  - Flagged as obsolete, does not support layered clothing meta params |
| [**V1GameStartInfoGet**](AvatarApi.md#v1gamestartinfoget) | **GET** /v1/game-start-info | The server will call this on game server start to request general information about the universe  This is version 1.1, which returns an entry from the UniverseAvatarType enum.  During mixed mode this may return unreliable results. |
| [**V1UsersUserIdAvatarGet**](AvatarApi.md#v1usersuseridavatarget) | **GET** /v1/users/{userId}/avatar | Returns details about a specified user&#39;s avatar |
| [**V1UsersUserIdCurrentlyWearingGet**](AvatarApi.md#v1usersuseridcurrentlywearingget) | **GET** /v1/users/{userId}/currently-wearing | Gets a list of asset ids that the user is currently wearing |
| [**V1UsersUserIdOutfitsGet**](AvatarApi.md#v1usersuseridoutfitsget) | **GET** /v1/users/{userId}/outfits | Deprecated, user v2.  Gets a list of outfits for the specified user. |

<a id="v1avatarassetsassetidremovepost"></a>
# **V1AvatarAssetsAssetIdRemovePost**
> RobloxApiAvatarModelsAvatarApiSuccessResponse V1AvatarAssetsAssetIdRemovePost (long assetId)

Removes the asset from the authenticated user's avatar.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarAssetsAssetIdRemovePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var assetId = 789L;  // long | The asset id.

            try
            {
                // Removes the asset from the authenticated user's avatar.
                RobloxApiAvatarModelsAvatarApiSuccessResponse result = apiInstance.V1AvatarAssetsAssetIdRemovePost(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarAssetsAssetIdRemovePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarAssetsAssetIdRemovePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes the asset from the authenticated user's avatar.
    ApiResponse<RobloxApiAvatarModelsAvatarApiSuccessResponse> response = apiInstance.V1AvatarAssetsAssetIdRemovePostWithHttpInfo(assetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarAssetsAssetIdRemovePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **long** | The asset id. |  |

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
| **400** | 2: Failed to remove asset. |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  1: You must be wearing the asset to remove it. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarassetsassetidwearpost"></a>
# **V1AvatarAssetsAssetIdWearPost**
> RobloxApiAvatarModelsAvatarApiSuccessResponse V1AvatarAssetsAssetIdWearPost (long assetId)

Puts the asset on the authenticated user's avatar.  - Flagged as obsolete, does not support layered clothing meta params

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarAssetsAssetIdWearPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var assetId = 789L;  // long | The asset id.

            try
            {
                // Puts the asset on the authenticated user's avatar.  - Flagged as obsolete, does not support layered clothing meta params
                RobloxApiAvatarModelsAvatarApiSuccessResponse result = apiInstance.V1AvatarAssetsAssetIdWearPost(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarAssetsAssetIdWearPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarAssetsAssetIdWearPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Puts the asset on the authenticated user's avatar.  - Flagged as obsolete, does not support layered clothing meta params
    ApiResponse<RobloxApiAvatarModelsAvatarApiSuccessResponse> response = apiInstance.V1AvatarAssetsAssetIdWearPostWithHttpInfo(assetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarAssetsAssetIdWearPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **long** | The asset id. |  |

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
| **400** | 2: Failed to wear asset. |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  1: You must own an asset to wear it. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarget"></a>
# **V1AvatarGet**
> RobloxApiAvatarModelsAvatarModelV2 V1AvatarGet ()

Returns details about the authenticated user's avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);

            try
            {
                // Returns details about the authenticated user's avatar
                RobloxApiAvatarModelsAvatarModelV2 result = apiInstance.V1AvatarGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns details about the authenticated user's avatar
    ApiResponse<RobloxApiAvatarModelsAvatarModelV2> response = apiInstance.V1AvatarGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxApiAvatarModelsAvatarModelV2**](RobloxApiAvatarModelsAvatarModelV2.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarmetadataget"></a>
# **V1AvatarMetadataGet**
> RobloxApiAvatarModelsAvatarMetadataModel V1AvatarMetadataGet ()

Returns metadata used by the avatar page of the website

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarMetadataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);

            try
            {
                // Returns metadata used by the avatar page of the website
                RobloxApiAvatarModelsAvatarMetadataModel result = apiInstance.V1AvatarMetadataGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarMetadataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarMetadataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns metadata used by the avatar page of the website
    ApiResponse<RobloxApiAvatarModelsAvatarMetadataModel> response = apiInstance.V1AvatarMetadataGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarMetadataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxApiAvatarModelsAvatarMetadataModel**](RobloxApiAvatarModelsAvatarMetadataModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarredrawthumbnailpost"></a>
# **V1AvatarRedrawThumbnailPost**
> Object V1AvatarRedrawThumbnailPost ()

Requests the authenticated user's thumbnail be redrawn

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarRedrawThumbnailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);

            try
            {
                // Requests the authenticated user's thumbnail be redrawn
                Object result = apiInstance.V1AvatarRedrawThumbnailPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarRedrawThumbnailPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarRedrawThumbnailPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests the authenticated user's thumbnail be redrawn
    ApiResponse<Object> response = apiInstance.V1AvatarRedrawThumbnailPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarRedrawThumbnailPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **429** | 1: Redrawing your avatar thumbnail is floodchecked at this time  1: Redrawing your avatar thumbnail is floodchecked at this time |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarrulesget"></a>
# **V1AvatarRulesGet**
> RobloxApiAvatarModelsAvatarRulesModel V1AvatarRulesGet ()

Returns the business rules related to avatars

BodyColorsPalette is a list of valid brickColors you can choose for your avatar.  WearableAssetTypes contains a list of asset types with names, ids, and the maximum number that you can wear at a time.  Does not include packages because they cannot be worn on your avatar directly.  PlayerAvatarTypes are the types of avatars you can choose between.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarRulesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);

            try
            {
                // Returns the business rules related to avatars
                RobloxApiAvatarModelsAvatarRulesModel result = apiInstance.V1AvatarRulesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarRulesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarRulesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the business rules related to avatars
    ApiResponse<RobloxApiAvatarModelsAvatarRulesModel> response = apiInstance.V1AvatarRulesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarRulesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxApiAvatarModelsAvatarRulesModel**](RobloxApiAvatarModelsAvatarRulesModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarsetbodycolorspost"></a>
# **V1AvatarSetBodyColorsPost**
> RobloxApiAvatarModelsAvatarApiSuccessResponse V1AvatarSetBodyColorsPost (RobloxApiAvatarModelsBodyColorsModel bodyColorsModel)

Sets the authenticated user's body colors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarSetBodyColorsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var bodyColorsModel = new RobloxApiAvatarModelsBodyColorsModel(); // RobloxApiAvatarModelsBodyColorsModel | 

            try
            {
                // Sets the authenticated user's body colors
                RobloxApiAvatarModelsAvatarApiSuccessResponse result = apiInstance.V1AvatarSetBodyColorsPost(bodyColorsModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarSetBodyColorsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarSetBodyColorsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the authenticated user's body colors
    ApiResponse<RobloxApiAvatarModelsAvatarApiSuccessResponse> response = apiInstance.V1AvatarSetBodyColorsPostWithHttpInfo(bodyColorsModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarSetBodyColorsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bodyColorsModel** | [**RobloxApiAvatarModelsBodyColorsModel**](RobloxApiAvatarModelsBodyColorsModel.md) |  |  |

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
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarsetplayeravatartypepost"></a>
# **V1AvatarSetPlayerAvatarTypePost**
> RobloxApiAvatarModelsAvatarApiSuccessResponse V1AvatarSetPlayerAvatarTypePost (RobloxApiAvatarModelsPlayerAvatarTypeModel playerAvatarTypeModel)

Sets the authenticated user's player avatar type (e.g. R6 or R15).

This is the avatar type chosen on the Avatar page. Some games can override this and force your character to be R6 or R15.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarSetPlayerAvatarTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var playerAvatarTypeModel = new RobloxApiAvatarModelsPlayerAvatarTypeModel(); // RobloxApiAvatarModelsPlayerAvatarTypeModel | R6 or R15

            try
            {
                // Sets the authenticated user's player avatar type (e.g. R6 or R15).
                RobloxApiAvatarModelsAvatarApiSuccessResponse result = apiInstance.V1AvatarSetPlayerAvatarTypePost(playerAvatarTypeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarSetPlayerAvatarTypePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarSetPlayerAvatarTypePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the authenticated user's player avatar type (e.g. R6 or R15).
    ApiResponse<RobloxApiAvatarModelsAvatarApiSuccessResponse> response = apiInstance.V1AvatarSetPlayerAvatarTypePostWithHttpInfo(playerAvatarTypeModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarSetPlayerAvatarTypePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playerAvatarTypeModel** | [**RobloxApiAvatarModelsPlayerAvatarTypeModel**](RobloxApiAvatarModelsPlayerAvatarTypeModel.md) | R6 or R15 |  |

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
| **400** | 1: Invalid playerAvatarType. Valid values are:  |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  2: You are not allowed to change player avatar type. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarsetscalespost"></a>
# **V1AvatarSetScalesPost**
> RobloxApiAvatarModelsAvatarApiSuccessResponse V1AvatarSetScalesPost (RobloxWebResponsesAvatarScaleModel scalesModel)

Sets the authenticated user's scales

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarSetScalesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var scalesModel = new RobloxWebResponsesAvatarScaleModel(); // RobloxWebResponsesAvatarScaleModel | 

            try
            {
                // Sets the authenticated user's scales
                RobloxApiAvatarModelsAvatarApiSuccessResponse result = apiInstance.V1AvatarSetScalesPost(scalesModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarSetScalesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarSetScalesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the authenticated user's scales
    ApiResponse<RobloxApiAvatarModelsAvatarApiSuccessResponse> response = apiInstance.V1AvatarSetScalesPostWithHttpInfo(scalesModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarSetScalesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scalesModel** | [**RobloxWebResponsesAvatarScaleModel**](RobloxWebResponsesAvatarScaleModel.md) |  |  |

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
| **400** | 1: Please pass in the scales JSON |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  3: The user does not have permissions to change scales. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1avatarsetwearingassetspost"></a>
# **V1AvatarSetWearingAssetsPost**
> RobloxApiAvatarModelsWearResponseModel V1AvatarSetWearingAssetsPost (RobloxApiAvatarModelsAssetIdListModel assetIdsModel)

Sets the avatar's current assets to the list  - Flagged as obsolete, does not support layered clothing meta params

Only allows items that you own, are not expired, and are wearable asset types.  Any assets being worn before this method is called are automatically removed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1AvatarSetWearingAssetsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var assetIdsModel = new RobloxApiAvatarModelsAssetIdListModel(); // RobloxApiAvatarModelsAssetIdListModel | The list of asset IDs

            try
            {
                // Sets the avatar's current assets to the list  - Flagged as obsolete, does not support layered clothing meta params
                RobloxApiAvatarModelsWearResponseModel result = apiInstance.V1AvatarSetWearingAssetsPost(assetIdsModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1AvatarSetWearingAssetsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AvatarSetWearingAssetsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the avatar's current assets to the list  - Flagged as obsolete, does not support layered clothing meta params
    ApiResponse<RobloxApiAvatarModelsWearResponseModel> response = apiInstance.V1AvatarSetWearingAssetsPostWithHttpInfo(assetIdsModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1AvatarSetWearingAssetsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetIdsModel** | [**RobloxApiAvatarModelsAssetIdListModel**](RobloxApiAvatarModelsAssetIdListModel.md) | The list of asset IDs |  |

### Return type

[**RobloxApiAvatarModelsWearResponseModel**](RobloxApiAvatarModelsWearResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 3: Invalid assetId |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed |  -  |
| **500** | 2: Failed to wear asset. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1gamestartinfoget"></a>
# **V1GameStartInfoGet**
> RobloxApiAvatarModelsGameStartInfoResponse V1GameStartInfoGet (long universeId)

The server will call this on game server start to request general information about the universe  This is version 1.1, which returns an entry from the UniverseAvatarType enum.  During mixed mode this may return unreliable results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1GameStartInfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var universeId = 789L;  // long | 

            try
            {
                // The server will call this on game server start to request general information about the universe  This is version 1.1, which returns an entry from the UniverseAvatarType enum.  During mixed mode this may return unreliable results.
                RobloxApiAvatarModelsGameStartInfoResponse result = apiInstance.V1GameStartInfoGet(universeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1GameStartInfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1GameStartInfoGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The server will call this on game server start to request general information about the universe  This is version 1.1, which returns an entry from the UniverseAvatarType enum.  During mixed mode this may return unreliable results.
    ApiResponse<RobloxApiAvatarModelsGameStartInfoResponse> response = apiInstance.V1GameStartInfoGetWithHttpInfo(universeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1GameStartInfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **universeId** | **long** |  |  |

### Return type

[**RobloxApiAvatarModelsGameStartInfoResponse**](RobloxApiAvatarModelsGameStartInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersuseridavatarget"></a>
# **V1UsersUserIdAvatarGet**
> RobloxApiAvatarModelsAvatarModelV2 V1UsersUserIdAvatarGet (long userId)

Returns details about a specified user's avatar

Includes assets, bodycolors, and playerAvatarType.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1UsersUserIdAvatarGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var userId = 789L;  // long | 

            try
            {
                // Returns details about a specified user's avatar
                RobloxApiAvatarModelsAvatarModelV2 result = apiInstance.V1UsersUserIdAvatarGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1UsersUserIdAvatarGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersUserIdAvatarGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns details about a specified user's avatar
    ApiResponse<RobloxApiAvatarModelsAvatarModelV2> response = apiInstance.V1UsersUserIdAvatarGetWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1UsersUserIdAvatarGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** |  |  |

### Return type

[**RobloxApiAvatarModelsAvatarModelV2**](RobloxApiAvatarModelsAvatarModelV2.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: The specified user does not exist.  2: An account for the given userId does not exist! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersuseridcurrentlywearingget"></a>
# **V1UsersUserIdCurrentlyWearingGet**
> RobloxApiAvatarModelsAssetIdListModel V1UsersUserIdCurrentlyWearingGet (long userId)

Gets a list of asset ids that the user is currently wearing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1UsersUserIdCurrentlyWearingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var userId = 789L;  // long | The user id.

            try
            {
                // Gets a list of asset ids that the user is currently wearing
                RobloxApiAvatarModelsAssetIdListModel result = apiInstance.V1UsersUserIdCurrentlyWearingGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1UsersUserIdCurrentlyWearingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersUserIdCurrentlyWearingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of asset ids that the user is currently wearing
    ApiResponse<RobloxApiAvatarModelsAssetIdListModel> response = apiInstance.V1UsersUserIdCurrentlyWearingGetWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1UsersUserIdCurrentlyWearingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The user id. |  |

### Return type

[**RobloxApiAvatarModelsAssetIdListModel**](RobloxApiAvatarModelsAssetIdListModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: The specified user does not exist.  2: An account for the given userId does not exist! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersuseridoutfitsget"></a>
# **V1UsersUserIdOutfitsGet**
> RobloxApiAvatarModelsAvatarFilteredPageResponseRobloxApiAvatarModelsOutfitModel V1UsersUserIdOutfitsGet (long userId, string outfitType = null, int? page = null, int? itemsPerPage = null, bool? isEditable = null)

Deprecated, user v2.  Gets a list of outfits for the specified user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1UsersUserIdOutfitsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new AvatarApi(config);
            var userId = 789L;  // long | The user id.
            var outfitType = "outfitType_example";  // string | The outfit type being searched for, null will return all outfitTypes (optional) 
            var page = 1;  // int? | The page number of the current page of requests, default is 1. (optional)  (default to 1)
            var itemsPerPage = 25;  // int? | The max number of outfits that can be returned. (optional)  (default to 25)
            var isEditable = true;  // bool? | Whether the outfits are editable. A null value will lead to no filtering. (optional) 

            try
            {
                // Deprecated, user v2.  Gets a list of outfits for the specified user.
                RobloxApiAvatarModelsAvatarFilteredPageResponseRobloxApiAvatarModelsOutfitModel result = apiInstance.V1UsersUserIdOutfitsGet(userId, outfitType, page, itemsPerPage, isEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarApi.V1UsersUserIdOutfitsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersUserIdOutfitsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deprecated, user v2.  Gets a list of outfits for the specified user.
    ApiResponse<RobloxApiAvatarModelsAvatarFilteredPageResponseRobloxApiAvatarModelsOutfitModel> response = apiInstance.V1UsersUserIdOutfitsGetWithHttpInfo(userId, outfitType, page, itemsPerPage, isEditable);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarApi.V1UsersUserIdOutfitsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The user id. |  |
| **outfitType** | **string** | The outfit type being searched for, null will return all outfitTypes | [optional]  |
| **page** | **int?** | The page number of the current page of requests, default is 1. | [optional] [default to 1] |
| **itemsPerPage** | **int?** | The max number of outfits that can be returned. | [optional] [default to 25] |
| **isEditable** | **bool?** | Whether the outfits are editable. A null value will lead to no filtering. | [optional]  |

### Return type

[**RobloxApiAvatarModelsAvatarFilteredPageResponseRobloxApiAvatarModelsOutfitModel**](RobloxApiAvatarModelsAvatarFilteredPageResponseRobloxApiAvatarModelsOutfitModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: The specified user does not exist.  2: An account for the given userId does not exist! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

