# Registro de Testes de Software

|**Caso de Teste** 	| ✅ **CT07 – Criação de Usuário**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT07 – O sistema deve permitir o cadastro de um novo usuário |
|Passos 	|  📌 Dentro da tela inicial clicar em "Cadastre-se" </br> Preencher os campos obrigatórios </br> 📌 Clicar em "Criar Conta" |
|Critério de Êxito |  Usuário é cadastrado e apresentado com sucesso no banco de dados |
|**Resultado**| Sucesso |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT07-criacao-de-usuario.gif?raw=true) |
|  	|  	|
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
Criou o usuário com sucesso seguindo os mesmos passos.

- Oportunidades de melhoria para próximas versões:
Alterar a tela que apresenta em seguida para a tela interna de boas-vindas após logado, ao invés da lista de usuários ativos.
```
----
|**Caso de Teste** 	| ✅ **CT04 – Criação de Anúncio**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT04 – O sistema deve permitir que o usuário crie anúncios para sua loja |
|Passos 	|  📌 Acessar loja </br> 📌 Clicar em "Criar Anúncio" </br> 📌 Preencher dados </br> 📌 Confirmar criação |
|Critério de Êxito |  Anúncio criado e listado na loja |
|**Resultado**| Sucesso |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT04-criacao-de-anuncio.gif) |
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
Criou o anúncio com sucesso.

- Oportunidades de melhoria para próximas versões:
Inserir botão adicional em outra tela também, de consulta de loja.
```
----
|**Caso de Teste** 	| ✅ **CT08 – Buscar e Visualizar Anúncios com Filtros Ativos**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT08 – O sistema deve permitir que usuários consigam buscar e visualizar os anúncios de peças de cosplay, utilizando palavras-chave e podendo filtrar por ordem alfabética ou preço (crescente ou decrescente) e selecionando tags da listagem |
|Passos 	|  📌 Acessar a página de anúncios </br> 📌 Informar a palavra-chave ou nome na barra de busca </br> 📌 Selecionar o critério de ordenação (opcional) |
|Critério de Êxito |   Os anúncios exibidos correspondem à palavra-chave (se informada), estão ordenados conforme o critério selecionado (se informado) e correspondem à tag selecionada (se informada) |
|**Resultado**| Sucesso Parcial |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT08-buscar-anuncios-filtros.gif?raw=true) |
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
Realizou a busca com sucesso.

- Oportunidades de melhoria para próximas versões:
A busca poder ser realizada por ordens ou palavras-chave, mas os anúncios são apresentados.
```
----
|**Caso de Teste** 	| ✅ **CT03 – Criação de Loja**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT03 – O sistema deve permitir que um usuário crie uma loja após logado |
|Passos 	|  📌 Navegar até "Criar Loja" </br> 📌 Preencher dados </br> 📌 Confirmar criação” |
|Critério de Êxito |  Loja criada com sucesso e associada ao vendedor |
|**Resultado**| Sucesso |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT04-criacao-de-anuncio.gif?raw=true) |
|  	|  	|
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
Realizou a criação de loja com sucesso.

- Oportunidades de melhoria para próximas versões:
A loja hoje está podendo ser criada sem precisar do login, uma melhoria poderia ser restringir esse acesso,
mas é criada e cumpriu a obrigatoriedade de estar associada a um vendedor.
```
----
|**Caso de Teste** 	| ✅ **CT05 – Edição de Anúncio**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT05 – O sistema deve permitir a edição de anúncios já criados |
|Passos 	|  📌 Acessar loja </br> 📌 Selecionar anúncio </br> 📌 Editar dados </br> 📌 Salvar alterações |
|Critério de Êxito | Anúncio atualizado corretamente |
|**Resultado**| Sucesso |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT05-edicao-de-anuncio.gif?raw=true) |
|  	|  	|
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
Realizou a edição de anúncio com sucesso.

