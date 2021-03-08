using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{  
    public class PanelForAgeRangeWithComboBoxes : Panel
    {
        private const int k_ComboBoxWidth = 80;
        private const string k_LabelComboBoxText = "Age Range";
        private const string k_ComboBoxFromAgeText = "From";
        private const string k_ComboBoxToAgeText = "To";

        public ComboBox ComboBoxFromAge { get; set; }
        
        public ComboBox ComboBoxToAge { get; set; }

        public Label LabelComboBox { get; set; }

        public PanelForAgeRangeWithComboBoxes()
        {
            initializePanel();
        }

        private void initializePanel()
        {
            int yComboBox = 0;
            int xComboBoxToAge = 0;
            this.BackColor = Color.WhiteSmoke;
            ComboBoxFromAge = new ComboBox();
            ComboBoxToAge = new ComboBox();
            LabelComboBox = new Label();
            this.Controls.Add(ComboBoxFromAge);
            this.Controls.Add(ComboBoxToAge);
            this.Controls.Add(LabelComboBox);
            LabelComboBox.Width = LabelComboBox.Width * 2;
            LabelComboBox.Height = LabelComboBox.Height * 2;
            ComboBoxFromAge.Width = k_ComboBoxWidth;
            ComboBoxToAge.Width = k_ComboBoxWidth;
            yComboBox = (this.Location.Y + (this.Height / 2)) - (ComboBoxFromAge.Height / 2);
            ComboBoxFromAge.Location = new Point(0, yComboBox);
            xComboBoxToAge = this.Location.X + this.Width - ComboBoxToAge.Width;
            ComboBoxToAge.Location = new Point(xComboBoxToAge, yComboBox);
            LabelComboBox.Text = k_LabelComboBoxText;
            ComboBoxFromAge.Text = k_ComboBoxFromAgeText;
            ComboBoxToAge.Text = k_ComboBoxToAgeText;
            LabelComboBox.ForeColor = Color.Black;

            ComboBoxFromAge.Items.AddRange(new object[] 
            {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120" 
            });
    
            ComboBoxToAge.Items.AddRange(new object[] 
            {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120" 
            });
        }   
    }
}
