using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary_ByComposition_
{
    internal class Base
    {
        public virtual decimal baseSalary => 1000;
        public List<Adds> adds { get; private set; } = new List<Adds>();
        public override string ToString()
        {
            string result = $"\n\tYour Base Salary is: {baseSalary}";
            foreach (Adds item in adds)
            {
                result += $"\n\t{item.title} ({item.salary.ToString("C")})";
            }
            result += "\n------------------------------------------";
            result += $"\n Total:({CalculateTotal().ToString("C")})";
            return result;
        }
        public void AddSalary(Adds add)
        {
            adds.Add(add);
        }
        public decimal CalculateTotal()
        {
            decimal total = 0;
            total=baseSalary;
            foreach (Adds add in adds)
            {
                total += add.salary;
            }
            return total;
        }

    }
    public interface Adds
    {
        string title { get; }
        decimal salary { get; }
    }
    public class PartTime : Adds
    {
        public string title => nameof(PartTime);

        public decimal salary => 100;
    }
    public class Hour : Adds
    {
        public string title => nameof(Hour);

        public decimal salary => 15;
    }
    public class ExtraDay : Adds
    {
        public string title => nameof(ExtraDay);

        public decimal salary => 150;
    }
}
