//Contagem de itens de um inventário.

string[] codigosID = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string ordemID in codigosID){
    if (ordemID.StartsWith("B")) {
        Console.WriteLine($"Cógido ID:{ordemID}");
    }
}

int[] inventario = { 200, 450, 700, 175, 250 };
int soma = 0;
int id = 0;

foreach (int items in inventario)
{
    soma += items;
    id++;
    Console.WriteLine($"ID: {id} = {items} items. (Total): {soma})");
}

Console.WriteLine($"Nós temos {soma} itens no inventário.");