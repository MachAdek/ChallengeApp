using ChallengeApp;

Employee empoylee1 = new Employee("Adrian","Mach",26);
Employee employee2 = new Employee("Adam", "Kami", 31);
Employee employee3 = new Employee("Olaf","Lubaszenko", 50);

empoylee1.AddScore(5);
empoylee1.AddScore(4);
empoylee1.AddScore(1);
empoylee1.AddScore(3);
empoylee1.AddScore(1);

employee2.AddScore(2);
employee2.AddScore(8);
employee2.AddScore(1);
employee2.AddScore(6);
employee2.AddScore(4);

employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(1);
employee3.AddScore(5);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    empoylee1,employee2, employee3,
};


int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine(empoylee1.Name + "" + empoylee1.Surname + " lat " + empoylee1.Age + "wynik " + empoylee1.Result);
Console.WriteLine(employee2.Name + "" + employee2.Surname + " lat " + employee2.Age + "wynik " + employee2.Result);
Console.WriteLine(employee3.Name + "" + employee3.Surname + " lat " + employee3.Age + "wynik " + employee3.Result);
Console.WriteLine();
Console.WriteLine("------------------------------");
Console.WriteLine("Najwiekszy wynik osiagnal pracownik :" + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age + " wynik " + maxResult);