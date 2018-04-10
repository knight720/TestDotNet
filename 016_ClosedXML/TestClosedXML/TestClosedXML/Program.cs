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

            //var ws = FillByCell(workbook);
            ////FilterEnable(ws);
            //HeadAlignCenter(ws);

            var ws = FillByDataTable(workbook);
            FilterDisable(ws);
            HeadAlignCenter(ws);

            workbook.SaveAs("HelloWorld.xlsx");
        }

        private static IXLWorksheet FillByCell(XLWorkbook wb)
        {
            var worksheet = wb.Worksheets.Add("Sample Sheet");
            worksheet.Cell("A1").Value = "Hello World!";
            worksheet.Cell("A2").Value = "One";
            worksheet.Cell("A3").Value = "二";
            worksheet.Cell(1, 2).Value = "Title";
            worksheet.Cell(2, 2).Value = "1";
            worksheet.Cell(3, 2).Value = "2";

            return worksheet;
        }

        private static IXLWorksheet FillByDataTable(XLWorkbook wb)
        {
            var dt = new DataTable("name");
            dt.Columns.Add("Col 1");
            dt.Columns.Add("Column Two");
            var row = dt.NewRow();
            row[0] = 1;
            row[1] = "abcdefghijklmnopqrstuvwxyz";
            dt.Rows.Add(row);
            row = dt.NewRow();
            row[0] = "Two";
            row[1] = "一二三四五六七八九十";
            dt.Rows.Add(row);

            return wb.Worksheets.Add(dt, "DataTable");
        }

        private static void FilterEnable(IXLWorksheet ws)
        {
            ws.RangeUsed().SetAutoFilter(true); // work
        }

        private static void FilterDisable(IXLWorksheet ws)
        {
            //Filter
            // not work
            //ws.RangeUsed().SetAutoFilter(false); 
            //ws.AutoFilter.Clear();
            //ws.Tables.FirstOrDefault().SetAutoFilter(false);
            //ws.SetAutoFilter(false);
            //ws.AutoFilter.Enabled = false;

            //work
            ws.Tables.FirstOrDefault().ShowAutoFilter = false;

            //error
            //ws.SetAutoFilter().Column("Value").Clear(); -- error message
        }

        public static void HeadAlignCenter(IXLWorksheet ws)
        {
            //Alignment
            // All Cell
            //ws.Tables.FirstOrDefault().Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center); // All Cell

            ws.Tables.FirstOrDefault().SetEmphasizeFirstColumn()...Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

        }
    }
}
