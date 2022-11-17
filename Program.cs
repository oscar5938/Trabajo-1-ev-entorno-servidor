using System;
// using XXXX.Clases;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int Menu()
    {
        bool initialAmount = false;
        decimal initial = 0;
        int opcionSel = 0;

        Console.WriteLine("Bienvenido a NGB");
        Console.WriteLine($"1 - Crear cuenta \n" +
            $"2 - Añadir fondos\n" +
            $"3 - Sacar fondos\n" +
            $"4 - Listado de operaciones\n" +
            $"5 - Listado de cuentas\n" +
            $"6 - Terminar programa\n" +
            $"7 - Save Json\n" +
            $"8 - Read Json"
            );
        Console.WriteLine("Escoga opción:");

        bool optionCheck = false;
        do
        {
            try
            {
                opcionSel = Int32.Parse(Console.ReadLine());
                optionCheck = true;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Debe escribir un número");
            }
        } while (!optionCheck);
        Console.Clear();

        // Variables para comprobar que se introduce un num valido
        switch (opcionSel)
        {
            case 1:
                Console.WriteLine("Introduce tu nombre");
                string name = Console.ReadLine();
                initialAmount = false;
                initial = 0;
                int cantidadSel = 0;
                string nota = "0";
                int cuentaSel = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("Introduce el deposito inicial");
                        initial = Convert.ToInt32(Console.ReadLine());
                        initialAmount = true;
                    }
                    catch (System.FormatException)
                    {
                    }
                } while (!initialAmount);

                // allBankAccounts.Add(new BankAccount(name, initial));
                // Console.WriteLine($"Cuenta creada con éxito, este es su número de cuenta {allBankAccounts.ElementAt(allBankAccounts.Count() - 1).Number}");
                break;
            case 2:
                Console.WriteLine("*****2 - Añadir fondos*****");
                Console.WriteLine("Ingrese la cantidad:");
                cantidadSel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota:");
                nota = Console.ReadLine();
                Console.WriteLine("Elige la cuenta:");
                cuentaSel = Int32.Parse(Console.ReadLine());
                // allBankAccounts[cuentaSel].MakeDeposit(cantidadSel, DateTime.Now, nota);
                break;
            case 3:
                Console.WriteLine("*****3 - Sacar fondos*****");
                Console.WriteLine("Ingrese la cantidad:");
                cantidadSel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota:");
                nota = Console.ReadLine();
                Console.WriteLine("Elige la cuenta:");
                cuentaSel = Int32.Parse(Console.ReadLine());
                // allBankAccounts[cuentaSel].MakeWithdrawal(cantidadSel, DateTime.Now, nota);
                break;
            case 4:
                Console.WriteLine("*****4 - Listado de operaciones*****");
                Console.WriteLine("Elige la cuenta:");
                cuentaSel = Int32.Parse(Console.ReadLine());
                Console.WriteLine(allBankAccounts[cuentaSel].GetAccountHistory());
                Console.WriteLine("*****Pulse una tecla para continuar...*****");
                Console.ReadKey();
                break;
            case 5:
                for (int i = 0; i < allBankAccounts.Count; i++)
                {
                    Console.WriteLine(i + ", Propietario: " + allBankAccounts[i].Owner + ", Cantidad: " + allBankAccounts[i].Balance);
                }
                break;
            case 6:
                Console.WriteLine("*****Programa terminado*****");
                break;
            case 7:
                Console.WriteLine("*****7 - Save Json*****");
                Console.WriteLine("Elige la cuenta:");
                cuentaSel = Int32.Parse(Console.ReadLine());
                // allBankAccounts[cuentaSel].writeJson();
                //allBankAccounts.ElementAt(cuentaSel);
                break;
            case 8:
                Console.WriteLine("*****8 - Read Json*****");
                break;
        }

        //No habrá tiempo de espera si se muestra el 4-listado
        if (opcionSel != 4 || opcionSel != 7 || opcionSel != 8)
        {
            System.Threading.Thread.Sleep(2000);
        }
        //Console.ReadKey();
        Console.Clear();
        return opcionSel;
    }

    static void Main(string[] args)
    {
        // allBankAccounts.Add(new BankAccount("Dario Cubero", 1000));
        // allBankAccounts[0].MakeDeposit(500, DateTime.Now, "Bizum");
        // allBankAccounts[0].MakeWithdrawal(50, DateTime.Now, "Carnicería");


        int value;
        do
        {
            value = Menu();
        } while (value != 6);
    }


}
