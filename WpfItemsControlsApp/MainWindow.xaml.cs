using System.Diagnostics.Tracing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfItemsControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employee> employees = new List<Employee>()
        {
            new(){ Name = "Bob", Age = 24 },
            new(){ Name = "Joe", Age = 31 },
            new(){ Name = "Sam", Age = 19 },
        };

        public MainWindow()
        {
            InitializeComponent();
            //ListBoxItem item = new() { Content = "Item 100" };
            //lb.Items.Add(item);

            //foreach(var e in employees)
            //{
            //    lb.Items.Add(e);
            //}

            //lb.ItemsSource = employees;

        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //tb.Text = ((ListBoxItem)lb.SelectedItem).Content.ToString();
        }

        private void lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //var item = lb.SelectedItem;
            //lb.Items.Remove(item);
            var item = employees.FirstOrDefault(e => e == lb.SelectedValue);
            employees.Remove(item);

            string empls = "";
            foreach (var em in employees)
                empls += em.ToString() + "\n";
            MessageBox.Show(empls);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employees.Add(new() { Name = "Tim", Age = 35 });
            lb.Items.Refresh();
            string str = "";
            foreach (var em in employees)
                str += em + "\n";
            MessageBox.Show(str);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(tb.Text.Trim()) &&
                !String.IsNullOrWhiteSpace(tbAge.Text.Trim()) &&
                Int32.TryParse(tbAge.Text, out int age))
            {
                employees.Add(new() { Name = tb.Text.Trim(), Age = age });
                lb.Items.Refresh();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string str = "";
            foreach (var em in lb.SelectedItems)
                str += em + "\n";
            txtSelected.Text = str;
        }
    }
}