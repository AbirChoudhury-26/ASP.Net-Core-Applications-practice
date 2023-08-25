using System.Text.RegularExpressions;

namespace FirstCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // Get the Configuration Service.
            ConfigurationManager configuration = builder.Configuration;

            //Get the Value
            string MyCustomKeyValue = configuration.GetValue<string>("MyCustomKey");
            //string MyCustomKeyValue = configuration["MyCustomKey"];

            app.MapGet("/", () => $"{MyCustomKeyValue}");

            app.Run();
        }
    }
}