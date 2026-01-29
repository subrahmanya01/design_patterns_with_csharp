namespace Structual.Facade
{
    internal class VersionControlTasks
    {
        public string PullCodeFromRepo(string url, string branch)
        {
            Console.WriteLine($"Pulling code from repo {url} and branch {branch}");

            return "D://s/RepoName";
        }
    }
}
