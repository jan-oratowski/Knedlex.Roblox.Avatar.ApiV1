# Knedlex.Roblox.Avatar.ApiV1.Api.RecentItemApi

All URIs are relative to *https://avatar.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1RecentItemsRecentItemListTypeListGet**](RecentItemApi.md#v1recentitemsrecentitemlisttypelistget) | **GET** /v1/recent-items/{recentItemListType}/list | Returns a list of recent items  Recent items can be Assets or Outfits |

<a id="v1recentitemsrecentitemlisttypelistget"></a>
# **V1RecentItemsRecentItemListTypeListGet**
> RobloxWebWebAPIModelsApiLegacyPageResponseRobloxApiAvatarModelsRecentItemModel V1RecentItemsRecentItemListTypeListGet (int recentItemListType)

Returns a list of recent items  Recent items can be Assets or Outfits

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1RecentItemsRecentItemListTypeListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://avatar.roblox.com";
            var apiInstance = new RecentItemApi(config);
            var recentItemListType = 0;  // int | 

            try
            {
                // Returns a list of recent items  Recent items can be Assets or Outfits
                RobloxWebWebAPIModelsApiLegacyPageResponseRobloxApiAvatarModelsRecentItemModel result = apiInstance.V1RecentItemsRecentItemListTypeListGet(recentItemListType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecentItemApi.V1RecentItemsRecentItemListTypeListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1RecentItemsRecentItemListTypeListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of recent items  Recent items can be Assets or Outfits
    ApiResponse<RobloxWebWebAPIModelsApiLegacyPageResponseRobloxApiAvatarModelsRecentItemModel> response = apiInstance.V1RecentItemsRecentItemListTypeListGetWithHttpInfo(recentItemListType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecentItemApi.V1RecentItemsRecentItemListTypeListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recentItemListType** | **int** |  |  |

### Return type

[**RobloxWebWebAPIModelsApiLegacyPageResponseRobloxApiAvatarModelsRecentItemModel**](RobloxWebWebAPIModelsApiLegacyPageResponseRobloxApiAvatarModelsRecentItemModel.md)

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

