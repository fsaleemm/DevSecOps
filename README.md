# DevSecOps

Here are some examples of using Code Analysis Tools in your CI Azure DevOps pipeline.

- [Credentail Scanning](https://github.com/fsaleemm/DevSecOps/tree/main/CredScan#credentail-scan)

## Structure of the directory

- CredScan/jobs: This directory contains the CI pipeline job templates. These are broken into the Build and Test and Credential Scanning jobs.
    - Build_Test-1.yml: The YAML that defines the build and test tasks for the source code in src/CSharpProject directory.
    - CredScan-1.yml: The YAML that defines the Credential Scanning tasks. 
    - CredScan-custom-searchers.yml: The YAML that defines the Credential scanning tasks using customizations, for example, detecting SSNs and Credit Card numbers.
- CredScan/searchers: This directory contains the definition of the custom searchers.
- CredScan/src: The source code used as an example for credential scanning. The code intentionally contains issues to highlight the credential scanning capabilities.
- azure-pipelines.yml: The main CI pipeline definition.
