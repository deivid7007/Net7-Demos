using Demos.Services.Interfaces;

namespace Demos.Services.Services
{
    public class FakeService : IFakeService
    {
        private List<string> _carBrands = new List<string>
        {
            "Audi",
            "Mercedes",
            "BMW",
            "Peugeot",
            "Dacia",
            "Renaut",
            "Fiat",
            "Mazda"
        };

        public List<string> GetCarBrands() { return _carBrands; }
    }
}