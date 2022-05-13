// using Amazon.Lambda.Core;
// using System.IO;

// // Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
// [assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

// namespace TheNewPanelists;

// public class Function
// {
    
//     /// <summary>
//     /// https://docs.aws.amazon.com/lambda/latest/dg/csharp-handler.html
//     /// https://docs.aws.amazon.com/lambda/latest/dg/urls-invocation.html#urls-payloads
//     /// </summary>
//     /// <param name="input"></param> 
//     /// <param name="context"></param>
//     /// <returns></returns>
//     public Stream FunctionHandler(Stream input, ILambdaContext context)
//     {
//         // Console.WriteLine(input);
//         // Console.WriteLine(context);
//         // return Request.CreateResponse(HttpStatusCode.OK,input.ToUpper());
//         // return input.ToUpper();
//     }
// }
