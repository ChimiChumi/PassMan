namespace PassMan.Core
{
    public static class ConfigurationManager
    {
        public static string DbPath => GetDbPath();

        private static string GetDbPath()
        {
            var dbPath = Environment.GetEnvironmentVariable("DB_PATH");

            if (!string.IsNullOrEmpty(dbPath))
            {
                dbPath = Path.Combine(dbPath, "resources\\data.db");
            }
            else
            {
                var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Navigate up to the root of the solution
                var solutionRoot = Directory.GetParent(baseDirectory)?.Parent?.Parent?.Parent?.Parent;
                if (solutionRoot != null)
                {
                    var relativePath = "resources\\data.db";
                    dbPath = Path.Combine(solutionRoot.FullName, relativePath);
                }
                else
                {
                    throw new InvalidOperationException("Could not find the solution root directory.");
                }
            }

            var connectionString = $"Data Source={dbPath}";
            return connectionString;
        }
    }
}
