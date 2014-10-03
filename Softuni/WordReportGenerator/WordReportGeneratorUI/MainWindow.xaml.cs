using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CompanyHierarchy;
using WordReportGenerator;
using DropNet;
using System.IO;
using DropNet.Models;

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

        private void ExportToDropbox(object sender, RoutedEventArgs e)
        {
            var client = new DropNetClient("flyxzhd2ts40zps", "0w9ucq9pqtambrj");
            client.UserLogin = new UserLogin();

            var fileBytes = File.ReadAllBytes(@"../../Reports/Donka-Karamanova-dk-Report.docx");
            var uploadResult = client.UploadFile("../../", "Donka-Karamanova-dk-Report_copy.docx", fileBytes);
        }
    }
}