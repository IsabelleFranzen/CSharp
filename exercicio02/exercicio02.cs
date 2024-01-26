//Criar grade de notas para os alunos.

int gradeA = 4;
int gradeB = 3;

string nomeEstudante = "Sophia Johnson";
string nomeCurso1 = "Inglês 101";
string nomeCurso2 = "Algebra 101";
string nomeCurso3 = "Biologia 101";
string nomeCurso4 = "Ciência da Computação I";
string nomeCurso5 = "Psicologia 101";

int creditoCurso1 = 3;
int creditoCurso2 = 3;
int creditoCurso3 = 4;
int creditoCurso4 = 4;
int creditoCurso5 = 3;

int gradeCurso1 = gradeA;
int gradeCurso2 = gradeB;
int gradeCurso3 = gradeB;
int gradeCurso4 = gradeB;
int gradeCurso5 = gradeA;

int totalCreditoHoras = 0;
totalCreditoHoras += creditoCurso1;
totalCreditoHoras += creditoCurso2;
totalCreditoHoras += creditoCurso3;
totalCreditoHoras += creditoCurso4;
totalCreditoHoras += creditoCurso5;

int totalGradePontos = 0;
totalGradePontos += creditoCurso1 * gradeCurso1;
totalGradePontos += creditoCurso2 * gradeCurso2;
totalGradePontos += creditoCurso3 * gradeCurso3;
totalGradePontos += creditoCurso4 * gradeCurso4;
totalGradePontos += creditoCurso5 * gradeCurso5;

decimal gradePointAverage = (decimal) totalGradePontos/ totalCreditoHoras;
int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10 ) % 10;
int secondDigit = (int) (gradePointAverage * 100 ) % 10;

Console.WriteLine("Estudante:\t" + nomeEstudante);
Console.WriteLine("\tCurso\t\t Grade\t\t Credito");

Console.WriteLine($"{nomeCurso1}\t\t {gradeCurso1}\t\t {creditoCurso1}");
Console.WriteLine($"{nomeCurso2}\t\t {gradeCurso2}\t\t {creditoCurso2}");
Console.WriteLine($"{nomeCurso3}\t\t {gradeCurso3}\t\t {creditoCurso3}");
Console.WriteLine($"{nomeCurso4}  {gradeCurso4}\t\t {creditoCurso4}");
Console.WriteLine($"{nomeCurso5}\t\t {gradeCurso5}\t\t {creditoCurso5}");

Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
