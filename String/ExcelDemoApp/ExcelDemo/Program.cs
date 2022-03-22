using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace ExcelDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo(@"c:\Demos\youtube.xls");

            var people = SetupData();
            // Writing in Excel File
              await SaveExcelFile(people, file);
            // Reading from Excel File
            List<PersonalModel> peoplefromExcel = await LoadExcelFile(file);

            foreach (var p in peoplefromExcel)
            {
                Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName}");
            }
        }

        private static async Task<List<PersonalModel>> LoadExcelFile(FileInfo file)
        {
            List<PersonalModel> outPut = new();

            using (var package = new ExcelPackage(file))
            {
                await package.LoadAsync(file);
                var ws = package.Workbook.Worksheets[0];

                int row = 3;
                int col = 1;
                // i look up the cell at row3 col1
                while (string.IsNullOrWhiteSpace(ws.Cells[row, col].Value?.ToString()) == false)
                {
                    PersonalModel p = new();
                    p.Id = int.Parse(ws.Cells[row, col].Value.ToString());
                    p.FirstName = ws.Cells[row, col + 1].Value.ToString();
                    p.LastName = ws.Cells[row, col + 2].Value.ToString();
                    outPut.Add(p);
                    row += 1;
                }
                return outPut;
            }

        }

        private static async Task SaveExcelFile(List<PersonalModel> people, FileInfo file)
        {
            DeleteifExist(file);
            // create excel file
            using (var package = new ExcelPackage(file))
            {
                // create work sheet
                var ws = package.Workbook.Worksheets.Add("MainReport");
                // we have said start at cell A2 which is upper left corner of the cell
                // and load from collection that people into our file and we print header as well
                var ranges = ws.Cells["A2"].LoadFromCollection(people, true);
                // we will auto fit this columns
                ranges.AutoFitColumns();
                // we are going to do some manipulation (Format the Header)
                ws.Cells["A1"].Value = "Our Call Report";
                ws.Cells["A1:C1"].Merge = true;
                ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Row(1).Style.Font.Size = 24;
                ws.Row(1).Style.Font.Color.SetColor(Color.Blue);

                ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Row(2).Style.Font.Bold = true;
                ws.Column(3).Width = 20;




                // save the excel file async    
                await package.SaveAsync();
            }
        }

        private static void DeleteifExist(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }

        static List<PersonalModel> SetupData()
        {
            List<PersonalModel> outPut = new()
            {
                new PersonalModel { Id = 1, FirstName = "ahmed", LastName = "ali" },
                new PersonalModel { Id = 2, FirstName = "mahmoud", LastName = "yaser" },
                new PersonalModel { Id = 3, FirstName = "ibraheem", LastName = "salem" },
            };
            return outPut;
        }
    }
}
