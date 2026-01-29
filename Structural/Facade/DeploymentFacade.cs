namespace Structual.Facade
{
    internal class DeploymentFacade
    {
        private readonly BuildTasks _buildTasks;
        private readonly VersionControlTasks _versionControlTasks;
        private readonly DeploymentTasks _deploymentTasks;

        public DeploymentFacade()
        {
            _buildTasks = new BuildTasks();
            _versionControlTasks = new VersionControlTasks();
            _deploymentTasks = new DeploymentTasks();
        }

        public void DeployApplication(DeploymentConfig config)
        {
            var repoClonePath = _versionControlTasks.PullCodeFromRepo(config.RepoUrl, config.BranchName);
            _buildTasks.BuildApplication(repoClonePath);
            var artefactPath = _buildTasks.GetArtifactPath();

            _deploymentTasks.StopAppPool();
            _deploymentTasks.TransferArtifacts(artefactPath, "");
            _deploymentTasks.StartAppPool();
        }
    }
}
