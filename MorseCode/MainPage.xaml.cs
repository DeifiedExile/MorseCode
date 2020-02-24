using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Letter.Text += ".";
        }
        private void Dash_Click(object sender, EventArgs e)
        {
            Letter.Text += "-";
        }

        private void Space_Click(object sender, EventArgs e)
        {
            Morse morse = new Morse();
            Message.Text += Morse.MorseCoder(Letter.Text.ToString());
            Letter.Text = "";
        }
    }
}
