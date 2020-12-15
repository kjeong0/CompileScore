﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CompileScore
{
    public class SettingsWindow : Window
    {
        public SettingsWindow(SolutionSettings settings)
        {
            Title = "Compile Score Options";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            SizeToContent = SizeToContent.Height;
            Width =  900;

            this.Content = new SettingsControl(this, settings == null? new SolutionSettings() : settings);
        }
    }
}
