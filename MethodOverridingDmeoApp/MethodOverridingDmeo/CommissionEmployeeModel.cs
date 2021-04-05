namespace MethodOverridingDmeo
{
    partial class Program
    {
        public class CommissionEmployeeModel : EmployeeModel
        {
            public decimal ComissionAmount { get; set; }
            public override decimal GetPayCheckAmount(int hoursWorked)
            {
                decimal intialpay =  base.GetPayCheckAmount(hoursWorked);
                return intialpay + ComissionAmount;
            }
        }

    }
}
