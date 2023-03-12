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
    public sealed class StretchModes
    {
        private static readonly Lazy<StretchModes> lazy = new Lazy<StretchModes>(() => new StretchModes());

        public static StretchModes Instance { get { return lazy.Value; } }

        public ObservableCollection<CellTypeModeModel> StretchList { get; set; }

        private StretchModes()
        {
            StretchList = new ObservableCollection<CellTypeModeModel>
            {
                new CellTypeModeModel("None", "None"),
                new CellTypeModeModel("Fill", "Fill"),
                new CellTypeModeModel("Uniform", "Uniform"),
                new CellTypeModeModel("UniformToFill", "UniformToFill"),
            };
        }
    }
}
