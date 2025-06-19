# Registro de Testes de Usabilidade

🔹 **Cenário 1**: O usuário recebeu o link do site: https://armario42-app.azurewebsites.net/, irá acessar o site pela primeira vez para conhecer e ter suas primeiras impressões.

|**Caso de Teste** 	| ✅ **CT01 – Avaliação do Design Visual do Sistema** | 
| ---	| ---	|
|*Requisito Associado* | RNF-CT01 – O sistema deve ter um design visual atraente e profissional, adequado ao público de cosplay |
|*Objetivo do Teste* 	| (RNF-001) Verificar se o layout e as cores estão visualmente agradáveis e em sintonia com a temática de cosplay e logomarca escolhida |   

| **Usuário**   | **Tempo Total (seg)** | **Quantidade de cliques** | **Tarefa foi concluída?** (Sim/Não) | **Erros Cometidos** | **Feedback do Usuário** |
|-------------|:--------------------:|:---------------------------------:|:-----------------:|:------------------------:|:------------------------------:|
| Usuário 1    |       8 seg             |                   6              |        Sim         |           Nenhum             |             Página inicial acessa e aparecem anúncios, acha que mais cores da logomarca seria legal.               |                       
| Usuário 2    |         5 seg           |                     5            |        Sim         |               Nenhum         |                Consegue entender do que se trata, gostou do nome e achou bem associativo.              |                          
| Usuário 3    |              10 seg      |                      6           |             Sim    |          Nenhum              |                     Gostaria que tivessem mais imagens na primeira página, acha que ficaria legal.         |                      
| Usuário 4    |            7 seg        |                 6                |          Sim       |           Nenhum             |              Sugere imagens na tela inicial.          |                     
| Usuário 5    |           8 seg         |                   6              |             Sim    |              Nenhum          |               Sugere um cajado de magia como símbolo.              |                     

----

🔹 **Cenário 2**: Os usuários vão visitar o link do site: https://armario42-app.azurewebsites.net/, mas cada um usa pelo menos dois navegadores diferentes.

|**Caso de Teste** 	| ✅ **CT02 – Teste de Compatibilidade com Navegadores** | 
| ---	| ---	|
|*Requisito Associado* | RNF-CT02 – O sistema deve ser compatível com os principais navegadores da web (Chrome, Firefox, Safari, Edge) |
|*Objetivo do Teste* 	| (RNF-002) Verificar se o sistema funciona corretamente nos navegadores listados |   

| **Usuário**   | **Tempo Total (seg)** | **Quantidade de cliques** | **Tarefa foi concluída?** (Sim/Não) | **Erros Cometidos** | **Feedback do Usuário** |
|-------------|:--------------------:|:---------------------------------:|:-----------------:|:------------------------:|:------------------------------:|
| Usuário 1    |         25 seg           |                 9                |           Sim      |           Nenhum             |               Testado no Chrome e Edge, funcionou nos dois.               |                       
| Usuário 2    |             23 seg       |                 10                |          Sim       |          Nenhum                |             Testado no Safari e Chrome, funcionou nos dois.                    |                          
| Usuário 3    |             27 seg       |                   9              |        Sim         |            Nenhum              |                Testado no Chrome e Edge, funcionou nos dois.                 |                      
| Usuário 4    |                 15 seg   |                    8             |        Sim          |            Nenhum              |               Testado no Chrome e Firefox, funcionou nos dois.                  |                     
| Usuário 5    |             15 seg       |                     9            |        Sim          |            Nenhum              |              Testado no Edge e Safari, funcionou nos dois.                   |                     

🔹 **Cenário 3**:  Os usuários vão visitar o link do site: https://armario42-app.azurewebsites.net/, em pelo menos duas telas de tamanhos diferentes. Além disso, movimentar a janela em cada um para aumentar ou diminuir em várias direções.

|**Caso de Teste** 	| ✅ **CT03 – Verificação de Responsividade do Sistema** | 
| ---	| ---	|
|*Requisito Associado* | RNF-CT03 – O sistema deve ser responsivo, podendo ser utilizado Bootstrap, com referência mínima de 10 polegadas |
|*Objetivo do Teste* 	| (RNF-003) Verificar se o sistema se adapta corretamente a diferentes tamanhos de tela |   

| **Usuário**   | **Tempo Total (seg)** | **Quantidade de cliques** | **Tarefa foi concluída?** (Sim/Não) | **Erros Cometidos** | **Feedback do Usuário** |
|-------------|:--------------------:|:---------------------------------:|:-----------------:|:------------------------:|:------------------------------:|
| Usuário 1    |         32 seg           |              9                   |        Sim         |           Nenhum            |             Não apresentado nenhum erro ou deformação crítica.                 |                       
| Usuário 2    |         29 seg           |                8                 |                 |                        |               Layout se ajustou bem no notebook e no celular.               |                          
| Usuário 3    |            31 seg        |                9                 |                 |                        |       Os elementos se adaptaram, testado em tablet e desktop.           |                      
| Usuário 4    |           28 seg        |                7                 |                 |                        |            Não quebrou layout ao redimensionar no navegador.                  |                     
| Usuário 5    |                33 seg    |                8                 |                 |                        |              Se ajustou conforme a movimentação.                |                     

🔹 **Cenário 4**: O usuário recebeu o link do site: https://armario42-app.azurewebsites.net/, irá acessar o site pela primeira vez para conhecer e ter suas primeiras impressões.

|**Caso de Teste** 	| ✅ **CT04 – Tempo de Resposta da Aplicação** | 
| ---	| ---	|
|*Requisito Associado* | RNF-CT04 – A aplicação deve processar requisições do usuário em no máximo 3 segundos |
|*Objetivo do Teste* 	| (RNF-004) Verificar se as respostas às ações do usuário acontecem dentro do tempo estipulado |   

| **Usuário**   | **Tempo Total (seg)** | **Quantidade de cliques** | **Tarefa foi concluída?** (Sim/Não) | **Erros Cometidos** | **Feedback do Usuário** |
|-------------|:--------------------:|:---------------------------------:|:-----------------:|:------------------------:|:------------------------------:|
| Usuário 1    |          3 seg          |                          6       |           Sim      |           Nenhum              |                  Site carregou rápido, sem atrasos.            |                       
| Usuário 2    |            2 seg        |                           5      |        Sim          |           Nenhum              |                Páginas abriram quase instantaneamente.              |                          
| Usuário 3    |            2 seg        |                      7          |       Sim           |            Nenhum             |             Tudo fluiu bem, mesmo no celular.                 |                      
| Usuário 4    |            3 seg        |                    6             |        Sim          |           Nenhum              |                Sem lentidão, trocas de página rápidas.              |                     
| Usuário 5    |         3 seg           |                     6            |          Sim        |           Nenhum              |                 Carregou rápido, o que processou um pouco mais foi a busca e criação, geralmente ações ligadas a banco mesmo mas quase imperceptível.         |                     

# Relatório dos Testes de Usabilidade
