/* Código simulando uma jogada de moeda.

Random moeda = new Random();
int jogada = moeda.Next(0,2);

Console.WriteLine((jogada == 0) ? "CARA" : "COROA");*/


// Avaliar quem pode receber acesso a algum servidor baseado no seu título e nível.
string permission = "Admin|Gerente";
int level = 16;

if (permission.Contains("Admin") && level > 55){
    Console.WriteLine("Bem-vindo Super Administrador.");

} else if (permission.Contains("Admin") && level <= 55){
    Console.WriteLine("Bem-vindo Administrador.");

} else if (permission.Contains("Gerente") && level >= 20) {
    Console.WriteLine("Contate o Administrador para acessar.");

} else if (permission.Contains("Gerente") && level < 20) {
    Console.WriteLine("Você não possui privilégios nesse acesso.");

} else {
    Console.WriteLine("Você não pode ter acesso.");
}