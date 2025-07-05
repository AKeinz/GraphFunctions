using Model;
using System.Collections.Generic;
using System.Data;

namespace ViewModel
{
    public interface IExportDataToExcel
    {
        string ExportDataToExcel(string equation, List<DataPoint> dataPoints);

        DataTable createDataTable(List<DataPoint> dataPoints, string equation);

        string exportData(DataTable dataTable);

    }
}
