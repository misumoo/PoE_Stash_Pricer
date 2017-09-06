using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_Stash_Pricer
{
    public partial class Form1 : Form
    {
        String sAccountName;
        String sCharacterName;
        String sGetEquippedUrl = "https://www.pathofexile.com/character-window/get-items";
        bool dev = true;

        public Form1()
        {
            InitializeComponent();
            if(dev)
            {
                txt_AccountName.Text = "Misumoo";
                txt_CharacterName.Text = "PeriodBloodEnema";
            }
        }
        
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Query API
            //https://www.pathofexile.com/character-window/get-items?character=PeriodBloodEnema&accountName=Misumoo
            sAccountName = txt_AccountName.Text;
            sCharacterName = txt_CharacterName.Text;
            string sEquipped = sGetEquippedUrl + "?accountName=" + sAccountName + "&character=" + sCharacterName;
            txt_Information.Text = sEquipped;

            Character c = new Character();
            c.Helmet = "test";
            txt_Information.Text += "\r\n" + c.Helmet;
        }

    }
    public class Character
    {
        Object helmet;
        Object armor;
        Object weapon1;
        Object weapon2;
        Object weapon3;
        Object weapon4;
        Object necklace;
        Object ringLeft;
        Object ringRight;
        Object gloves;
        Object belt;
        Object boots;
        Object flask1;
        Object flask2;
        Object flask3;
        Object flask4;
        Object flask5;

        public object Helmet { get => helmet; set => helmet = value; }
        public object Armor { get => armor; set => armor = value; }
        public object Weapon1 { get => weapon1; set => weapon1 = value; }
        public object Weapon2 { get => weapon2; set => weapon2 = value; }
        public object Weapon3 { get => weapon3; set => weapon3 = value; }
        public object Weapon4 { get => weapon4; set => weapon4 = value; }
        public object Necklace { get => necklace; set => necklace = value; }
        public object RingLeft { get => ringLeft; set => ringLeft = value; }
        public object RingRight { get => ringRight; set => ringRight = value; }
        public object Gloves { get => gloves; set => gloves = value; }
        public object Belt { get => belt; set => belt = value; }
        public object Boots { get => boots; set => boots = value; }
        public object Flask1 { get => flask1; set => flask1 = value; }
        public object Flask2 { get => flask2; set => flask2 = value; }
        public object Flask3 { get => flask3; set => flask3 = value; }
        public object Flask4 { get => flask4; set => flask4 = value; }
        public object Flask5 { get => flask5; set => flask5 = value; }
    }
}
