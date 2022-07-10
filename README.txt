#Decisões Técnicas
-> Escolhi utilizar o Framework NET 6 por já ser uma versão multiplataforma
-> Utilizei o modelo DDD para a arquitetura da solução

#Instruções de Execução
-> A aplicação é executada através de console, é necessário passar a linha do Json com todas as operações em linha única.
Ex: [{"operation":"buy", "unit-cost":10.00, "quantity": 100},{"operation":"sell", "unit-cost":15.00, "quantity": 50},{"operation":"sell", "unit-cost":15.00, "quantity": 50}]

#Instruções para Testes
-> Criei um projeto de Teste de Unidade, inclui todos os cenários propostos na classe de teste. Para execução, se acessar o projeto pelo Visual Studio, 
basta apenas selecionar a opção Teste > Executar todos os testes.