

DateOnly birthday = DateOnly.Parse("9/8/75");
DateTime today = DateTime.Now;

Console.WriteLine(birthday.ToString(format:"dd/MM/yyyy"));
Console.WriteLine($"Today full format:  {today}");
Console.WriteLine($"Today just date:  {today.Date}");
Console.WriteLine($"Birthday just date:  {birthday}");


string continua ="";
do //Se ejectuta al menos 1 vez
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.WriteLine($"Hola {nombre}");
    Console.Write("Continuar (S/N):");
    continua = Console.ReadLine();
} while (continua.ToLower() == "s");

Console.Write("Edad: ");
string edadText=Console.ReadLine();
bool edadValida = int.TryParse(edadText, out int edad);
while (!edadValida) //Se ejectuta 0 o más veces
{
    Console.WriteLine("Es una edad inválida");
    Console.Write("Edad: ");
    edadText = Console.ReadLine();
    edadValida = int.TryParse(edadText, out edad);
}
Console.WriteLine($"Tu edad en 10 años es {edad+10} años");

string profesor = "";
do 
{
    Console.Write("Nombre del Profesor: ");
    profesor = Console.ReadLine();
    if (profesor.ToLower() != "héctor") Console.WriteLine($"{profesor} no es el nombre del profesor.");
} while (profesor.ToLower() != "héctor");

Console.WriteLine("Hola Profesor Héctor");







