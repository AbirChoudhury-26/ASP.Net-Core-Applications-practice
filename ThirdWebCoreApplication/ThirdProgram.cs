//namespace ThirdWebCoreApplication
//{   
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var builder = WebApplication.CreateBuilder(args);
//        var app = builder.Build();

//        //Configuring New Inline Middleware Component using Run Extension Method
//        app.Run(async (context) =>
//        {
//            await context.Response.WriteAsync("Getting Response from Third Middleware");
//        });

//        //This will Start the Application
//        app.Run();
//    }
//}



//It will run only first middleware only because of its Run method because it is responsible to acts a s terminal Middleware and hence no other middleware is called next to it.

//namespace ThirdCoreWebApplication
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);
//            var app = builder.Build();

//            //Configuring New Middleware Component using Run Extension Method
//            app.Run(async (context) =>
//            {
//                await context.Response.WriteAsync("Getting Response from First Middleware");
//            });

//            //Configuring New Middleware Component using Run Extension Method
//            app.Run(async (context) =>
//            {
//                await context.Response.WriteAsync("Getting Response from Second Middleware");
//            });

//            //This will Run Application
//            app.Run();
//        }
//    }
//}



//To do call next middle ware ,we need to use " Use" Method from UseExtension ,which takes 2 params (context,next) to cexecute the given context of midfdlware and call the next in pipeline process.


//namespace FirstCoreWebApplication
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);
//            var app = builder.Build();

//            //Configuring New Middleware Components using Use Extension Method
//            app.Use(async (context, next) =>
//            {
//                await context.Response.WriteAsync("Getting Response from First Middleware");
//                await next();
//            });

//            app.Run(async (context) =>
//            {
//                await context.Response.WriteAsync("\nGetting Response from Second Middleware");
//            });

//            //This will Run Application
//            app.Run();
//        }
//    }
//}




// Now performing Middleware Pipeline Prrocessing



//namespace ThirdCoreWebApplication
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);
//            var app = builder.Build();

//            //Configuring Middleware Component using Use and Run Extension Method

//            //First Middleware Component Registered using Use Extension Method
//            app.Use(async (context, next) =>
//            {
//                await context.Response.WriteAsync("Middleware1: Incoming Request\n");
//                //Calling the Next Middleware Component
//                await next();
//                await context.Response.WriteAsync("Middleware1: Outgoing Response\n");
//            });

//            //Second Middleware Component Registered using Use Extension Method
//            app.Use(async (context, next) =>
//            {
//                await context.Response.WriteAsync("Middleware2: Incoming Request\n");
//                //Calling the Next Middleware Component
//                await next();
//                await context.Response.WriteAsync("Middleware2: Outgoing Response\n");
//            });

//            //Third Middleware Component Registered using Run Extension Method
//            app.Run(async (context) =>
//            {
//                await context.Response.WriteAsync("Middleware3: Incoming Request handled and response generated\n");
//                //Terminal Middleware Component i.e. cannot call the Next Component
//            });

//            //This will Start the Application
//            app.Run();
//        }
//    }
//}


namespace FirstCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Step1: Creating an Instance of WebApplicationOptions Class
            WebApplicationOptions webApplicationOptions = new WebApplicationOptions
            {
                WebRootPath = "MyWebRoot", //Setting the WebRootPath as MyWebRoot
                Args = args, //Setting the Command Line Arguments in Args
                EnvironmentName = "Production", //Changing to Production
            };

            // We have to create a builder for that instance of class only

            var builder = WebApplication.CreateBuilder(webApplicationOptions);
            var app = builder.Build();
            app.MapGet("/", () => $"EnvironmentName: {app.Environment.EnvironmentName} \n" +
            $"ApplicationName: {app.Environment.ApplicationName} \n" +
            $"WebRootPath: {app.Environment.WebRootPath} \n" +
            $"ContentRootPath: {app.Environment.ContentRootPath}");

            //This will Run the Application
            app.Run();
        }
    }
}