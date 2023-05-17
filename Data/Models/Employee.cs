using System.ComponentModel.DataAnnotations;

namespace TeamManager.Data.Models
{
    public class Employee
    {
        [Key]
        public int employee_id { get; set; } 

        public string name { get; set; }    
        public string? email { get; set; }
        public string phone_number { get; set; }

        public string stack { get; set; }
        public string exp { get; set; }

        //public bool isActive { get; set; }
        //public int haveTime { get; set; }

    }
}
