/*Você usará o método Random.Next() para simular a rolagem de três dados de seis lados cada. Você avaliará os valores para calcular a 
pontuação. Se quaisquer dois dados rolados resultarem no mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado.
Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado.
Se a pontuação do jogador for maior ou igual a 16, ele ganhará um carro novo.
Se a pontuação do jogador for maior ou igual a 10, ele ganhará um laptop novo.
Se a pontuação do jogador for exatamente 7, ele ganhará uma viagem.
Caso contrário, ganhará um gatinho. */

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice Roll: |{roll1}| + |{roll2}| + |{roll3}| = {total}");

if ( (roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3) ) {

    if ( (roll1 == roll2) && (roll2 == roll3) ){

    Console.WriteLine("Você rolou em triplo! +6 pontos no total");
    total += 6;

}   else {

    Console.WriteLine("Você rolou em dobro! +2 pontos no total!");
    total += 2;
}

}

if(total >= 16) {

    Console.WriteLine("Você ganhou um carro!");
}
else if (total >= 10) {

    Console.WriteLine("Você ganhou um computador!");
}
else if (total == 7){
    Console.WriteLine("Você ganhou uma viagem!");
}
else {
    Console.WriteLine("Você ganhou um gatinho!");
}

