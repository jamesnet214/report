using JamesReport.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace JamesReport.Forms.Local.Datas
{
    public sealed class FontWeightModes
    {
        private static readonly Lazy<FontWeightModes> lazy = new Lazy<FontWeightModes>(() => new FontWeightModes());

        public static FontWeightModes Instance { get { return lazy.Value; } }

        public ObservableCollection<ModeModel> List { get; set; }

        private FontWeightModes()
        {
            List = new ObservableCollection<ModeModel>
            {
                new ModeModel("Thin", "Thin"),
                new ModeModel("ExtraLight", "ExtraLight"),
                new ModeModel("Light", "Light"),
                new ModeModel("Regular", "Normal"),
                new ModeModel("Medium", "Medium"),
                new ModeModel("SemiBold", "SemiBold"),
                new ModeModel("Bold", "Bold"),
                new ModeModel("ExtraBold", "ExtraBold"),
                new ModeModel("Black", "Black"),
                new ModeModel("ExtraBlack", "ExtraBlack")
            };
        }
    }
}
