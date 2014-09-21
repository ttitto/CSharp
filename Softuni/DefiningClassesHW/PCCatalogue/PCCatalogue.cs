namespace PCCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public class PCCatalogueClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");

            Component mcardVLC = new Motherboard("VLC", (decimal)185.98);
            Component vcardRadeon = new GraphicCard("Radeon", (decimal)102.34, "the best grafic card forever");
            Component vcardGeForce = new GraphicCard("GeForce", (decimal)154.45, "is not worth");

            Component procIntel = new Processor("Intel", (decimal)346.563, "can be better");
            Component procAMD = new Processor("AMD", (decimal)405.239, "always the best");

            Computer compAMDRadeon = new Computer("Fasty", new List<Component>() { mcardVLC, vcardRadeon, procAMD });
            Computer compIntelGeForce = new Computer("Star");
            compIntelGeForce.Components.Add(vcardGeForce);
            compIntelGeForce.Components.Add(mcardVLC);

            List<Computer> computers = new List<Computer>() { compIntelGeForce, compAMDRadeon };

            computers.OrderBy(c => c.Price).ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }
    }
}
