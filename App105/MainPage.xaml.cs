// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

using ClassLibrary1;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace App105;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page {
    public ObservableCollection<Employee> Employees { get; } = new();

    public MainPage() {

        InitializeComponent();

        Employees.Add(new Employee("Fons", 2000));
        Employees.Add(new Employee("Jim", 5000));
        Employees.Add(new Employee("Ellen", 4000));

    }

    private void ButtonAdd_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
        Employees.Add(new Employee($"Emp {Employees.Count}", 4000));

    }

    private void ButtonRaiseSalary_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
        if (listViewEmployees.SelectedItem is Employee emp) {
            emp.Salary += 100;
        }
    }
}
