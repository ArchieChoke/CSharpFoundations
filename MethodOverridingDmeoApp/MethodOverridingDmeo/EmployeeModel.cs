namespace MethodOverridingDmeo
{
    partial class Program
    {
        public class EmployeeModel : PersonModel
        {
            public decimal HourlyRate { get; set; }

            public virtual decimal GetPayCheckAmount (int hoursWorked) //Virutal allows for overriding
            {
                return HourlyRate * hoursWorked;
            }
        }

    }
}
