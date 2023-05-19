using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace TeamManager.Data.Models
{
    public class AssignmentCard
    {
        [Key]
        public int task_id { get; set; }

        public int client_id { get; set; }

        public string title { get; set; }
        public string requirements { get; set; }
        public string desc { get; set; }
        public DateOnly deadline { get; set; }
        public string payment { get; set; }
        public string priority { get; set; }

        public string stack { get; set; }
        //public float progress { get; set; }
    }
}
