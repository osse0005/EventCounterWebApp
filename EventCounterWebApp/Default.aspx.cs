using System;
using System.IO;
using System.Web;
using System.Web.UI;

namespace EventCounterWebApp
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){
            string[] resultsFiles = this.listAllScanResults();

            if(!IsPostBack){
                foreach(string result in resultsFiles){
                    ResultsTextBox.Text += result +"<br/>";


                }
            }
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";

        }

        public string[] listAllScanResults(){
            string[] filePaths = Directory.GetFiles(@"Resources/", "*EventLogResult.csv", SearchOption.TopDirectoryOnly);


            return filePaths;
		}
    }
}
