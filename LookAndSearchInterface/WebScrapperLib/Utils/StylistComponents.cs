using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WebScrapperLib.Utils
{
    public class StylistComponents
    {
        public Dictionary<string, DataGridViewProperties> DataGridViewPropertiesList { get; }
        private List<string> palletsAvailable = new List<string>
        {
            "Blue",
            "Black",
            "Pink",
        };

        public StylistComponents()
        {
            DataGridViewPropertiesList = new Dictionary<string, DataGridViewProperties>();

            foreach (var pallet in palletsAvailable)
            {
                DataGridViewPropertiesList.Add(pallet,
                new DataGridViewProperties(
                    pallet,
                    BorderStyle.None,
                    DataGridViewCellBorderStyle.None,
                    DataGridViewHeaderBorderStyle.None,
                    DataGridViewContentAlignment.MiddleLeft,
                    DataGridViewTriState.False,
                    FontStyle.Regular,
                    false,
                    DataGridViewHeaderBorderStyle.None));
            }
        }
        
        public class DataGridViewProperties
        {
            public Color HeaderBackgroundColor { get; }
            public Color RowBackgroundColor { get; }
            public Color CellBackgroundColor { get; }
            public BorderStyle BorderStyle { get; }
            public DataGridViewCellBorderStyle CellBorderStyle { get; }
            public DataGridViewHeaderBorderStyle ColumnHeadersBorderStyle { get; }
            //public DataGridViewCellStyle ColumnHeadersDefaultCellStyle { get; }
            public DataGridViewCellStyle CellStyle { get; }
            public Dictionary<string, DataGridViewCellStyle> DataGridViewCellStyleList { get; }
            public bool ColumnHeadersVisible { get; }
            public bool RowHeadersVisible { get; }
            public Color HeaderGridColor { get; }
            public Color RowGridColor { get; }
            public Color CellGridColor { get; }
            public DataGridViewHeaderBorderStyle RowHeadersBorderStyle { get; }

            private List<string> palletsColorsAvailable = new List<string>
            {
                "Blue#Header", "Blue#Cell", "Blue#Row",
                "Pink#Header", "Pink#Cell", "Pink#Row",
                "Black#Header", "Black#Cell", "Black#Row",
            };
            public DataGridViewProperties(string palletParam, 
                BorderStyle borderStyle, 
                DataGridViewCellBorderStyle cellBorderStyle,
                DataGridViewHeaderBorderStyle headerBorderStyle,
                DataGridViewContentAlignment headerAlignment,
                DataGridViewTriState wrapMode,
                FontStyle fontStyle,
                bool rowHeadersVisible,
                DataGridViewHeaderBorderStyle rowBorderStyle = DataGridViewHeaderBorderStyle.None)
            {
                DataGridViewCellStyleList = new Dictionary<string, DataGridViewCellStyle>();
                var palletsInternal = palletsColorsAvailable.Where(w => w.Contains($"{palletParam}#"));

                foreach(var palletInternal in palletsInternal)
                {
                    DataGridViewCellStyleList.Add(palletInternal, new DataGridViewCellStyle()
                    {
                        BackColor = DataGridViewHeaderColors.PalletDic[palletInternal][0],
                        Font = new Font("Segoe UI", DataGridViewCellSize.PalletDic[palletInternal], fontStyle),
                        ForeColor = DataGridViewHeaderColors.PalletDic[palletInternal][1],
                        SelectionBackColor = DataGridViewHeaderColors.PalletDic[palletInternal][2],
                        SelectionForeColor = DataGridViewHeaderColors.PalletDic[palletInternal][3],
                        Alignment = headerAlignment,
                        WrapMode = wrapMode
                    });
                }
                
                HeaderBackgroundColor = DataGridViewCellsColors.PalletDic[$"{palletParam}#Header"][0];
                RowBackgroundColor = DataGridViewCellsColors.PalletDic[$"{palletParam}#Row"][0];
                CellBackgroundColor = DataGridViewCellsColors.PalletDic[$"{palletParam}#Cell"][0];
                BorderStyle = borderStyle;
                CellBorderStyle = cellBorderStyle;
                ColumnHeadersBorderStyle = headerBorderStyle;
                HeaderGridColor = DataGridViewCellsColors.PalletDic[$"{palletParam}#Header"][1];
                RowGridColor = DataGridViewCellsColors.PalletDic[$"{palletParam}#Row"][1];
                CellGridColor = DataGridViewCellsColors.PalletDic[$"{palletParam}#Cell"][1];
                RowHeadersBorderStyle = headerBorderStyle;
                RowHeadersVisible = rowHeadersVisible;
            }
        }
    }
}
