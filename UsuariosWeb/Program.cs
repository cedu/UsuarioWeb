using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UsuariosWeb;
using UsuariosWeb.Helpers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped
    (sp => new HttpClient 
    { 
        BaseAddress = new Uri("https://usuariosapp1.azurewebsites.net/") 
    });

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddTransient<UsuarioHelper>();

await builder.Build().RunAsync();
