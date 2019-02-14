## Introduction

The Uiza API is organized around RESTful standard. Our API has predictable, resource-oriented URLs, and uses HTTP response codes to indicate API errors. JSON is returned by all API responses, including errors, although our API libraries convert responses to appropriate language-specific objects.

The library building project provides convenient access to the Uiza API, supporting .NET Standard 1.6+, .NET Core 2.0+, and .NET Framework 4.5.2+

## Documentation

See the [.NET API docs](https://docs.uiza.io/).

## Installation

### Install Uiza.net via NuGet

From the command line:

	nuget install Uiza.net

From Package Manager:

	PM> Install-Package Uiza.net

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Uiza.net".
5. Click on the Uiza.net package, select the appropriate version in the right-tab and click *Install*.

### Set the API Key for your project

You can configure the Uiza.net package to use your secret API key by the way:

In your application initialization, set your API key (only once once during startup):

```Csharp
UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "Your api key here",
	ApiBase = "Work Space"
});
```


You can obtain your secret API key from the [API Settings](https://docs.uiza.io/#get-api-key) in the Dashboard.


## Additional Resources


## Support

* Make sure to review open [issues](https://github.com/uizaio/api-wrapper-dotnet/issues) and [pull requests](https://github.com/uizaio/api-wrapper-dotnet/pulls) before opening a new issue.
* Feel free to leave a comment or [reaction](https://github.com/blog/2119-add-reactions-to-pull-requests-issues-and-comments) on any existing issues.

## Helpful Library Information


### Responses

The[`UizaResponse`](./src/Uiza.Net/Response/Base/UizaResponse.cs) class is an base Response which all Responses in Uiza.net inheritance. 

Please see [`Uiza introduction`](https://docs.uiza.io/#introduction)

```Csharp
    public class UizaResponse : IUizaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datetime")]
        public string DateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy")]
        public string policy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata")]
        public dynamic MetaData { get; set; }
    }
```

The[`UizaData`](.src/Uiza.Net/Response/Base/UizaData.cs) class inheritance from **UizaResponse**. 

```Csharp
    /// <summary>
    /// 
    /// </summary>
    public class UizaData : UizaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public dynamic Data { get; set; }
    }
```

Using [`QueryJsonDynamic`](https://www.newtonsoft.com/json/help/html/QueryJsonDynamic.htm) to Parse API Response

see the [`Create Entity API`](https://docs.uiza.io/#create-entity) and Example

```Csharp
	var service = new EntityService();
	var result = service.Create(...);
	Console.WriteLine(string.Format("Create New Entity Id = {0} Success", result.Data.id));
```

### UizaException

The[`UizaException`](.src/Uiza.Net/UizaException/UizaException.cs) Object is an attribute inheritance from [`Exception`](https://docs.microsoft.com/en-us/dotnet/api/system.exception?view=netframework-4.5.2)

```Csharp
	/// <summary>
    /// 
    /// </summary>
    public class UizaException : Exception
    {
        /// <summary>
        /// constain errors with Uiza.Net Format
        /// </summary>
        public UizaExceptionResponse UizaInnerException { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UizaException()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public UizaException(string message)
            : base(message)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public UizaException(string message, Exception ex)
            : base(message, ex)
        {
        }
        /// <summary>
        /// Constructor Exception from API Response
        /// </summary>
        /// <param name="error"></param>
        public UizaException(UizaExceptionResponse error)
            : base(error.Message)
        {
            this.UizaInnerException = error;
        }

        /// <summary>
        /// Constructor Exception with custom Error
        /// </summary>
        /// <param name="message"></param>
        /// <param name="error"></param>
        public UizaException(string message, UizaExceptionResponse error)
            : base(message)
        {
            this.UizaInnerException = error;
        }
    }
```

using **try catch** to handle Error

```Csharp
 try
 {
	////
 }
 catch (UizaException ex)
 {
	var result = ex.UizaInnerException.Error;
 }
```

**UizaExceptionResponse**
The[`UizaExceptionResponse`](.src/Uiza.Net/UizaException/UizaExceptionResponse.cs)

```Csharp
	public class UizaExceptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("retryable")]
        public bool RetryAble { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }

        /// <summary>
        /// First Error
        /// </summary>
        public ErrorData Error
        {
            get
            {
                return Errors.FirstOrDefault() ?? new ErrorData();
            }
        }

        /// <summary>
        /// This Property Handle Error and return list Error
		///	The error may be one of the formats
		///	- string
		///	- object
		///	- json Array
		///	- List custom Error (List<ErrorData>)
        /// </summary>
        public List<ErrorData> Errors
        {
            get
            {
                if (Data.IsJArray())
                    return JsonConvert.DeserializeObject<List<ErrorData>>(JsonConvert.SerializeObject(Data));
                if (Data is IList<ErrorData>)
                    return (List<ErrorData>)Data;
                if (Data is string)
                    return new List<ErrorData>() {
                        new ErrorData()
                        {
                            Message = Message,
                            Type = Type
                        }
                    };
                return new List<ErrorData>() {
                    JsonConvert.DeserializeObject<ErrorData>(JsonConvert.SerializeObject(Data))
                };
            }
        }
    }

    /// <summary>
    /// This Object Constain Error Infomation
    /// </summary>
    public class ErrorData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }
    }
```

## Usage

```Csharp
	try
	{
		var service = new EntityService();
		var result = service.Create(...);
		Console.WriteLine(string.Format("Create New Entity Id = {0} Success", result.Data.id));
		Console.ReadLine();
	}
	catch (UizaException ex)
	{
		var result = ex.UizaInnerException.Error;
		Console.WriteLine(ex.Message);
		Console.ReadLine();
	}
```

## Contribution Guidelines

We welcome contributions from anyone interested in Uiza or Uiza.net development. If you'd like to submit a pull request, it's best to start with an issue to describe what you'd like to build.