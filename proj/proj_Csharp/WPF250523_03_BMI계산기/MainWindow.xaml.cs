using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF250523_03_BMI계산기
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

        private void btnBMI_Click(object sender, RoutedEventArgs e)
        {
            if(txtHeight.Text == "" || txtWeight.Text == "")
            {
                lblResult.Content = "키 또는 체중이 입력되지 않았어요";
                return;
            }
            double h = Convert.ToDouble(txtHeight.Text)/100.0;
            double w = Double.Parse(txtWeight.Text);
            double bmi = w / (h * h);
            lblResult.Content = string.Format("당신의 BMI는 {0:F2} 입니다", bmi);
            // WinForm에서는 Label.Text인데, WPF에서는 label.Content
        }
    }
}