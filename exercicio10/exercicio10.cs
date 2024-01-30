/* Criar um jogo de RPG:
O herói e o monstro começarão com dez pontos de integridade.
Todos os ataques serão um valor entre 1 e 10.
O herói atacará primeiro.
Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
Imprima quem foi o vencedor. 
*/

Random dados = new Random();
int heroi = 10;
int monstro = 10;

do {
    int dano = dados.Next(1,11);
    monstro = monstro - dano;
    Console.WriteLine($"O monstro tomou {dano} de dano. Restam {monstro} de HP.");

    if (monstro <= 0) continue;

        dano = dados.Next(1,11);
        heroi = heroi - dano;
        Console.WriteLine($"O herói tomou {dano} de dano. Restam {heroi} de HP.");
    

} while((heroi > 0) && (monstro > 0));

if (heroi > monstro){
    Console.WriteLine($"O herói venceu o turno.");
} else {
    Console.WriteLine($"O monstro venceu o turno.");
}

//Console.WriteLine(heroi > monstro ? "O herói venceu o turno!" : "O monstro venceu o turno!"); -- outra solução.