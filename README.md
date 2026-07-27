Azure Function App

Overview

Architecture

Technology Stack

Function Workflow

Implementation Highlights

Getting Started

Configuration

Future Enhancements

# ⚡ Azure Function App

> A serverless HTTP API built using **Azure Functions (.NET Isolated Worker)** demonstrating cloud-native development, dependency injection, structured logging, and event-driven application design.

![Azure Functions](https://img.shields.io/badge/Azure_Functions-Serverless-0062AD?style=for-the-badge&logo=microsoftazure)
![.NET](https://img.shields.io/badge/.NET-8-512BD4?style=for-the-badge&logo=.net)
![C#](https://img.shields.io/badge/C%23-Programming-239120?style=for-the-badge&logo=csharp)

## 📖 Project Overview

This project demonstrates an HTTP-triggered Azure Function built using the .NET isolated worker model.

The function exposes a lightweight serverless API endpoint that accepts HTTP GET/POST requests and returns a personalized greeting response.

The implementation demonstrates fundamental Azure Functions concepts including:

- HTTP triggers
- Dependency injection
- Structured logging
- Serverless execution model
- Cloud-native application development

## 🏗 Architecture

```mermaid
flowchart LR

Client[Client Application]
    --> Function[Azure Function<br/>HTTP Trigger]

Function --> Logic[Function Business Logic]

Logic --> Response[HTTP Response]


This renders directly on GitHub.

---

# Technology Stack

```markdown
## 🛠 Technology Stack

### Cloud

- Microsoft Azure Functions
- Azure Functions Runtime

### Backend

- C#
- .NET Isolated Worker Model
- HTTP Trigger

### Development

- Visual Studio
- Azure Functions Core Tools
- Git

## 🔄 Function Workflow

1. Client sends HTTP GET/POST request.
2. Azure Functions runtime activates the HTTP trigger.
3. Function validates the incoming `name` parameter.
4. Business logic generates the response.
5. HTTP response is returned to the caller.

Example:

```txt

GET /api/HelloFunction?name=Raj

Response:

Hello, Raj!

```

## 🚀 Implementation Highlights

- Developed using Azure Functions .NET isolated worker model.
- Implemented HTTP-triggered serverless API endpoint.
- Applied dependency injection using `ILoggerFactory`.
- Added structured logging using Microsoft.Extensions.Logging.
- Implemented clean request-response handling using `HttpRequestData` and `HttpResponseData`.


## ⚙️ Getting Started

### Prerequisites

- .NET SDK
- Azure Functions Core Tools
- Visual Studio 2022

### Run Locally

```bash
git clone https://github.com/Raj-Kumar-Arora/AzureFunctionApp.git

cd AzureFunctionApp

dotnet restore

func start
```

Once started, the Azure Functions runtime hosts the HTTP-triggered endpoint locally for testing and development.

---

# Future Enhancements

```markdown
## 🔮 Future Enhancements

- Add Azure Service Bus trigger
- Add Blob Storage integration
- Add Application Insights monitoring
- Add Azure Key Vault configuration
- Deploy using Azure DevOps / GitHub Actions CI/CD
- Containerize with Docker
