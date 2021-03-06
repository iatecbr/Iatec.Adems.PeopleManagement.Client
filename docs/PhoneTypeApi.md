# Iatec.Adems.PeopleManagement.Client.Api.PhoneTypeApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetListPhoneTypeByFilter**](PhoneTypeApi.md#getlistphonetypebyfilter) | **GET** /phoneType/byFilter | 
[**GetListPhoneTypeByIdList**](PhoneTypeApi.md#getlistphonetypebyidlist) | **GET** /phoneType/byIdList | 
[**GetPhoneTypeById**](PhoneTypeApi.md#getphonetypebyid) | **GET** /phoneType/byId | 
[**PhoneTypeDeleteSystemReference**](PhoneTypeApi.md#phonetypedeletesystemreference) | **DELETE** /phoneType/systemReference | 
[**PhoneTypeSaveSystemReference**](PhoneTypeApi.md#phonetypesavesystemreference) | **PUT** /phoneType/systemReference | 


<a name="getlistphonetypebyfilter"></a>
# **GetListPhoneTypeByFilter**
> List<PhoneTypeModel> GetListPhoneTypeByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPhoneTypeByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneTypeApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;PhoneTypeModel&gt; result = apiInstance.GetListPhoneTypeByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneTypeApi.GetListPhoneTypeByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**|  | [optional] 

### Return type

[**List<PhoneTypeModel>**](PhoneTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistphonetypebyidlist"></a>
# **GetListPhoneTypeByIdList**
> List<PhoneTypeModel> GetListPhoneTypeByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPhoneTypeByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneTypeApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PhoneTypeModel&gt; result = apiInstance.GetListPhoneTypeByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneTypeApi.GetListPhoneTypeByIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PhoneTypeModel>**](PhoneTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphonetypebyid"></a>
# **GetPhoneTypeById**
> PhoneTypeModel GetPhoneTypeById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPhoneTypeByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                PhoneTypeModel result = apiInstance.GetPhoneTypeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneTypeApi.GetPhoneTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**PhoneTypeModel**](PhoneTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="phonetypedeletesystemreference"></a>
# **PhoneTypeDeleteSystemReference**
> void PhoneTypeDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class PhoneTypeDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.PhoneTypeDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneTypeApi.PhoneTypeDeleteSystemReference: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="phonetypesavesystemreference"></a>
# **PhoneTypeSaveSystemReference**
> void PhoneTypeSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class PhoneTypeSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.PhoneTypeSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneTypeApi.PhoneTypeSaveSystemReference: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

