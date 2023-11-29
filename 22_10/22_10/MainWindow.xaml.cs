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
using Newtonsoft.Json;
using System.Xml;

namespace _22_10
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = FileNameTextbox.Text;
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
                saveFileDialog.FileName = fileName;
                saveFileDialog.DefaultExt = ".txt"; 
                saveFileDialog.Filter = "Text documents (.txt)|*.txt"; 

                bool? result = saveFileDialog.ShowDialog();
                if (result == true)
                {
                    string filePath = saveFileDialog.FileName;
                 
                }
            }
        }

            private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AutoSaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CutButton_Click(object sender, RoutedEventArgs e)
        {
            TextTextbox.Cut();
            TextTextbox.Focus();
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            TextTextbox.Copy();
            TextTextbox.Focus();
            
        }

        private void PasteButton_Click(object sender, RoutedEventArgs e)
        {
            
            TextTextbox.Paste();

        }
    

        private void SelectAllButton_Click(object sender, RoutedEventArgs e)
        {
            TextTextbox.SelectAll();
            TextTextbox.Focus();
        }

        private void FileNameTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string fileName = FileNameTextbox.Text;
            FileNameTextbox.Text = fileName;
        }

        private void AutoSaveButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Text documents (.txt)|*.txt"; 
            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                string filePath = openFileDialog.FileName;
            }
        }
    }
}
