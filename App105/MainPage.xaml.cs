// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace App105;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page {
    public List<Employee> Employees { get; }

    public MainPage() {
        InitializeComponent();


        Employees = new List<Employee> {
                new Employee("Fons", 2000),
                new Employee("Jim", 4000),
                new Employee("Ellen", 3000),
            };

    }
}
