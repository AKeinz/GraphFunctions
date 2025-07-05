using ClosedXML.Excel;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace ViewModel
{
    public class ExportDataToExcelByClosedXML : IExportDataToExcel
    {
        public string ExportDataToExcel(string equation, List<DataPoint> dataPoints)
        {
            DataTable dataTable = createDataTable(dataPoints, equation);
            string fileName = exportData(dataTable);
            return fileName;
        }

        public DataTable createDataTable(List<DataPoint> dataPoints, string equation)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("X"));
            dataTable.Columns.Add(new DataColumn("Y"));
            dataTable.Columns.Add(new DataColumn("equation"));
            foreach (DataPoint point in dataPoints)
            {
                dataTable.Rows.Add(point.X, point.Y);
            }
            dataTable.Rows[0].SetField("equation", equation);
            return dataTable;
        }

        public string exportData(DataTable dataTable)
        {
            try
            {
                string projectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
                string exportFolder = Path.Combine(projectDirectory, "Exports");
                Directory.CreateDirectory(exportFolder);

                string fileName = $"Export_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                string fullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"MyExports", fileName);
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add(DateTime.Now.ToLongDateString());
                    worksheet.Cell(1, 1).InsertTable(dataTable, false);
                    workbook.SaveAs(fullPath);
                }
                return fullPath;
            }
            catch
            {
                return String.Empty;
            }
        }

    }
}
