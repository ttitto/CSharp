namespace LINQtoExcel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestLINQtoExcel
    {
        public static void Main()
        {
            string filename = @"../../data/Students-data.txt";
            IList<Student> students = new List<Student>();

            if (File.Exists(filename))
            {
                using (StreamReader stReader = new StreamReader(filename, Encoding.GetEncoding("UTF-8")))
                {
                    string line = stReader.ReadLine();
                    line = stReader.ReadLine();
                    while (line != null)
                    {
                        var data = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        students.Add(new Student(
                            int.Parse(data[0]),
                            data[1],
                            data[2],
                            data[3],
                            (Genders)Enum.Parse(typeof(Genders), data[4], true),
                            (StudentTypes)Enum.Parse(typeof(StudentTypes), data[5], true),
                            int.Parse(data[6]),
                            int.Parse(data[7]),
                            int.Parse(data[8]),
                            float.Parse(data[9]),
                            float.Parse(data[10]),
                            float.Parse(data[11])));

                        line = stReader.ReadLine();
                    }
                }
            }

            var onlineStudentsChart = from st in students
                                      where st.StudentType == StudentTypes.Online
                                      orderby st.Result descending
                                      select st;

            foreach (var student in onlineStudentsChart)
            {
                Console.WriteLine(student.ToString());
            }

            // Excel file generation
            string[] headerItems = new string[] 
            { 
                "ID", 
                "First name", 
                "Last Name", 
                "Email", 
                "Gender", 
                "Student type", 
                "Exam result",
                "Homework sent", 
                "Homework evaluated",
                "Teamwork", 
                "Attendances", 
                "Bonus", 
                "Result"
            };

            ExcelGenerator<Student> excelGenerator = new ExcelGenerator<Student>(
                @"../../students.xls",
                "Online students",
                headerItems,
                onlineStudentsChart.ToList());

            excelGenerator.GenerateFromCollection(new string[] { ", " });
        }
    }
}