//namespace FirstCoreWebApplication
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            var app = builder.Build();

//            app.UseDefaultFiles();

//            //Adding Static Files Middleware Component to serve the static files
//            app.UseStaticFiles();

//            //Adding Another Middleware Component to the Request Processing Pipeline
//            app.Run(async (context) =>
//            {
//                await context.Response.WriteAsync("Request Handled and Response Generated");
//            });

//            //This will Run the Application
//            app.Run();
//        }
//    }
//}




// This program is running to create a default page if multiple Static files exist in Web root folder & then we want to make a specifc one Default 
namespace FirstCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            //Specify the MyCustomPage1.html as the default page
            //First Create an Instance of DefaultFilesOptions
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();

            //Clear any DefaultFileNames if already there
            defaultFilesOptions.DefaultFileNames.Clear();

            //Add the default HTML Page to the DefaultFilesOptions Instance
            defaultFilesOptions.DefaultFileNames.Add("MyCustomPage1.html");

            //Setting the Default Files
            //Pass the DefaultFilesOptions Instance to the UseDefaultFiles Middleware Component
            app.UseDefaultFiles(defaultFilesOptions);

            //Adding Static Files Middleware Component to serve the static files
            app.UseStaticFiles();

            //Adding Another Middleware Component to the Request Processing Pipeline
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Request Handled and Response Generated");
            });

            //This will Run the Application
            app.Run();
        }
    }
}