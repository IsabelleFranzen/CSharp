string? informacao;
string valorInformado = "";
int numero = 0;
bool numeroValido = false;

Console.WriteLine("Informe um número de 5 a 10.");

do {
    informacao = Console.ReadLine();
    if (informacao != null ){
        valorInformado = informacao;
    }

    numeroValido = int.TryParse(valorInformado, out numero);

    if (numeroValido == true) {

        if ((numero <= 5) || (numero >= 10)){
        numeroValido =  false;
        Console.WriteLine($"Você informou o número {numero}. Insira um número entre 5 e 10.");
        }
    } else {
        Console.WriteLine("Você inseriu um número inválido, insira novamente.");
    }

} while (numeroValido == false);
Console.WriteLine($"Você informou corretamente o número {numero}.");
informacao = Console.ReadLine();