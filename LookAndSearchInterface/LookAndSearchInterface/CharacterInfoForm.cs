using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.Models;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class CharacterInfoForm : Form
    {
        CharacterScrapper ScrapperService;
        public CharacterInfoForm()
        {
            InitializeComponent();
        }

        private void btnCharacterSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxCharacterNameSearch.Text))
            {
                ScrapperService = new CharacterScrapper(txtBoxCharacterNameSearch.Text);
                ScrapperService.RecoverScrapperData();

                if (ScrapperService.CharacterEntity != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Attribute", typeof(string));
                    dt.Columns.Add("Value", typeof(string));
                    BuildDataGridViewByEntity(dt, ScrapperService.CharacterEntity);
                    dtaGridCharacterInformation.DataSource = dt;
                    Extender.ResizeDtaGrdView(dt, dtaGridCharacterInformation);
                }
                else
                {
                    dtaGridCharacterInformation.DataSource = null;
                    dtaGridAchievementInformationList.DataSource = null;
                    dtaGridCharacterInformationList.DataSource = null;
                    dtaGridDeathInformationList.DataSource = null;

                    MessageBox.Show("No data found, please check the name typed.", "No data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                MessageBox.Show("Plase fill the name before query data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BuildDataGridViewByEntity(DataTable dt, object paramObj = null)
        {
            if (paramObj != null)
            {
                foreach (var property in paramObj.GetType().GetProperties())
                {
                    try
                    {
                        if (property.PropertyType == typeof(string))
                            dt.Rows.Add(property.Name, property.GetValue(paramObj));

                        if (property.PropertyType == typeof(List<AchievementType>))
                            BuildDataGridViewByListAttribute(dtaGridAchievementInformationList, property.GetValue(paramObj));

                        if (property.PropertyType == typeof(List<CharacterDeath>))
                            BuildDataGridViewByListAttribute(dtaGridDeathInformationList, property.GetValue(paramObj));

                        if (property.PropertyType == typeof(List<CharacterGrid>))
                            BuildDataGridViewByListAttribute(dtaGridCharacterInformationList, property.GetValue(paramObj));
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private void BuildDataGridViewByListAttribute(DataGridView dtaGrdParam, dynamic paramObjList = null)
        {
            dtaGrdParam.DataSource = null;
            if (paramObjList != null && paramObjList.Count > 0)
            {
                try
                {
                    DataTable dtParam = new DataTable();

                    foreach (var property in paramObjList[0].GetType().GetProperties())
                        dtParam.Columns
                                .Add(((DescriptionAttribute)property.GetCustomAttributes(typeof(DescriptionAttribute), true)[0])
                                .Description, typeof(string));

                    List<KeyValuePair<int, List<string>>> listKeyValuePair = new List<KeyValuePair<int, List<string>>>();
                    int counter = 0;

                    foreach (var paramObj in paramObjList)
                    {
                        List<string> valuePair = new List<string>();
                        foreach (var property in paramObj.GetType().GetProperties())
                            valuePair.Add(property.GetValue(paramObj).ToString());

                        listKeyValuePair.Add(new KeyValuePair<int, List<string>>(counter, valuePair));
                        counter++;
                    }

                    foreach (var item in listKeyValuePair)
                        dtParam.Rows.Add(item.Value.ToArray());

                    dtaGrdParam.DataSource = dtParam;
                    Extender.ResizeDtaGrdView(dtParam, dtaGrdParam);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
