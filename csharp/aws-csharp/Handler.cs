using System.Runtime.Serialization.Json;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using System;
using Newtonsoft.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
    public class Handler
    {
        public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request)
        {
            return new APIGatewayProxyResponse
            {
                Body = JsonConvert.SerializeObject(new { Message = "Test body" }),
                StatusCode = 200
            };
        }
    }

}
