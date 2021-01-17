using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.Models;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class CharacterSpecificInfoForm : Form
    {
        private readonly string UrlForScrappingPage;
        private readonly CharacterSpecificInfoScrapper ScrapperService;

        private void timerUpdateFillGrids_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ScrapperService.Entity.General.Titles)
                    && dtaGridGeneralPart1Info.DataSource == null)
                    FillGridViewGeneralPart1();
                if (ScrapperService.Entity.General.SKillsValuePercentage.Count > 0
                    && dtaGridGeneralPart2Info.DataSource == null)
                    FillGridViewGeneralPart2();
                if (!string.IsNullOrEmpty(ScrapperService.Entity.General.AchievementPoints)
                    && dtaGridGeneralPart3Info.DataSource == null)
                    FillGridViewGeneralPart3();
                if (!string.IsNullOrEmpty(ScrapperService.Entity.General.RegularWorldTransfer)
                    && dtaGridGeneralPart4Info.DataSource == null)
                    FillGridViewGeneralPart4();
                if (!string.IsNullOrEmpty(ScrapperService.Entity.General.SpentCharmPoints)
                    && dtaGridGeneralPart5Info.DataSource == null)
                    FillGridViewGeneralPart5();
                if (!string.IsNullOrEmpty(ScrapperService.Entity.General.DailyRewardStreak)
                    && dtaGridGeneralPart6Info.DataSource == null)
                    FillGridViewGeneralPart6();
                if (!string.IsNullOrEmpty(ScrapperService.Entity.General.PermanentPreySlots)
                    && dtaGridGeneralPart7Info.DataSource == null)
                    FillGridViewGeneralPart7();
                if (!string.IsNullOrEmpty(ScrapperService.Entity.General.HirelingOutfits)
                    && dtaGridGeneralPart8Info.DataSource == null)
                    FillGridViewGeneralPart8();
                if (!string.IsNullOrEmpty(ScrapperService.Entity.General.UrlMainOutfit)
                    && picBoxMainIconStatus.Image == null)
                    picBoxMainIconStatus.Image = Extender.RecoverImageFromUrl(ScrapperService.Entity.General.UrlMainOutfit, "IconSize64x64", "CipSoftHeaders");
            }
            catch (Exception ex)
            {
                dtaGridGeneralPart1Info.DataSource = null;
                dtaGridGeneralPart2Info.DataSource = null;
                dtaGridGeneralPart3Info.DataSource = null;
                dtaGridGeneralPart4Info.DataSource = null;
                dtaGridGeneralPart5Info.DataSource = null;
                dtaGridGeneralPart6Info.DataSource = null;
                dtaGridGeneralPart7Info.DataSource = null;
                dtaGridGeneralPart8Info.DataSource = null;
            }
        }

        public async Task FillGridViewGeneralPart1()
        {
            dtaGridGeneralPart1Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Hit Points", ScrapperService.Entity.General.HitPoints);
                dt.Rows.Add("Mana", ScrapperService.Entity.General.Mana);
                dt.Rows.Add("Capacity", ScrapperService.Entity.General.Capacity);
                dt.Rows.Add("Speed", ScrapperService.Entity.General.Speed);
                dt.Rows.Add("Blessings", ScrapperService.Entity.General.Blessings);
                dt.Rows.Add("Mounts", ScrapperService.Entity.General.Mounts);
                dt.Rows.Add("Outfits", ScrapperService.Entity.General.Outfits);
                dt.Rows.Add("Titles", ScrapperService.Entity.General.Titles);

                dtaGridGeneralPart1Info.DataSource = dt;
                dtaGridGeneralPart1Info.BackgroundColor = Color.PapayaWhip;
                Extender.ResizeDtaGrdView(dt, dtaGridGeneralPart1Info);
            });
        }
        public async Task FillGridViewGeneralPart2()
        {
            dtaGridGeneralPart2Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Columns.Add("Percentage", typeof(string));

                foreach (var item in ScrapperService.Entity.General.SKillsValuePercentage)
                {
                    string[] valuePercentSplited = item.Value.Split(';');
                    dt.Rows.Add(item.Key, valuePercentSplited[0], valuePercentSplited[1]);
                }
                
                dtaGridGeneralPart2Info.DataSource = dt;
                dtaGridGeneralPart2Info.BackgroundColor = Color.PapayaWhip;
                Extender.ResizeDtaGrdView(dt, dtaGridGeneralPart2Info);
            });
        }
        public async Task FillGridViewGeneralPart3()
        {
            dtaGridGeneralPart3Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));

                dt.Rows.Add("Creation Date", Extender.FormatAuctionDateFromEntity(ScrapperService.Entity.General.CreationDate, 0));
                dt.Rows.Add("Experience", ScrapperService.Entity.General.Experience);
                dt.Rows.Add("Gold", ScrapperService.Entity.General.Gold);
                dt.Rows.Add("Achievement Points", ScrapperService.Entity.General.AchievementPoints);

                dtaGridGeneralPart3Info.DataSource = dt;
                dtaGridGeneralPart3Info.BackgroundColor = Color.PapayaWhip;
                Extender.ResizeDtaGrdView(dt, dtaGridGeneralPart3Info);
            });
        }
        public async Task FillGridViewGeneralPart4()
        {
            dtaGridGeneralPart4Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Regular World Transfer", ScrapperService.Entity.General.RegularWorldTransfer);

                dtaGridGeneralPart4Info.DataSource = dt;
                dtaGridGeneralPart4Info.BackgroundColor = Color.PapayaWhip;
                Extender.ResizeDtaGrdView(dt, dtaGridGeneralPart4Info);
            });
        }
        public async Task FillGridViewGeneralPart5()
        {
            dtaGridGeneralPart5Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Charm Expansion", ScrapperService.Entity.General.CharmExpansion);
                dt.Rows.Add("Available Charm Points", ScrapperService.Entity.General.AvailableCharmPoints);
                dt.Rows.Add("Spent Charm Points", ScrapperService.Entity.General.SpentCharmPoints);

                dtaGridGeneralPart5Info.DataSource = dt;
                dtaGridGeneralPart5Info.BackgroundColor = Color.PapayaWhip;
                Extender.ResizeDtaGrdView(dt, dtaGridGeneralPart5Info);
            });
        }
        public async Task FillGridViewGeneralPart6()
        {
            dtaGridGeneralPart6Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Daily Reward Streak", ScrapperService.Entity.General.DailyRewardStreak);

                dtaGridGeneralPart6Info.DataSource = dt;
                dtaGridGeneralPart6Info.BackgroundColor = Color.PapayaWhip;
                Extender.ResizeDtaGrdView(dt, dtaGridGeneralPart6Info);
            });
        }
        public async Task FillGridViewGeneralPart7()
        {
            dtaGridGeneralPart7Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Hunting Task Points", ScrapperService.Entity.General.HuntingTaskPoints);
                dt.Rows.Add("Permanent Hunting Task Slots", ScrapperService.Entity.General.PermanentHuntingTaskSlots);
                dt.Rows.Add("Permanent Prey Slots", ScrapperService.Entity.General.PermanentPreySlots);

                dtaGridGeneralPart7Info.DataSource = dt;
                dtaGridGeneralPart7Info.BackgroundColor = Color.PapayaWhip;
                Extender.ResizeDtaGrdView(dt, dtaGridGeneralPart7Info);
            });
        }
        public async Task FillGridViewGeneralPart8()
        {
            dtaGridGeneralPart8Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Hirelings", ScrapperService.Entity.General.Hirelings);
                dt.Rows.Add("Hireling Jobs", ScrapperService.Entity.General.HirelingJobs);
                dt.Rows.Add("Hireling Outfits", ScrapperService.Entity.General.HirelingOutfits);

                dtaGridGeneralPart8Info.DataSource = dt;
                dtaGridGeneralPart8Info.BackgroundColor = Color.PapayaWhip;
                Extender.ResizeDtaGrdView(dt, dtaGridGeneralPart8Info);
            });
        }

        private void CharacterSpecificInfoForm_Load(object sender, EventArgs e) => Task.Run(() => ScrapperService.RecoverScrapperDataAsync(this));
        
        public CharacterSpecificInfoForm(string UrlForScrappingPageParam)
        {
            InitializeComponent();
            this.UrlForScrappingPage = UrlForScrappingPageParam;
            ScrapperService = new CharacterSpecificInfoScrapper(UrlForScrappingPageParam);
        }
    }
}
