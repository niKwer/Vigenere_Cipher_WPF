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
using System.Windows.Controls.Primitives;
using Microsoft.Win32;
using System.IO;
using Xceed.Words.NET;

namespace WPF_Cipher_Nyss
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Popup buttons
        private void OpenBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = OpenBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Open text from file";
        }

        private void OpenBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void EncryptBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = EncryptBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Encrypt text";
        }

        private void EncryptBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void DecryptBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = DecryptBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Decrypt text";
        }

        private void DecryptBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void SaveBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = SaveBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Save text to File";
        }
        private void SaveBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }
        #endregion

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMessage.Visibility = Visibility.Collapsed;
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt|Docs file (*.docx)|*docx";
            Nullable<bool> result = dlg.ShowDialog();

            try
            {
                if (result == true)
                {
                    var value = dlg.FilterIndex;
                    string fileName = dlg.FileName;
                    if (value == 1)
                    {
                        string contents = File.ReadAllText(fileName);
                        TextBoxOriginal.Text = contents;
                    }
                    else if (value == 2)
                    {
                        var doc = DocX.Load(fileName);
                        string contents = doc.Text;
                        TextBoxOriginal.Text = contents;
                    }
                }
            }
            catch(Exception)
            {
                TextBoxMessage.Text = "Failed to open file.";
                TextBoxMessage.Visibility = Visibility.Visible;
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMessage.Visibility = Visibility.Collapsed;
            if(TextBoxFinal.Text=="")
            {
                TextBoxMessage.Text = "Please decrypt or encrypt some text";
                TextBoxMessage.Visibility = Visibility.Visible;
                TextBoxOriginal.Tag = "Please decrypt / encrypt the text";
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text file (*.txt)|*.txt|Doc files (*.docx)|*.docx";
                Nullable<bool> result = saveFileDialog.ShowDialog();
                try
                {
                    if (result == true)
                    {
                        string fileName = saveFileDialog.FileName;
                        var value = saveFileDialog.FilterIndex;
                        if (value == 1)
                        {
                            File.WriteAllText(fileName, TextBoxFinal.Text);
                        }
                        else if (value == 2)
                        {
                            var doc = DocX.Create(fileName, Xceed.Document.NET.DocumentTypes.Document);
                            doc.InsertParagraph(TextBoxFinal.Text);
                            doc.Save();
                        }
                    }
                }
                catch (Exception)
                {
                    TextBoxMessage.Text = "Failed to save file.";
                    TextBoxMessage.Visibility = Visibility.Visible;
                }
            }
        }

        private void EncryptBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMessage.Visibility = Visibility.Collapsed;

            if(TextBoxOriginal.Text=="" && TextBoxKey.Text=="")
            {
                TextBoxFinal.Text = "";
                TextBoxOriginal.Tag = "Please write some text;";
                TextBoxKey.Tag = "Please write the key;";
            }
            else if(TextBoxOriginal.Text == "")
            {
                TextBoxFinal.Text = "";
                TextBoxOriginal.Tag = "Please write some text;";
            }
            else if(TextBoxKey.Text == "")
            {
                TextBoxMessage.Text = "Please write the key";
                TextBoxMessage.Visibility = Visibility.Visible;
                TextBoxKey.Tag = "Please write the key";
            }
            else
            {
                string messageString = "";
                TextBoxFinal.Text = VigenereCalc.Encrypt(TextBoxOriginal.Text, TextBoxKey.Text, ref messageString);
                if(messageString!="")
                {
                    TextBoxMessage.Text = messageString;
                    TextBoxMessage.Visibility = Visibility.Visible;
                }
            }
        }

        private void DecryptBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMessage.Visibility = Visibility.Collapsed;

            if (TextBoxOriginal.Text == "" && TextBoxKey.Text == "")
            {
                TextBoxFinal.Text = "";
                TextBoxOriginal.Tag = "Please write some text;";
                TextBoxKey.Tag = "Please write the key;";
            }
            else if (TextBoxOriginal.Text == "")
            {
                TextBoxFinal.Text = "";
                TextBoxOriginal.Tag = "Please write some text;";
            }
            else if (TextBoxKey.Text == "")
            {
                TextBoxMessage.Text = "Please write the key";
                TextBoxMessage.Visibility = Visibility.Visible;
                TextBoxKey.Tag = "Please write the key";
            }
            else
            {
                string messageString = "";
                TextBoxFinal.Text = VigenereCalc.Decrypt(TextBoxOriginal.Text, TextBoxKey.Text, ref messageString);
                if (messageString != "")
                {
                    TextBoxMessage.Text = messageString;
                    TextBoxMessage.Visibility = Visibility.Visible;
                }
            }
        }

        private void TextBoxOriginal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TextBoxOriginal.Text=="")
            {
                TextBoxOriginal.Tag = "Please write text";
            }
        }
    }
}
