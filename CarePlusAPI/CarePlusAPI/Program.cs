using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// --- CORREÇÃO: ROTA DA PÁGINA INICIAL ---
// Isso garante que quando o navegador abrir, você veja algo escrito.
app.MapGet("/", () => "O SERVIDOR ESTÁ RODANDO! \n\nAgora digite '/api/status' lá em cima na barra de endereço para gerar os logs.");

// --- ROTA DA CARE PLUS (QUE VALE NOTA) ---
app.MapGet("/api/status", (ILogger<Program> logger) =>
{
    // 1. LOG DE APLICAÇÃO (REGRA DE NEGÓCIO)
    string caminhoDoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "Log_CarePlus_App.txt");
    string mensagem = $"[{DateTime.Now}] CHECK: Sistema HealthFlow operando. Status: OK." + Environment.NewLine;

    // Escreve no arquivo (Cria se não existir)
    File.AppendAllText(caminhoDoArquivo, mensagem);

    // 2. LOG DO SERVIDOR (IIS)
    logger.LogInformation("Recebida requisição HTTP no endpoint /status");

    return Results.Ok(new
    {
        Projeto = "Care Plus Challenge",
        Status = "Serviço Operante",
        Log_Gerado = "Sim"
    });
});

app.Run();