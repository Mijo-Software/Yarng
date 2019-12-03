namespace Yarng
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupMiscellaneous = new System.Windows.Forms.GroupBox();
			this.buttonAbout = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonHistory = new System.Windows.Forms.Button();
			this.buttonHowTo = new System.Windows.Forms.Button();
			this.groupPostProcessing = new System.Windows.Forms.GroupBox();
			this.buttonStepLeft = new System.Windows.Forms.Button();
			this.buttonStepRight = new System.Windows.Forms.Button();
			this.buttonScramble = new System.Windows.Forms.Button();
			this.buttonSort = new System.Windows.Forms.Button();
			this.buttonMirror = new System.Windows.Forms.Button();
			this.progressGenerate = new System.Windows.Forms.ProgressBar();
			this.textList = new System.Windows.Forms.TextBox();
			this.groupSettings = new System.Windows.Forms.GroupBox();
			this.textConsonants = new System.Windows.Forms.TextBox();
			this.labelConsonants = new System.Windows.Forms.Label();
			this.textVowels = new System.Windows.Forms.TextBox();
			this.labelVowels = new System.Windows.Forms.Label();
			this.labelCharacters = new System.Windows.Forms.Label();
			this.numericCharacterLenghtsMax = new System.Windows.Forms.NumericUpDown();
			this.labelCharacterLenghtsMax = new System.Windows.Forms.Label();
			this.numericCharacterLenghtsMin = new System.Windows.Forms.NumericUpDown();
			this.labelCharacterLenghtsMin = new System.Windows.Forms.Label();
			this.labelCharacterLenghts = new System.Windows.Forms.Label();
			this.labelNumberOfNames = new System.Windows.Forms.Label();
			this.numericNumberOfNames = new System.Windows.Forms.NumericUpDown();
			this.buttonShowProbabilityTable = new System.Windows.Forms.Button();
			this.buttonLoadDefaultSettings = new System.Windows.Forms.Button();
			this.labelLanguage = new System.Windows.Forms.Label();
			this.comboLanguage = new System.Windows.Forms.ComboBox();
			this.labelTemplate = new System.Windows.Forms.Label();
			this.buttonSaveTemplate = new System.Windows.Forms.Button();
			this.buttonLoadTemplate = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.contextMenuStripIconThemes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemFatcowIcons = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFugueIcons = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSilkIcons = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonSpeechText = new System.Windows.Forms.Button();
			this.buttonPrintList = new System.Windows.Forms.Button();
			this.buttonExportList = new System.Windows.Forms.Button();
			this.buttonCopyList = new System.Windows.Forms.Button();
			this.buttonClearList = new System.Windows.Forms.Button();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.groupMiscellaneous.SuspendLayout();
			this.groupPostProcessing.SuspendLayout();
			this.groupSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericCharacterLenghtsMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCharacterLenghtsMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericNumberOfNames)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.contextMenuStripIconThemes.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupMiscellaneous
			// 
			this.groupMiscellaneous.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupMiscellaneous.Controls.Add(this.buttonAbout);
			this.groupMiscellaneous.Controls.Add(this.buttonExit);
			this.groupMiscellaneous.Controls.Add(this.buttonHistory);
			this.groupMiscellaneous.Controls.Add(this.buttonHowTo);
			resources.ApplyResources(this.groupMiscellaneous, "groupMiscellaneous");
			this.groupMiscellaneous.Name = "groupMiscellaneous";
			this.groupMiscellaneous.TabStop = false;
			// 
			// buttonAbout
			// 
			this.buttonAbout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonAbout.Image = global::Yarng.Properties.Resources.fatcow_information_16;
			resources.ApplyResources(this.buttonAbout, "buttonAbout");
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.UseVisualStyleBackColor = true;
			this.buttonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
			this.buttonAbout.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonAbout.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonAbout.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonAbout.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonExit
			// 
			this.buttonExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonExit.Image = global::Yarng.Properties.Resources.fatcow_door_16;
			resources.ApplyResources(this.buttonExit, "buttonExit");
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			this.buttonExit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonExit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonExit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonExit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonHistory
			// 
			this.buttonHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonHistory.Image = global::Yarng.Properties.Resources.fatcow_time_16;
			resources.ApplyResources(this.buttonHistory, "buttonHistory");
			this.buttonHistory.Name = "buttonHistory";
			this.buttonHistory.UseVisualStyleBackColor = true;
			this.buttonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
			this.buttonHistory.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonHistory.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonHistory.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonHistory.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonHowTo
			// 
			this.buttonHowTo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonHowTo.Image = global::Yarng.Properties.Resources.fatcow_lightbulb_16;
			resources.ApplyResources(this.buttonHowTo, "buttonHowTo");
			this.buttonHowTo.Name = "buttonHowTo";
			this.buttonHowTo.UseVisualStyleBackColor = true;
			this.buttonHowTo.Click += new System.EventHandler(this.ButtonHowTo_Click);
			this.buttonHowTo.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonHowTo.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonHowTo.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonHowTo.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// groupPostProcessing
			// 
			this.groupPostProcessing.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupPostProcessing.Controls.Add(this.buttonStepLeft);
			this.groupPostProcessing.Controls.Add(this.buttonStepRight);
			this.groupPostProcessing.Controls.Add(this.buttonScramble);
			this.groupPostProcessing.Controls.Add(this.buttonSort);
			this.groupPostProcessing.Controls.Add(this.buttonMirror);
			resources.ApplyResources(this.groupPostProcessing, "groupPostProcessing");
			this.groupPostProcessing.Name = "groupPostProcessing";
			this.groupPostProcessing.TabStop = false;
			// 
			// buttonStepLeft
			// 
			this.buttonStepLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStepLeft.Image = global::Yarng.Properties.Resources.fatcow_arrow_left_16;
			resources.ApplyResources(this.buttonStepLeft, "buttonStepLeft");
			this.buttonStepLeft.Name = "buttonStepLeft";
			this.buttonStepLeft.UseVisualStyleBackColor = true;
			this.buttonStepLeft.Click += new System.EventHandler(this.ButtonStepLeft_Click);
			this.buttonStepLeft.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonStepLeft.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonStepLeft.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonStepLeft.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonStepRight
			// 
			this.buttonStepRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStepRight.Image = global::Yarng.Properties.Resources.fatcow_arrow_right_16;
			resources.ApplyResources(this.buttonStepRight, "buttonStepRight");
			this.buttonStepRight.Name = "buttonStepRight";
			this.buttonStepRight.UseVisualStyleBackColor = true;
			this.buttonStepRight.Click += new System.EventHandler(this.ButtonStepRight_Click);
			this.buttonStepRight.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonStepRight.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonStepRight.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonStepRight.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonScramble
			// 
			this.buttonScramble.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonScramble.Image = global::Yarng.Properties.Resources.fatcow_arrow_switch_16;
			resources.ApplyResources(this.buttonScramble, "buttonScramble");
			this.buttonScramble.Name = "buttonScramble";
			this.buttonScramble.UseVisualStyleBackColor = true;
			this.buttonScramble.Click += new System.EventHandler(this.ButtonScramble_Click);
			this.buttonScramble.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonScramble.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonScramble.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonScramble.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSort
			// 
			this.buttonSort.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSort.Image = global::Yarng.Properties.Resources.fatcow_text_replace_16;
			resources.ApplyResources(this.buttonSort, "buttonSort");
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
			this.buttonSort.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSort.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSort.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSort.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonMirror
			// 
			this.buttonMirror.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonMirror.Image = global::Yarng.Properties.Resources.fatcow_shape_align_center_16;
			resources.ApplyResources(this.buttonMirror, "buttonMirror");
			this.buttonMirror.Name = "buttonMirror";
			this.buttonMirror.UseVisualStyleBackColor = true;
			this.buttonMirror.Click += new System.EventHandler(this.ButtonMirror_Click);
			this.buttonMirror.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMirror.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonMirror.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMirror.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// progressGenerate
			// 
			resources.ApplyResources(this.progressGenerate, "progressGenerate");
			this.progressGenerate.Name = "progressGenerate";
			this.progressGenerate.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// textList
			// 
			this.textList.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			resources.ApplyResources(this.textList, "textList");
			this.textList.Name = "textList";
			this.textList.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textList.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.textList.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textList.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// groupSettings
			// 
			this.groupSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupSettings.Controls.Add(this.textConsonants);
			this.groupSettings.Controls.Add(this.labelConsonants);
			this.groupSettings.Controls.Add(this.textVowels);
			this.groupSettings.Controls.Add(this.labelVowels);
			this.groupSettings.Controls.Add(this.labelCharacters);
			this.groupSettings.Controls.Add(this.numericCharacterLenghtsMax);
			this.groupSettings.Controls.Add(this.labelCharacterLenghtsMax);
			this.groupSettings.Controls.Add(this.numericCharacterLenghtsMin);
			this.groupSettings.Controls.Add(this.labelCharacterLenghtsMin);
			this.groupSettings.Controls.Add(this.labelCharacterLenghts);
			this.groupSettings.Controls.Add(this.labelNumberOfNames);
			this.groupSettings.Controls.Add(this.numericNumberOfNames);
			this.groupSettings.Controls.Add(this.buttonShowProbabilityTable);
			this.groupSettings.Controls.Add(this.buttonLoadDefaultSettings);
			this.groupSettings.Controls.Add(this.labelLanguage);
			this.groupSettings.Controls.Add(this.comboLanguage);
			this.groupSettings.Controls.Add(this.labelTemplate);
			this.groupSettings.Controls.Add(this.buttonSaveTemplate);
			this.groupSettings.Controls.Add(this.buttonLoadTemplate);
			resources.ApplyResources(this.groupSettings, "groupSettings");
			this.groupSettings.Name = "groupSettings";
			this.groupSettings.TabStop = false;
			// 
			// textConsonants
			// 
			resources.ApplyResources(this.textConsonants, "textConsonants");
			this.textConsonants.Name = "textConsonants";
			this.textConsonants.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textConsonants.Leave += new System.EventHandler(this.TextConsonants_Leave);
			this.textConsonants.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textConsonants.MouseLeave += new System.EventHandler(this.TextConsonants_Leave);
			// 
			// labelConsonants
			// 
			this.labelConsonants.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelConsonants, "labelConsonants");
			this.labelConsonants.Name = "labelConsonants";
			this.labelConsonants.DoubleClick += new System.EventHandler(this.LabelConsonants_DoubleClick);
			this.labelConsonants.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelConsonants.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelConsonants.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelConsonants.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// textVowels
			// 
			resources.ApplyResources(this.textVowels, "textVowels");
			this.textVowels.Name = "textVowels";
			this.textVowels.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textVowels.Leave += new System.EventHandler(this.TextVowels_Leave);
			this.textVowels.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textVowels.MouseLeave += new System.EventHandler(this.TextVowels_Leave);
			// 
			// labelVowels
			// 
			this.labelVowels.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelVowels, "labelVowels");
			this.labelVowels.Name = "labelVowels";
			this.labelVowels.DoubleClick += new System.EventHandler(this.LabelVowels_DoubleClick);
			this.labelVowels.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelVowels.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelVowels.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelVowels.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCharacters
			// 
			this.labelCharacters.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelCharacters, "labelCharacters");
			this.labelCharacters.Name = "labelCharacters";
			this.labelCharacters.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCharacters.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCharacters.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCharacters.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericCharacterLenghtsMax
			// 
			this.numericCharacterLenghtsMax.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			resources.ApplyResources(this.numericCharacterLenghtsMax, "numericCharacterLenghtsMax");
			this.numericCharacterLenghtsMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericCharacterLenghtsMax.Name = "numericCharacterLenghtsMax";
			this.numericCharacterLenghtsMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericCharacterLenghtsMax.ValueChanged += new System.EventHandler(this.NumericCharacterLenghtsMax_ValueChanged);
			this.numericCharacterLenghtsMax.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericCharacterLenghtsMax.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCharacterLenghtsMax
			// 
			this.labelCharacterLenghtsMax.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelCharacterLenghtsMax, "labelCharacterLenghtsMax");
			this.labelCharacterLenghtsMax.Name = "labelCharacterLenghtsMax";
			this.labelCharacterLenghtsMax.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCharacterLenghtsMax.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCharacterLenghtsMax.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCharacterLenghtsMax.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericCharacterLenghtsMin
			// 
			this.numericCharacterLenghtsMin.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			resources.ApplyResources(this.numericCharacterLenghtsMin, "numericCharacterLenghtsMin");
			this.numericCharacterLenghtsMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericCharacterLenghtsMin.Name = "numericCharacterLenghtsMin";
			this.numericCharacterLenghtsMin.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numericCharacterLenghtsMin.ValueChanged += new System.EventHandler(this.NumericCharacterLenghtsMin_ValueChanged);
			this.numericCharacterLenghtsMin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericCharacterLenghtsMin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCharacterLenghtsMin
			// 
			this.labelCharacterLenghtsMin.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelCharacterLenghtsMin, "labelCharacterLenghtsMin");
			this.labelCharacterLenghtsMin.Name = "labelCharacterLenghtsMin";
			this.labelCharacterLenghtsMin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCharacterLenghtsMin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCharacterLenghtsMin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCharacterLenghtsMin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCharacterLenghts
			// 
			this.labelCharacterLenghts.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelCharacterLenghts, "labelCharacterLenghts");
			this.labelCharacterLenghts.Name = "labelCharacterLenghts";
			this.labelCharacterLenghts.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCharacterLenghts.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCharacterLenghts.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCharacterLenghts.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNumberOfNames
			// 
			this.labelNumberOfNames.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelNumberOfNames, "labelNumberOfNames");
			this.labelNumberOfNames.Name = "labelNumberOfNames";
			this.labelNumberOfNames.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfNames.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNumberOfNames.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfNames.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericNumberOfNames
			// 
			this.numericNumberOfNames.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			resources.ApplyResources(this.numericNumberOfNames, "numericNumberOfNames");
			this.numericNumberOfNames.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
			this.numericNumberOfNames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericNumberOfNames.Name = "numericNumberOfNames";
			this.numericNumberOfNames.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericNumberOfNames.ValueChanged += new System.EventHandler(this.NumericNumberOfNames_ValueChanged);
			this.numericNumberOfNames.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericNumberOfNames.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonShowProbabilityTable
			// 
			this.buttonShowProbabilityTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonShowProbabilityTable.Image = global::Yarng.Properties.Resources.fatcow_table_16;
			resources.ApplyResources(this.buttonShowProbabilityTable, "buttonShowProbabilityTable");
			this.buttonShowProbabilityTable.Name = "buttonShowProbabilityTable";
			this.buttonShowProbabilityTable.UseVisualStyleBackColor = true;
			this.buttonShowProbabilityTable.Click += new System.EventHandler(this.ButtonShowProbabilityTable_Click);
			this.buttonShowProbabilityTable.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonShowProbabilityTable.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonShowProbabilityTable.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonShowProbabilityTable.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonLoadDefaultSettings
			// 
			this.buttonLoadDefaultSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonLoadDefaultSettings.Image = global::Yarng.Properties.Resources.fatcow_arrow_refresh_16;
			resources.ApplyResources(this.buttonLoadDefaultSettings, "buttonLoadDefaultSettings");
			this.buttonLoadDefaultSettings.Name = "buttonLoadDefaultSettings";
			this.buttonLoadDefaultSettings.UseVisualStyleBackColor = true;
			this.buttonLoadDefaultSettings.Click += new System.EventHandler(this.ButtonLoadDefaultSettings_Click);
			this.buttonLoadDefaultSettings.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonLoadDefaultSettings.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonLoadDefaultSettings.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonLoadDefaultSettings.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLanguage
			// 
			this.labelLanguage.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelLanguage, "labelLanguage");
			this.labelLanguage.Name = "labelLanguage";
			this.labelLanguage.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLanguage.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLanguage.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLanguage.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// comboLanguage
			// 
			this.comboLanguage.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboLanguage.FormattingEnabled = true;
			this.comboLanguage.Items.AddRange(new object[] {
            resources.GetString("comboLanguage.Items"),
            resources.GetString("comboLanguage.Items1"),
            resources.GetString("comboLanguage.Items2"),
            resources.GetString("comboLanguage.Items3"),
            resources.GetString("comboLanguage.Items4"),
            resources.GetString("comboLanguage.Items5"),
            resources.GetString("comboLanguage.Items6"),
            resources.GetString("comboLanguage.Items7"),
            resources.GetString("comboLanguage.Items8"),
            resources.GetString("comboLanguage.Items9")});
			resources.ApplyResources(this.comboLanguage, "comboLanguage");
			this.comboLanguage.Name = "comboLanguage";
			this.comboLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboLanguage_SelectedIndexChanged);
			this.comboLanguage.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.comboLanguage.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.comboLanguage.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.comboLanguage.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTemplate
			// 
			this.labelTemplate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelTemplate, "labelTemplate");
			this.labelTemplate.Name = "labelTemplate";
			this.labelTemplate.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTemplate.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTemplate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTemplate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSaveTemplate
			// 
			this.buttonSaveTemplate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSaveTemplate.Image = global::Yarng.Properties.Resources.fatcow_disk_16;
			resources.ApplyResources(this.buttonSaveTemplate, "buttonSaveTemplate");
			this.buttonSaveTemplate.Name = "buttonSaveTemplate";
			this.buttonSaveTemplate.UseVisualStyleBackColor = true;
			this.buttonSaveTemplate.Click += new System.EventHandler(this.ButtonSaveTemplate_Click);
			this.buttonSaveTemplate.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSaveTemplate.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSaveTemplate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSaveTemplate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonLoadTemplate
			// 
			this.buttonLoadTemplate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonLoadTemplate.Image = global::Yarng.Properties.Resources.fatcow_folder_16;
			resources.ApplyResources(this.buttonLoadTemplate, "buttonLoadTemplate");
			this.buttonLoadTemplate.Name = "buttonLoadTemplate";
			this.buttonLoadTemplate.UseVisualStyleBackColor = true;
			this.buttonLoadTemplate.Click += new System.EventHandler(this.ButtonLoadTemplate_Click);
			this.buttonLoadTemplate.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonLoadTemplate.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonLoadTemplate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonLoadTemplate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.ContextMenuStrip = this.contextMenuStripIconThemes;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			resources.ApplyResources(this.statusStrip, "statusStrip");
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.SizingGrip = false;
			// 
			// contextMenuStripIconThemes
			// 
			this.contextMenuStripIconThemes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFatcowIcons,
            this.toolStripMenuItemFugueIcons,
            this.toolStripMenuItemSilkIcons});
			this.contextMenuStripIconThemes.Name = "contextMenuStrip1";
			this.contextMenuStripIconThemes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			resources.ApplyResources(this.contextMenuStripIconThemes, "contextMenuStripIconThemes");
			this.contextMenuStripIconThemes.TabStop = true;
			// 
			// toolStripMenuItemFatcowIcons
			// 
			this.toolStripMenuItemFatcowIcons.AutoToolTip = true;
			this.toolStripMenuItemFatcowIcons.Checked = true;
			this.toolStripMenuItemFatcowIcons.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemFatcowIcons.Name = "toolStripMenuItemFatcowIcons";
			resources.ApplyResources(this.toolStripMenuItemFatcowIcons, "toolStripMenuItemFatcowIcons");
			this.toolStripMenuItemFatcowIcons.MouseEnter += new System.EventHandler(this.ToolStripMenuItemFatcowIcons_MouseEnter);
			// 
			// toolStripMenuItemFugueIcons
			// 
			this.toolStripMenuItemFugueIcons.AutoToolTip = true;
			this.toolStripMenuItemFugueIcons.Name = "toolStripMenuItemFugueIcons";
			resources.ApplyResources(this.toolStripMenuItemFugueIcons, "toolStripMenuItemFugueIcons");
			this.toolStripMenuItemFugueIcons.MouseEnter += new System.EventHandler(this.ToolStripMenuItemFugueIcons_MouseEnter);
			// 
			// toolStripMenuItemSilkIcons
			// 
			this.toolStripMenuItemSilkIcons.AutoToolTip = true;
			this.toolStripMenuItemSilkIcons.Name = "toolStripMenuItemSilkIcons";
			resources.ApplyResources(this.toolStripMenuItemSilkIcons, "toolStripMenuItemSilkIcons");
			this.toolStripMenuItemSilkIcons.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSilkIcons_MouseEnter);
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.AutoToolTip = true;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
			// 
			// buttonSpeechText
			// 
			this.buttonSpeechText.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSpeechText.Image = global::Yarng.Properties.Resources.fatcow_sound_16;
			resources.ApplyResources(this.buttonSpeechText, "buttonSpeechText");
			this.buttonSpeechText.Name = "buttonSpeechText";
			this.buttonSpeechText.UseVisualStyleBackColor = true;
			this.buttonSpeechText.Click += new System.EventHandler(this.ButtonSpeechText_Click);
			this.buttonSpeechText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSpeechText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSpeechText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSpeechText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonPrintList
			// 
			this.buttonPrintList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonPrintList.Image = global::Yarng.Properties.Resources.fatcow_printer_16;
			resources.ApplyResources(this.buttonPrintList, "buttonPrintList");
			this.buttonPrintList.Name = "buttonPrintList";
			this.buttonPrintList.UseVisualStyleBackColor = true;
			this.buttonPrintList.Click += new System.EventHandler(this.ButtonPrintList_Click);
			this.buttonPrintList.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonPrintList.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonPrintList.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonPrintList.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonExportList
			// 
			this.buttonExportList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonExportList.Image = global::Yarng.Properties.Resources.fatcow_document_export_16;
			resources.ApplyResources(this.buttonExportList, "buttonExportList");
			this.buttonExportList.Name = "buttonExportList";
			this.buttonExportList.UseVisualStyleBackColor = true;
			this.buttonExportList.Click += new System.EventHandler(this.ButtonExportList_Click);
			this.buttonExportList.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonExportList.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonExportList.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonExportList.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCopyList
			// 
			this.buttonCopyList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCopyList.Image = global::Yarng.Properties.Resources.fatcow_paste_plain_16;
			resources.ApplyResources(this.buttonCopyList, "buttonCopyList");
			this.buttonCopyList.Name = "buttonCopyList";
			this.buttonCopyList.UseVisualStyleBackColor = true;
			this.buttonCopyList.Click += new System.EventHandler(this.ButtonCopyList_Click);
			this.buttonCopyList.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyList.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCopyList.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyList.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonClearList
			// 
			this.buttonClearList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClearList.Image = global::Yarng.Properties.Resources.fatcow_page_white_16;
			resources.ApplyResources(this.buttonClearList, "buttonClearList");
			this.buttonClearList.Name = "buttonClearList";
			this.buttonClearList.UseVisualStyleBackColor = true;
			this.buttonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
			this.buttonClearList.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonClearList.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonClearList.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonClearList.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			resources.ApplyResources(this.buttonGenerate, "buttonGenerate");
			this.buttonGenerate.Image = global::Yarng.Properties.Resources.fatcow_resultset_next_16;
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
			this.buttonGenerate.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGenerate.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonGenerate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGenerate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// MainForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonSpeechText);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.groupSettings);
			this.Controls.Add(this.textList);
			this.Controls.Add(this.progressGenerate);
			this.Controls.Add(this.groupPostProcessing);
			this.Controls.Add(this.groupMiscellaneous);
			this.Controls.Add(this.buttonPrintList);
			this.Controls.Add(this.buttonExportList);
			this.Controls.Add(this.buttonCopyList);
			this.Controls.Add(this.buttonClearList);
			this.Controls.Add(this.buttonGenerate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupMiscellaneous.ResumeLayout(false);
			this.groupPostProcessing.ResumeLayout(false);
			this.groupSettings.ResumeLayout(false);
			this.groupSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericCharacterLenghtsMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCharacterLenghtsMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericNumberOfNames)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.contextMenuStripIconThemes.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonExportList;
        private System.Windows.Forms.Button buttonCopyList;
        private System.Windows.Forms.Button buttonPrintList;
        private System.Windows.Forms.Button buttonScramble;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonMirror;
        private System.Windows.Forms.Button buttonStepRight;
        private System.Windows.Forms.Button buttonStepLeft;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonHowTo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupMiscellaneous;
        private System.Windows.Forms.GroupBox groupPostProcessing;
        private System.Windows.Forms.ProgressBar progressGenerate;
        private System.Windows.Forms.TextBox textList;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.Button buttonShowProbabilityTable;
        private System.Windows.Forms.Button buttonLoadDefaultSettings;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.Button buttonSaveTemplate;
        private System.Windows.Forms.Button buttonLoadTemplate;
        private System.Windows.Forms.NumericUpDown numericNumberOfNames;
        private System.Windows.Forms.NumericUpDown numericCharacterLenghtsMax;
        private System.Windows.Forms.Label labelCharacterLenghtsMax;
        private System.Windows.Forms.NumericUpDown numericCharacterLenghtsMin;
        private System.Windows.Forms.Label labelCharacterLenghtsMin;
        private System.Windows.Forms.Label labelCharacterLenghts;
        private System.Windows.Forms.Label labelNumberOfNames;
        private System.Windows.Forms.TextBox textConsonants;
        private System.Windows.Forms.Label labelConsonants;
        private System.Windows.Forms.TextBox textVowels;
        private System.Windows.Forms.Label labelVowels;
        private System.Windows.Forms.Label labelCharacters;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.Button buttonSpeechText;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripIconThemes;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFatcowIcons;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFugueIcons;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSilkIcons;
	}
}

