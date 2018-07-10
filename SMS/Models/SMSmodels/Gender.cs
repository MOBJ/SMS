using System.ComponentModel.DataAnnotations;

namespace SMS.Models.SMSmodels
{
    public class Gender
    {
        [Key]
        public string GenderId { get; set; }
    }
}