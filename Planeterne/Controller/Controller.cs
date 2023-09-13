using Planeterne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne.Controller
{
    public class Controller
    {
        Model.AddPlanet List = new Model.AddPlanet();


        public List<Model.Planet> PlanetInfo = new List<Model.Planet>
        {
            { new Model.Planet(0.330f, 4879, 5427, 3.7f, 1407.6f, 4222.6f, 57.9f, 88.0f, 47.4f, 167, 0, false) },
            { new Model.Planet(4.87f, 12104, 5243, 8.9f, -5832.5f, 2802.0f, 108.2f, 224.7f, 35.5f, 464, 0, false)},
            { new Model.Planet(5.97f, 12756, 5514, 9.8f, 23.9f, 24.0f, 149.6f, 365.2f, 29.8f, 15, 1, false)},
            { new Model.Planet(0.642f, 6792, 3933, 3.7f, 24.6f, 24.7f, 227.9f, 687.0f, 24.1f, -65, 2, false)},
            { new Model.Planet(1898f, 142984, 1326, 23.1f, 9.9f, 9.9f, 778.6f, 4331f, 13.1f, -110, 67, false)},
            { new Model.Planet(538f, 120536, 687, 9.0f, 10.7f, 10.7f, 1433.5f, 10747f, 9.7f, -140, 62, false)},
            { new Model.Planet(86.8f, 51118, 1271, 8.7f, -17.2f, 17.2f, 2872.5f, 30589f, 6.8f, -195, 27, false)},
            { new Model.Planet(102f, 49528, 1638, 11.0f, 16.1f, 16.1f, 4495.1f, 59.8f, 5.4f, -200, 14, false)},
            { new Model.Planet(0.0146f, 2370, 2095, 0.7f, -153.3f, 153.3f, 5906.4f, 90.56f, 4.7f, -225, 5, false)}
        };
        public List<string> PlanetList = new List<string> { };
        public List<string> PlanetName()
        {
            PlanetList.Add("Merkur");
            PlanetList.Add("Jorden");
            PlanetList.Add("Mars");
            PlanetList.Add("Jupiter");
            PlanetList.Add("Saturn");
            PlanetList.Add("Uranus");
            PlanetList.Add("Neptun");
            PlanetList.Add("Pluto");
            return PlanetList;
        }
        public List<string> AllPlanetNames()
        {
            if (!PlanetList.Contains("Venus"))
            {
                PlanetList.Insert(1, "Venus");
            }
            if (PlanetList.Count < 9)
            {
                PlanetList.Add("Pluto");
            }
            return PlanetList;
        }
        public List<string> PlutoRemover()
        {
            PlanetList.Remove("Pluto");
            return PlanetList;
        }

        public void WritePlanet()
        {
            PlanetName();
            foreach (string planet in PlanetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadKey();
            Console.Clear();
            AllPlanetNames();
            foreach (string planet in PlanetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadKey();
            Console.Clear();
            PlutoRemover();
            foreach (string planet in PlanetList)
            { 
                Console.WriteLine(planet);
            }
            Console.ReadKey();
            Console.Clear();
            AllPlanetNames();
            foreach(string planet in PlanetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadKey();
        }
    };
            
        //Model.Planet Merkur = new Model.Planet(0.330f, 4879, 5427, 3.7f, 1407.6f, 4222.6f, 57.9f, 88.0f, 47.4f, 167, 0, false);
        //Model.Planet Venus = new Model.Planet(4.87f, 12104, 5243, 8.9f, -5832.5f, 2802.0f, 108.2f, 224.7f, 35.5f, 464, 0, false);
        //Model.Planet Jorden = new Model.Planet(5.97f, 12756, 5514, 9.8f, 23.9f, 24.0f, 149.6f, 365.2f, 29.8f, 15, 1, false);
        //Model.Planet Mars = new Model.Planet(0.642f, 6792, 3933, 3.7f, 24.6f, 24.7f, 227.9f, 687.0f, 24.1f, -65, 2, false);
        //Model.Planet Jupiter = new Model.Planet(1898f, 142984, 1326, 23.1f, 9.9f, 9.9f, 778.6f, 4331f, 13.1f, -110, 67, false);
        //Model.Planet Saturn = new Model.Planet(538f, 120536, 687, 9.0f, 10.7f, 10.7f, 1433.5f, 10747f, 9.7f, -140, 62, false);
        //Model.Planet Uranus = new Model.Planet(86.8f, 51118, 1271, 8.7f, -17.2f, 17.2f, 2872.5f, 30589f, 6.8f, -195, 27, false);
        //Model.Planet Neptun = new Model.Planet(102f, 49528, 1638, 11.0f, 16.1f, 16.1f, 4495.1f, 59.8f, 5.4f, -200, 14, false);
        //Model.Planet Pluto = new Model.Planet(0.0146f, 2370, 2095, 0.7f, -153.3f, 153.3f, 5906.4f, 90.56f, 4.7f, -225, 5, false);
}
