using System.Linq;
using System.Windows.Forms;
using WebScrapperLib;

namespace LookAndSearchInterface
{
    public partial class WorldsForm : Form
    {
        public WorldsForm()
        {
            InitializeComponent();
            WebScrapper.RecoverWorldsData();
            lblHoraUltimaAtualizacao.Text = $"Hora da última atualização: {WebScrapper.LastUpdateWorldEntity.ToString("dd/MM/yyyy HH:mm:ss")}";
            LoadComponentsData();
        }

        public void LoadComponentsData()
        {
            cboBoxWorldNames.DataSource = WebScrapper.DictionaryWorldEntity.Keys.ToList();
        }

        private void cboBoxWorldNames_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            WebScrapperLib.Models.WorldEntity entity = new WebScrapperLib.Models.WorldEntity();
            WebScrapper.DictionaryWorldEntity.TryGetValue(cboBoxWorldNames.Text, out entity);
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
            WebScrapper.RecoverWorldsData();
            lblHoraUltimaAtualizacao.Text = $"Hora da última atualização: {WebScrapper.LastUpdateWorldEntity.ToString("dd/MM/yyyy HH:mm:ss")}";
        }
    }
}
