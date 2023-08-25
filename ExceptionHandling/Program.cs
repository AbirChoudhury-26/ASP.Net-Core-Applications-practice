namespace FirstCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            //If the Environment is Development, Please Show the Unhandled Exception Details 
            if (app.Environment.IsDevelopment())
            {
                //Using UseDeveloperExceptionPage Middleware to Show Exception Details
                app.UseDeveloperExceptionPage();
            }

            app.MapGet("/", async context =>
            {
                int Number1 = 10, Number2 = 0;
                int Result = Number1 / Number2; //This statement will throw Runtime Exception
                await context.Response.WriteAsync($"Result : {Result}");
            });

            //This will Start the Application
            app.Run();
        }
    }
}