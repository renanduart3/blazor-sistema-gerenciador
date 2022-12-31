using SistemaGerenciador.Blaze.Data;
using SistemaGerenciador.Regras.Interfaces;
using SistemaGerenciador.Regras.Inventories;
using SistemaGerenciador.Regras.Inventories.Interfaces;
using SistemaGerenciador.Regras.Products;
using SistemaGerenciador.Regras.Products.Interfaces;
using SistemaGerenciador.Services.ServicoMock;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IInventoryRepository, InventoryRepositoryInMemory>();
builder.Services.AddSingleton<IProductRepository, ProductRepositoryInMemory>();
//USeCases -- Inventory
builder.Services.AddTransient<IVisualizarPorNome, VisualizarPorNome>();
builder.Services.AddTransient<IAdicionarInventory, AdicionarInventory>();
builder.Services.AddTransient<IEditInventory, EditInventory>();
builder.Services.AddTransient<IVisualizarPorId, VisualizarPorId>();

//UseCases -- Product
builder.Services.AddTransient<IAddProduct, AddProduct>();
builder.Services.AddTransient<IVisualizarProdutoPorNome, VisualizarProdutoPorNome>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
