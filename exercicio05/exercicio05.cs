Random dias = new Random();
int diasParaExpirar = dias.Next(12);
int porcentagemDesconto = 0;

Console.WriteLine($"{diasParaExpirar} dias.");

if (diasParaExpirar == 0) {
    Console.WriteLine("Sua assinatura expirou.");
} else if (diasParaExpirar == 1) {
        Console.WriteLine("Sua assinatura expira em 1 dia. Renove agora e ganhe 20% de desconto!");
            porcentagemDesconto = 20;
} else if (diasParaExpirar <= 5) {
        Console.WriteLine($"Sua assinatura expira em {diasParaExpirar} dias. Renove agora e ganhe 10% de desconto!");
            porcentagemDesconto = 10;
} else if (diasParaExpirar <= 10) {
    Console.WriteLine("Sua assinatura está para expirar. Renove agora!");
} else {
    Console.WriteLine("");
}

if (porcentagemDesconto > 0){
Console.WriteLine($"Você tem {porcentagemDesconto}% de desconto para usar na renovação.");
}