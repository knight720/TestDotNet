using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace TestClosedXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var workbook = new XLWorkbook();
            //var worksheet = workbook.Worksheets.Add("Sample Sheet");
            //worksheet.Cell("A1").Value = "Hello World!";
            //worksheet.Cell(1, 2).Value = "Title";
            //worksheet.Cell(2, 2).Value = "1";
            //worksheet.Cell(3, 2).Value = "2";

            var dt = new DataTable("name");
            dt.Columns.Add("Value");
            var row = dt.NewRow();
            row[0] = 1;
            dt.Rows.Add(row);
            row = dt.NewRow();
            row[0] = 2;
            dt.Rows.Add(row);

            var ws = workbook.Worksheets.Add(dt, "DataTable");

            //ws = workbook.Worksheets.Worksheet("DataTable");

            //Filter
            //Fail
            //ws.RangeUsed().SetAutoFilter(false);
            //ws.AutoFilter.Clear();
            //ws.Tables.FirstOrDefault().ShowAutoFilter = false;
            //ws.Tables.FirstOrDefault().SetAutoFilter(false);
            //ws.SetAutoFilter(false);
            //ws.AutoFilter.Enabled = false;

            //error
            //ws.SetAutoFilter().Column("Value").Clear(); -- error message

            //Alignment
            //
            ws.Tables.FirstOrDefault().Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center); // All Cell


            workbook.SaveAs("HelloWorld.xlsx");
        }
    }
}
