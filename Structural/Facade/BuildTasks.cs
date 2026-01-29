namespace Structual.Facade
{
    internal class BuildTasks
    {
        public void BuildApplication(string appSourcePath)
        {
            Console.WriteLine($"Building Application {appSourcePath}");
        }

        public string GetArtifactPath()
        {
            return "D://Artifact";
        }
    }
}
