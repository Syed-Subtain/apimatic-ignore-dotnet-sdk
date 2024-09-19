
# Getting Started with apimatic calculator

## Introduction

Simple calculator API hosted on APIMATIC

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package apimaticignoredotnetsdk --version 2.2.2
```

You can also view the package at:
https://www.nuget.org/packages/apimaticignoredotnetsdk/2.2.2

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/client.md)

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

* [Simple Calculator](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/controllers/simple-calculator.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/http-request.md)
* [HttpResponse](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/http-string-response.md)
* [HttpContext](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/syed-subtain/apimatic-ignore-dotnet-sdk/tree/2.2.2/doc/api-exception.md)

