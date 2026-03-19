using Microsoft.EntityFrameworkCore;
using SupplierHub;
using SupplierHub.MapProfile;

using SupplierHub.Repositories;
using SupplierHub.Repositories.Interface;
using SupplierHub.Services;
using SupplierHub.Services.Interface;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb")));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Make overload resolution unambiguous by passing a Type so the params Type[] overload is selected
builder.Services.AddAutoMapper(typeof(ApplicationMapperProfile).Assembly);







// SUPPLIER
builder.Services.AddScoped<ISuppliersRepository, SuppliersRepository>();
builder.Services.AddScoped<ISupplierService, SupplierService>();


// SUPPLIER RISK
builder.Services.AddScoped<ISupplierRiskRepository, SupplierRiskRepository>();
builder.Services.AddScoped<ISupplierRiskService, SupplierRiskService>();


// SUPPLIER CONTACT
builder.Services.AddScoped<ISupplierContactRepository, SupplierContactRepository>();
builder.Services.AddScoped<ISupplierContactService, SupplierContactService>();


// ORGANIZATION
builder.Services.AddScoped<IOrganizationRepository, OrganizationRepository>();
builder.Services.AddScoped<IOrganizationService, OrganizationService>();


// CATEGORY
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();


// ITEM
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IItemService, ItemService>();


// CATALOG
builder.Services.AddScoped<ICatalogRepository, CatalogRepository>();
builder.Services.AddScoped<ICatalogService, CatalogService>();


// CATALOG ITEM
builder.Services.AddScoped<ICatalogItemRepository, CatalogItemRepository>();
builder.Services.AddScoped<ICatalogItemService, CatalogItemService>();


// CONTRACT
builder.Services.AddScoped<IContractRepository, ContractRepository>();
builder.Services.AddScoped<IContractService, ContractService>();


// COMPLIANCE DOCUMENT
builder.Services.AddScoped<IComplianceDocRepository, ComplianceDocRepository>();
builder.Services.AddScoped<IComplianceDocService, ComplianceDocService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
}



app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();





