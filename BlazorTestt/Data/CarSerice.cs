using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace BlazorTestt.Data
{
    public class CarService
    {
        private static readonly string[] Names = new[]
        {
            "Kia", "BMW", "Citroen", "Skoda", "Audi"
        };
        private static readonly string[] Models = new[]
        {
            "Rio","5", "Jumper", "Octavia", "A6"
        };

        public Task<Car[]> GetCarsAsync()
        {
            var rnd = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Car
            {
                Name = Names[rnd.Next(Names.Length)],
                Model = Models[rnd.Next(Models.Length)],
                Price = rnd.Next(10, 10000000),
            }).ToArray());
        }
    }
}
