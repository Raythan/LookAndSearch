using System.Linq;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class WorldsForm : Form
    {
        WorldScrapper ScrapperService = new WorldScrapper();
        public WorldsForm()
        {
            InitializeComponent();
            ScrapperService.RecoverScrapperData();
            lblHoraUltimaAtualizacao.Text = $"Data da última atualização: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
            LoadComponentsData();
        }

        public void LoadComponentsData()
        {
            cboBoxWorldNames.DataSource = null;
            cboBoxWorldNames.DataSource = ScrapperService.DictionaryEntity.Keys.ToList();
        }

        private void cboBoxWorldNames_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dynamic entity = new WebScrapperLib.Models.WorldEntity();
            ScrapperService.DictionaryEntity.TryGetValue(cboBoxWorldNames.Text, out entity);
            txtBoxOnline.Text = entity.Online.ToString();
            txtBoxLocation.Text = entity.Location;
            txtBoxPvpType.Text = entity.PvpType;
            txtBoxAdditionalInformation.Text = entity.AdditionalInformation;

            if (!string.IsNullOrEmpty(entity.BattleEye) && 
                !entity.BattleEye.Equals("nothing"))
            {
                picBoxBattleEye.BorderStyle = BorderStyle.None;
                picBoxBattleEye.Load(LoadBattleEyeIcon(entity.BattleEye));
            }
            else
            {
                picBoxBattleEye.BorderStyle = BorderStyle.FixedSingle;
                picBoxBattleEye.Image = null;
            }
        }

        private string LoadBattleEyeIcon(string pathUrl)
        {
            return $"{Extender.AssemblyDirectory}\\Images\\{pathUrl.Split('/').Last()}";
        }

        private void btnRefreshWorldDictionary_Click(object sender, System.EventArgs e)
        {
            ScrapperService.RecoverScrapperData();
            lblHoraUltimaAtualizacao.Text = $"Data da última atualização: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
            LoadComponentsData();
        }
    }
}
