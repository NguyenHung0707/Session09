using IO = System.Console;
using Emp = Bank.Accounts.EmployesDetails;
class AliasExample
{
    static void Main(string[] args)
    {
        Emp.Employess objEmp = new Emp.Employess();
        objEmp.EmpName = "Peter";   
        IO.WriteLine("Employess Name: " + objEmp.EmpName);
    }
}