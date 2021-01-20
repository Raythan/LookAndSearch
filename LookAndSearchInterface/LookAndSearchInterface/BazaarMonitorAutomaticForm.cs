using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.Models;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class BazaarMonitorAutomaticForm : Form
    {
        private readonly string SoundAlertUrl = "https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/WebScrapperLib/Sounds/alert_bazaar.wav";
        private bool StillMonitoring = true;
        BazaarScrapper ScrapperService;
        WorldScrapper WorldScrapperService = new WorldScrapper();
        ParameterForFilterMonitorEntity parameterForFilterEntity = new ParameterForFilterMonitorEntity();
        private string QueryParameters = null;
        Regex rgxAlphaNumeric = new Regex(@"^[a-zA-Z0-9\w\s]*$");

        List<string> listVocationFilter = new List<string>
        {
            "None",
            "Druid",
            "Knight",
            "Paladin",
            "Sorcerer"
        };

        Dictionary<string, int?> DictionarySkillId = new Dictionary<string, int?>
        {
            {"Select..", null},
            {"Axe Fighting", 10},
            {"Club Fighting", 9},
            {"Distance Fighting", 7},
            {"Fishing", 13},
            {"Fist Fighting", 11},
            {"Magic Level", 1},
            {"Shielding", 6},
            {"Sword Fighting", 8}
        };

        private async Task StartMonitoringAsync()
        {
            if (!chkBoxBlinkTaskBar.Checked && !chkBoxSendWindowsSound.Checked && !chkBoxNotifiedByEmail.Checked)
            {
                Extender.UpdateComponentText(lblStatusMonitorInfo, "Hey, you need to select at least one type of alert. :)");
                Extender.UpdateComponentVisible(lblStatusMonitorInfo, true);
                Extender.UpdateComponentVisible(picBoxBazaarCheckResultMonitor, true);
                Extender.UpdateComponentImage(picBoxBazaarCheckResultMonitor, Extender.RecoverImageFromRepository("ConfusedIcon", "IconSize64x64"));
                return;
            }

            if (chkBoxNotifiedByEmail.Checked && 
                (string.IsNullOrEmpty(txtBoxDisplayEmailName.Text) || 
                string.IsNullOrEmpty(txtBoxEmailTo.Text)))
            {
                Extender.UpdateComponentText(lblStatusMonitorInfo, "I noticed you want to be notified by email.\r\nBut I need you fill the fields. :)");
                Extender.UpdateComponentVisible(lblStatusMonitorInfo, true);
                Extender.UpdateComponentVisible(picBoxBazaarCheckResultMonitor, true);
                Extender.UpdateComponentImage(picBoxBazaarCheckResultMonitor, Extender.RecoverImageFromRepository("ConfusedIcon", "IconSize64x64"));
                return;
            }

            //Extender.UpdateComponentEnable(chkBoxBlinkTaskBar, false);
            Extender.UpdateComponentEnable(chkBoxNotifiedByEmail, false);
            Extender.UpdateComponentEnable(chkBoxSendWindowsSound, false);
            Extender.UpdateComponentEnable(btnBazaarStartMonitor, false);
            Extender.UpdateComponentEnable(btnBazaarStopMonitor, true);
            Extender.UpdateComponentText(lblStatusMonitorInfo, "Relax now, I will warn you when I'm done. :)");
            Extender.UpdateComponentVisible(lblStatusMonitorInfo, true);
            Extender.UpdateComponentVisible(picBoxBazaarCheckResultMonitor, true);
            Extender.UpdateComponentVisible(lnkLblBazaarCheckNames, false);
            Extender.UpdateComponentImage(picBoxBazaarCheckResultMonitor, Extender.RecoverImageFromRepository("VeryHappyIcon", "IconSize64x64"));
            while (StillMonitoring)
            {
                BuildQueryParametersPath();
                ScrapperService = new BazaarScrapper(QueryParameters, StillMonitoring);

                ScrapperService.MonitoringBazaarPageAsync(parameterForFilterEntity)
                    .GetAwaiter().GetResult();

                if (ScrapperService.DictionaryEntity != null && ScrapperService.DictionaryEntity.Count() > 0 && StillMonitoring)
                {
                    if (chkBoxBlinkTaskBar.Checked)
                        BlinkTaskBar();

                    if (chkBoxSendWindowsSound.Checked)
                        PlaySoundByUrl();

                    if (chkBoxNotifiedByEmail.Checked)
                        SendEmailWithListName();

                    Extender.UpdateComponentText(lblStatusMonitorInfo, "Unbelievable, check the names I found out.\r\nBecame a little tired, just resting\r\nbefore search for you again.");
                    Extender.UpdateComponentVisible(picBoxBazaarCheckResultMonitor, true);
                    Extender.UpdateComponentImage(picBoxBazaarCheckResultMonitor, Extender.RecoverImageFromRepository("SurprisedIcon", "IconSize64x64"));
                    Extender.UpdateComponentVisible(lnkLblBazaarCheckNames, true);
                    Thread.Sleep((int)numUpDownCheckTimeMinutes.Value * 60000);
                }
                else if (!StillMonitoring)
                {
                    Extender.UpdateComponentText(lblStatusMonitorInfo, "What's up buddy? Anything wrong?");
                    Extender.UpdateComponentVisible(picBoxBazaarCheckResultMonitor, true);
                    Extender.UpdateComponentImage(picBoxBazaarCheckResultMonitor, Extender.RecoverImageFromRepository("SadIcon", "IconSize64x64"));
                }
                else
                {
                    Extender.UpdateComponentText(lblStatusMonitorInfo, "Well, I'm finished and we don't had lucky\r\nMaybe in next search.\r\nBecame a little tired, just resting\r\nbefore search for you again.");
                    Extender.UpdateComponentVisible(picBoxBazaarCheckResultMonitor, true);
                    Extender.UpdateComponentImage(picBoxBazaarCheckResultMonitor, Extender.RecoverImageFromRepository("SadIcon", "IconSize64x64"));
                    Thread.Sleep((int)numUpDownCheckTimeMinutes.Value * 60000);
                }    
            }

            //Extender.UpdateComponentEnable(chkBoxBlinkTaskBar, true);
            Extender.UpdateComponentEnable(chkBoxNotifiedByEmail, true);
            Extender.UpdateComponentEnable(chkBoxSendWindowsSound, true);
            Extender.UpdateComponentEnable(btnBazaarStartMonitor, true);
            StillMonitoring = true;
            ScrapperService.StillScrapping = true;
        }

        private void SendEmailWithListName()
        {
            StringBuilder bodyMessage = new StringBuilder();
            bodyMessage.Append("<table><caption>Character List Names</caption>");

            foreach (var item in ScrapperService.DictionaryEntity)
                bodyMessage.Append($"<tr><td>{((BazaarEntity)item.Value).CharacterName}</td><td><a href=\"{ ((BazaarEntity)item.Value).UrlEntityInfo}\">Oficial Web Site Auction</a></td></tr>");

            bodyMessage.Append("</table>");

            try
            {
                EmailSender.SendEmail(new EmailEntity(bodyMessage.ToString())
                {
                    EmailToDisplayName = txtBoxDisplayEmailName.Text,
                    EmailTo = txtBoxEmailTo.Text
                });

                lblStatusEmailInfo.Text = $"An email was sent at {DateTime.Now.ToString(Extender.GetDateFormatFromKey(0))}.";
            }
            catch (Exception)
            {
                lblStatusEmailInfo.Text = "The server to send mail is already busy, I'll try to send again later.";
            }
            finally
            {
                lblStatusEmailInfo.Visible = true;
            }
        }

        private void StopMonitoring()
        {
            StillMonitoring = false;
            ScrapperService.StillScrapping = false;
            btnBazaarStopMonitor.Enabled = false;
        }

        private void BlinkTaskBar()
        {
            FlashWindow.Flash(this);
            FlashWindow.Flash(this, 5);
            FlashWindow.Tray(this);
            FlashWindow.TrayAndWindow(this);
        }

        private void BuildQueryParametersPath()
        {
            QueryParameters = "";
            QueryParameters += numMinLevelFilter.Value > 0 ? $"&filter_levelrangefrom={numMinLevelFilter.Value}" : "";
            QueryParameters += numMaxLevelFilter.Value > 0 ? $"&filter_levelrangeto={numMaxLevelFilter.Value}" : "";

            cboBoxSkillsFilter.Invoke((MethodInvoker)delegate
            {
                if (!string.IsNullOrEmpty(cboBoxSkillsFilter.SelectedItem.ToString()))
                {
                    int? parameterSkillId = DictionarySkillId
                    .Where(w => w.Key.Equals(cboBoxSkillsFilter.SelectedItem.ToString()))
                    .Select(s => s.Value)
                    .FirstOrDefault();
                    QueryParameters += $"&filter_skillid={parameterSkillId}";
                }
            });

            QueryParameters += numMinSkillFilter.Value > 0 ? $"&filter_skillrangefrom={numMinSkillFilter.Value}" : "";
            QueryParameters += numMaxSkillFilter.Value > 0 ? $"&filter_skillrangeto={numMaxSkillFilter.Value}" : "";
        }

        public void FillUpdateChkListVocationNames()
        {
            if (chkLstBoxVocationFilter.Items.Count > 0)
                chkLstBoxVocationFilter.Items.Clear();

            foreach (var item in listVocationFilter)
                chkLstBoxVocationFilter.Items.Add(item);
        }

        public void FillUpdateComboWorldNames()
        {
            if (chkLstBoxWorldFilter.Items.Count > 0)
                chkLstBoxWorldFilter.Items.Clear();
            else
                WorldScrapperService.RecoverScrapperData();

            foreach (var item in WorldScrapperService.DictionaryEntity)
                chkLstBoxWorldFilter.Items.Add(item.Key);
        }

        private void FillUpdateComboWorldPvpType()
        {
            if (chkLstBoxPvpTypeFilter.Items.Count > 0)
                chkLstBoxPvpTypeFilter.Items.Clear();

            List<string> pvpTypeList = new List<string>();

            foreach (var item in WorldScrapperService.DictionaryEntity)
                if (!pvpTypeList.Contains(((WorldEntity)item.Value).PvpType))
                    pvpTypeList.Add(((WorldEntity)item.Value).PvpType);

            foreach (var item in pvpTypeList)
                chkLstBoxPvpTypeFilter.Items.Add(item);
        }

        private async Task FillUpdateImagesButton()
        {
            btnBazaarApplyFilter.Image = Extender.RecoverImageFromRepository("FilterIcon", "IconSize32x32");
            btnBazaarStartMonitor.Image = Extender.RecoverImageFromRepository("RefreshIcon", "IconSize32x32");
            btnBazaarStopMonitor.Image = Extender.RecoverImageFromRepository("StopIcon", "IconSize32x32");
        }

        private void BazaarMonitorAutomaticForm_Load(object sender, System.EventArgs e)
        {
            ResetAllControls();
            Task.Run(() => FillUpdateImagesButton());
        }

        private void ResetAllControls()
        {
            FillUpdateChkListVocationNames();
            FillUpdateComboWorldNames();
            FillUpdateComboWorldPvpType();
            FillUpdateComboSkillsFilterById();
        }

        private void chkLstBoxPvpTypeFilter_Leave(object sender, System.EventArgs e)
        {
            if (chkLstBoxWorldFilter.Items.Count > 0)
                chkLstBoxWorldFilter.Items.Clear();

            if (chkLstBoxPvpTypeFilter.CheckedItems.Count > 0)
            {
                foreach (var item in chkLstBoxPvpTypeFilter.CheckedItems)
                    foreach (var item2 in WorldScrapperService.DictionaryEntity)
                        if (item.Equals(((WorldEntity)item2.Value).PvpType))
                            chkLstBoxWorldFilter.Items.Add(item2.Key);
            }
            else
            {
                foreach (var item2 in WorldScrapperService.DictionaryEntity)
                    chkLstBoxWorldFilter.Items.Add(item2.Key);
            }
        }

        private void cboBoxSkillsFilter_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cboBoxSkillsFilter.Text.Equals("Select.."))
            {
                parameterForFilterEntity.PropSkillFilter = null;
                numMinSkillFilter.Value = 0;
                numMaxSkillFilter.Value = 500;
                numMinSkillFilter.Enabled = false;
                numMaxSkillFilter.Enabled = false;
            }
            else
            {
                parameterForFilterEntity.PropSkillFilter = cboBoxSkillsFilter.Text;
                numMinSkillFilter.Enabled = true;
                numMaxSkillFilter.Enabled = true;
            }
        }

        private void chkLstBoxWorldFilter_Leave(object sender, EventArgs e)
        {
            if (chkLstBoxWorldFilter.CheckedItems.Count > 0)
                parameterForFilterEntity.WorldsFilter = chkLstBoxWorldFilter.CheckedItems.Cast<string>().ToList();
            else
                parameterForFilterEntity.WorldsFilter = new List<string>();
        }

        private void chkLstBoxVocationFilter_Leave(object sender, EventArgs e)
        {
            if (chkLstBoxVocationFilter.CheckedItems.Count > 0)
                parameterForFilterEntity.VocationsFilter = chkLstBoxVocationFilter.CheckedItems.Cast<string>().ToList();
            else
                parameterForFilterEntity.VocationsFilter = new List<string>();
        }

        private void numUpDownBidMaxFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDownBidMaxFilter.Value > 0)
                parameterForFilterEntity.MaxBidFilter = (int)numUpDownBidMaxFilter.Value;
            else
                parameterForFilterEntity.MaxBidFilter = 0;
        }

        private void numMinLevelFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numMinLevelFilter.Value > 0)
                parameterForFilterEntity.MinLevelFilter = (int)numMinLevelFilter.Value;
            else
                parameterForFilterEntity.MinLevelFilter = 0;
        }

        private void numMaxLevelFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numMaxLevelFilter.Value < 10000)
                parameterForFilterEntity.MaxLevelFilter = (int)numMaxLevelFilter.Value;
            else
                parameterForFilterEntity.MaxLevelFilter = 10000;
        }

        private void numMinSkillFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numMinSkillFilter.Value > 0)
                parameterForFilterEntity.MinSkillFilter = (int)numMinSkillFilter.Value;
            else
                parameterForFilterEntity.MinLevelFilter = 0;
        }

        private void numMaxSkillFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numMaxSkillFilter.Value < 500)
                parameterForFilterEntity.MaxSkillFilter = (int)numMaxSkillFilter.Value;
            else
                parameterForFilterEntity.MaxSkillFilter = 500;
        }

        private void chkBoxNotifiedByEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxNotifiedByEmail.Checked)
                grpBoxEmailDataFields.Visible = true;
            else
            {
                txtBoxDisplayEmailName.Text = "";
                txtBoxEmailTo.Text = "";
                grpBoxEmailDataFields.Visible = false;
                btnBazaarStartMonitor.Enabled = true;
            }
        }

        private void txtBoxEmailTo_Leave(object sender, EventArgs e)
        {
            try
            {
                MailAddress validParam = new MailAddress(txtBoxEmailTo.Text);
                btnBazaarStartMonitor.Enabled = true;
            }
            catch (Exception)
            {
                btnBazaarStartMonitor.Enabled = false;
                MessageBox.Show("You apparently informed an invalid email, please check it.", "Review!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtBoxDisplayEmailName_Leave(object sender, EventArgs e)
        {
            if (!rgxAlphaNumeric.Match(txtBoxDisplayEmailName.Text).Success)
            {
                MessageBox.Show("You apparently input some invalid digits\r\nPlease garante they are only alphanumeric.", "Review!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnBazaarStartMonitor.Enabled = false;
                return;
            }
            btnBazaarStartMonitor.Enabled = true;
        }

        private void lnkLblBazaarCheckNames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ScrapperService.DictionaryEntity.Count > 0)
            {
                DialogListCharacterNamesForm dialog = new DialogListCharacterNamesForm(ScrapperService.DictionaryEntity.Keys.ToList());
                dialog.ShowDialog();
            }
        }

        private void FillUpdateComboSkillsFilterById() => cboBoxSkillsFilter.DataSource = DictionarySkillId.Keys.ToList();

        private void PlaySoundByUrl() => Extender.PlaySoundFromUrlStream(SoundAlertUrl, "GitHubHeaders", 3000);

        private void chkBoxIsBiddedFilter_CheckedChanged(object sender, EventArgs e) => parameterForFilterEntity.IsBiddedFilter = chkBoxIsBiddedFilter.Checked;

        private void btnBazaarStartMonitor_Click(object sender, System.EventArgs e) => Task.Run(() => StartMonitoringAsync());

        private void btnBazaarStopMonitor_Click(object sender, EventArgs e) => StopMonitoring();

        public BazaarMonitorAutomaticForm() => InitializeComponent();
    }
}
