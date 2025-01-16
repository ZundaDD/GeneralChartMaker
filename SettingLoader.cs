using ChartMaker.setting;
using HandyControl.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChartMaker
{
    public partial class MainWindow : System.Windows.Window
    {
        public void LoadFromSetting(object sender, RoutedEventArgs e)
        {
            HandyControl.Controls.TextBox chartText = (HandyControl.Controls.TextBox)FindName("Chart_Text");
            chartText.FontSize = Setting.Instance.fontsize;
        }
    }
}
