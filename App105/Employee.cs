// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

using System;

namespace App105;

public class Employee {

	private string? _name;
	private decimal _salary;

	public Employee() {
	}

	public Employee(string? name, decimal salary) {
		this.Name = name;
		this.Salary = salary;
	}

	public string? Name {
		get => _name;
		set {
			_name = value?.ToUpper();
		}
	}

	public void RaiseSalary(decimal percentage) {
		Salary += Salary * (percentage / 100);
	}

	public decimal Salary {
		get {
			return _salary;
		}
		set {
			if (value < 0) {
				throw new ArgumentOutOfRangeException(nameof(value), "Must be positive");
			}
			_salary = value;
		}
	}

	public override string ToString() => $"Employee Name = {Name}, Salary = {Salary}";
}
