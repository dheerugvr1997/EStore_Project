var builder = WebApplication.CreateBuilder(args);

// This will collect and create a new instance of all the Controllers
// and register it with the dependency injection container.
// builder.Services will create the objects of the controllers and inject them into the application.
builder.Services.AddControllersWithViews();

// This is added for learning purpose. 
// Integration issue encountered when working with Angular + ASP.NET Core.
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AngularClient", policy =>
//    {
//        policy.WithOrigins("http://localhost:4200")
//              .AllowAnyHeader()
//              .AllowAnyMethod();
//    });
//});

var app = builder.Build();

//app.UseCors("AngularClient");

// Pre-defined Middlewares.
app.UseStaticFiles(); // This will enable the application to serve static files (e.g. HTML, CSS, JS, Images) from the wwwroot folder.
app.MapControllers(); // This will map the controllers to the endpoints.
app.UseRouting(); // This will enable routing(Action Method) for the application. (e.g. http://localhost:5000/Brand/Index , http://localhost:5000/Brand/Details/5)

app.Run();
