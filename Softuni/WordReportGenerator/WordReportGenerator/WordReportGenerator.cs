namespace WordReportGenerator
{
    using System;
    using System.Collections.Generic;
    using CompanyHierarchy;
    using Novacode;

    public static class DocumentGenerator
    {
        public static string dirPath = "../../Reports/";

        public static void GenerateReport(IEmployee employee)
        {
            string reportType = employee is IDeveloper ? "Project" : "Sales";
            string fileName = String.Format("{0}-{1}-{2}-Report.docx",
                employee.FirstName, employee.LastName, employee.Id);
            var document = DocX.Create(dirPath + fileName);

            // Heading
            var heading = document.InsertParagraph(String.Format("{0} {1} : {2} Report",
                employee.FirstName, employee.LastName, reportType));
            heading.Alignment = Alignment.left;
            heading.FontSize(20d).Bold();
            document.InsertParagraph();

            // Personal Info
            Dictionary<string, object> dict = new Dictionary<string, object>() { 
                {"Name:", employee.FirstName + " " + employee.LastName},
                {"Id:", employee.Id},
                {"Department:", employee.Department},
                {"Salary:", employee.Salary}};
            foreach (var prop in dict)
            {
                var text = document.InsertParagraph(prop.Key).Bold();
                text.InsertText(" " + prop.Value, true);
                text.FontSize(12);
                text.Alignment = Alignment.right;
            }
            document.InsertParagraph();

            // Project / Sales Report Details
            var detailsList = document.AddList(null, 0, ListItemType.Bulleted);
            if (employee is IDeveloper)
            {
                var projectsHeading = document.InsertParagraph("Projects:")
                    .UnderlineStyle(UnderlineStyle.singleLine)
                    .FontSize(15);
                foreach (var project in (employee as IDeveloper).Projects)
                {
                    document.AddListItem(detailsList, project.ToString());
                }
            }
            else if (employee is ISalesEmployee)
            {
                var salesHeading = document.InsertParagraph("Sales:");
                foreach (var sale in (employee as ISalesEmployee).Sales)
                {
                    document.AddListItem(detailsList, sale.ToString());
                    var innerList = document.AddList(null, 2, ListItemType.Numbered);
                }
            }
            document.InsertList(detailsList);

            // Save changes to file
            document.Save();
        }
    }
}
