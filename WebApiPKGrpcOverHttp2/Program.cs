using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServer;

namespace WebApiPKGrpcOverHttp2 {
    class Program {
        static long totalCount = 10000;
        static async Task Main (string[] args) {
            while (true) {

                Console.WriteLine ("1 GRPC Test, 2 WebApi2 Test, 3 WebApi1 Test");

                switch (Console.ReadLine ()) {
                    case "1":
                        {
                            var totalTime = await GrpcTest ();
                            Console.WriteLine ($"GRPC takes:{totalTime}毫秒");
                        };
                        break;
                    case "2":
                        {
                            var totalTime = await WebApi2Test ();
                            Console.WriteLine ($"WebApi2 takes:{totalTime}毫秒");
                        };
                        break;
                    case "3":
                        {
                            var totalTime = await WebApi1Test();
                            Console.WriteLine($"WebApi1 takes:{totalTime}毫秒");
                        };
                        break;
                }
            }
        }

        static async Task<long> GrpcTest () {
            var channel = GrpcChannel.ForAddress ("https://localhost:2000");
            var client = new Greeter.GreeterClient (channel);

            Stopwatch s = new Stopwatch ();
            s.Start ();

            for (int i = 0; i < totalCount; i++) {
                await client.SayHelloAsync (new HelloRequest { Name = "GreeterClient" });
                //var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
                //Console.WriteLine("Greeting: " + reply.Message);
            }

            return s.ElapsedMilliseconds;
        }

        static async Task<long> WebApi2Test () {
            Stopwatch s = new Stopwatch ();
            s.Start ();
            HttpClient client = new HttpClient () {
                BaseAddress = new Uri ("https://localhost"),
                DefaultRequestVersion = new Version (2, 0)
            };
            for (int i = 0; i < totalCount; i++) {
                await client.GetStringAsync ("https://localhost/api/values");
                //Console.WriteLine(await client.GetStringAsync("https://localhost/api/values"));
            }

            return s.ElapsedMilliseconds;
        }

        //http://10.1.30.251:1009/AssetCenter/Values/1

        static async Task<long> WebApi1Test()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:3000")
            };
            for (int i = 0; i < totalCount; i++)
            {
                await client.GetStringAsync("https://localhost:3000/api/Values");
                //Console.WriteLine(await client.GetStringAsync("https://localhost/api/values"));
            }

            return s.ElapsedMilliseconds;
        }
    }
}