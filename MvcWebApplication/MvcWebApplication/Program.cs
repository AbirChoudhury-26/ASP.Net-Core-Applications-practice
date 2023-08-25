//namespace FirstCoreMVCWebApplication
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            // Add MVC services to the container.
//            builder.Services.AddMvc();

//            var app = builder.Build();

//            app.UseRouting();
//            app.UseEndpoints(endpoints =>
//            {
//                //Configuring the MVC middleware to the request processing pipeline
//                endpoints.MapDefaultControllerRoute();
//            });

//            app.Run();
//        }
//    }
//}




//namespace FirstCoreMVCWebApplication
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            // Add Framework MVC Services to the container.
//            builder.Services.AddMvc();

//            var app = builder.Build();

//            //Adding MVC Middleware
//            app.UseRouting();
//            app.UseEndpoints(endpoints =>
//            {
//                //Configuring the MVC middleware to the request processing pipeline
//                endpoints.MapDefaultControllerRoute();
//            });

//            app.Run();
//        }
//    }
//}


namespace FirstCoreMVCWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add Framework MVC Services to the container.
            builder.Services.AddMvc();

            var app = builder.Build();

            //Adding MVC Middleware
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //Configuring the MVC middleware to the request processing pipeline
                endpoints.MapDefaultControllerRoute();
            });

            app.Run();
        }
    }
}