# AcademiaOdata 🏋️‍♀️

Um sistema de gestão de academias desenvolvido como **projeto de estudos** para explorar e aplicar arquiteturas modernas e padrões de design em .NET e Angular.

---

## 📋 Sobre o Projeto

**AcademiaOdata** é uma aplicação full-stack que permite gerenciar os principais aspectos operacionais de uma academia:

- ✅ **Cadastro e gestão de professores**
- ✅ **Cadastro e gestão de alunos** com atribuição a professores responsáveis
- ✅ **Estrutura pronta** para aulas de alunos
- ✅ **Estrutura pronta** para gestão de estoque de equipamentos

Este projeto serve como **material de aprendizado** para:
- Arquitetura de software moderna
- Padrões de design SOLID
- Integração entre frontend e backend
- Boas práticas de desenvolvimento

---

## 🎯 Funcionalidades Atuais

### Backend (API REST)

#### Módulo de Alunos
- `GET /api/alunos` - Listar todos os alunos
- `GET /api/alunos/{id}` - Obter aluno por ID
- `POST /api/alunos` - Cadastrar novo aluno

#### Módulo de Professores
- `GET /api/professores` - Listar todos os professores
- `GET /api/professores/{id}` - Obter professor por ID
- `POST /api/professores` - Cadastrar novo professor

### Frontend (Interface Web)

- 🎨 Dashboard responsivo com Bootstrap
- 📱 Visualização de professores e alunos
- ➕ Formulários para cadastro

---

## 🏗️ Arquitetura Técnica

### Backend (.NET 8)

O projeto segue a **Clean Architecture** com separação clara de responsabilidades:

```
Academia.Domain/
  └── Modelos de Domínio
      ├── AlunoModulo/
      └── ProfessorModulo/

Academia.Application/
  └── Camada de Aplicação (CQRS + MediatR)
      ├── AlunoModulo/
      │   ├── Commands/      (AddAlunoCommand, AddAlunoCommandHandler)
      │   ├── Queries/       (GetAllAlunosQuery, GetAlunoByIdQuery)
      │   ├── Validators/    (AddAlunoCommandValidator)
      │   ├── Mappers/       (AlunoMapper - AutoMapper)
      │   └── Services/      (AlunoService)
      └── ProfessorModulo/
          ├── Commands/      (AddProfessorCommand, AddProfessorCommandHandler)
          ├── Queries/       (GetAllProfessoresQuery, GetProfessorByIdQuery)
          ├── Validators/    (AddProfessorCommandValidator)
          ├── Mappers/       (ProfessorMapper - AutoMapper)
          └── Services/      (ProfessorService)

Academia.Infra.Data.EF/
  └── Camada de Infraestrutura (Persistência)
      ├── Alunos/
      │   ├── AlunoRepository
      │   ├── IAlunoRepository
      │   └── AlunoEntityConfiguration
      ├── Professores/
      │   ├── ProfessorRepository
      │   ├── IProfessorRepository
      │   └── ProfessorEntityConfiguration
      ├── AcademiaDbContext
      └── Migrations/

AcademiaOdata.Api/
  └── Camada de Apresentação (API)
      ├── Controllers/
      │   ├── AlunosController
      │   └── ProfessoresController
      ├── Extensions/
      │   └── DependencyInjectionExtensions
      └── Program.cs
```

### Padrões e Tecnologias Utilizados

#### 🏛️ Padrões de Arquitetura
- **Clean Architecture**: Separação em camadas independentes
- **CQRS (Command Query Responsibility Segregation)**: Separação entre leitura e escrita
- **Repository Pattern**: Abstração da persistência de dados

#### 📦 Padrões de Design
- **MediatR**: Implementação do padrão Mediator para desacoplamento
- **Dependency Injection**: Injeção de dependências nativa do ASP.NET Core
- **Strategy Pattern**: Através dos Handlers do MediatR

#### 🔧 Tecnologias Backend
| Tecnologia | Versão | Propósito |
|-----------|--------|----------|
| **.NET** | 8.0 | Runtime |
| **Entity Framework Core** | 8.0.2 | ORM (Object-Relational Mapping) |
| **MediatR** | 13.0.0 | Padrão Mediator |
| **AutoMapper** | 12.0.0 | Mapeamento de objetos (DTO) |
| **FluentValidation** | 12.0.0 | Validação de dados |
| **Microsoft.AspNetCore.OData** | 8.2.7 | Suporte para queries OData |
| **MySQL** | - | Banco de dados |
| **Swagger/OpenAPI** | 6.6.2 | Documentação da API |

