using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependecyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using WebAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddSingleton<IBrandService, BrandServiceManager>();
//builder.Services.AddSingleton<IBrandDal, EfBrandDal>();

//builder.Services.AddSingleton<ICityService, CityServiceManager>();
//builder.Services.AddSingleton<ICityDal, EfCityDal>();

//builder.Services.AddSingleton<ICarDetailService, CarDetailServiceManager>();
//builder.Services.AddSingleton<ICarDetailDal, EfCarDetailsDal>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
	builder.RegisterModule(new AutofacBusinessModule());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
