using System.Reflection;
using Api.Modules;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using MstBlog.Api.Extensions;
using MstBlog.Api.Middlewares;
using MstBlog.Core.Domain;
using MstBlog.Core.Entities;
using MstBlog.Repository.Contexts;
using MstBlog.Service.Mapping;
using MstBlog.Service.Services;
using MstBlog.Service.Validations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DB connection
builder.Services.AddDbContext<MstBlogDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString(SettingNames.ConnectionString), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(MstBlogDbContext)).GetName().Name);
    });
});

//Dapper Context
builder.Services.AddSingleton<MstBlogDapperContext>();

//Automapper implemantasyonu
builder.Services.AddAutoMapper(typeof(MapProfiles));

//Autofac implemantasyonu
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
    containerBuilder.RegisterModule(new RepositoryServiceModule()));

//Token Options integration
builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("TokenOptions"));

//Authentication ve token implementasyonu
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opts =>
{
    var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenSettings>();
    opts.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidIssuer = tokenOptions.Issuer,
        ValidAudience = tokenOptions.Audience,
        IssuerSigningKey = SignService.GetSymmetricSecurityKey(tokenOptions.SecurityKey),

        ValidateIssuerSigningKey = true,
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddScoped<IValidator<Contact>, ContactValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<ContactValidator>();

//Identity Implemantation
builder.Services.AddIdentity();

//cors implementasyonu 
builder.Services.UseCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyAllowedOrigins");

app.UseMiddleware<ApiKeyAuthorizationMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCustomException();

app.MapControllers();

app.Run();