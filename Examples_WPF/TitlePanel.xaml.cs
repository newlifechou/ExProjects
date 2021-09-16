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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examples_WPF
{
    /// <summary>
    /// TitlePanel.xaml 的交互逻辑
    /// </summary>
    public partial class TitlePanel : UserControl
    {
        public TitlePanel()
        {
            InitializeComponent();
        }

        public string MyTitle
        {
            set
            {
                TxtTitle.Text = value;
            }
        }

        public Object MyContent
        {
            set
            {
                TxtContent.Content = value;
            }
        }

    }
}
