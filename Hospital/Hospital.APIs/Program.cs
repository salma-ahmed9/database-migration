using Hospital.DatabaseSpecific;
using Hospital.EntityClasses;
using Hospital.Linq;
using Npgsql;
using SD.LLBLGen.Pro.DQE.PostgreSql;
using SD.LLBLGen.Pro.ORMSupportClasses;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ConnectionString.Postgres Server");
RuntimeConfiguration.AddConnectionString("ConnectionString.Postgres Server", builder.Configuration.GetConnectionString("ConnectionString.Postgres Server"));
RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(c =>
{
    c.AddDbProviderFactory(typeof(NpgsqlFactory));
});

var app = builder.Build();


app.MapGet("/", async (HttpContext context) =>
{
    var htmlpage = await File.ReadAllTextAsync("wwwroot/index.html");
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(htmlpage);
});

app.MapPost("/add_doctor", async (HttpContext context) =>
{
    var firstname = context.Request.Form["firstname"];
    var lastname = context.Request.Form["lastname"];
    var email = context.Request.Form["email"];
    var address = context.Request.Form["address"];

    using (var adapter = new DataAccessAdapter(connectionString))
    {
        try
        {
            var newDoctor = new DoctorEntity() { FirstName= firstname , LastName = lastname, Email= email , Address = address };
            adapter.SaveEntity(newDoctor);
            return Results.Ok("Doctor is added successfully!");
        }
        catch (Exception e)
        {
            return Results.BadRequest(e.Message);
        }

    }
});
app.UseStaticFiles();
app.Run();