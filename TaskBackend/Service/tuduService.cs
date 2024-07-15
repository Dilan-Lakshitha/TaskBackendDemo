using TaskBackend.Enum;
using TaskBackend.Models;

namespace TaskBackend.tuduService
{
    public class TuduService
    {
        public List<tudu> AllTUDU()
        {
            var tudus = new List<tudu>();

            var Tudus1 = new tudu
            {
                Id = 1,
                Title = "Tudu",
                Description = "Test",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Status = todo.New
            };

            tudus.Add(Tudus1);

            var Tudus2 = new tudu
            {
                Id = 2,
                Title = "Tudu2",
                Description = "Test2",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Status = todo.New
            };

            tudus.Add(Tudus1);

            return tudus;
        }
    }
}
