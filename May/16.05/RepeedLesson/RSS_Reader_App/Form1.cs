using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RSS_Reader_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<News> news = XmlToList();

            lstNews.DataSource = news;
        }
        private List<News> XmlToList()
        {
            string Url = txtRSSURL.Text;
            List<News> newsList = new List<News>();
            XDocument xmlSource =XDocument.Load(Url);

            List<XElement> rows = xmlSource.Descendants("item").ToList();

            foreach (var item in rows)
            {
                News news = new News();
                news.Header = item.Element("title").Value;
                news.URL = item.Element("link").Value;
                news.Description = item.Element("description").Value;

                newsList.Add(news);
            }

            return newsList;
        }

        private void lstNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBOX = (ListBox)sender;
            News selecedNews = (News)listBOX.SelectedItem;
            webNews.DocumentText = selecedNews.Description;
            webNews.ScriptErrorsSuppressed = true;
        }
    }
}
