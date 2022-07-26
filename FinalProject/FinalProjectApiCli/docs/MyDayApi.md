# FinalProjectApiCli.Api.MyDayApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MyDayDeletebystatusDelete**](MyDayApi.md#mydaydeletebystatusdelete) | **DELETE** /MyDay/Deletebystatus |  |
| [**MyDayDonePost**](MyDayApi.md#mydaydonepost) | **POST** /MyDay/Done |  |
| [**MyDayGet**](MyDayApi.md#mydayget) | **GET** /MyDay |  |
| [**MyDayNameDelete**](MyDayApi.md#mydaynamedelete) | **DELETE** /MyDay/{name} |  |
| [**MyDayNameGet**](MyDayApi.md#mydaynameget) | **GET** /MyDay/{name} |  |
| [**MyDayPost**](MyDayApi.md#mydaypost) | **POST** /MyDay |  |
| [**MyDayPut**](MyDayApi.md#mydayput) | **PUT** /MyDay |  |

<a name="mydaydeletebystatusdelete"></a>
# **MyDayDeletebystatusDelete**
> void MyDayDeletebystatusDelete (MyTask myTask = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;
using FinalProjectApiCli.Model;

namespace Example
{
    public class MyDayDeletebystatusDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MyDayApi(config);
            var myTask = new MyTask(); // MyTask |  (optional) 

            try
            {
                apiInstance.MyDayDeletebystatusDelete(myTask);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyDayApi.MyDayDeletebystatusDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MyDayDeletebystatusDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MyDayDeletebystatusDeleteWithHttpInfo(myTask);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyDayApi.MyDayDeletebystatusDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **myTask** | [**MyTask**](MyTask.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mydaydonepost"></a>
# **MyDayDonePost**
> void MyDayDonePost (MyTask myTask = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;
using FinalProjectApiCli.Model;

namespace Example
{
    public class MyDayDonePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MyDayApi(config);
            var myTask = new MyTask(); // MyTask |  (optional) 

            try
            {
                apiInstance.MyDayDonePost(myTask);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyDayApi.MyDayDonePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MyDayDonePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MyDayDonePostWithHttpInfo(myTask);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyDayApi.MyDayDonePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **myTask** | [**MyTask**](MyTask.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mydayget"></a>
# **MyDayGet**
> List&lt;MyTask&gt; MyDayGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;
using FinalProjectApiCli.Model;

namespace Example
{
    public class MyDayGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MyDayApi(config);

            try
            {
                List<MyTask> result = apiInstance.MyDayGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyDayApi.MyDayGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MyDayGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<MyTask>> response = apiInstance.MyDayGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyDayApi.MyDayGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;MyTask&gt;**](MyTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mydaynamedelete"></a>
# **MyDayNameDelete**
> void MyDayNameDelete (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;
using FinalProjectApiCli.Model;

namespace Example
{
    public class MyDayNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MyDayApi(config);
            var name = "name_example";  // string | 

            try
            {
                apiInstance.MyDayNameDelete(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyDayApi.MyDayNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MyDayNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MyDayNameDeleteWithHttpInfo(name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyDayApi.MyDayNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mydaynameget"></a>
# **MyDayNameGet**
> MyTask MyDayNameGet (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;
using FinalProjectApiCli.Model;

namespace Example
{
    public class MyDayNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MyDayApi(config);
            var name = "name_example";  // string | 

            try
            {
                MyTask result = apiInstance.MyDayNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyDayApi.MyDayNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MyDayNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MyTask> response = apiInstance.MyDayNameGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyDayApi.MyDayNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

[**MyTask**](MyTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mydaypost"></a>
# **MyDayPost**
> void MyDayPost (MyTask myTask = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;
using FinalProjectApiCli.Model;

namespace Example
{
    public class MyDayPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MyDayApi(config);
            var myTask = new MyTask(); // MyTask |  (optional) 

            try
            {
                apiInstance.MyDayPost(myTask);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyDayApi.MyDayPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MyDayPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MyDayPostWithHttpInfo(myTask);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyDayApi.MyDayPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **myTask** | [**MyTask**](MyTask.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mydayput"></a>
# **MyDayPut**
> void MyDayPut (string name = null, MyTask myTask = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;
using FinalProjectApiCli.Model;

namespace Example
{
    public class MyDayPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MyDayApi(config);
            var name = "name_example";  // string |  (optional) 
            var myTask = new MyTask(); // MyTask |  (optional) 

            try
            {
                apiInstance.MyDayPut(name, myTask);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyDayApi.MyDayPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MyDayPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MyDayPutWithHttpInfo(name, myTask);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyDayApi.MyDayPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  | [optional]  |
| **myTask** | [**MyTask**](MyTask.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

