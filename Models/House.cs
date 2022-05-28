using System.Collections.Generic;
using System.Linq;

namespace WebApplication4.Models
{
    public class House
    {
        public int Id { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string State { get; set; }

        public IEnumerable<House> GetHouses()
        {
            House[] houses = new House[]
            {
                new House { Address = "12", Id = 1, City = "ASDF", State = "GA", Zip = 78974 },
                new House { Address = "13", Id = 2, City = "AasdfDF", State = "GA", Zip = 78974 },
                new House { Address = "14", Id = 3, City = "asbrt", State = "GA", Zip = 78974 },
                new House { Address = "15", Id = 4, City = "jythr", State = "GA", Zip = 78974 },
                new House { Address = "16", Id = 5, City = "dfgre", State = "GA", Zip = 78974 },
                new House { Address = "17", Id = 6, City = "refwer", State = "GA", Zip = 78974 },
            };

            return houses;
        }

        public House GetHouseById(int Id)
        {
            var houses = GetHouses();
            //var h = houses.Select(h => h.Id = Id);
            var house = houses.FirstOrDefault(h => h.Id == Id);
            return house;
        }
    }
}
