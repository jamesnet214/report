﻿using JamesReport.Models;
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

        public ObservableCollection<ModeModel> List { get; set; }

        private StretchModes()
        {
            List = new ObservableCollection<ModeModel>
            {
                new ModeModel("None", "None"),
                new ModeModel("Fill", "Fill"),
                new ModeModel("Uniform", "Uniform"),
                new ModeModel("UniformToFill", "UniformToFill"),
            };
        }
    }
}
