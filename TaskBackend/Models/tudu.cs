using TaskBackend.Enum;

namespace TaskBackend.Models
{
    public class tudu
    {
        public int Id {  get; set; }

        public string Title { get; set; }    

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set;}

        public todo Status { get; set; }
    }
}
