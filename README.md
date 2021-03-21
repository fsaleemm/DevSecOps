# DevSecOps

The DevSecOps topic is broad and 

- [DevSecOps Concepts](/Concepts#devSecOps-concepts)
- [Credential Scanning](/CredScan#credential-scan)

## Structure of the directory

- [CredScan/jobs](https://github.com/fsaleemm/DevSecOps/tree/main/CredScan/jobs): This directory contains the CI pipeline job templates. These are broken into the Build and Test and Credential Scanning jobs.
  - [Build_Test-1.yml](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/jobs/Build_Test-1.yml): The YAML that defines the build and test tasks for the source code in src/CSharpProject directory.
  - [CredScan-1.yml](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/jobs/CredScan-1.yml): The YAML that defines the Credential Scanning tasks. 
  - [CredScan-custom-searchers.yml](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/jobs/CredScan-custom-searchers.yml): The YAML that defines the Credential scanning tasks using customizations, for example, detecting SSNs and Credit Card numbers.
  - [CredScan-truffleHog-1.yml](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/jobs/CredScan-truffleHog-1.yml): The YAML that defines the Credential scanning tasks using truffleHog scan tool.
  - [CredScan-credential-digger-1.yml](https://github.com/fsaleemm/DevSecOps/blob/main/CredScan/jobs/CredScan-credential-digger-1.yml): The YAML that defines the Credential scanning tasks using credential digger scan tool.
- [CredScan/searchers](https://github.com/fsaleemm/DevSecOps/tree/main/CredScan/searchers): This directory contains the definition of the custom searchers for MSCA Credential Scan tool.
- [CredScan/scan-rules](https://github.com/fsaleemm/DevSecOps/tree/main/CredScan/scan-rules): This directory contains the definition of the regex rules used by the truffleHog and Credential Digger Credential Scan tool.
- [CredScan/src](https://github.com/fsaleemm/DevSecOps/tree/main/CredScan/src): The source code used as an example for credential scanning. The code intentionally contains issues to highlight the credential scanning capabilities.
- [azure-pipelines.yml](https://github.com/fsaleemm/DevSecOps/blob/main/azure-pipelines.yml): The main CI pipeline definition with all tools combined.
- [azure-pipelines-msca.yml](https://github.com/fsaleemm/DevSecOps/blob/main/azure-pipelines-msca.yml): The main CI pipeline definition for using MSCA Cred Scan tool.
- [azure-pipelines-truffleHog.yml](https://github.com/fsaleemm/DevSecOps/blob/main/azure-pipelines-truffleHog.yml): The main CI pipeline definition for using truffleHog Credential Scan tool.
- [azure-pipelines-credential-digger.yml](https://github.com/fsaleemm/DevSecOps/blob/main/azure-pipelines-credential-digger.yml): The main CI pipeline definition for using Credential Digger Credential Scan tool.
