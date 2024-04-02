using ConceptPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("===========");

try
{

    Console.WriteLine(new Date(1981,11,5));
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(1985, 14, 5));

}
catch (Exception error)
{
   
    Console.WriteLine(error.Message);
}





