string cdp = "01-MN-G";

string[] produto = cdp.Split('-');

string tipo = "";
string cor = "";
string tamanho = "";

switch(produto[0]){
    case "01":
    tipo = "Blusão";
    break;

    case "02":
    tipo = "Camiseta";
    break;

    case "03":
    tipo = "Calça";
    break;

    default:
    tipo = "Outros";
    break;

}
switch(produto[1]){
     case "PT":
    cor = "Preto";
    break;

    case "MN":
    cor = "Marrom";
    break;

    default:
    cor = "Branco";
    break;
}

switch(produto[2]){
     case "P":
    tamanho = "Pequeno";
    break;

    case "M":
    tamanho = "Medio";
    break;

    case "G":
    tamanho = "Grande";
    break;

    default:
    tamanho = "Tamanho Universal";
    break;
}

Console.WriteLine($"Produto: {tipo} {cor} {tamanho}");