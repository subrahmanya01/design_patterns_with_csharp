namespace Structual.Facade
{
    internal class DeploymentTasks
    {
        public void StartAppPool()
        {
            Console.WriteLine("Starting app pool");
        }

        public void StopAppPool()
        {
            Console.WriteLine("Stopping app pool");
        }

        public void TransferArtifacts(string sourcePath, string targetPath)
        {
            Console.WriteLine($"Transfering the artifact from {sourcePath} to {targetPath}");
        }
    }
}
