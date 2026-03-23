# 🌐 ConsumirAPI — Consulta de Feriados e CEP

Aplicação desktop em **C# Windows Forms** que consome APIs públicas brasileiras para consulta de feriados nacionais por ano e endereços por CEP, exibindo os resultados em tabelas interativas.

---

## ✨ Funcionalidades

- ✅ Buscar feriados nacionais por ano via **BrasilAPI**
- ✅ Buscar endereço completo por CEP via **BrasilAPI**
- ✅ Exibição dos resultados em `DataGridView`
- ✅ Validação de entrada com mensagens de erro amigáveis
- ✅ Deserialização automática de JSON com **Newtonsoft.Json**

---

## 🛠️ Tecnologias

| Tecnologia | Versão | Uso |
|---|---|---|
| C# | .NET 10 | Linguagem principal |
| Windows Forms | .NET 10 | Interface gráfica |
| HttpClient | — | Requisições HTTP |
| Newtonsoft.Json | — | Deserialização de JSON |
| BrasilAPI | — | API pública de feriados e CEP |

---

## 📁 Estrutura do projeto

```
ConsumirAPI/
├── FrmApi.cs          # Formulário de consulta de feriados por ano
├── FrmCep.cs          # Formulário de consulta de endereço por CEP
├── feriado.cs         # Modelo de dados — feriado
└── cep.cs             # Modelo de dados — CEP
```

---

## 🚀 Como executar

### Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou superior

### Passos

1. **Clone o repositório**
```bash
git clone https://github.com/guilhermemorelidev/ConsumirAPI.git
cd ConsumirAPI
```

2. **Abra no Visual Studio e execute com F5**

Por padrão o projeto inicia no formulário de CEP (`FrmCep`). Para usar o formulário de feriados, altere o `Program.cs`:

```csharp
// Feriados por ano
Application.Run(new FrmApi());

// Consulta de CEP
Application.Run(new FrmCep());
```

---

## 🔗 APIs utilizadas

| API | Endpoint |
|---|---|
| Feriados nacionais | `https://brasilapi.com.br/api/feriados/v1/{ano}` |
| Consulta de CEP | `https://brasilapi.com.br/api/cep/v1/{cep}` |

Ambas são gratuitas e não requerem autenticação.

---

## 📄 Licença

MIT © [Guilherme Moreli](https://github.com/guilhermemorelidev)
