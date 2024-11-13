using WolfDen.Domain.Enums;

namespace WolfDen.Domain.Entity
{
    public class Status
    {
        public int Id { get;private set; }
        public int EmployeeId { get;private set; }
        public DateOnly Date { get;private set; }
        public int Duration { get;private set; }
        public StatusType StatusType { get;private set; }
        public virtual Employee Employee { get;private set; }
        public Status()
        {
            
        }
        public Status(int employeeId, DateOnly date, int duration, StatusType statusType, Employee employee)
        {
            EmployeeId= employeeId;
            Date= date;
            Duration= duration;
            StatusType= statusType;
            Employee = employee;

        }
    }
}
