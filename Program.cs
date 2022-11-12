



{
    /* simulador de financiamento
    Financiamento de R$1.000,00 em quantas vezes
    Voce pagará 2 parcela(s) fixa(s) de R$500,00.

    Obrigado por utilizar o nosso programa!
    */
    Console.Clear();

    Console.WriteLine("\nEscreva o valor total para simular o financiamento!");
    decimal valorTotal = Convert.ToDecimal(Console.ReadLine());
    int quantidadeParcelas;
    string quantidadeDigitada;
    bool numeroValido;                        
      //pode ser true (verdadeiro) ou false (falso)
    Console.WriteLine(" -- Simulador de Financiamento--");

    Console.Write($"\nFinanciamento de {valorTotal:C} em quantas vezes? ");
    
    quantidadeDigitada = Console.ReadLine();
    

    numeroValido = Int32.TryParse(quantidadeDigitada, out quantidadeParcelas);
    

//o tryparse vai ser guardado na variavel que queira "bool" e vai decidir se é falso ou verdadeiro assim como está acima


    if (!numeroValido)
    {
        Console.WriteLine("Quantidade de parcelas inválida. Por favor digite um número.");

    } 
    
    else if  (quantidadeParcelas <= 0 || quantidadeParcelas >10) //posso usar pipe "||" significa "ou"  para fazer com que separe um teste do outro
    {
        
        Console.WriteLine($"Não é possivel parcelar em {quantidadeParcelas} vez(es).");
    
    }
    else
    {

    decimal valorParcela = valorTotal / quantidadeParcelas;
    Console.WriteLine($"Voce pagará {quantidadeParcelas} parcela(s) fixa(s) de {valorParcela:C}.");

    }

    Console.WriteLine("\nObrigado por utilizar o nosso programa!");





}

// Simulador de Financiamento - ok
// Validação de "0" parcelas : if e finalização com codigo de erro - ok
// Blocos e adição de mensagem de erro - ok
// exibindo sempre a mensagem de saida : else - ok
// validação de parcelas negativas: opeadores de comparação - ok
// Validação de Conversão: tryparse, inversão e ifs aninhados - ok
// Refatorando para legivilidade: else-if - ok
// Numero maximo de parcelas: operadores logicos





    
/* colocar um m no final como '1000.00m" vai avisar a variavel q o numero armazenado é do tipo decimal!
Enviroment.exit(); é usado para finalizar o programa, usamos tb "-1" para indicar que houve um problema
IF é igual a "se" serve para  por exemplo, eu quero rodar meu programa "se" algo acontecer
"==" serve para fazer uma comparação se a condição for verdadeira ele vai executar o comando antes do "; ponto e virgula"
o que fazer quando quero escrever varios comandos quando so posso um? uma estrutura chamada "bloco" abrindo as {} chaves
if com else necessitamos de mais de um comando diferente para cada um dos casos.
else significa "se não" ou seja se nao acontecer tal coisa isso vai ocorrer
podemos utilizar <= ou => para indicar se for igual ou menor do que tal coisa como por exemplo não quero que o numero possa ser  0 ou menor que ele: eu uso <=
Tryparse vai receber uma string e vai passar uma variavel no qual voce deseja e ele vai poder alterar, se ele conseguir a variavel vai estar alterada e se nao conseguir ele nao vai dar erro. ele vai pegar outra variavel e vai dizer que é false
como autorizar q ele modifique? use a palavra "OUT"
o "!" é uma negação se for colocada por exemplo numa variavel bool, ele vai inverter a situação. se for false vai se tornar true e se for true se torna false
else if serve para por exemplo: se for numerovalido mas a quantidade de parcelas não é valida vai ocorrer tal coisa, mas se for valida vai pular o else if e seguir para o proximo else acontecendo o proximo teste

// notas: para fazer de um espaço até o outro para deixar o codigo "invisivel" se usa '/* e fecha com */