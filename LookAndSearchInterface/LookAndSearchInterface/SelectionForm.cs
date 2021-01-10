using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;

namespace LookAndSearchInterface
{
    public partial class SelectionForm : Form
    {
        private readonly string LoupeUrl = "https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/WebScrapperLib/Images/loupe.png",
            IconLogoOtServer = "http://go.baiakao.tk/layouts/tibiarl/images/general/favicon.ico",
            UrlPathApiAdSenseList = "LookAndSearchInterface/LookAndSearchInterface/UrlListAdSense.txt";
        private List<string> AdSenseUrlList = new List<string>();
        private readonly int AdSenseTransactionTime = 4000;
        public SelectionForm()
        {
            InitializeComponent();
            picBoxSelectionFace.Image = Extender.RecoverImageFromUrl(LoupeUrl, "SelectionSize250x250", "GitHubHeaders");
            lblUrlStoreServer.Text = "http://go.baiakao.tk/";
            picBoxAdSenseLogo.Image = Extender.RecoverImageFromUrl(IconLogoOtServer, "IconSize170x175", "GitHubHeaders");
        }

        private async Task LoadAdSenseFromGitHub()
        {
            AdSenseUrlList = Extender.RecoverAdSenseUrlListFromGitHub(UrlPathApiAdSenseList);
            AdSenseUrlList.RemoveAt(0);
            while (true)
            {
                foreach (var item in AdSenseUrlList)
                {
                    picBoxSelectionAdSense.Invoke((MethodInvoker)delegate
                    {
                        picBoxSelectionAdSense.Image = Extender.RecoverImageFromUrl(item.Trim(), "SelectionSize250x250", "GitHubHeaders");
                    });
                    Thread.Sleep(AdSenseTransactionTime);
                }
            }
        }

        private void SelectionForm_Load(object sender, EventArgs e) => Task.Run(() => LoadAdSenseFromGitHub());

        private void linkLblOtServerAdSense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start(lblUrlStoreServer.Text);
    }
}
