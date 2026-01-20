Example of a multi-architecture application to run on Kubernetes.  It has no database backend.  The build creates an x86/x64 and an ARM version of the application for Kubernetes to run.

# Requirements

Currently, this application has no external requirements to run on Kubernetes.  It is a .NET application.  All the necessary build information can be found in the Dockerfile.

# Build Workflow

The application is built using GitHub Actions - the workflow can be found in .github/workflows/build.yml.  The action will run unit tests, scan for vulnerabilities, generate attestations, an SBOM, and a Docker container.

# Deployments

The application is deployed using Octopus Deploy - the process can be found in .octopus/deployment_process.ocl.

# Forking

If you wish to Fork this repo, you'll need to set the following GitHub Actions variables in the forked repo.

## Secrets

- DOCKERHUB_PAT - the PAT of your DockerHub User
- DOCKERHUB_USERNAME - The username of your DockerHub user
- OCTOPUS_OIDC_SERVICE_ACCOUNT_ID - The [service account identifier from Octopus Deploy](https://octopus.com/docs/octopus-rest-api/openid-connect) for OIDC

## Variables
- DOCKER_HUB_REPO - The repository on DockerHub you want to push this build to
- OCTOPUS_FEATURE_BRANCH_CHANNEL - The name of the channel you want to use when working on feature branches or bug fixes - e.g. Branches
- OCTOPUS_PROJECT_NAME - The name of the project housing the deployment process to deploy this application - e.g. Spear
- OCTOPUS_RELEASE_CHANNEL - The name of the channel you want to use when deploying to production - e.g. Release
- OCTOPUS_SERVER_URL - The url of the Octopus Deploy instance - e.g. bobjwalker.octopus.app
- OCTOPUS_SPACE - The name of the space on the Octopus Deploy instance - e.g. Default
