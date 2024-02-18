/* EX 6
Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
impar
*/

Console.WriteLine("Introduceti un numar:");
int numar = int.Parse(Console.ReadLine());

if (numar % 2 == 0)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impar");
}