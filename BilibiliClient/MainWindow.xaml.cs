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

using System.Net;
using System.Net.Http;
using HtmlAgilityPack;

namespace BilibiliClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
           this.label.Content = MessageBox.Show("Fucked");


            Task<int> getBaiduLengthTask = fuck(3);

            this.label.Content = await getBaiduLengthTask;

            HtmlDocument doc = new HtmlDocument();
            doc.Load("file.htm");
            foreach (HtmlNode link in doc.DocumentElement.SelectNodes("//a[@href"])
 {
                HtmlAttribute att = link["href"];
                att.Value = FixLink(att);
            }
            doc.Save("file.htm");
        }

        private async Task<int> fuck(int fuckee)
        {
            HttpWebRequest myRequest;
            //            myRequest.be
            using (var client = new HttpClient())
            {
                Task<string> getStringTask = client.GetStringAsync("http://baidu.com");

                Console.Write("Fucking");

                string s = await getStringTask;

                return s.Length;
            }
        }
    }
}
