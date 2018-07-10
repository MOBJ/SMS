using System.ComponentModel.DataAnnotations;

namespace SMS.Models.SMSmodels
{
    public class UserStatus
    {
        [Key]
        public int UserStatusId { get; set; }
        public string UserStatusName { get; set; }
    }
}