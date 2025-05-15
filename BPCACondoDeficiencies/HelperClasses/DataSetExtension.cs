using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;

namespace BPCACondoDeficiencies.HelperClasses
{
    

    
//dt.ExportToExcel(ExcelFilePath);
//Extension method for DataTable class:

public static class DataSetExtension
    {
        private static DataSet ds;

        //public static void ExportToExcel(this DataSet ds, string excelFilePath = null)
        //{
        //    try
        //    {
        //        if(ds.Tables.Count == 0)
        //            throw new Exception("ExportToExcel: Null or empty input table!\n");

        //        // load excel, and create a new workbook
        //        var excelApp = new Excel.Application();

        //        foreach (DataTable dt in ds.Tables)
        //        {
        //            excelApp.Workbooks.Add();

        //            // single worksheet
        //            Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

        //            // column headings
        //            for (var i = 0; i < dt.Columns.Count; i++)
        //            {
        //                workSheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
        //            }

        //            // rows
        //            for (var i = 0; i < dt.Rows.Count; i++)
        //            {
        //                // to do: format datetime values before printing
        //                for (var j = 0; j < dt.Columns.Count; j++)
        //                {
        //                    workSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
        //                }
        //            }
        //            workSheet.S
        //        }
        //        // check file path
        //        if (!string.IsNullOrEmpty(excelFilePath))
        //        {
        //            try
        //            {
        //                excelApp.Workbood
        //                workSheet.SaveAs(excelFilePath);
        //                excelApp.Quit();
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
        //                                    + ex.Message);
        //            }
        //        }
        //        else
        //        { // no file path is given
        //            excelApp.Visible = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("ExportToExcel: \n" + ex.Message);
        //    }
        //}
    }
}
