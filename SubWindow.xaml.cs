using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EventSubscribe
{
    /// <summary>
    /// SubWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SubWindow : Window
    {
        public SubWindow()
        {
            InitializeComponent();
            MainWindow.TestEvent += MainWindow_TestEvent;
        }

        private void MainWindow_TestEvent(object? sender, EventArgs e)
        {
            MyEventArgs? args = e as MyEventArgs;
            Tb_content.Text = $"收到事件 {args?.Message}";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            MainWindow.TestEvent -= MainWindow_TestEvent;
        }
    }
}
