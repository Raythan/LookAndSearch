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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
            try
            {
                picBoxSelectionForm.Image = Extender.RecoverImageFromUrl("https://github.com/Raythan/LookAndSearch/blob/main/LookAndSearchInterface/WebScrapperLib/Images/lupa_512x512.png?raw=true",
                    "SelectionSize250x250");
            }
            catch (Exception ex)
            {
                picBoxSelectionForm.Image = null;
            }   
        }
    }
}
