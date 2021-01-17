using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;

namespace LookAndSearchInterface
{
    public partial class AboutForm : Form
    {
        private readonly string UrlAboutInfo = "https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/LookAndSearchInterface/ImagesReferences.txt",
            PathUrlGetContent = "LookAndSearchInterface/LookAndSearchInterface/ImagesReferences.txt";
        public AboutForm()
        {
            InitializeComponent();
            UpdateFillAboutTxtBoxForm();
        }

        private void UpdateFillAboutTxtBoxForm()
        {
            if (File.Exists(Extender.AssemblyDirectory + "\\LocalImagesReferences.txt"))
            {
                txtBoxAboutInfo.Text = File.ReadAllText(Extender.AssemblyDirectory + "\\LocalImagesReferences.txt");
                return;
            }
            
            string[] inputTextSplited = Extender.RecoverContentFromGitHub(PathUrlGetContent).Split(';');
            StringBuilder strBuilded = new StringBuilder();

            foreach (var item in inputTextSplited)
                strBuilded.Append(item).AppendLine().AppendLine();
            txtBoxAboutInfo.Text = strBuilded.ToString();
        }
    }
}
