# devops-cicd-dotnet

This repository demonstrates a complete CI/CD pipeline for a simple ASP.NET Core web application using both Azure DevOps and Jenkins. It is part of the [canepro DevOps Portfolio](https://github.com/canepro/devops-portfolio).

## Contents
- `src/WebApp/` – ASP.NET Core web application
- `tests/WebApp.Tests/` – Unit tests
- `azure-pipelines.yml` – Azure DevOps pipeline definition
- `Jenkinsfile` – Jenkins pipeline definition
- `README.md` – Project documentation

## Setup Instructions

### Prerequisites
- .NET 8 SDK
- Azure DevOps account
- Jenkins server (local or cloud)
- Azure subscription (for deployment)

### 1. Clone the repository
```pwsh
git clone https://github.com/canepro/devops-cicd-dotnet.git
cd devops-cicd-dotnet
```

### 2. Set up the .NET app
```pwsh
dotnet restore
dotnet build
```

### 3. Run tests
```pwsh
dotnet test
```

### 4. Configure Azure DevOps Pipeline
- Import this repo into Azure DevOps.
- Set up a Service Connection to your Azure subscription.
- Edit `azure-pipelines.yml` as needed (set your app name, etc).

### 5. Configure Jenkins Pipeline
- Install .NET SDK and Azure CLI on your Jenkins agent.
- Connect Jenkins to this GitHub repo.
- Use the provided `Jenkinsfile`.

## Pipeline Files

### azure-pipelines.yml
Automates build, test, and deploy to Azure App Service.

### Jenkinsfile
Automates build, test, and deploy using Jenkins and Azure CLI.

## Challenges Faced
- .NET SDK version compatibility in CI/CD
- Azure CLI authentication in CI/CD

## Screenshots/Diagrams
_Add screenshots of pipeline runs and app deployment here._

## References
- [Azure DevOps Pipelines Documentation](https://docs.microsoft.com/azure/devops/pipelines/)
- [Jenkins Pipeline Documentation](https://www.jenkins.io/doc/book/pipeline/)
- [ASP.NET Core Documentation](https://learn.microsoft.com/aspnet/core/)
