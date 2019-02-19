using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string surname;
        private int age;

        public Employee()
        {
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            this.age = age;
        }

        private string GetEmployeeAge()
        {
            return age.ToString();
        }

        public void ChangeEmployeeSurname(string surname)
        {
            this.surname = surname;
        }

        public string InfoAboutEmployee()
        {
            return $"Surname: {surname}, Age: {age}";
        }
    }
}
