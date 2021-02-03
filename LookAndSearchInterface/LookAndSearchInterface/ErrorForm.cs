using System.Windows.Forms;
using WebScrapperLib.Utils;

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
