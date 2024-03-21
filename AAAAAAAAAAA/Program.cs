using System;



class Program
{
    static void Main()
    {
        int ejercicios = 0;
        do
        {
            Console.WriteLine("Dime a que ejercicio quieres ir del 1 al 26");
            ejercicios = int.Parse(Console.ReadLine());
        }
        while (ejercicios > 26 || ejercicios < 1);

        switch (ejercicios)
        {


            case 7:
            string sex;
        Console.WriteLine("Dime un correo");
        sex = Console.ReadLine();
        string[] correo = sex.Split('@');
        Console.WriteLine("El dominio es " + correo[1]);
        Console.ReadLine();
                break;
    }


        
    }
}