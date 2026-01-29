namespace Structual.Facade
{
    internal class DeploymentConfig
    {
        public string RepoUrl { get; set; }
        public string BranchName { get; set; }
        public string TargetArtifactPath { get; set; }
        public string AppPoolName {get; set;}
    }
}
