#Decis�es T�cnicas
-> Escolhi utilizar o Framework NET 6 por j� ser uma vers�o multiplataforma
-> Utilizei o modelo DDD para a arquitetura da solu��o

#Instru��es de Execu��o
-> A aplica��o � executada atrav�s de console, � necess�rio passar a linha do Json com todas as opera��es em linha �nica.
Ex: [{"operation":"buy", "unit-cost":10.00, "quantity": 100},{"operation":"sell", "unit-cost":15.00, "quantity": 50},{"operation":"sell", "unit-cost":15.00, "quantity": 50}]

#Instru��es para Testes
-> Criei um projeto de Teste de Unidade, inclui todos os cen�rios propostos na classe de teste. Para execu��o, se acessar o projeto pelo Visual Studio, 
basta apenas selecionar a op��o Teste > Executar todos os testes.