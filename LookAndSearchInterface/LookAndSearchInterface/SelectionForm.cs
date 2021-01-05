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
                //picBoxSelectionForm.Image = Extender.RecoverImageFromUrl("https://image.freepik.com/fotos-gratis/lupa-isolada-no-fundo-branco_39665-93.jpg",
                picBoxSelectionForm.Image = Extender.RecoverImageFromUrl("https://lh3.googleusercontent.com/kCvzed6AbpuufeNanVD0E7VuOklLDSAnDmLDR8DwK6s_d-4WLFqNhxmboL583e3uXWmU5zeZpwILT6mOpEMFKFvsksJAh5Vr6i403kRVBv5fLFJJ2VBuv7e4dwwAEW83aLy3LQCwgPhepHq1BwXy3dood-rcSQKpZv6L41lbZbroCmjUPbhosZa3JkdDEl21_fphVVdCYtpAKcXdWmgkxzvxRvm0c52RX4vj_8j3VBJjVeu8IXnYjYDs__lgwjvS2JURRTRK_APGKI8tnvm9mvTB7k7ZvLce2LRpImLhTfi3BYVKnFjGHdyQyD7OzCjKfMcNUGSYabeeexD7XCPsTouApCzl3sVaxK71on3OJqvdpBf7YJH1Nh-RMm6Lvs0-90SJYZLCVB86uI8feMz3JL-PULuULCUq0pKpNEuStd4HJHZ8a8XCjquhGG1KV5GQskqPWN5yYD6OpXs9eGwHO0QsJWhyC3F8cOipa_Bqz_JXFzTC0UyUO1OkNBjteMNPS6QLAhFH3oaZhRHRc_x8izrMPl3LzEqtjq3tpNgRu1vK6uRYmnN6bdeD0PfyieMq8bhfsTs1zaYxtN73PEcMH5k8iWLPevIKnl6CgMJ3jF9asW7CRMUoAgYl4R7tB_QUJck4hn6gal8YFjRZ3FGycD0k_fyQN3kVEDvtwImZNJjcZJhYh8H5bWYUqVmUYw=w823-h618-no?authuser=0",
                    "SelectionSize536x273");
            }
            catch (Exception ex)
            {
                picBoxSelectionForm.Image = null;
            }
            
        }
    }
}
