using System;

public class Manager:Employee
{
	//onsite allowance, bonus
	public double OnsiteAllowance { get; set; }
	public double Bonus { get; set; }

	public Manager(string name, double salary, DateTime dob, double onsiteAllowance, double bonus):base(name, salary, dob)
	{
		OnsiteAllowance = onsiteAllowance;
		Bonus = bonus;
	}

	public override double ComputeSalary()
	{
		return Salary + OnsiteAllowance + Bonus;
	}

	public override string ToString()
	{
		return $"Employee ID: {EmployeeId}\t" +
			$"Employee Name: {EmployeeName}\t" +
			$"Date of Birth: {DateOfBirth}\t" +
			$"Designation: Manager" +
			$"Onsite allowance: {OnsiteAllowance}\t" +
			$"Bonus: {Bonus}\n";
	}
}
