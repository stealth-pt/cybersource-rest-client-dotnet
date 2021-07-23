/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICaptureApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>PtsV2PaymentsCapturesPost201Response</returns>
        PtsV2PaymentsCapturesPost201Response CapturePayment (CapturePaymentRequest capturePaymentRequest, string id);

        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>ApiResponse of PtsV2PaymentsCapturesPost201Response</returns>
        ApiResponse<PtsV2PaymentsCapturesPost201Response> CapturePaymentWithHttpInfo (CapturePaymentRequest capturePaymentRequest, string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of PtsV2PaymentsCapturesPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsCapturesPost201Response> CapturePaymentAsync (CapturePaymentRequest capturePaymentRequest, string id);

        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsCapturesPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsCapturesPost201Response>> CapturePaymentAsyncWithHttpInfo (CapturePaymentRequest capturePaymentRequest, string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CaptureApi : ICaptureApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CaptureApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CaptureApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
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
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
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
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Capture a Payment Include the payment ID in the POST request to capture the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>PtsV2PaymentsCapturesPost201Response</returns>
        public PtsV2PaymentsCapturesPost201Response CapturePayment (CapturePaymentRequest capturePaymentRequest, string id)
        {
            logger.Debug("CALLING API \"CapturePayment\" STARTED");
            ApiResponse<PtsV2PaymentsCapturesPost201Response> localVarResponse = CapturePaymentWithHttpInfo(capturePaymentRequest, id);
            logger.Debug("CALLING API \"CapturePayment\" ENDED");
            return localVarResponse.Data;
        }

        /// <summary>
        /// Capture a Payment Include the payment ID in the POST request to capture the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>ApiResponse of PtsV2PaymentsCapturesPost201Response</returns>
        public ApiResponse< PtsV2PaymentsCapturesPost201Response > CapturePaymentWithHttpInfo (CapturePaymentRequest capturePaymentRequest, string id)
        {
            // verify the required parameter 'capturePaymentRequest' is set
            if (capturePaymentRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'capturePaymentRequest' when calling CaptureApi->CapturePayment");
                throw new ApiException(400, "Missing required parameter 'capturePaymentRequest' when calling CaptureApi->CapturePayment");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling CaptureApi->CapturePayment");
                throw new ApiException(400, "Missing required parameter 'id' when calling CaptureApi->CapturePayment");
            }

            var localVarPath = $"/pts/v2/payments/{id}/captures";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{LogUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (capturePaymentRequest != null && capturePaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(capturePaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = capturePaymentRequest; // byte array
            }

            if (LogUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{LogUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CapturePayment", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsCapturesPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsCapturesPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsCapturesPost201Response))); // Return statement
        }

        /// <summary>
        /// Capture a Payment Include the payment ID in the POST request to capture the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of PtsV2PaymentsCapturesPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsCapturesPost201Response> CapturePaymentAsync (CapturePaymentRequest capturePaymentRequest, string id)
        {
            logger.Debug("CALLING API \"CapturePaymentAsync\" STARTED");
            ApiResponse<PtsV2PaymentsCapturesPost201Response> localVarResponse = await CapturePaymentAsyncWithHttpInfo(capturePaymentRequest, id);
            logger.Debug("CALLING API \"CapturePaymentAsync\" STARTED");
            return localVarResponse.Data;

        }

        /// <summary>
        /// Capture a Payment Include the payment ID in the POST request to capture the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsCapturesPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsCapturesPost201Response>> CapturePaymentAsyncWithHttpInfo (CapturePaymentRequest capturePaymentRequest, string id)
        {
            // verify the required parameter 'capturePaymentRequest' is set
            if (capturePaymentRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'capturePaymentRequest' when calling CaptureApi->CapturePayment");
                throw new ApiException(400, "Missing required parameter 'capturePaymentRequest' when calling CaptureApi->CapturePayment");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling CaptureApi->CapturePayment");
                throw new ApiException(400, "Missing required parameter 'id' when calling CaptureApi->CapturePayment");
            }

            var localVarPath = $"/pts/v2/payments/{id}/captures";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{LogUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (capturePaymentRequest != null && capturePaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(capturePaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = capturePaymentRequest; // byte array
            }

            if (LogUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{LogUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CapturePayment", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsCapturesPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsCapturesPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsCapturesPost201Response))); // Return statement
        }
    }
}
