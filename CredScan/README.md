# Credential Scan

![toc]

## Prerequisite Steps

1) Setup GitHub integrations with Azure Pipelines by following instructions [here](https://www.azuredevopslabs.com/labs/vstsextend/github-azurepipelines/#task-1-installing-azure-pipelines-from-github-marketplace).

## 1) truffleHog (Secret scanning)

This section has an example of using the [truffleHog](https://github.com/dxa4481/truffleHog/tree/dev) tool for performing credential scanning.

### Steps

1) Configure Azure DevOps Pipeline for Continuous Integration following instructions [here](https://www.azuredevopslabs.com/labs/vstsextend/github-azurepipelines/#task-2-configuring-a-continuous-integration-pipeline). For step 4 use the YAML [here](https://github.com/fsaleemm/DevSecOps/blob/main/azure-pipelines-truffleHog.yml).
2) Run the Azure DevOps Pipeline and review the output. See below for details.

NOTE: The truffleHog credential scan tool fails the build if issues are found.

### truffleHog Output

The execution of the truffleHog tool can be output to the standard output as shown below:
![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss6.PNG)

Or as JSON output as shown below that can be saved and processed for creating a unified report:

![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss7.PNG)

## 2) Microsoft Security Code Analysis

The section contains an example of using the [Microsoft Security Code Analysis Extension](https://docs.microsoft.com/en-us/azure/security/develop/security-code-analysis-overview) for performing Credential scanning in source code. Additionally, an example of customizing the Credential scanning capabilities to include detecting SSNs and Credit Card numbers is provided. 

### Steps

1) Install the Microsoft Security Code Analysis Extension by following instruction [here](https://docs.microsoft.com/en-us/azure/security/develop/security-code-analysis-onboard#onboarding-the-microsoft-security-code-analysis-extension).
2) Configure Azure DevOps Pipeline for Continuous Integration following instructions [here](https://www.azuredevopslabs.com/labs/vstsextend/github-azurepipelines/#task-2-configuring-a-continuous-integration-pipeline). For step 4 use the YAML [here](https://github.com/fsaleemm/DevSecOps/blob/main/azure-pipelines.yml).
3) Run the Azure DevOps Pipeline and review the reports. See below for details.

### Review Published Reports

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

## 3) Credential Digger

This section has an example of using the [Credential Digger](https://github.com/SAP/credential-digger) tool for performing credential scanning.

The scan rules for credential digger are based on these [instructions](https://github.com/SAP/credential-digger#add-rules) and the rules defined [here](https://github.com/SAP/credential-digger/blob/main/ui/backend/rules.yml).

### Steps

1) Configure Azure DevOps Pipeline for Continuous Integration following instructions [here](https://www.azuredevopslabs.com/labs/vstsextend/github-azurepipelines/#task-2-configuring-a-continuous-integration-pipeline). For step 4 use the YAML [here](https://github.com/fsaleemm/DevSecOps/blob/main/azure-pipelines-credential-digger.yml).
2) Run the Azure DevOps Pipeline and review the output. See below for details.

### Credential Digger Output

The result of the Credential Digger are stored in the sqlite database or they can be stored in an external [postgres database](https://github.com/SAP/credential-digger#external-postgres-database). We tested with using the sqlite database.

![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss8.PNG)

The output can be to a CSV using sqlite [".mode csv"](https://www.w3resource.com/sqlite/sqlite-dot-commands.php#mode) dot-command and processed for creating a unified report.

![](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/images/ss9.PNG)