# devops-cicd-nodejs

This repository demonstrates a complete CI/CD pipeline for a simple Node.js web application using both Azure DevOps and Jenkins. It is part of the [canepro DevOps Portfolio](https://github.com/canepro/devops-portfolio).

## Contents
- `app/` – Express web application
- `tests/` – Unit tests
- `package.json` – Node.js dependencies and scripts
- `azure-pipelines.yml` – Azure DevOps pipeline definition
- `Jenkinsfile` – Jenkins pipeline definition
- `README.md` – Project documentation

## Setup Instructions

### Prerequisites
- Node.js 18+
- npm
- Azure DevOps account
- Jenkins server (local or cloud)
- Azure subscription (for deployment)

### 1. Clone the repository
```pwsh
git clone https://github.com/canepro/devops-cicd-nodejs.git
cd devops-cicd-nodejs
```

### 2. Set up the Node.js app
```pwsh
npm install
```

### 3. Run tests
```pwsh
npm test
```

### 4. Configure Azure DevOps Pipeline
- Import this repo into Azure DevOps.
- Set up a Service Connection to your Azure subscription.
- Edit `azure-pipelines.yml` as needed (set your app name, etc).

### 5. Configure Jenkins Pipeline
- Install Node.js and Azure CLI on your Jenkins agent.
- Connect Jenkins to this GitHub repo.
- Use the provided `Jenkinsfile`.

## Pipeline Files

### azure-pipelines.yml
Automates build, test, and deploy to Azure App Service.

### Jenkinsfile
Automates build, test, and deploy using Jenkins and Azure CLI.

## Challenges Faced
- Node.js version compatibility in CI/CD
- Azure CLI authentication in CI/CD

## Screenshots/Diagrams
_Add screenshots of pipeline runs and app deployment here._

## References
- [Azure DevOps Pipelines Documentation](https://docs.microsoft.com/azure/devops/pipelines/)
- [Jenkins Pipeline Documentation](https://www.jenkins.io/doc/book/pipeline/)
- [Express Documentation](https://expressjs.com/)
