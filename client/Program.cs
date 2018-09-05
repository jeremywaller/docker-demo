using System;
using System.Net.Http;
using System.Threading;

namespace Client
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numOfRequests = int.Parse(Environment.GetEnvironmentVariable("NumberOfRequests"));
            for (int i = 0; i < numOfRequests; i++)
            {
                GetData();
                var sleepTime = int.Parse(Environment.GetEnvironmentVariable("SleepTime"));
                Thread.Sleep(sleepTime);
            }
        }

        static async void GetData()
        {
            var machineName = Environment.MachineName;

            string baseUrl = $"http://dockerapi/api/values/{machineName}";

            using (HttpClient client = new HttpClient())       

            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
