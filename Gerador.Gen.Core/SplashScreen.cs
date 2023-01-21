using System;
using System.Collections.Generic;
using System.Text;

namespace Gerador.Gen.Core
{
    public class SplashScreen
    {
        public int DataAtual;

        public void Run()
        {
            string SoftwareName = "Gerador";
            string Version = "1.0";
            string CopyrightName = "Target Software.";
            DateTime AnoAtual = DateTime.Today;

            Console.WriteLine($"Target {SoftwareName} [Version {Version}]");

            string StrAnoAtual = AnoAtual.ToString("yyyy");
            int IntAnoAtual = Convert.ToInt32(StrAnoAtual);
            DataAtual = IntAnoAtual;

            if (IntAnoAtual == 2023)
            {
                Console.WriteLine("Copyright © " + IntAnoAtual + " | " + CopyrightName + " Todos os direitos reservados.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Copyright © 2023 - " + IntAnoAtual + " | " + CopyrightName + " Todos os direitos reservados.");
                Console.WriteLine();
            }

            Console.WriteLine("[" + SoftwareName + "] - Em Execução...");
            Console.WriteLine();
        }
    }
}
