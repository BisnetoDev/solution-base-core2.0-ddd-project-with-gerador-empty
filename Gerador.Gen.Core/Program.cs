using Common.Gen;
using Seed.Gen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador.Gen.Core;

namespace Seed.Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            var Splash = new SplashScreen();
            Splash.Run();

            HelperFlow.Flow(args, () =>
            {

                return new ConfigExternalResources().GetConfigExternarReources();

            }, new HelperSysObjects(new ConfigContext().GetConfigContext()));
        }

    }
}