- Oportunidades de melhoria para próximas versões:
Nenhuma, o anúncio criado possibilita edição de qualquer informação e exclusão.
```
----
|**Caso de Teste** 	| ✅ **CT01 – Login com Dados Válidos**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT01 – O sistema deve permitir que usuários realizem login |
|Passos 	|  📌 Acessar tela de login </br> 📌 Informar  os dados obrigatórios (E-mail e Senha) </br> 📌 Clicar em “Entrar” |
|Critério de Êxito |  Usuário é redirecionado para o painel principal interno |
|**Resultado**| Sucesso Parcial |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT01-login-valido.gif?raw=true) |
|  	|  	|
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
Realizou o login com dados válidos.

- Oportunidades de melhoria para próximas versões:
Após login direcionar para um ambiente interno após logado.
```
----
|**Caso de Teste** 	| ✅ **CT02 – Login com Dados Inválidos**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT02 – O sistema deve exibir erro ao tentar login com dados incorretos |
|Passos 	|  📌 Acessar tela de login </br> 📌 Informar dados </br> 📌 Clicar em “Entrar” |
|Critério de Êxito |  Deve ser exibida mensagem de erro: "Usuário ou Senha Incorreto(s)" |
|**Resultado**| Sucesso |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT03-login-invalido.gif?raw=true) |
|  	|  	|
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
Apresentou mensagem de aviso com sucesso quando feita tentativa de login com dados inválidos.

- Oportunidades de melhoria para próximas versões:
Nenhuma, foi apresentada mensagem correta para essa situação.
```
----
|**Caso de Teste** 	| ✅ **CT06 – Logoff de Usuário**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT06 – O sistema deve permitir que usuários com login no sistema encerrem suas sessões |
|Passos 	|  📌 Acessar o menu do usuário </br> 📌 Clicar em "Sair" |
|Critério de Êxito |  Sistema deve realizar o logoff e estar habilitado para outro usuário logar |
|**Resultado**| Possui pendências |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT06-logoff.gif?raw=true) |
|  	|  	|
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
Embora seja possível o login e validação, não tinha o botão com funcionalidade para "Sair".

- Oportunidades de melhoria para próximas versões:
Continuar a criação do ambiente interno após logado para criação do menu com a opção "Sair".
```
----
|**Caso de Teste** 	| ✅ **CT09 – Gerar e Exportar Relatórios**	|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT09 – O sistema deve permitir que o usuário consiga gerar e exportar um relatório dos anúncios da sua loja |
|Passos 	|  📌 Acessar o painel do vendedor </br> 📌 Navegar até a seção de relatórios </br> 📌 Selecionar a opção para gerar relatório de anúncios </br> 📌 Clicar em “Gerar Relatório” |
|Critério de Êxito |  O relatório é gerado e disponibilizado para download no formato CSV, contendo os dados dos anúncios da loja |
|**Resultado**| Sucesso Parcial |
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT09-gerar-exportar-relatorios.gif?raw=true) |
|  	|  	|
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
O model de relatório foi criado e possibilita criação, possui sua tela própria, apenas não conclui a exportação no banco.

- Oportunidades de melhoria para próximas versões:
Continuar o ajuste para conclusão da exportação via Azure.
```
----
|**Caso de Teste** 	| ✅ **CT10 – Recuperar Senha**|
|:---:	|:---:	|
|Requisito Associado 	| RF-CT10 – O sistema deve permitir que usuários recuperem suas senhas |
|Passos 	|  📌 Acessar a tela de login </br> 📌 Clicar em “Esqueci minha senha” </br> 📌 Informar o e-mail cadastrado </br> 📌 Clicar em “Enviar” |
|Critério de Êxito |  Uma mensagem informando que um e-mail de recuperação de senha foi enviado para o endereço fornecido é exibida. Usuário deverá checar a Caixa de Entrada, Spam ou Lixo Eletrônico do seu e-mail |
|**Resultado**| Sucesso Parcial|
|Registro de Evidência | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/main/docs/img/evidencias-dos-registros-de-testes/CT10-recuperar-senha.gif?raw=true) |
|  	|  	|
```
RELATÓRIO DO TESTE

- Detalhes do Resultado:
A recuperação de senha possui sua tela com clicáveis funcionando, apenas não conclui o envio do e-mail.

- Oportunidades de melhoria para próximas versões:
Continuar o ajuste para conclusão da recuperação de senha com envio do e-mail via Azure.
```
----
