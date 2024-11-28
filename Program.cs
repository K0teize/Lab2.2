using System.Reflection.PortableExecutable;
using System.Security.AccessControl;

public class program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов: ");
        int b = int.Parse(Console.ReadLine());
        int left = 0, count = 0; 
        Console.WriteLine("Введите элементы: ");
        int curr = int.Parse(Console.ReadLine());
        int right = int.Parse(Console.ReadLine());
        for (int i = 2; i < b; i++) 
        {
            left = curr;
            curr = right;
            right = int.Parse(Console.ReadLine());
            if (curr > left && curr > right)
            {
                count++;
            }
            
        }
        
        Console.WriteLine("Количество локальных максимумов: "+count);
    }
}