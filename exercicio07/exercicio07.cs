//Criar uma grade de notas para alunos com maiores informações.

using System;
int materias = 5;

int[] sophiaNotas = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewNotas = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaNotas = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganNotas = new int[] { 90, 95, 87, 88, 96, 96 };

string[] nomeEstudantes = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] estudantesNotas = new int[10];

string gradeEstudanteAtual = "";

Console.WriteLine("Estudante\tPontos\tNota Final\tPontos Extras\n");

foreach (string nome in nomeEstudantes) {
    string estudanteAtual = nome;

    if (estudanteAtual == "Sophia")
        estudantesNotas = sophiaNotas;

    else if (estudanteAtual == "Andrew")
        estudantesNotas = andrewNotas;

    else if (estudanteAtual == "Emma")
        estudantesNotas = emmaNotas;

    else if (estudanteAtual == "Logan")
        estudantesNotas = loganNotas;

    decimal notaEstudanteAtual = 0;
    decimal pontoEstudanteAtual = 0;
    decimal pontoExtraEstudanteAtual = 0;

    int atribuicaoGrade = 0;
    int atribuicaoNotaExtra = 0;
    int somaPontos = 0;
    int somaPontosExtra = 0;

    foreach (int pontos in estudantesNotas) {
        atribuicaoGrade += 1;

        if (atribuicaoGrade <= materias){

            somaPontos = somaPontos + pontos;

        } else{

            atribuicaoNotaExtra += 1;
            somaPontosExtra += pontos;
        }
    }

    pontoEstudanteAtual = (decimal)(somaPontos) / materias;
    pontoExtraEstudanteAtual = (decimal)(somaPontosExtra) / atribuicaoNotaExtra;
    
    notaEstudanteAtual = (decimal)((decimal)somaPontos + ((decimal)somaPontosExtra / 10)) / materias;

    if (notaEstudanteAtual >= 97)
        gradeEstudanteAtual = "A+";
    else if (notaEstudanteAtual >= 93)
        gradeEstudanteAtual = "A";
    else if (notaEstudanteAtual >= 90)
        gradeEstudanteAtual = "A-";
    else if (notaEstudanteAtual >= 87)
        gradeEstudanteAtual = "B+";
    else if (notaEstudanteAtual >= 83)
        gradeEstudanteAtual = "B";
    else if (notaEstudanteAtual >= 80)
        gradeEstudanteAtual = "B-";
    else if (notaEstudanteAtual >= 77)
        gradeEstudanteAtual = "C+";
    else if (notaEstudanteAtual >= 73)
        gradeEstudanteAtual = "C";
    else if (notaEstudanteAtual >= 70)
        gradeEstudanteAtual = "C-";
    else if (notaEstudanteAtual >= 67)
        gradeEstudanteAtual = "D+";
    else if (notaEstudanteAtual >= 63)
        gradeEstudanteAtual = "D";
    else if (notaEstudanteAtual >= 60)
        gradeEstudanteAtual = "D-";
    else 
    gradeEstudanteAtual = "F";

    Console.WriteLine($"{estudanteAtual}\t\t{pontoEstudanteAtual}\t{notaEstudanteAtual}\t{gradeEstudanteAtual}\t{pontoExtraEstudanteAtual}({(((decimal)somaPontosExtra / 10) / materias)} pts)");
}

Console.WriteLine("Pressione Enter para continuar.");
Console.ReadLine();
