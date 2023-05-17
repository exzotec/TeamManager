using System.ComponentModel.DataAnnotations;

namespace TeamManager.Data.Models
{
    public class userAuth
    {
        public int user_id { get; set; }
        public string login { get; set; }
        string password { get; set; }
    }
}
