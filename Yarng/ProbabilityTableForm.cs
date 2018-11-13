using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yarng
{
    public partial class ProbabilityTableForm : Form
    {
        public ProbabilityTableForm()
        {
            InitializeComponent();
        }

        private void ProbabilityTableForm_Load(object sender, EventArgs e)
        {
            listViewCharacters.Clear();

            /*ListViewGroup listViewGroupVowels = new ListViewGroup("Vowels", HorizontalAlignment.Left);
            ListViewGroup listViewGroupConsonants = new ListViewGroup("Consonants", HorizontalAlignment.Left);*/
            ColumnHeader columnHeaderCharacter = new ColumnHeader();
            ColumnHeader columnHeaderType = new ColumnHeader();
            ColumnHeader columnHeaderLength = new ColumnHeader();
            ColumnHeader columnHeaderPercent = new ColumnHeader();
            columnHeaderCharacter.Text = "Character";
            columnHeaderType.Text = "Type";
            columnHeaderType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeaderType.Width = 39;
            columnHeaderLength.Text = "Length";
            columnHeaderLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeaderLength.Width = 45;
            columnHeaderPercent.Text = "Percent";
            columnHeaderPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeaderPercent.Width = 50;
            
            //listViewCharacters.Activation = ItemActivation.OneClick;
            listViewCharacters.GridLines = true;
            
            listViewCharacters.Columns.AddRange(new ColumnHeader[] { columnHeaderCharacter, columnHeaderType, columnHeaderLength, columnHeaderPercent });
            //listViewCharacters.Groups.AddRange(new ListViewGroup[] { listViewGroupVowels, listViewGroupConsonants });

            ListViewItem itemCharacterA = new ListViewItem("A");
            itemCharacterA.SubItems.Add("V");
            itemCharacterA.SubItems.Add("10");
            itemCharacterA.SubItems.Add("_");
            ListViewItem itemCharacterB = new ListViewItem("B");
            itemCharacterB.SubItems.Add("C");
            itemCharacterB.SubItems.Add("10");
            itemCharacterB.SubItems.Add("_");
            ListViewItem itemCharacterC = new ListViewItem("C");
            itemCharacterC.SubItems.Add("C");
            itemCharacterC.SubItems.Add("10");
            itemCharacterC.SubItems.Add("_");
            ListViewItem itemCharacterD = new ListViewItem("D");
            itemCharacterD.SubItems.Add("C");
            itemCharacterD.SubItems.Add("10");
            itemCharacterD.SubItems.Add("_");
            ListViewItem itemCharacterE = new ListViewItem("E");
            itemCharacterE.SubItems.Add("V");
            itemCharacterE.SubItems.Add("10");
            itemCharacterE.SubItems.Add("_");
            ListViewItem itemCharacterF = new ListViewItem("F");
            itemCharacterF.SubItems.Add("C");
            itemCharacterF.SubItems.Add("10");
            itemCharacterF.SubItems.Add("_");
            ListViewItem itemCharacterG = new ListViewItem("G");
            itemCharacterG.SubItems.Add("C");
            itemCharacterG.SubItems.Add("10");
            itemCharacterG.SubItems.Add("_");
            ListViewItem itemCharacterH = new ListViewItem("H");
            itemCharacterH.SubItems.Add("C");
            itemCharacterH.SubItems.Add("10");
            itemCharacterH.SubItems.Add("_");
            ListViewItem itemCharacterI = new ListViewItem("I");
            itemCharacterI.SubItems.Add("V");
            itemCharacterI.SubItems.Add("10");
            itemCharacterI.SubItems.Add("_");
            ListViewItem itemCharacterJ = new ListViewItem("J");
            itemCharacterJ.SubItems.Add("C");
            itemCharacterJ.SubItems.Add("10");
            itemCharacterJ.SubItems.Add("_");
            ListViewItem itemCharacterK = new ListViewItem("K");
            itemCharacterK.SubItems.Add("C");
            itemCharacterK.SubItems.Add("10");
            itemCharacterK.SubItems.Add("_");
            ListViewItem itemCharacterL = new ListViewItem("L");
            itemCharacterL.SubItems.Add("C");
            itemCharacterL.SubItems.Add("10");
            itemCharacterL.SubItems.Add("_");
            ListViewItem itemCharacterM = new ListViewItem("M");
            itemCharacterM.SubItems.Add("C");
            itemCharacterM.SubItems.Add("10");
            itemCharacterM.SubItems.Add("_");
            ListViewItem itemCharacterN = new ListViewItem("N");
            itemCharacterN.SubItems.Add("C");
            itemCharacterN.SubItems.Add("10");
            itemCharacterN.SubItems.Add("_");
            ListViewItem itemCharacterO = new ListViewItem("O");
            itemCharacterO.SubItems.Add("V");
            itemCharacterO.SubItems.Add("10");
            itemCharacterO.SubItems.Add("_");
            ListViewItem itemCharacterP = new ListViewItem("P");
            itemCharacterP.SubItems.Add("C");
            itemCharacterP.SubItems.Add("10");
            itemCharacterP.SubItems.Add("_");
            ListViewItem itemCharacterQ = new ListViewItem("Q");
            itemCharacterQ.SubItems.Add("C");
            itemCharacterQ.SubItems.Add("10");
            itemCharacterQ.SubItems.Add("_");
            ListViewItem itemCharacterR = new ListViewItem("R");
            itemCharacterR.SubItems.Add("C");
            itemCharacterR.SubItems.Add("10");
            itemCharacterR.SubItems.Add("_");
            ListViewItem itemCharacterS = new ListViewItem("S");
            itemCharacterS.SubItems.Add("C");
            itemCharacterS.SubItems.Add("10");
            itemCharacterS.SubItems.Add("_");
            ListViewItem itemCharacterT = new ListViewItem("T");
            itemCharacterT.SubItems.Add("C");
            itemCharacterT.SubItems.Add("10");
            itemCharacterT.SubItems.Add("_");
            ListViewItem itemCharacterU = new ListViewItem("U");
            itemCharacterU.SubItems.Add("V");
            itemCharacterU.SubItems.Add("10");
            itemCharacterU.SubItems.Add("_");
            ListViewItem itemCharacterV = new ListViewItem("V");
            itemCharacterV.SubItems.Add("C");
            itemCharacterV.SubItems.Add("10");
            itemCharacterV.SubItems.Add("_");
            ListViewItem itemCharacterW = new ListViewItem("W");
            itemCharacterW.SubItems.Add("C");
            itemCharacterW.SubItems.Add("10");
            itemCharacterW.SubItems.Add("_");
            ListViewItem itemCharacterX = new ListViewItem("X");
            itemCharacterX.SubItems.Add("C");
            itemCharacterX.SubItems.Add("10");
            itemCharacterX.SubItems.Add("_");
            ListViewItem itemCharacterY = new ListViewItem("Y");
            itemCharacterY.SubItems.Add("C");
            itemCharacterY.SubItems.Add("10");
            itemCharacterY.SubItems.Add("_");
            ListViewItem itemCharacterZ = new ListViewItem("Z");
            itemCharacterZ.SubItems.Add("C");
            itemCharacterZ.SubItems.Add("10");
            itemCharacterZ.SubItems.Add("_");
            listViewCharacters.Items.AddRange(new ListViewItem[] { itemCharacterA, itemCharacterB, itemCharacterC, itemCharacterD, itemCharacterE, itemCharacterF, itemCharacterG, itemCharacterH, itemCharacterI, itemCharacterJ, itemCharacterK, itemCharacterL, itemCharacterM, itemCharacterN, itemCharacterO, itemCharacterP, itemCharacterQ, itemCharacterR, itemCharacterS, itemCharacterT, itemCharacterU, itemCharacterV, itemCharacterW, itemCharacterX, itemCharacterY, itemCharacterZ });
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {

        }


    }
}