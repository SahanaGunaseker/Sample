using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Autofac;
using Autofac.Builder;

namespace Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();

            var container = BuildContainer();
            var service = container.Resolve<Services>();
            Sample s = new Sample {
            sampleText = "Hello World"
            };
                service.Print(s);
        }
        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SampleRep>().As<IPrint>();
            builder.RegisterType<Services>();
            return builder.Build();
        }
    }
}
