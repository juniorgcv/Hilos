using System;
using System.Threading;

public class Programa
{
    static void Main()
    {
        Thread hiloUno = new Thread(FuncionHilo);
        hiloUno.Start(1);

        Thread hiloDos = new Thread(FuncionHilo);
        hiloDos.Start(2);

        hiloUno.Join();
        hiloDos.Join();
    }

    static void FuncionHilo(object? num)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hilo {0} ejecutando iteración {1}", num, i);
            Thread.Sleep(1000);
        }
    }
}
