using Hospital.DatabaseSpecific;
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
app.MapGet("/", async () =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        var metaData = new LinqMetaData(adapter);
        var count = metaData.Doctor.Count();
        Console.WriteLine($"Number of students : {count}");
    }
});

app.Run();