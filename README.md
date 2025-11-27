# Challenge Care Plus - Monitoramento & Infraestrutura (HealthFlow) 🖥️⚙️

Este repositório contém a entrega da disciplina de **Operating Systems** para o Challenge 2025.
O projeto consiste na implementação de uma API Backend (.NET) hospedada em ambiente Windows/IIS, com foco na **Gestão de Logs** e diferenciação entre eventos de aplicação e eventos de servidor.

---

## 👥 Participantes do Grupo

| Nome Completo | RM |
| :--- | :--- |
| **Rafael de Almeida Sigoli** | RM554019 |
| **Giovanna Franco Gaudino Rodrigues** | RM553701 |
| **Rafael Jorge Del Padre** | RM552765 |
| **Lucas Bertolassi Iori** | RM553183 |

---

## 🎯 Objetivo da Entrega

Demonstrar competências de infraestrutura e sistemas operacionais, especificamente:
1.  **Configuração de Ambiente:** Utilização do IIS (Internet Information Services) no Windows.
2.  **Gestão de Logs:** Implementação e análise de duas camadas de registro:
    * **Log de Aplicação:** Registros de regra de negócio (criados via código C#).
    * **Log do Servidor:** Registros nativos do IIS (HTTP Requests, Status Code, Latência).

## 🛠️ Tecnologias & Estrutura

* **Linguagem:** C# (ASP.NET Core Web API)
* **Servidor Web:** IIS / IIS Express
* **Sistema Operacional:** Windows 10/11
* **Endpoints:**
    * `GET /`: Mensagem de verificação de atividade do servidor.
    * `GET /api/status`: Endpoint da regra de negócio Care Plus (Gera log de aplicação).

---

## 📂 Estrutura de Logs

O projeto foi desenhado para gerar evidências claras de monitoramento:

### 1. Log de Aplicação (Business Rule)
* **Arquivo:** `Log_CarePlus_App.txt` (Na raiz da aplicação)
* **Função:** Registra que o sistema HealthFlow está operante e realizou o check de status.
* **Exemplo:** `[Data/Hora] CHECK: Sistema HealthFlow operando. Status: OK.`

### 2. Log do Servidor (Infrastructure)
* **Local:** Diretório de Logs do IIS (`W3SVC...`)
* **Função:** O Sistema Operacional registra automaticamente as requisições HTTP, IPs de origem e User-Agents.
* **Exemplo:** `GET /api/status - 200 - 0 0 15`

---

## 🎬 Evidência em Vídeo

link youtube (caso de erro no arquivo .mp4): https://youtu.be/mGjtxALsFwM
O vídeo demonstrativo (`Video_Entrega_OS.mp4`) encontra-se neste repositório. Ele demonstra:
1.  O recurso IIS ativado no Windows.
2.  A execução da API.
3.  A geração simultânea dos dois tipos de logs citados acima.

## 🚀 Como Executar Localmente

1.  Clone o repositório.
2.  Abra o arquivo `.sln` no **Visual Studio**.
3.  Certifique-se de que o perfil de execução está definido como **IIS Express**.
4.  Execute a aplicação (F5).
5.  Acesse `localhost:PORTA/api/status` no navegador.
6.  Verifique a criação do arquivo de log na pasta raiz.

---
*Projeto acadêmico - FIAP 2025*
