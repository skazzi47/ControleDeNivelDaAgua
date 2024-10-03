using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("||\tSistema de Monitoramento de Nível e Válvulas de Água\t||");
        bool boiaA, boiaB, boiaC, bomba, torneirinha, erro;

        Console.WriteLine("\nDigite 0 para FALSO ou 1 para VERDADEIRO.\n");
        
        Console.WriteLine("\nQual a situação da boia A?:");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nQual a situação da boia B?:");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nQual a situação da boia C?:");
        int c = int.Parse(Console.ReadLine());

        if (a == 1)
        {
            boiaA = true;
        }
        else
        {
            boiaA = false;
        }

        if (b == 1)
        {
            boiaB = true;
        }
        else
        {
            boiaB = false;
        }

        if (c == 1)
        {
            boiaC = true;
        }
        else
        {
            boiaC = false;
        }


        if (boiaA == false && boiaB == false && boiaC == false)
        {
            bomba = true;
            torneirinha = true;
            erro = false;
            if(erro == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n||\tFalha de Funcionamento Detectada!\t Travando Fluxo de Água na Bomba e na Eletroválvula...\t||\n");
                Console.WriteLine("||\tChamar Manutenção!\t||");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSistema Totalmente Funcional!\t Finalizando Programa...\n");
                Console.ResetColor();
            }
        }
        else if (boiaA == false && boiaB == false && boiaC == true)
        {
            bomba = false;
            torneirinha = true;
            erro = false;
            if(erro == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n||\tFalha de Funcionamento Detectada!\t Travando Fluxo de Água na Bomba e na Eletroválvula...\t||\n");
                Console.WriteLine("||\tChamar Manutenção!\t||");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSistema Totalmente Funcional!\t Finalizando Programa...\n");
                Console.ResetColor();
            }
        }
        else if (boiaA == false && boiaB == true && boiaC == false)
        {
            bomba = false;
            torneirinha = false;
            erro = true;
            if(erro == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n||\tFalha de Funcionamento Detectada!\t Travando Fluxo de Água na Bomba e na Eletroválvula...\t||\n");
                Console.WriteLine("||\tChamar Manutenção!\t||");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSistema Totalmente Funcional!\t Finalizando Programa...\n");
                Console.ResetColor();
            }
        }
        else if (boiaA == false && boiaB == true && boiaC == true)
        {
            bomba = false;
            torneirinha = false;
            erro = true;
            if(erro == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n||\tFalha de Funcionamento Detectada!\t Travando Fluxo de Água na Bomba e na Eletroválvula...\t||\n");
                Console.WriteLine("||\tChamar Manutenção!\t||");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSistema Totalmente Funcional!\t Finalizando Programa...\n");
                Console.ResetColor();
            }
        }
        else if (boiaA == true && boiaB == false && boiaC == false)
        {
            bomba = true;
            torneirinha = true;
            erro = false;
            if(erro == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n||\tFalha de Funcionamento Detectada!\t Travando Fluxo de Água na Bomba e na Eletroválvula...\t||\n");
                Console.WriteLine("||\tChamar Manutenção!\t||");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSistema Totalmente Funcional!\t Finalizando Programa...\n");
                Console.ResetColor();
            }
        }
        else if (boiaA == true && boiaB == false && boiaC == true)
        {
            bomba = false;
            torneirinha = true;
            erro = false;
            if(erro == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n||\tFalha de Funcionamento Detectada!\t Travando Fluxo de Água na Bomba e na Eletroválvula...\t||\n");
                Console.WriteLine("||\tChamar Manutenção!\t||");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSistema Totalmente Funcional!\t Finalizando Programa...\n");
                Console.ResetColor();
            }
        }
        else if (boiaA == true && boiaB == true && boiaC == false)
        {
            bomba = true;
            torneirinha = false;
            erro = false;
            if(erro == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n||\tFalha de Funcionamento Detectada!\t Travando Fluxo de Água na Bomba e na Eletroválvula...\t||\n");
                Console.WriteLine("||\tChamar Manutenção!\t||");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSistema Totalmente Funcional!\t Finalizando Programa...\n");
                Console.ResetColor();
            }
        }
        else if (boiaA == true && boiaB == true && boiaC == true)
        {
            bomba = false;
            torneirinha = false;
            erro = false;
            if(erro == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n||\tFalha de Funcionamento Detectada!\t Travando Fluxo de Água na Bomba e na Eletroválvula...\t||\n");
                Console.WriteLine("||\tChamar Manutenção!\t||");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSistema Totalmente Funcional!\t Finalizando Programa...\n");
                Console.ResetColor();
            }
        }
    }
}