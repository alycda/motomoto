using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;

using Amazon.Lambda.Core;
// using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Serialization.SystemTextJson;
// using Amazon.Lambda.Serialization.Json;

// [assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

[assembly:
LambdaSerializer(typeof(SourceGeneratorLambdaJsonSerializer<TheNewPanelists.HttpApiJsonSerializerContext>))]

// [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace TheNewPanelists;

// https://docs.aws.amazon.com/lambda/latest/dg/urls-invocation.html#urls-payloads
public class FunctionRequest
    {
        public string? rawPath { get; set; }
    }

// https://devblogs.microsoft.com/dotnet/try-the-new-system-text-json-source-generator/
public class FunctionResponse
    {
        public int StatusCode { get; set; }
        public string? Body { get; set; }

        public IDictionary<string, string> Headers { get; set; }
    }

// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-6-0
[JsonSerializable(typeof(FunctionRequest))]
[JsonSerializable(typeof(FunctionResponse))]

public partial class HttpApiJsonSerializerContext : JsonSerializerContext
{
}

// https://docs.aws.amazon.com/lambda/latest/dg/csharp-handler.html
public class Function
{
    public FunctionResponse FunctionHandler(FunctionRequest
request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request");
        // context.Logger.LogInformation(request);
        context.Logger.LogInformation(request.rawPath);
        // context.Logger.LogInformation(request.queryStringParameters);
        // context.Logger.LogInformation(request.body);

        // https://github.com/aws/aws-lambda-dotnet/issues/1124
        var response = new FunctionResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "Hello AWS Serverless",
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };
            
        return response;

        // return "OK";
    }
}