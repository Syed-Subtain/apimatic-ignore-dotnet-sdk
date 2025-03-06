
# Getting Started with Apimatic Calculator

## Introduction

Simple calculator API hosted on APIMATIC

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package ApimaticignoreSDK --version 9.6.1
```

You can also view the package at:
https://www.nuget.org/packages/ApimaticignoreSDK/9.6.1

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |

The API client can be initialized as follows:

```csharp
ApimaticCalculatorClient client = new ApimaticCalculatorClient.Builder()
    .Environment(ApimaticCalculator.Standard.Environment.Production)
    .Build();
```

## List of APIs

* [Simple Calculator](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/controllers/simple-calculator.md)

## Additional Documentation

### Wrappers

* [HttpRequest](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/http-request.md)
* [HttpResponse](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/http-string-response.md)
* [HttpContext](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/http-client-configuration-builder.md)
* [ApiException](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/api-exception.md)

### Utilities

* [ApiHelper](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/api-helper.md)
* [HttpCallback](https://www.github.com/Syed-Subtain/apimatic-ignore-dotnet-sdk/tree/9.6.1/doc/http-callback.md)

