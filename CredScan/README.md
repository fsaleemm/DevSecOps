# Credentail Scan

The documentation here contains an example of using the [Microsoft Security Code Analysis Extension](https://docs.microsoft.com/en-us/azure/security/develop/security-code-analysis-overview) for performing Credentail scanning in source code. Additionally, an example of customizing the Credentail scanning capabilities to include detecting SSNs and Credit Card numbers is provided. 

## High Level Steps

1) Install the Microsoft Security Code Analysis Extension by following instruction [here](https://docs.microsoft.com/en-us/azure/security/develop/security-code-analysis-onboard#onboarding-the-microsoft-security-code-analysis-extension).
2) Setup Github integrations with Azure Pipelines by following instructions [here](https://www.azuredevopslabs.com/labs/vstsextend/github-azurepipelines/#task-1-installing-azure-pipelines-from-github-marketplace). Use this option if your code repository is GitHub.
3) Configure Azure DevOps Pipeline for Contiuous Integration following instructions [here](https://www.azuredevopslabs.com/labs/vstsextend/github-azurepipelines/#task-1-installing-azure-pipelines-from-github-marketplace). For step 4 use the YAML [here](https://github.com/fsaleemm/DevSecOps).
4) Run the Azure DevOps Pipeline and review the reports. See below for details.

## Structure of the directory

- CredScan/jobs: This directory contains the CI pipeline job templates. These are broken into the Build and Test and Credential Scanning jobs.
    - Build_Test-1.yml: The YAML that defines the build and test tasks for the source code in src/CSharpProject directory.
    - CredScan-1.yml: The YAML that defines the Credential Scanning tasks. 
    - CredScan-custom-searchers.yml: The YAML that defines the Credential scanning tasks using customizations, for example, detecting SSNs and Credit Card numbers.
- CredScan/searchers: This directory contains the definition of the custom searchers.
- CredScan/src: The source code used as an example for credential scanning. The code intentionally contains issues to highlight the credential scanning capabilities.
- azure-pipelines.yml: The main CI pipeline definition.
