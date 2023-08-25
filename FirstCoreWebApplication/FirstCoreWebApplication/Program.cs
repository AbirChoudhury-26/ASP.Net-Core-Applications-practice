namespace FirstCoreWebApplication;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello Abir,Welcome to the world of TECH");

        app.Run();
    }
}

