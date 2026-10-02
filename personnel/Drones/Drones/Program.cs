
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
<<<<<<< HEAD
            List<Drone> fleet = new List<Drone>();
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2, "Joe", charger));
=======
            List<Drone> fleet= new List<Drone>();
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2, "Joe", charger));
            
>>>>>>> 341c3d4d2c0a0139acc2a45688aa4ca76190f22c

            // Démarrage
            Application.Run(new AirSpace(fleet, charger));
        }
    }
}