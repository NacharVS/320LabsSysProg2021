using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace BlazorApp1.Data
{
    public class CarServise
    {
        private static readonly string[] Names = new[]
        {
            "Golden Eagle", "Stels ATV 300B", "Regulmoto sport 003 PR", "Regulmoto sport 003 PR", "Ãðèççëè",
            "Avantis Hunter LUX New", "Honda PCX125", "Vento retro 49cc", "Honda CMX1100A", "Pulsar NS 125"
        };

        public Task<Car[]> GetCarsAsync()
        {
            var rnd = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Car
            {
                Name = Names[rnd.Next(Names.Length)],
                Mileage = rnd.Next(0, 100000),
                EngineCapacity = rnd.Next(10, 3000),
                Price = rnd.Next(10, 10000000)
            }).ToArray());
        }
    }
}