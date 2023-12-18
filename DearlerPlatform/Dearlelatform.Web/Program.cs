using Microsoft.EntityFrameworkCore;
using DearlerPlatform.Core;
using DearlerPlatform.Core.Repository;
using DearlerPlatform.Service.CustomerApp.DTO;
using DearlerPlatform.Extensions;
using DearlerPlatform.Service;
using DealerPlatform.Common.TokenModel;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Dearlelatform.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.BuilderEnter();



var app = builder.Build();

// Configure the HTTP request pipeline.


app.IntiEnter();

app.IntiMap();

app.Run();
