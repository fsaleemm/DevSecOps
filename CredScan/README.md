# Credential Scan

The documentation here contains an example of using the [Microsoft Security Code Analysis Extension](https://docs.microsoft.com/en-us/azure/security/develop/security-code-analysis-overview) for performing Credential scanning in source code. Additionally, an example of customizing the Credential scanning capabilities to include detecting SSNs and Credit Card numbers is provided. 

## High Level Steps

1) Install the Microsoft Security Code Analysis Extension by following instruction [here](https://docs.microsoft.com/en-us/azure/security/develop/security-code-analysis-onboard#onboarding-the-microsoft-security-code-analysis-extension).
2) Setup GitHub integrations with Azure Pipelines by following instructions [here](https://www.azuredevopslabs.com/labs/vstsextend/github-azurepipelines/#task-1-installing-azure-pipelines-from-github-marketplace). Use this option if your code repository is GitHub.
3) Configure Azure DevOps Pipeline for Continuous Integration following instructions [here](https://www.azuredevopslabs.com/labs/vstsextend/github-azurepipelines/#task-2-configuring-a-continuous-integration-pipeline). For step 4 use the YAML [here](https://github.com/fsaleemm/DevSecOps/blob/main/azure-pipelines.yml).
4) Run the Azure DevOps Pipeline and review the reports. See below for details.

## Review Published Reports

1) In Azure DevOps, go to your Organization and respective project that you setup for credential scanning.
2) Go to Pipelines, click on the pipeline created for credential scanning.

![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss1.PNG)

3) From the list of runs, click on the recent run to get to the summary.
4) In the Summary, click on the published artifacts.

![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss2.PNG)

5) There will be 2 published directories:
    - CodeAnalysisLogs: This contains the output of the default Credential Scanning report.
    - CodeAnalysisLogs-custom: This contains the output of the custom Credential Scanning report.

![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss3.PNG)

6) Expand CodeAnalysisLogs and view the SdtReport.html. It should look like below:

![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss4.PNG)

7) Expand CodeAnalysisLogs-custom and view the SdtReport.html. It should look like below:

![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss5.PNG)

The report with custom searchers should have detected any SSNs and Credit Card numbers in the source code in addition to the default issues.
