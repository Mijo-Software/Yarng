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
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("A");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("B");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("C");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("D");
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("E");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("F");
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem("G");
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem("H");
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("I");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("J");
            System.Windows.Forms.ListViewItem listViewItem37 = new System.Windows.Forms.ListViewItem("K");
            System.Windows.Forms.ListViewItem listViewItem38 = new System.Windows.Forms.ListViewItem("L");
            System.Windows.Forms.ListViewItem listViewItem39 = new System.Windows.Forms.ListViewItem("M");
            System.Windows.Forms.ListViewItem listViewItem40 = new System.Windows.Forms.ListViewItem("N");
            System.Windows.Forms.ListViewItem listViewItem41 = new System.Windows.Forms.ListViewItem("O");
            System.Windows.Forms.ListViewItem listViewItem42 = new System.Windows.Forms.ListViewItem("P");
            System.Windows.Forms.ListViewItem listViewItem43 = new System.Windows.Forms.ListViewItem("Q");
            System.Windows.Forms.ListViewItem listViewItem44 = new System.Windows.Forms.ListViewItem("R");
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem("S");
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem("T");
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem("U");
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem("V");
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem("W");
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem("X");
            System.Windows.Forms.ListViewItem listViewItem51 = new System.Windows.Forms.ListViewItem("Y");
            System.Windows.Forms.ListViewItem listViewItem52 = new System.Windows.Forms.ListViewItem("Z");
            this.listViewCharacters = new System.Windows.Forms.ListView();
            this.columnHeaderCharacter = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderType = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLength = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPercent = new System.Windows.Forms.ColumnHeader();
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
            listViewItem27.StateImageIndex = 0;
            listViewItem47.StateImageIndex = 0;
            this.listViewCharacters.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30,
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36,
            listViewItem37,
            listViewItem38,
            listViewItem39,
            listViewItem40,
            listViewItem41,
            listViewItem42,
            listViewItem43,
            listViewItem44,
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48,
            listViewItem49,
            listViewItem50,
            listViewItem51,
            listViewItem52});
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
            this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
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
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Image = global::Yarng.Properties.Resources.dice_16;
            this.buttonRandomize.Location = new System.Drawing.Point(174, 336);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(75, 32);
            this.buttonRandomize.TabIndex = 3;
            this.buttonRandomize.Text = "&Random";
            this.buttonRandomize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
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