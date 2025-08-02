using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace AzureFunctionApp
{
    public class HelloFunction
    {
        private readonly ILogger _logger;

        public HelloFunction(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HelloFunction>();
        }

        [Function("HelloFunction")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            //response.WriteString("Welcome to Azure Functions!");

            string name = req.Query["name"];
            if (string.IsNullOrWhiteSpace(name))
                response.WriteString("Hello, world!");
            else 
                response.WriteString($"Hello, {name}!");

            return response;
        }
    }
}
