Example of a multi-architecture application to run on Kubernetes.  It has no database backend.  Creates an x86/x64 and Arm version of the application for Kubernetes.

# Build Workflow

The application is built using GitHub Actions - the workflow can be found in .github/workflows/build.yml.

# Deployments

The application is deployed using Octopus Deploy - the process can be found in .octopus/deployment_process.ocl

# Forking

If you wish to Fork this repo, you'll need to set the following GitHub Actions variables in the forked repo.

- DOCKER_HUB_REPO
- OCTOPUS_FEATURE_BRANCH_CHANNEL
- OCTOPUS_PROJECT_NAME
- OCTOPUS_RELEASE_CHANNEL
- OCTOPUS_SERVER_URL
- OCTOPUS_SPACE
