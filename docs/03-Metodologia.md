
# Metodologia


## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: código principal, testado e revisado.
- `homolog`: repositório revisado pelo time antes do deploy.
- `docs`: atualização de documentação.
- `project`: atividades relacionadas a organização do projeto, inclui criação de branches, labels e issues.

Para melhor desenvolvimento do POC (Prova de Conceito de Arquitetura) e recomendação do orientador para continuidade por enquanto, foram substituídas branches de teste, refatoração, etc, por uma branch para cada integrante. ENtão foram mantidas as branches acima e essas abaixo:

- `alexandre`
- `aliane` 
- `deuslano`
- `lucas`
- `murilo`

Quanto à gerência de commits das issues, o projeto adota a seguinte convenção para
etiquetas:

- `fix`: quando o commit é para inserir uma correção de algo já existente.
- `feat`: quando o commit é para inserir um conteúdo de algo novo, que não existia antes no contexto.

Definimos um padrão de commit para ser seguido por todos do time:

⚠️ **ação(branch): o que foi feito?**
Exemplo: feat(docs): Adiciona dados dos integrantes no README.md

- feat: quando for algo novo.
- fix: quando for uma atualização de algo que já existe.

Através do feedback dos integrantes, combinamos de ter cuidado ao fazer um commit, conferir sempre antes a branch selecionada.

**Link para saber para que serve cada branch:** https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/labels

## Gerenciamento de Projeto e Processos Ágeis

Buscamos aplicar as práticas da metodologia ágil SCRUM em nossa gestão de desenvolvimento da seguinte forma:

- **Sprints:** O projeto possui 5 etapas, cada uma com as particularidades que devem ser entregues. Dividimos o trabalho em ciclos de desenvolvimento (sprints), cada etapa é considerada uma sprint, devido a necessidade de adaptação com os prazos da faculdade, cada sprint possui duração de um mês aproximadamente.

- **Reuniões Periódicas (Dailys):** Consideramos dois tipos de reuniões, as "dailys" que são periódicas realizadas com a equipe e uma reunião com o cliente (professor/orientador) uma vez por semana.

- **Kanban:** Utilizamos o GitHub Project com um quadro Kanban para acompanhar o progresso das tarefas ao longo da sprint, disponível na aba "Projects".

- **Product Backlog:** Realizamos uma reunião inicial no primeiro dia de sprint para preparar o Product Backlog no GitHub Project, organizamos as tarefas prioritárias e estimamos o esforço necessário, as dividindo conforme as funções dos membros do time.

- **Papéis no Time:** Buscamos selecionar alguns papéis adicionais para alguns membros do time para suprir necessidades que poderiam surgir e melhor organização, como Scrum Master, Product Owner e Desenvolvedores focais em Front-End e/ou Back-End.

- **Reuniões de Revisão:** Próximo ao final da sprint, recebemos a avaliação do que foi entregue na sprint e ajustamos o backlog conforme necessário.

- **Retrospectiva:** Ao final da sprint, realizamos uma reunião com uma ata, com os pontos de reconhecimento e de melhorias para a sprint seguinte.

Consideramos aplicar o SCRUM pois além de ser considerada uma prática muito importante na área da tecnologia e muito usada no mercado hoje, auxilia as equipes a trabalharem de forma colaborativa para atingir um objetivo comum. O objetivo da metodologia é otimizar a eficiência, agilizar o desenvolvimento de produtos complexos, gerar valor contínuo ao cliente, promover a colaboração e adaptar-se constantemente às mudanças.

## Ferramentas e Tecnologias Utilizadas

- IDE / Editor de Código: Visual Studio Code. 
- Serviços Web: A definir.
- Frameworks: A definir.
- Bibliotecas: A definir.
- Hospedagem: Vercel ou Azure.

- Ferramentas de Comunicação: Microsoft Teams e WhatsApp. 
- Ferramenta de Wireframe: Marvel App. 
- Ferramenta de Diagramação: LucidChart, PLantUML.

O editor VS Code foi escolhido pois ele possui uma integração com o sistema de versão do GitHub. <br/>
As ferramentas de comunicação são as mais ágeis para o dia a dia dos acadêmicos e o padrão da faculdade. <br/>
Para wireframe, selecionamos essa opção devido a facilidade de aplicação das interações, opção gratuita e de fácil acesso. <br/>
As opções de ferramentas de hospedagem foram sugeridas pela indicação e integração com GitHub. <br/>
Por fim, para criar diagramas utilizamos as ferramentas de conhecimento já do grupo. <br/>
