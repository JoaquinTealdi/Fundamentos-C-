

List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7};




SortedList<int, string> autosOrdenados = new SortedList<int, string>()
{
    { 3, "renault"},
    { 1, "fiat"},
    { 2, "chevrolet"}
};

foreach (var i in autosOrdenados)
{
    Console.WriteLine("Elementos de la lista: " + i); // output "fiat", "chevrolet", "renault"
}

