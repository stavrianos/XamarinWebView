using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string html = "<html><head><style> .grid-container { display: grid; grid-template-columns: 55% 45%; padding: 0px; grid-column-gap: 2px; } .grid-container2 { display: grid; grid-template-columns: 55% 15% 30%; padding: 0px; grid-column-gap: 2px; } .grid-item { padding: 5px;font-size: 1em; text-align: start;} .grid-item2 {padding: 5px;font-size: 1em;text-align: end;} </style></head><body><div class='grid-container'><div class='grid-item'>GRAND TOTALE</div><div class='grid-item2'>0</div></div></body></html>";
            var htmlSource = new HtmlWebViewSource
            {
                Html = html,
            };
            Browser.Source = htmlSource;
        }
    }
}
