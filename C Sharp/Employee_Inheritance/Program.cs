//Create classes employee and manager. An employee will have attributes such as		.
//A manager extends from an employee he will have additionally properties such as onsite allowance and bonus.
//Compute the salary of an employee and manager

namespace Employee_Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Enter name:");
				string name = Console.ReadLine();
				Console.WriteLine("Enter date of birth:");
				DateTime dob = DateTime.Parse(Console.ReadLine());
				Console.WriteLine("Enter salary:");
				double salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter designation:");
				string designation = Console.ReadLine();

				if (designation.ToLower().Equals("employee"))
				{
					Employee employee = new Employee(name, salary, dob);
                    Console.WriteLine("--------------------------------");
					Console.WriteLine(employee);
					Console.WriteLine($"The salary is: {employee.ComputeSalary()}");
					Console.WriteLine("--------------------------------");
				}
				else
				{
					Console.WriteLine("Enter onsite allowance:");
					double onsiteAllowance = double.Parse(Console.ReadLine());
					Console.WriteLine("Enter bonus:");
					double bonus = double.Parse(Console.ReadLine());
					Manager manager = new Manager(name, salary, dob, onsiteAllowance, bonus);
					Console.WriteLine("--------------------------------");
					Console.WriteLine(manager);
                    Console.WriteLine($"The salary is: {manager.ComputeSalary()}");
					Console.WriteLine("--------------------------------");
				}

                Console.WriteLine("Enter 1 to continue or 0 to exit");
				int choice = int.Parse(Console.ReadLine());
				if (choice == 0) break;
			}

		}
	}
}
