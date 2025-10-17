Example multi-architecture application to run on Kubernetes.  Creates an x86/x64 and Arm version of the application for Kubernetes.

# Build Workflow

The application is built using GitHub Actions - the workflow can be found in .github/workflows/build.yml.

# Deployments

The application is deployed using Octopus Deploy - the process can be found in .octopus/deployment_process.ocl
