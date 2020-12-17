# DevOpsSettings
I use this ASP.NET Core web app to try to set different configuration in different deployments

# multiple Azure App Services, all linux, .NetCore 3.1
1. injectsettings-dev: (publish: code) 
2. injectsettings-staging: (publish: code)
3. injectsettings-docker-dev: (publish: docker container)
4. injectsettings-docker-staging: (publish: docker container)

# setting or injecting or replacing several settings/variables/configuration
all done in Azure DevOps release pipelines, using
* use File Transform task to apply file transformations and variable substitutions on configuration and parameters files
* use Application and Configuration Settings in Deploy Azure App Service task
