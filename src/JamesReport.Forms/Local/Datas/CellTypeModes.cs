using JamesReport.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace JamesReport.Forms.Local.Datas
{
    public sealed class CellTypeModes
    {
        private static readonly Lazy<CellTypeModes> lazy = new Lazy<CellTypeModes>(() => new CellTypeModes());

        public static CellTypeModes Instance { get { return lazy.Value; } }

        public ObservableCollection<CellTypeModeModel> CellTypeList { get; set; }

        private CellTypeModes()
        {
            CellTypeList = new ObservableCollection<CellTypeModeModel>
            {
                new CellTypeModeModel("Label", "Label"),
                new CellTypeModeModel("Value", "Value"),
            };
        }
    }
}
