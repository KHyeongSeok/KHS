using System.Text;
using System.Windows;
using System.Windows.Forms; // 프로젝트 속성에서 WinForm 사용 허용 항목 체크
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF250523_05_WinFormInWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\강형석\Desktop\스마트팩토리\proj_Csharp\WPF250523_05_WinFormInWPF";
            ofd.Multiselect = true;
            var result = ofd.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var s in ofd.FileNames)
                {
                    lbFiles.Items.Add(s);
                }
            }
        }
    }
}