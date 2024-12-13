// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace ClassLibrary1;

public partial class Employee : ObservableObject {

    public Employee() {
    }

    public Employee(string name, decimal salary) {
        this.Name = name;
        this.Salary = salary;
    }

    [ObservableProperty]
    public partial string Name { get; set; }

    [ObservableProperty]
    public partial decimal Salary { get; set; }

    public override string ToString() => $"Employee Name = {Name}, Salary = {Salary}";
}
