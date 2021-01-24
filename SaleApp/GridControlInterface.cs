using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp
{
    interface GridControlInterface
    {
        void AddNewRow();

        void DeleteRow();

        void ExportExcel();

        void ExportPdf();

        void PrintPage();

        void ChangeCurrency();

        void MergeCells();

        void SaveRows();

        void RefreshRows();

        void ShowHideColumns();

        void ShowCurrency(int currency_id, bool isVisible);

        void ChangeFontWeight(int type, bool isActive);

        void ChangeBackColor();
    }
}
