using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        StreamReader file = File.OpenText("tecleado.txt");

        string linea;
        int contador = 0;


        while ((linea = file.ReadLine()) != null && contador < 3)
        {
            Console.WriteLine(linea);
            contador++;
        }


        file.Close();

        Console.WriteLine("Programa finalizado.");
        Console.ReadLine();
    }
}