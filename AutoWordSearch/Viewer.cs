using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWordSearch {
    public partial class Viewer : Form {
        public Viewer() {
            InitializeComponent();
        }

        public void Search(string data) {
            string word = System.Web.HttpUtility.UrlEncode(data);
            string url;
            string[] tmp = data.Split(' ');
            if (tmp.Length > 1) {
                url = "https://translate.google.com/#en/ko/" + word;
            }
            else {
                url = "http://dic.naver.com/search.nhn?dicQuery=" + word + "&x=0&y=0&query=" + word + "&target=dic&ie=utf8&query_utf=&isOnlyViewEE=";
            }
            webBrowser1.Navigate(url);
        }
    }
}
