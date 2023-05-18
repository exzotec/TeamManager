using System.ComponentModel.DataAnnotations;

namespace TeamManager.Data.Models
{
    public class userAuth
    {
        [Key] 
        public int user_id { get; set; }

        public string login { get; set; }
        public string password {protected get; set; }
    }
}
