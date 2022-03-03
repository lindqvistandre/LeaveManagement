using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Names")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please Enter A Valid Number Between 1-25")]   
        public int DefaultDays { get; set; }
    }
}
