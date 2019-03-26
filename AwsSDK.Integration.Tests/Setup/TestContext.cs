using System;
using System.Diagnostics;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace AwsSDK.Integration.Tests.Setup
{
    public class TestContext : IDisposable
    {
        private TestServer _server;

        public HttpClient Client { get; set; }

        public TestContext()
        {
            SetupClient();

            RunCommandPromptCommand("docker pull amazon/dynamodb-local");
            RunCommandPromptCommand("docker run -d -p 8000:8000 amazon/dynamodb-local");
        }

        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());

            _server.BaseAddress = new Uri("http://localhost:8000");

            Client = _server.CreateClient();
        }


        public static void RunCommandPromptCommand(string argument)
        {
            using (var process = new Process())
            {
                var startInfo = new ProcessStartInfo()
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe", // TODO: update filename
                    Arguments = $"/C {argument}" // TODO: update Arguments
                };

                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        public void Dispose()
        {
            TestDataSetup.TearDownStore("MovieRank");
            Client?.Dispose();
        }
    }
}