# ChatGptAPI
Integrando a API do chatGPT em uma API ASP NET CORE para enviar pacotes com frases para o chat GPT corrigir e me retornar corretamente.

## Ferramentas utilizadas
- Chat GPT API
- ASP NET CORE
- SWAGGER

referencia: https://platform.openai.com/docs/api-reference/introduction

## Exemplo

![](https://github.com/DiegoLins10/ChatGptAPI/blob/master/chatgpt.png)


# User secret como usar

O comando `dotnet user-secrets` permite armazenar informações sensíveis de forma segura durante o desenvolvimento de aplicativos .NET Core. Essas informações são armazenadas localmente no computador do desenvolvedor, fora do controle de versão do código-fonte.

Para usar o `dotnet user-secrets`, siga estas etapas:

### 1. Instalar a Ferramenta `dotnet user-secrets`
Certifique-se de que a ferramenta `dotnet user-secrets` esteja instalada. Você pode instalá-la globalmente com o seguinte comando:

```bash
dotnet tool install --global dotnet-user-secrets
```

### 2. Adicionar uma Chave Secreta
No diretório raiz do seu projeto, execute o seguinte comando para adicionar uma chave secreta:

```bash
dotnet user-secrets set "SendGrid:ApiKey" "sua-chave-de-api-aqui"
```

Isso criará uma entrada de chave secreta chamada `SendGrid:ApiKey` no arquivo de segredos do usuário associado ao seu projeto.

### 3. Acessar a Chave Secreta no Código
Agora, você pode acessar a chave secreta em seu código. Aqui está um exemplo de como você pode fazer isso:

```csharp
using Microsoft.Extensions.Configuration;

public class EmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void EnviarEmail()
    {
        string apiKey = _configuration["SendGrid:ApiKey"];
        // Use a chave de API conforme necessário...
    }
}
```

### 4. Adicionar Referência ao Pacote `Microsoft.Extensions.Configuration.UserSecrets`
Certifique-se de que seu projeto tenha uma referência ao pacote `Microsoft.Extensions.Configuration.UserSecrets`. Se não tiver, adicione-o ao seu arquivo `.csproj`:

```xml
<ItemGroup>
  <PackageReference Include="Microsoft.Extensions.Configuration.UserSecrets" Version="5.0.0" />
</ItemGroup>
```

### Notas Importantes:
- Os segredos são armazenados em um arquivo JSON oculto em um diretório específico do usuário. Certifique-se de não compartilhar esse arquivo com outras pessoas.
- Os segredos definidos são específicos para o projeto atual e não são compartilhados com outros projetos.
- Certifique-se de que todas as dependências necessárias estejam instaladas para usar `dotnet user-secrets`.

Usando o `dotnet user-secrets`, você pode armazenar e acessar informações sensíveis, como chaves de API, de forma segura durante o desenvolvimento de seus aplicativos .NET Core.
