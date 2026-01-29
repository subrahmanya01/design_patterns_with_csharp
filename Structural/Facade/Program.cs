using Structual.Facade;

var deploymentFacade = new DeploymentFacade();

var deploymentConfig = new DeploymentConfig
{
    RepoUrl = "https://github.com/subrahmanya01/design_patterns_with_csharp",
    BranchName = "main",
    TargetArtifactPath = "fs://targetlocation",
    AppPoolName = "designPatterns"
};

deploymentFacade.DeployApplication(deploymentConfig);