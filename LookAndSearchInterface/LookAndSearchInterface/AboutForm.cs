using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;

namespace LookAndSearchInterface
{
    public partial class AboutForm : Form
    {
        private readonly string UrlAboutInfo = "https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/LookAndSearchInterface/ImagesReferences.txt";
        public AboutForm()
        {
            InitializeComponent();
            UpdateFillAboutTxtBoxForm();
        }

        private void UpdateFillAboutTxtBoxForm()
        {
            txtBoxAboutInfo.Text = Extender.RecoverStringFromUrl(UrlAboutInfo, "GitHubHeaders");
        }
    }
}
