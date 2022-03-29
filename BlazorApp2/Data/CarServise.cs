using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace BlazorApp2.Data
{
    public class CarServise
    {
        private static readonly string[] Names = new[]
        {
            "McLaren F1", "Bugatti Chiron", "Lamborghini Veneno", "Ferrari Enzo Ferrari", "Porsche Carrera GT",
            "BMW M3 GTR", "Honda Civic Type R", "GTA Spano", "Koenigsegg Agera R", "Chevrolet Corvette C6"
        };

        public Task<Car[]> GetCarsAsync()
        {
            var rnd = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Car
            {
                Name = Names[rnd.Next(Names.Length)],
                MaxSpeed = rnd.Next(100, 400),
                HP = rnd.Next(500, 1500),
                Price = rnd.Next(10000, 10000000)
            }).ToArray());
        }
    }
}