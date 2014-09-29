namespace LINQtoExcel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelLibrary;
    using ExcelLibrary.SpreadSheet;

    public class ExcelGenerator<T>
    {
        private string fileName;
        private string[] headerItems;
        private IList<T> dataCollection;
        private string sheetName;

        public ExcelGenerator(string fileName, string sheetName, string[] headerItems, IList<T> dataCollection)
        {
            this.FileName = fileName;
            this.SheetName = sheetName;
            this.HeaderItems = headerItems;
            this.DataCollection = dataCollection;
        }

        public string SheetName
        {
            get
            {
                return this.sheetName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("SheetName", "SheetName can not be null or empty!");
                }

                this.sheetName = value;
            }
        }

        public IList<T> DataCollection
        {
            get
            {
                return this.dataCollection;
            }

            set
            {
                this.dataCollection = value;
            }
        }

        public string[] HeaderItems
        {
            get
            {
                return this.headerItems;
            }

            set
            {
                this.headerItems = value;
            }
        }

        public string FileName
        {
            get
            {
                return this.fileName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Filename", "Filename can not be null or empty!");
                }

                this.fileName = value;
            }
        }

        public void GenerateFromCollection(string[] separator)
        {
            Workbook workBook = new Workbook();
            Worksheet workSheet = new Worksheet(this.SheetName);

            for (int i = 0; i < this.HeaderItems.Length; i++)
            {
                workSheet.Cells[0, i] = new Cell(this.HeaderItems[i]);
            }

            for (int d = 0; d < this.DataCollection.Count; d++)
            {
                var properties = this.DataCollection[d].ToString().Split(
                    separator,
                    StringSplitOptions.RemoveEmptyEntries);

                for (int p = 0; p < properties.Length; p++)
                {
                    workSheet.Cells[d + 1, p] = new Cell(properties[p].ToString());
                }
            }

            workBook.Worksheets.Add(workSheet);
            workBook.Save(this.FileName);
        }
    }
}