PROJECT robo.services

Foram utilizadas as tecnologias:

.Net Core 3.1 com Entity Framework para PostgreSQL
Vue.Js 2 com Vuetify

Observações:

- Após executar o projeto, deve ser executado o arquivo script_inicial.sql que está na pasta da API do projeto.

- A API foi configurada para ser executada como uma aplicação self-host e deve ser instalada como windows service ou serviço daemon linux onde irá ser publicada. Deve ser configurada a porta no arquivo de configuração da API.

- No client, desenvolvido em vue.js, para executar em ambiente de desenvolvimento, o ambiente deverá ter o npm intalado. Após isso, é necessário executar o comando "npm install" e após isso, o comando "npm run serve" na pasta robo.client. No arquivo public/config.json deve ser indicado qual a porta que a API está rodando.

- O arquivo sql becomex-sqltest.sql na raiz do repositório contém os scripts SQL referente ao teste da Becomex.
