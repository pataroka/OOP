using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;


namespace _03.PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");

            var pcConfig1 = new Computer("Techno-X2 2650N", new Dictionary<string, Component>()
            {
                {"case", new Component("Neotech 2123", "Black, with PSU 400W", 50.60m)},
                {"motherboard", new Component("ASUS AM1M-A", "Vga HDMI, 2xDDR3, 1xPCIE16, 4xUSB3", 66.84m)},
                {"processor", new Component("Sempron X2 2650", 56.72m)},
                {"RAM", new Component("Corsair DDR3 4GB", 61.57m)},
                {"HDD", new Component("Seagate HDD 500GB", "7200.12, 16MB, S-ATA3", 111.75m)},
                {"keyboard", new Component("Logitech K120", 25.93m)},
                {"mouse", new Component("Logitech B100", 16.45m)}
            });

            var pcConfig2 = new Computer("Game/Work PC X99-A", new Dictionary<string, Component>());

            pcConfig2.Components.Add("case", new Component("CM Middle HAF 912 Advanced", "no PSU", 199.47m));
            pcConfig2.Components.Add("motherboard", new Component("ASUS X99-A", 590.39m));
            pcConfig2.Components.Add("processor", new Component("Intel i7-5820K", "3.3/15M/s2011-V3, Box", 887.48m));
            pcConfig2.Components.Add("PSU", new Component("Corsair RM850", "850W, Modular, 80+ Gold", 356.13m));

            var pcConfig3 = new Computer("MINIX NEO Z64");

            pcConfig1.DisplayInfo();
            Console.WriteLine();
            pcConfig2.DisplayInfo();
            Console.WriteLine();
            pcConfig3.DisplayInfo();
        }
    }
}
