using LeaveManagement.Data.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; } /*Fick inkludera data.migrations även om inte egentligen tänkt.*/
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; }

    }
}
