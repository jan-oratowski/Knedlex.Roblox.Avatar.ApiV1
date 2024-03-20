/*
 * Thumbnails Api v1
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Knedlex.Roblox.Avatar.ApiV1.Client;
using Knedlex.Roblox.Avatar.ApiV1.Model;

namespace Knedlex.Roblox.Avatar.ApiV1.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeveloperProductsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Thumbnails developer product icons.
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Avatar.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="developerProductIds">The developer product ids.</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 150x150)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse V1DeveloperProductsIconsGet(List<long> developerProductIds, string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Thumbnails developer product icons.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Avatar.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="developerProductIds">The developer product ids.</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 150x150)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> V1DeveloperProductsIconsGetWithHttpInfo(List<long> developerProductIds, string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeveloperProductsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Thumbnails developer product icons.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Avatar.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="developerProductIds">The developer product ids.</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 150x150)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        System.Threading.Tasks.Task<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> V1DeveloperProductsIconsGetAsync(List<long> developerProductIds, string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Thumbnails developer product icons.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Avatar.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="developerProductIds">The developer product ids.</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 150x150)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>> V1DeveloperProductsIconsGetWithHttpInfoAsync(List<long> developerProductIds, string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeveloperProductsApi : IDeveloperProductsApiSync, IDeveloperProductsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeveloperProductsApi : IDeveloperProductsApi
    {
        private Knedlex.Roblox.Avatar.ApiV1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeveloperProductsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeveloperProductsApi(string basePath)
        {
            this.Configuration = Knedlex.Roblox.Avatar.ApiV1.Client.Configuration.MergeConfigurations(
                Knedlex.Roblox.Avatar.ApiV1.Client.GlobalConfiguration.Instance,
                new Knedlex.Roblox.Avatar.ApiV1.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Knedlex.Roblox.Avatar.ApiV1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Knedlex.Roblox.Avatar.ApiV1.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Knedlex.Roblox.Avatar.ApiV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperProductsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeveloperProductsApi(Knedlex.Roblox.Avatar.ApiV1.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Knedlex.Roblox.Avatar.ApiV1.Client.Configuration.MergeConfigurations(
                Knedlex.Roblox.Avatar.ApiV1.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Knedlex.Roblox.Avatar.ApiV1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Knedlex.Roblox.Avatar.ApiV1.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Knedlex.Roblox.Avatar.ApiV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperProductsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DeveloperProductsApi(Knedlex.Roblox.Avatar.ApiV1.Client.ISynchronousClient client, Knedlex.Roblox.Avatar.ApiV1.Client.IAsynchronousClient asyncClient, Knedlex.Roblox.Avatar.ApiV1.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Knedlex.Roblox.Avatar.ApiV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Knedlex.Roblox.Avatar.ApiV1.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Knedlex.Roblox.Avatar.ApiV1.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Knedlex.Roblox.Avatar.ApiV1.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Knedlex.Roblox.Avatar.ApiV1.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Thumbnails developer product icons. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Avatar.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="developerProductIds">The developer product ids.</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 150x150)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        public RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse V1DeveloperProductsIconsGet(List<long> developerProductIds, string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0)
        {
            Knedlex.Roblox.Avatar.ApiV1.Client.ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> localVarResponse = V1DeveloperProductsIconsGetWithHttpInfo(developerProductIds, size, format, isCircular);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Thumbnails developer product icons. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Avatar.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="developerProductIds">The developer product ids.</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 150x150)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        public Knedlex.Roblox.Avatar.ApiV1.Client.ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> V1DeveloperProductsIconsGetWithHttpInfo(List<long> developerProductIds, string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0)
        {
            // verify the required parameter 'developerProductIds' is set
            if (developerProductIds == null)
            {
                throw new Knedlex.Roblox.Avatar.ApiV1.Client.ApiException(400, "Missing required parameter 'developerProductIds' when calling DeveloperProductsApi->V1DeveloperProductsIconsGet");
            }

            Knedlex.Roblox.Avatar.ApiV1.Client.RequestOptions localVarRequestOptions = new Knedlex.Roblox.Avatar.ApiV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json"
            };

            var localVarContentType = Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.ParameterToMultiMap("csv", "developerProductIds", developerProductIds));
            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }
            if (isCircular != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "isCircular", isCircular));
            }

            localVarRequestOptions.Operation = "DeveloperProductsApi.V1DeveloperProductsIconsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>("/v1/developer-products/icons", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1DeveloperProductsIconsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Thumbnails developer product icons. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Avatar.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="developerProductIds">The developer product ids.</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 150x150)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        public async System.Threading.Tasks.Task<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> V1DeveloperProductsIconsGetAsync(List<long> developerProductIds, string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Knedlex.Roblox.Avatar.ApiV1.Client.ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> localVarResponse = await V1DeveloperProductsIconsGetWithHttpInfoAsync(developerProductIds, size, format, isCircular, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Thumbnails developer product icons. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Avatar.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="developerProductIds">The developer product ids.</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 150x150)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse)</returns>
        public async System.Threading.Tasks.Task<Knedlex.Roblox.Avatar.ApiV1.Client.ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>> V1DeveloperProductsIconsGetWithHttpInfoAsync(List<long> developerProductIds, string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'developerProductIds' is set
            if (developerProductIds == null)
            {
                throw new Knedlex.Roblox.Avatar.ApiV1.Client.ApiException(400, "Missing required parameter 'developerProductIds' when calling DeveloperProductsApi->V1DeveloperProductsIconsGet");
            }


            Knedlex.Roblox.Avatar.ApiV1.Client.RequestOptions localVarRequestOptions = new Knedlex.Roblox.Avatar.ApiV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json"
            };

            var localVarContentType = Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.ParameterToMultiMap("csv", "developerProductIds", developerProductIds));
            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }
            if (isCircular != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Avatar.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "isCircular", isCircular));
            }

            localVarRequestOptions.Operation = "DeveloperProductsApi.V1DeveloperProductsIconsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>("/v1/developer-products/icons", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1DeveloperProductsIconsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}