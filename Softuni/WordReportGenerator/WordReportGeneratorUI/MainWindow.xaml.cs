using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CompanyHierarchy;
using WordReportGenerator;

namespace WordReportGeneratorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        TreeViewItem salesTreeViewItem;
        TreeViewItem developersTreeViewItem;

        private void ImportCompanyData(object sender, RoutedEventArgs e)
        {
            employeesTreeView.Items.Clear();

            var salesEmployees = from saleEmpl in TestCompanyHierarchy.employees
                                 where saleEmpl is ISalesEmployee
                                 select saleEmpl;

            salesTreeViewItem = new TreeViewItem();
            salesTreeViewItem.IsExpanded = true;
            salesTreeViewItem.Header = "Sales Reports";

            foreach (var item in salesEmployees)
            {
                CheckBox chb = new CheckBox();
                chb.Content = item.FirstName + " " + item.LastName + "'s Report";
                chb.Name = item.Id;
                chb.Click += chb_Click;
                salesTreeViewItem.Items.Add(chb);
            }



            this.employeesTreeView.Items.Add(salesTreeViewItem);

            var developerEmployees = from devEmpl in TestCompanyHierarchy.employees
                                     where devEmpl is IDeveloper
                                     select devEmpl;

            developersTreeViewItem = new TreeViewItem();
            developersTreeViewItem.IsExpanded = true;
            developersTreeViewItem.Header = "Project Reports";

            foreach (var item in developerEmployees)
            {
                CheckBox chb = new CheckBox();
                chb.Content = item.FirstName + " " + item.LastName + "'s Reports";
                chb.Name = item.Id;
                chb.Click += chb_Click;
                developersTreeViewItem.Items.Add(chb);
            }

            this.employeesTreeView.Items.Add(developersTreeViewItem);
        }

        private void chb_Click(object sender, RoutedEventArgs e)
        {
            var clickedEmployee = GetEmployee(((CheckBox)sender).Name);
            this.previewReportArea.Text = clickedEmployee.ToString();
        }

        private void ExportCheckedReportsAsWord(object sender, RoutedEventArgs e)
        {
            foreach (var item in this.salesTreeViewItem.Items)
            {
                var itemChb = item as CheckBox;

                if (itemChb.IsChecked == true)
                {
                    DocumentGenerator.GenerateReport(GetEmployee(itemChb.Name));
                }
            }

            foreach (var item in this.developersTreeViewItem.Items)
            {
                var itemChb = item as CheckBox;

                if (itemChb.IsChecked == true)
                {
                    DocumentGenerator.GenerateReport(GetEmployee(itemChb.Name));
                }
            }
        }

        public IEmployee GetEmployee(string id)
        {
            return TestCompanyHierarchy.employees.First<IEmployee>(emp => emp.Id == id);
        }
    }
}