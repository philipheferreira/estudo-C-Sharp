
using SimplesAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços da API
builder.Services.AddControllers();

// Registra o ProdutoRepository como um serviço que pode ser injetado
builder.Services.AddSingleton<ProdutoRepository>();

// Adiciona o Swagger para documentação da API (opcional, mas útil)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurações de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configura o roteamento e mapeamento de controladores
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Inicia a aplicação
app.Run();