### Frontend (Angular 15)

```
Client/AcademiaOdata/
  └── src/
      ├── app/
      │   ├── features/
      │   │   ├── aluno/
      │   │   │   ├── aluno.component.ts
      │   │   │   ├── aluno.component.html
      │   │   │   └── aluno.component.scss
      │   │   └── professor/
      │   │       ├── professor.component.ts
      │   │       ├── professor.component.html
      │   │       └── professor.component.scss
      │   ├── services/
      │   │   ├── alunoService/
      │   │   │   └── aluno.service.ts
      │   │   └── professorService/
      │   │       └── professor.service.ts
      │   ├── app.component.ts
      │   ├── app-routing.module.ts
      │   └── app.module.ts
      ├── environments/
      │   └── environment.development.ts
      └── index.html
```

#### 🔧 Tecnologias Frontend
| Tecnologia | Versão | Propósito |
|-----------|--------|----------|
| **Angular** | 15 | Framework web |
| **TypeScript** | - | Linguagem |
| **Bootstrap** | 5.x | Framework CSS responsivo |
| **RxJS** | - | Programação reativa |
| **HttpClientModule** | - | Comunicação HTTP com API |

---

## 🚀 Começando

### Pré-requisitos

- **.NET 8 SDK** ou superior
- **Node.js** (v18 ou superior)
- **Angular CLI** 15
- **MySQL** (local ou remoto)

### Instalação e Execução

#### Backend

1. **Clone o repositório**
```bash
git clone https://github.com/RafaKowalski/AcademiaOdata.git
cd AcademiaOdata
```

2. **Configure a string de conexão**
   - Abra `AcademiaOdata.Api/appsettings.json`
   - Atualize a `DefaultConnection` conforme sua configuração MySQL:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "server=localhost;userid=root;password=P@ssw0rd;database=AcademiaDB"
   }
   ```

3. **Aplique as migrations**
```bash
cd Academia.Infra.Data.EF
dotnet ef database update --startup-project ../AcademiaOdata.Api
```

4. **Execute a API**
```bash
cd AcademiaOdata.Api
dotnet run
```

A API estará disponível em: `https://localhost:5001`

**Swagger UI**: `https://localhost:5001/swagger`

#### Frontend

1. **Instale as dependências**
```bash
cd Client/AcademiaOdata
npm install
```

2. **Execute a aplicação Angular**
```bash
ng serve
```

A aplicação estará disponível em: `http://localhost:4200`

---

## 📚 Conceitos Aprendidos e Aplicados

### Arquitetura e Design

✅ **Clean Architecture**
- Separação em camadas (Domain, Application, Infrastructure, Presentation)
- Independência de frameworks e bibliotecas externas
- Facilidade de teste e manutenção

✅ **CQRS (Command Query Responsibility Segregation)**
- Separação clara entre operações de leitura (Queries) e escrita (Commands)
- Facilita escalabilidade e performance
- Exemplo: `GetAllAlunosQuery`, `AddAlunoCommand`

✅ **Padrão Repository**
- Abstração da camada de dados
- Facilita mudanças de banco de dados
- Melhora testabilidade

✅ **Injeção de Dependência**
- Reduz acoplamento
- Facilita testes unitários com mocks
- Código mais limpo e manutenível

### Padrões de Código

✅ **MediatR**
- Implementação do padrão Mediator
- Desacoplamento entre componentes
- Facilita adição de comportamentos transversais

✅ **AutoMapper**
- Mapeamento automático entre objetos
- Separação entre Domain Models e DTOs
- Reduz código boilerplate

✅ **FluentValidation**
- Validação fluente e expressiva
- Separação da lógica de validação
- Reutilizável em diferentes contextos

✅ **OData**
- Padrão para consultas RESTful avançadas
- Suporte para filtragem, ordenação e seleção
- Reduz transfer de dados desnecessários

### Banco de Dados

✅ **Entity Framework Core**
- ORM moderno e eficiente
- LINQ para queries type-safe
- Migrations para versionamento de schema
- Lazy loading e eager loading

✅ **Design do Banco**
- Entity Configurations para fluent API
- Relacionamentos 1:N (Professor:Alunos)
- Chaves primárias e estrangeiras

---

## 📊 Estrutura do Banco de Dados

### Tabela: Professores
```sql
CREATE TABLE Professores (
  ProfessorId CHAR(36) PRIMARY KEY,
  Nome VARCHAR(255) NOT NULL
);
```

