using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern;
#region Prototype Pattern
public class Employee
{


    public int Age { get; set; }
    public int numb2;
    public int numb3;
    public int numb4;
    public int numb5;
    public int numb6;
    public string Name { get; set; }
    public Employee(int age, int numb1, int numb2, int numb3, int numb4, int numb5, int numb6, int numb7, int numb8)
    {
        Age = age;
    }

    public Employee GetClone()
    {
        return (Employee)MemberwiseClone();
    }

}
public class Work
{
    public void Main(string[] args)
    {
        Employee emb1 = new Employee(2, 3, 4, 5, 6, 7, 8, 9, 9);
        Employee emb2 = emb1.GetClone();
        emb2.Age = 12;
    }
}

#endregion





