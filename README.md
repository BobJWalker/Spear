Example of a multi-architecture application to run on Kubernetes.  It has no database backend.  The build creates an x86/x64 and an ARM version of the application for Kubernetes to run.

# Requirements

Currently, this application has no external requirements to run on Kubernetes.  It is a .NET application.  All the necessary build information can be found in the Dockerfile.

# Build Workflow

The application is built using GitHub Actions - the workflow can be found in .github/workflows/build.yml.  The action will run unit tests, scan for vulnerabilities, generate attestations, an SBOM, and a Docker container.

# Deployments

The application is deployed using Octopus Deploy - the process can be found in .octopus/deployment_process.ocl.

# Forking

If you wish to Fork this repo, you'll need to set the following GitHub Actions variables in the forked repo.

- DOCKER_HUB_REPO
- OCTOPUS_FEATURE_BRANCH_CHANNEL
- OCTOPUS_PROJECT_NAME
- OCTOPUS_RELEASE_CHANNEL
- OCTOPUS_SERVER_URL
- OCTOPUS_SPACE