### Tabela: Alunos
```sql
CREATE TABLE Alunos (
  AlunoId CHAR(36) PRIMARY KEY,
  Nome VARCHAR(255) NOT NULL,
  Altura VARCHAR(10),
  Peso VARCHAR(10),
  Email VARCHAR(255),
  Telefone VARCHAR(20),
  ProfessorResponsavelId CHAR(36) NOT NULL,
  FOREIGN KEY (ProfessorResponsavelId) REFERENCES Professores(ProfessorId)
);
```

### Dados Iniciais

**Professores:**
- Kowalski
- Rafael
- Rockeiro

**Alunos:**
- João (1,55m, 47kg) - Professor: Kowalski
- Otário (1,75m, 78kg) - Professor: Rafael
- Varginha (1,63m, 60kg) - Professor: Rockeiro
- Vader (1,89m, 93kg) - Professor: Kowalski
- Yoda (1,10m, 20kg) - Professor: Rafael

---

## 🔄 Fluxo de Uma Requisição

### Exemplo: Listar Alunos

```
Frontend (Angular)
    ↓
GET /api/alunos (HttpClient)
    ↓
AlunosController.GetAllAlunos()
    ↓
MediatR.Send(GetAllAlunosQuery)
    ↓
GetAllAlunosHandler.Handle()
    ↓
AlunoService.GetAllAlunos()
    ↓
AlunoRepository.GetAllAlunos()
    ↓
Entity Framework (DbContext)
    ↓
MySQL Database
    ↓
Resposta JSON
    ↓
Frontend (Exibição em lista)
```

---

## 🧪 Testes

O projeto inclui testes unitários abrangentes em:

- `Academia.Application.Tests/`

**Cobertura:**
- ✅ Services (AlunoService, ProfessorService)
- ✅ Handlers (Commands e Queries)
- ✅ Validators (Regras de validação)
- ✅ Mappers (Mapeamento de objetos)

**Rodar testes:**
```bash
dotnet test
```

---

## 📈 Roadmap / Funcionalidades Futuras

- [ ] **Módulo de Aulas**: Cadastro de aulas dos alunos, horários e presença
- [ ] **Módulo de Estoque**: Gestão de equipamentos, entrada/saída
- [ ] **Autenticação e Autorização**: JWT, roles de usuário
- [ ] **Dashboard de Relatórios**: Estatísticas e insights
- [ ] **Filtros e Paginação**: Melhor navegação em listas
- [ ] **Edição e Deleção**: CRUD completo
- [ ] **Notificações em Tempo Real**: SignalR
- [ ] **Testes de Integração**: Testes E2E

---

## 🤝 Contribuindo

Este é um projeto de estudos pessoal. Sinta-se livre para:

- 🍴 Fazer fork
- 🔀 Criar branches
- 📝 Sugerir melhorias
- 🐛 Reportar issues

---

## 📝 Notas de Aprendizado

### Por que Clean Architecture?

Escolhi Clean Architecture porque:
- Facilita testes independentes de cada camada
- Permite mudança de frameworks sem afetar lógica de negócio
- Código mais organizado e fácil de manter
- Preparação para projetos em produção

### Por que CQRS?

- Separação clara entre leitura e escrita
- Melhor performance (possibilita otimizações específicas)
- Escalabilidade horizontal
- Menos acoplamento

### Por que OData?

- Padrão industry-standard
- Queries flexíveis sem criar múltiplos endpoints
- Cliente controla a resposta
- Preparação para APIs modernas

---

## 📖 Recursos de Aprendizado

- [Clean Architecture - Robert C. Martin](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
- [CQRS Pattern - Martin Fowler](https://martinfowler.com/bliki/CQRS.html)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
- [Angular Documentation](https://angular.io/docs)
- [MediatR Documentation](https://github.com/jbogard/MediatR)

---

## 📞 Contato

- **GitHub**: [@RafaKowalski](https://github.com/RafaKowalski)
- **Repositório**: [AcademiaOdata](https://github.com/RafaKowalski/AcademiaOdata)

---

## 📄 Licença

Este projeto é de uso educacional. Sinta-se livre para usar como base para seus próprios projetos.

---

## ⭐ Se Aprendeu Algo Útil

Se este projeto o ajudou a entender esses conceitos, consider dar uma ⭐ no repositório!

---

**Última atualização**: Fevereiro de 2025  
**Status**: 🚧 Em desenvolvimento contínuo para fins educacionais
