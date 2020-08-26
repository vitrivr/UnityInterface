/* 
 * Cineast RESTful API
 *
 * Cineast is vitrivr's content-based multimedia retrieval engine. This is it's RESTful API.
 *
 * The version of the OpenAPI document: v1
 * Contact: contact@vitrivr.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Org.Vitrivr.CineastApi.Client;
using Org.Vitrivr.CineastApi.Model;

namespace Org.Vitrivr.CineastApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMiscApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Find all distinct elements of a given column
        /// </summary>
        /// <remarks>
        /// Find all distinct elements of a given column. Please note that this operation does cache results.
        /// </remarks>
        /// <exception cref="Org.Vitrivr.CineastApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="columnSpecification"> (optional)</param>
        /// <returns>DistinctElementsResult</returns>
        DistinctElementsResult FindDistinctElementsByColumn (ColumnSpecification columnSpecification = default(ColumnSpecification));

        /// <summary>
        /// Find all distinct elements of a given column
        /// </summary>
        /// <remarks>
        /// Find all distinct elements of a given column. Please note that this operation does cache results.
        /// </remarks>
        /// <exception cref="Org.Vitrivr.CineastApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="columnSpecification"> (optional)</param>
        /// <returns>ApiResponse of DistinctElementsResult</returns>
        ApiResponse<DistinctElementsResult> FindDistinctElementsByColumnWithHttpInfo (ColumnSpecification columnSpecification = default(ColumnSpecification));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Find all distinct elements of a given column
        /// </summary>
        /// <remarks>
        /// Find all distinct elements of a given column. Please note that this operation does cache results.
        /// </remarks>
        /// <exception cref="Org.Vitrivr.CineastApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="columnSpecification"> (optional)</param>
        /// <returns>Task of DistinctElementsResult</returns>
        System.Threading.Tasks.Task<DistinctElementsResult> FindDistinctElementsByColumnAsync (ColumnSpecification columnSpecification = default(ColumnSpecification));

        /// <summary>
        /// Find all distinct elements of a given column
        /// </summary>
        /// <remarks>
        /// Find all distinct elements of a given column. Please note that this operation does cache results.
        /// </remarks>
        /// <exception cref="Org.Vitrivr.CineastApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="columnSpecification"> (optional)</param>
        /// <returns>Task of ApiResponse (DistinctElementsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<DistinctElementsResult>> FindDistinctElementsByColumnAsyncWithHttpInfo (ColumnSpecification columnSpecification = default(ColumnSpecification));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MiscApi : IMiscApi
    {
        private Org.Vitrivr.CineastApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MiscApi(String basePath)
        {
            this.Configuration = new Org.Vitrivr.CineastApi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.Vitrivr.CineastApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscApi"/> class
        /// </summary>
        /// <returns></returns>
        public MiscApi()
        {
            this.Configuration = Org.Vitrivr.CineastApi.Client.Configuration.Default;

            ExceptionFactory = Org.Vitrivr.CineastApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MiscApi(Org.Vitrivr.CineastApi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.Vitrivr.CineastApi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.Vitrivr.CineastApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.Vitrivr.CineastApi.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.Vitrivr.CineastApi.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Find all distinct elements of a given column Find all distinct elements of a given column. Please note that this operation does cache results.
        /// </summary>
        /// <exception cref="Org.Vitrivr.CineastApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="columnSpecification"> (optional)</param>
        /// <returns>DistinctElementsResult</returns>
        public DistinctElementsResult FindDistinctElementsByColumn (ColumnSpecification columnSpecification = default(ColumnSpecification))
        {
             ApiResponse<DistinctElementsResult> localVarResponse = FindDistinctElementsByColumnWithHttpInfo(columnSpecification);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find all distinct elements of a given column Find all distinct elements of a given column. Please note that this operation does cache results.
        /// </summary>
        /// <exception cref="Org.Vitrivr.CineastApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="columnSpecification"> (optional)</param>
        /// <returns>ApiResponse of DistinctElementsResult</returns>
        public ApiResponse<DistinctElementsResult> FindDistinctElementsByColumnWithHttpInfo (ColumnSpecification columnSpecification = default(ColumnSpecification))
        {

            var localVarPath = "/api/v1/find/boolean/column/distinct";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (columnSpecification != null && columnSpecification.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(columnSpecification); // http body (model) parameter
            }
            else
            {
                localVarPostBody = columnSpecification; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindDistinctElementsByColumn", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DistinctElementsResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DistinctElementsResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DistinctElementsResult)));
        }

        /// <summary>
        /// Find all distinct elements of a given column Find all distinct elements of a given column. Please note that this operation does cache results.
        /// </summary>
        /// <exception cref="Org.Vitrivr.CineastApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="columnSpecification"> (optional)</param>
        /// <returns>Task of DistinctElementsResult</returns>
        public async System.Threading.Tasks.Task<DistinctElementsResult> FindDistinctElementsByColumnAsync (ColumnSpecification columnSpecification = default(ColumnSpecification))
        {
             ApiResponse<DistinctElementsResult> localVarResponse = await FindDistinctElementsByColumnAsyncWithHttpInfo(columnSpecification);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find all distinct elements of a given column Find all distinct elements of a given column. Please note that this operation does cache results.
        /// </summary>
        /// <exception cref="Org.Vitrivr.CineastApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="columnSpecification"> (optional)</param>
        /// <returns>Task of ApiResponse (DistinctElementsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DistinctElementsResult>> FindDistinctElementsByColumnAsyncWithHttpInfo (ColumnSpecification columnSpecification = default(ColumnSpecification))
        {

            var localVarPath = "/api/v1/find/boolean/column/distinct";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (columnSpecification != null && columnSpecification.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(columnSpecification); // http body (model) parameter
            }
            else
            {
                localVarPostBody = columnSpecification; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindDistinctElementsByColumn", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DistinctElementsResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DistinctElementsResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DistinctElementsResult)));
        }

    }
}
