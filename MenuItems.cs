using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChartMaker
{
    /// <summary>
    /// 这里处理工具栏的交互
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 文件菜单
        private void New_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion

        #region 导出菜单
        private void Output_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
        #region 编辑菜单
        private void Undo_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Redo_Click(object sender, RoutedEventArgs e)
        {
        }
        #endregion
        private void About_Click(object sender, RoutedEventArgs e)
        {
        }
    }

}
