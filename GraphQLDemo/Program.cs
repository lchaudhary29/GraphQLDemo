using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQLDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<AppSchema>();
builder.Services.AddGraphQL(options =>
    {
        options.EnableMetrics = false;
    })
    .AddSystemTextJson()
    .AddGraphTypes(typeof(AppSchema), ServiceLifetime.Scoped);

builder.Services.AddControllers()
        .AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseGraphQL<AppSchema>();
app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();