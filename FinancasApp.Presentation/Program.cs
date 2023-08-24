var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

/*
 Definindo o padr�o de navega��o do projeto /Controller/View
 � a p�gina inicial que ser� aberta ao acessar o sistema
 */
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");
//  pattern: "{controller=coloco a pasta aqui}/{action=coloco a p�gina aqui}/{id?}");

app.Run();
