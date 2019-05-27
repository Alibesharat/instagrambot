using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstagarmBot.Models
{
    public class Report
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("user")]
        public int UserId { get; set; }
        public user user { get; set; }

        public string Datetime { get; set; }

        public string ReportData { get; set; }
    }
}
