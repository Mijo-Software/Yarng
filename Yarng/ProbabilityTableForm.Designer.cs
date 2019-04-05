namespace Yarng
{
    partial class ProbabilityTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("A");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("B");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("C");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("D");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("E");
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("F");
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("G");
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("H");
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("I");
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("J");
			System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("K");
			System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("L");
			System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("M");
			System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("N");
			System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("O");
			System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("P");
			System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Q");
			System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("R");
			System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("S");
			System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("T");
			System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("U");
			System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("V");
			System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("W");
			System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("X");
			System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Y");
			System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Z");
			this.listViewCharacters = new System.Windows.Forms.ListView();
			this.columnHeaderCharacter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonRandomize = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listViewCharacters
			// 
			this.listViewCharacters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCharacter,
            this.columnHeaderType,
            this.columnHeaderLength,
            this.columnHeaderPercent});
			this.listViewCharacters.GridLines = true;
			this.listViewCharacters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			listViewItem1.StateImageIndex = 0;
			listViewItem21.StateImageIndex = 0;
			this.listViewCharacters.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26});
			this.listViewCharacters.LabelEdit = true;
			this.listViewCharacters.Location = new System.Drawing.Point(12, 12);
			this.listViewCharacters.MultiSelect = false;
			this.listViewCharacters.Name = "listViewCharacters";
			this.listViewCharacters.ShowGroups = false;
			this.listViewCharacters.Size = new System.Drawing.Size(237, 318);
			this.listViewCharacters.TabIndex = 0;
			this.listViewCharacters.UseCompatibleStateImageBehavior = false;
			this.listViewCharacters.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderCharacter
			// 
			this.columnHeaderCharacter.Text = "Character";
			// 
			// columnHeaderType
			// 
			this.columnHeaderType.Text = "Type";
			this.columnHeaderType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderType.Width = 39;
			// 
			// columnHeaderLength
			// 
			this.columnHeaderLength.Text = "Length";
			this.columnHeaderLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderLength.Width = 45;
			// 
			// columnHeaderPercent
			// 
			this.columnHeaderPercent.Text = "Percent";
			this.columnHeaderPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderPercent.Width = 50;
			// 
			// buttonApply
			// 
			this.buttonApply.Image = global::Yarng.Properties.Resources.accept_16;
			this.buttonApply.Location = new System.Drawing.Point(12, 336);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 32);
			this.buttonApply.TabIndex = 1;
			this.buttonApply.Text = "&Apply";
			this.buttonApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Image = global::Yarng.Properties.Resources.cancel_16;
			this.buttonCancel.Location = new System.Drawing.Point(93, 336);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 32);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// buttonRandomize
			// 
			this.buttonRandomize.Image = global::Yarng.Properties.Resources.dice_16;
			this.buttonRandomize.Location = new System.Drawing.Point(174, 336);
			this.buttonRandomize.Name = "buttonRandomize";
			this.buttonRandomize.Size = new System.Drawing.Size(75, 32);
			this.buttonRandomize.TabIndex = 3;
			this.buttonRandomize.Text = "&Random";
			this.buttonRandomize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonRandomize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonRandomize.UseVisualStyleBackColor = true;
			this.buttonRandomize.Click += new System.EventHandler(this.ButtonRandomize_Click);
			// 
			// ProbabilityTableForm
			// 
			this.AcceptButton = this.buttonApply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(538, 380);
			this.Controls.Add(this.buttonRandomize);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.listViewCharacters);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProbabilityTableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProbabilityTableForm";
			this.Load += new System.EventHandler(this.ProbabilityTableForm_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCharacters;
        private System.Windows.Forms.ColumnHeader columnHeaderCharacter;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderLength;
        private System.Windows.Forms.ColumnHeader columnHeaderPercent;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRandomize;
    }
}