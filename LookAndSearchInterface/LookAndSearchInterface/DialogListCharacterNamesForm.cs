using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookAndSearchInterface
{
    public partial class DialogListCharacterNamesForm : Form
    {
        public DialogListCharacterNamesForm(List<string> characterNames)
        {
            InitializeComponent();
            StringBuilder strBuild = new StringBuilder();

            foreach (var item in characterNames)
                strBuild.Append(item).AppendLine();

            txtBoxCharactersNames.Text = strBuild.ToString();
        }
    }
}
