<h1 align="center">Desafio MXM - Backend</h1>

# Sumário

- [Descrição](#Descrição)
- [Desafios](#Desafios)
- [Features](#Features)
- [Tecnologias Utilizadas](#Tecnologias-Utilizadas)
- [Instalação](#Instalação)
- [Autor](#Autor)

# Descrição

API desenvolvida para o Desafio MXM, com o objetivo de interceptar as requisições feitas a API da MXM, devido a limitação de consumo de requisições do tipo GET com body, a partir do XmlHttpRequest - objeto da API dos browsers modernos respons pelo consumo HTTP.

# Features

- [x] Interceptar requisições do tipo GET a API da MXM com body, a partir de endpoint do tipo POST;
- [x] Interceptar requisições do tipo POST a API da MXM.

# Desafios

Durante o desenvolviemento deste projeto, o maior desafio consistiu em conseguir entregar uma API agnóstica, que não possuísse definição de tipos, e pudesse da maneira possível interceptar requsições de quaisquer tipos. Para isso, foi utilizada a serialização e desserialização de objetos (sem tipo de dado específico) para JSON.

# Tecnologias Utilizadas

- Linguagem C#
- .NET Core

# Uso

O consumo pode ser feito diretamente pelo cliente de escolha do usuário ao serviço hospedado, com documentação disponível a partir do endereço abaixo:

```
https://mxm-desafio-backend-man4j4fmwa-rj.a.run.app/swagger/index.html
```

Para uso local, o usuário deve fazer a clonagem do repositório, e a partir do diretório do projeto da API, executar o comando:
```
dotnet run
```

# Autor

<img src="https://avatars.githubusercontent.com/u/49618629?v=4" alt="ProfilePicture" title="ProfilePicture" width="200px" height="200px" />

[Alexandre Lima](https://github.com/chandelima) &#128640;
