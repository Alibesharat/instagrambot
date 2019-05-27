using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InstagarmBot.Models
{
    public class user
    {
        [Key]
        public int Id { get; set; }

        public string userName { get; set; }
        public string password { get; set; }

        public string InstagramUserName { get; set; }
        public string InstagramPassword { get; set; }

        public bool BotState { get; set; }

        //seperator : ','
        public string Commentlist { get; set; }

        public virtual ICollection<Report>  Reports { get; set; }

    }
}