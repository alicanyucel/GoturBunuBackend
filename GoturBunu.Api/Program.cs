using GoturBunu.Infrastructure;
using GoturBunu.Persistance;
using GoturBunu.Presentation;
using Microsoft.EntityFrameworkCore;
using GoturBunu.Application;
using Microsoft.OpenApi.Models;

//-----------CONFIGURE SERVICES-----------//
var builder = WebApplication.CreateBuilder(args);

// configure db context pool.
builder.Services.AddGoturBunuDbContext(builder.Configuration.GetConnectionString("SqlServer"));

// configure application.
builder.Services.AddApplication();

// gotur bunu uow.
builder.Services.AddGoturBunuUnitOfWork();

// gotur bunu repos.
builder.Services.AddGoturBunuRepositories();

// configure infrastructure.
builder.Services.AddInfrastructure(builder.Configuration);

// configure presentation.
builder.Services.AddPresentation();

// swagger
builder.Services.AddSwaggerGen(option =>
{
    option.CustomSchemaIds(x => x.FullName);
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "GoturBunu API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

// cors
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

builder.Services.AddEndpointsApiExplorer();

//-----------BUILD APP-----------//
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCookiePolicy();
app.UseStaticFiles();
app.UseCors();
app.UseInfrastructure();
app.UsePresentation();
app.Run();
