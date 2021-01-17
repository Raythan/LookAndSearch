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
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
            picBoxErrorImage.Image = Extender.RecoverImageFromUrl("https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/WebScrapperLib/Images/erro.png", "IconSize400x400", "GitHubHeaders");
        }
    }
}
