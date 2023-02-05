// See https://aka.ms/new-console-template for more information
void PrintSq(int n);
{
    int i = 1;
    while(i <= n);
    {
        Console.Write(i + " ");
        i++;   
    }
}
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintSq(n);
