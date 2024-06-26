# Knedlex.Roblox.Avatar.ApiV1.Api.BatchApi

All URIs are relative to *https://thumbnails.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1BatchPost**](BatchApi.md#v1batchpost) | **POST** /v1/batch | Returns a list of thumbnails with varying types and sizes |

<a id="v1batchpost"></a>
# **V1BatchPost**
> RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailBatchResponse V1BatchPost (List<RobloxThumbnailsApisModelsThumbnailBatchRequest> requests, long? robloxPlaceId = null)

Returns a list of thumbnails with varying types and sizes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Avatar.ApiV1.Api;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Example
{
    public class V1BatchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://thumbnails.roblox.com";
            var apiInstance = new BatchApi(config);
            var requests = new List<RobloxThumbnailsApisModelsThumbnailBatchRequest>(); // List<RobloxThumbnailsApisModelsThumbnailBatchRequest> | List of ThumbnailBatchRequest objects, may contain the following request types:              1. Avatar              2. AvatarHeadShot              3. GameIcon              4. BadgeIcon              5. GameThumbnail              6. GamePass              7. Asset              8. BundleThumbnail              9. Outfit              10. GroupIcon              11. DeveloperProduct              12. AutoGeneratedAsset              13. AvatarBust              14. PlaceIcon              15. AutoGeneratedGameIcon              16. ForceAutoGeneratedGameIcon              17. Look
            var robloxPlaceId = 789L;  // long? | (optional) placeid (optional) 

            try
            {
                // Returns a list of thumbnails with varying types and sizes
                RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailBatchResponse result = apiInstance.V1BatchPost(requests, robloxPlaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.V1BatchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1BatchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of thumbnails with varying types and sizes
    ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailBatchResponse> response = apiInstance.V1BatchPostWithHttpInfo(requests, robloxPlaceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.V1BatchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requests** | [**List&lt;RobloxThumbnailsApisModelsThumbnailBatchRequest&gt;**](RobloxThumbnailsApisModelsThumbnailBatchRequest.md) | List of ThumbnailBatchRequest objects, may contain the following request types:              1. Avatar              2. AvatarHeadShot              3. GameIcon              4. BadgeIcon              5. GameThumbnail              6. GamePass              7. Asset              8. BundleThumbnail              9. Outfit              10. GroupIcon              11. DeveloperProduct              12. AutoGeneratedAsset              13. AvatarBust              14. PlaceIcon              15. AutoGeneratedGameIcon              16. ForceAutoGeneratedGameIcon              17. Look |  |
| **robloxPlaceId** | **long?** | (optional) placeid | [optional]  |

### Return type

[**RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailBatchResponse**](RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailBatchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: There are too many requested Ids.  2: The requested image format is invalid. Please see documentation for valid thumbnail format parameter name and values.  3: The requested size is invalid. Please see documentation for valid thumbnail size parameter name and format.  4: The requested Ids are invalid, of an invalid type or missing.  7: The specified type is not supported by the batch endpoint |  -  |
| **403** | 9: User not authorized to use AutoGenerated or ForceAutoGenerated return policies. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

