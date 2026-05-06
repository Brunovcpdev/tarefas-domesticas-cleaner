# 🧹 Tarefas Domésticas Cleaner

Console application para remoção automática de tarefas domésticas vencidas do banco de dados.

> Projeto complementar ao [tarefas-domesticas](https://github.com/Brunovcpdev/tarefas-domesticas) — utiliza o mesmo banco de dados SQL Server.

---

## ⚙️ Como Funciona

Ao ser executado, o programa:

1. Lê a data e hora atual do sistema
2. Conecta ao banco de dados SQL Server
3. Busca todas as tarefas cuja data é anterior à data atual
4. Remove automaticamente todas as tarefas vencidas
5. Salva as alterações no banco

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# (.NET)
- **Banco de Dados:** SQL Server
- **ORM:** Entity Framework Core
- **Configuração:** Microsoft.Extensions.Configuration (appsettings.json)

---

## 🗂️ Estrutura do Projeto

```
ControleTarefa/
├── Models/
│   ├── Tarefas.cs              # Model da entidade Tarefa
│   └── ApplicationDbContext.cs # Contexto do banco de dados
├── Program.cs                  # Lógica principal de limpeza
└── appsettings.json            # String de conexão com o banco
```

---

## ⚙️ Como Rodar o Projeto

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server)
- Banco de dados do projeto [tarefas-domesticas](https://github.com/Brunovcpdev/tarefas-domesticas) configurado

### Passo a passo

1. Clone o repositório:
```bash
git clone https://github.com/Brunovcpdev/tarefas-domesticas-cleaner.git
```

2. Configure a string de conexão no `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "ConnString": "Server=SEU_SERVIDOR;Database=TarefasDomesticas;Trusted_Connection=True;"
  }
}
```

3. Execute o projeto:
```bash
dotnet run
```

---

## 💡 Sugestão de Uso

Para automatizar a limpeza diária, configure o executável como uma **tarefa agendada no Windows**:

1. Abra o **Agendador de Tarefas** do Windows
2. Crie uma nova tarefa para executar o programa diariamente
3. As tarefas vencidas serão removidas automaticamente todo dia

---

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
