using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeMaps2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void s_Button_Click(object sender, EventArgs e)
        {
            //variables to retreive data
            string street = streetText.Text;
            string city = cityText.Text;
            string state = stateText.Text;
            string zip = zipText.Text;

            try
            {
                //query to open web browser to Google Maps
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("https://maps.google.com/maps?q=");

                //details of search conditions
                if(street != string.Empty)
                {
                    queryAddress.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryAddress.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryAddress.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryAddress.Append(zip + "," + "+");
                }

                //passing data to the webBrowser
                mapsBrowser.Navigate(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            } 
        }

        private void previousSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
