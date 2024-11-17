using System;

public class Employee
{
	//id , name, salary, dob
	public int EmployeeId { get; set; }
	public string EmployeeName { get; set; }
	public double Salary { get; set; }
	public DateTime DateOfBirth { get; set; }

	public static int employeeId = 1000;

	public Employee(string name, double salary, DateTime dob)
	{
		EmployeeId = employeeId + 1;
		EmployeeName = name;
		Salary = salary;
		DateOfBirth = dob;
	}

	public virtual double ComputeSalary()
	{
		return Salary;
	}

	public override string ToString()
	{
		return $"Employee ID: {EmployeeId}\t" +
			$"Employee Name: {EmployeeName}\t" +
			$"Date of Birth: {DateOfBirth}\t" +
			$"Designation: Employee\n";
	}

}
