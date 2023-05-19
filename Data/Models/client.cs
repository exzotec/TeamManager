using System.ComponentModel.DataAnnotations;

namespace TeamManager.Data.Models
{
    public class client
    {
        [Key]
        public int client_id { get; set; }

        public string client_name { get; set; }
    }
}
