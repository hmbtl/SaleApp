using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp
{
    public static class Utilities
    {

        public const int EXPORT_EXCEL = 1;
        public const int EXPORT_PDF = 2;
        public const int EXPORT_WORD = 3;
       


       public static void Export(int exportType, string name, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            string title = name + "_export_" + DateTime.Now.ToString("dd_MM_yyyy");


            switch (exportType)
            {
                case Utilities.EXPORT_EXCEL:
                    title += ".xlsx";
                        break;
                case Utilities.EXPORT_PDF:
                    title += ".pdf";
                    break;
            }

            saveFile.FileName = title;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                switch (exportType)
                {
                    case Utilities.EXPORT_EXCEL:
                        gridView.ExportToXlsx(saveFile.FileName);
                        break;
                    case Utilities.EXPORT_PDF:
                        gridView.ExportToPdf(saveFile.FileName);
                        break;
                }

            }
        }

       

    }
}
