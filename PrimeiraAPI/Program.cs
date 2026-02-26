using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add serviços basicos para a aplicação, como controllers e OpenAPI.

builder.Services.AddControllers();

//Add OpenAPI para gerar a documentação da API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

//builder.Build() => é onde a aplicação e construida
var app = builder.Build();

// Configure the HTTP/HTTPS request pipeline -> ponto de acesso para conseguir executar um codigo antes de chegar na controller, antes de chegar no endpoint da API
// permite que funcione somente em ambiente de desenvolvimento,não é para produção
if (app.Environment.IsDevelopment())
{
    //endpoint OpenAPI
    app.MapOpenApi();
    //interface do Scalar para testar API
    app.MapScalarApiReference(options =>
    {
        options.Title = "Primeira API - Scalar";
        options.Theme = ScalarTheme.Default;
        options.ShowSidebar = true;
    });
    //Para abrir a interface do scalar automaticamente
    // Redireciona a pagina raiz "/" para "/scalar"
    app.MapGet("/", () => Results.Redirect("/scalar"));
}

//Redireciona todas as requisições http para https
app.UseHttpsRedirection();
//middleware de autorização (pode/deve ser usado para proteger endpoints especificos
app.UseAuthorization();
//mapeia os controladores para os endpoints da api
app.MapControllers();
//inicia a app e começa a esutar as requisições
app.Run();
