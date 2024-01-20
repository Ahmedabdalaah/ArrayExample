// See https://aka.ms/new-console-template for more information
using ArrayExample;
ArrayEx arr = new ArrayEx();
Console.WriteLine(" please enter Count  of Clients");
try
{
    String s = Console.ReadLine();
    int count = Convert.ToInt32(s);
    arr.arrayBuild(count);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}