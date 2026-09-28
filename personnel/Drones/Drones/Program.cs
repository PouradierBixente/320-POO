using Drones.Helpers;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            Charger charger = new Charger(100, 100);
            List<Drone> fleet= new List<Drone>();
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2, "Joe", charger));

            List<Pizzeria> Pizzi = new List<Pizzeria>();
            for (int i = 0; i < 5; i++)
                Pizzi.Add(new Pizzeria(GeneratorHelpers.Generating(Config.AIRSPACE_WIDTH - 25), GeneratorHelpers.Generating(Config.AIRSPACE_HEIGHT - 25)));

            List<Client> cliente = new List<Client>();
            for (int i = 0; i < 20; i++)
                cliente.Add(new Client(GeneratorHelpers.Generating(Config.AIRSPACE_WIDTH), GeneratorHelpers.Generating(Config.AIRSPACE_HEIGHT)));


            // Démarrage
            Application.Run(new AirSpace(fleet, charger, Pizzi, cliente));
        }
    }
}