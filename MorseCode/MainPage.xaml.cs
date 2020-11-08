using AwsomeApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string dotdashline = "";
        string theline = "";

        int count = 0;
        void Handle_dot(object sender, System.EventArgs e)
        {
            dotdashline += "."; 
            dotNdashs.Text = dotdashline;
        }
        void Handle_dash(object sender, System.EventArgs e)
        {
            dotdashline += "-";
            dotNdashs.Text = dotdashline;
        }
        void Handle_space(object sender, System.EventArgs e)
        {
            theline += Morse.MorseCoder(dotdashline);
            dotdashline = "";
            theText.Text = theline;
        }
        void Clear(object sender, System.EventArgs e)
        {
            theline = "";
            theText.Text = "";
            dotNdashs.Text = "";
        }
    }
}
