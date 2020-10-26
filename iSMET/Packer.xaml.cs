using FirstFloor.ModernUI.Windows.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace iSMET
{
    /// <summary>
    /// Interaction logic for Packer.xaml
    /// </summary>
    public partial class Packer : ModernWindow
    {
        string _strMeterpreterFilePath = string.Empty;
        string _strStubFilePath = string.Empty;
        public Packer()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            fileDialog.Title = @"iSMET - Select Meterpreter File";
            fileDialog.Multiselect = false;
            var result = fileDialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                try
                {
                    _strMeterpreterFilePath = fileDialog.FileName;
                    txtStatus.AppendText(Environment.NewLine + "Selected File:" + _strMeterpreterFilePath);
                    GetMeterpreterBinary(_strMeterpreterFilePath);
                }
                catch (Exception ex)
                {
                    txtStatus.AppendText(Environment.NewLine + ex.Message);
                }
            }
            else
            {
                txtStatus.AppendText(Environment.NewLine + "No file selected.");
            }
        }

        private void ModernWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void GetMeterpreterBinary(string meterpreterPath)
        {

        }
    }
}
