//Calcular a nota media dos alunos.

int avaliacoes = 5;
/*  97 - 100    A+
    93 - 96     A
    90 - 92     A-
    87 - 89     B+
    83 - 86     B */

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int joao1 = 90;
int joao2 = 92;
int joao3 = 98;
int joao4 = 100;
int joao5 = 97;

int somaSophia = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int somaNicolas = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int somaZahirah = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int somaJoao = joao1 + joao2 + joao3 + joao4 + joao5;

decimal mediaSophia = (decimal) somaSophia / avaliacoes;
decimal mediaNicolas = (decimal) somaNicolas / avaliacoes;
decimal mediaZahirah = (decimal) somaZahirah / avaliacoes;
decimal mediaJoao = (decimal) somaJoao / avaliacoes;

Console.WriteLine("\tEstudante\tGrade\n");
Console.WriteLine("Nota média Sophia:\t" + mediaSophia + "\tA");
Console.WriteLine("Nota média Nicolas:\t" + mediaNicolas + "\tB");
Console.WriteLine("Nota média Zahirah:\t" + mediaZahirah + "\tB");
Console.WriteLine("Nota média João:\t" + mediaJoao + "\tA");