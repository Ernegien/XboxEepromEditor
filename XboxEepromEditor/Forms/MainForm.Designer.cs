using System;
using System.Windows.Forms;
using XboxEepromEditor.Extensions;
using XboxEepromEditor.Types;

namespace XboxEepromEditor.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvAudio = new System.Windows.Forms.ListView();
            this.lvVideo = new System.Windows.Forms.ListView();
            this.chkDst = new System.Windows.Forms.CheckBox();
            this.cmbDvdZone = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvRegions = new System.Windows.Forms.ListView();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfounder = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHddKey = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.tabSections = new System.Windows.Forms.TabControl();
            this.tabFactory = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVideoStandard = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOnlineKey = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMacAddress = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerial = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabParental = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbPass4 = new System.Windows.Forms.ComboBox();
            this.cmbPass3 = new System.Windows.Forms.ComboBox();
            this.cmbPass2 = new System.Windows.Forms.ComboBox();
            this.cmbPass1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbMaxMovieRating = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbMaxGameRating = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabLive = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLiveSubnet = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLiveGateway = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLiveDns = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLiveAddress = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabUnknown1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtUnknownF4 = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtUnknownC0 = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtPadding80 = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPadding70 = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPadding56 = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPadding46 = new XboxEepromEditor.Controls.ValidatedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabUnknown2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lvUnknownFC = new System.Windows.Forms.ListView();
            this.label29 = new System.Windows.Forms.Label();
            this.lvUnknownF8 = new System.Windows.Forms.ListView();
            this.label28 = new System.Windows.Forms.Label();
            this.lvUnknownB8 = new System.Windows.Forms.ListView();
            this.label27 = new System.Windows.Forms.Label();
            this.mnuArduionoProm = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSections.SuspendLayout();
            this.tabFactory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabParental.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabLive.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabUnknown1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabUnknown2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuArduionoProm,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSaveAs,
            this.mnuExportTxt,
            this.mnuReset,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(130, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(130, 22);
            this.mnuSaveAs.Text = "Save As";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // mnuExportTxt
            // 
            this.mnuExportTxt.Name = "mnuExportTxt";
            this.mnuExportTxt.Size = new System.Drawing.Size(130, 22);
            this.mnuExportTxt.Text = "Export TXT";
            this.mnuExportTxt.Click += new System.EventHandler(this.mnuExportTxt_Click);
            // 
            // mnuReset
            // 
            this.mnuReset.Name = "mnuReset";
            this.mnuReset.Size = new System.Drawing.Size(130, 22);
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.mnuReset_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(130, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 297);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupBox3);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(391, 269);
            this.tabGeneral.TabIndex = 2;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvAudio);
            this.groupBox3.Controls.Add(this.lvVideo);
            this.groupBox3.Controls.Add(this.chkDst);
            this.groupBox3.Controls.Add(this.cmbDvdZone);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmbLanguage);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbTimeZone);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 236);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Settings";
            // 
            // lvAudio
            // 
            this.lvAudio.CheckBoxes = true;
            this.lvAudio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAudio.HideSelection = false;
            this.lvAudio.LabelWrap = false;
            this.lvAudio.Location = new System.Drawing.Point(105, 168);
            this.lvAudio.Name = "lvAudio";
            this.lvAudio.Size = new System.Drawing.Size(166, 58);
            this.lvAudio.TabIndex = 45;
            this.lvAudio.UseCompatibleStateImageBehavior = false;
            this.lvAudio.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvVideo
            // 
            this.lvVideo.CheckBoxes = true;
            this.lvVideo.HideSelection = false;
            this.lvVideo.LabelWrap = false;
            this.lvVideo.Location = new System.Drawing.Point(105, 104);
            this.lvVideo.Name = "lvVideo";
            this.lvVideo.Size = new System.Drawing.Size(166, 58);
            this.lvVideo.TabIndex = 44;
            this.lvVideo.UseCompatibleStateImageBehavior = false;
            this.lvVideo.View = System.Windows.Forms.View.SmallIcon;
            // 
            // chkDst
            // 
            this.chkDst.AutoSize = true;
            this.chkDst.Enabled = false;
            this.chkDst.Location = new System.Drawing.Point(278, 26);
            this.chkDst.Name = "chkDst";
            this.chkDst.Size = new System.Drawing.Size(48, 17);
            this.chkDst.TabIndex = 43;
            this.chkDst.Text = "DST";
            this.chkDst.UseVisualStyleBackColor = true;
            // 
            // cmbDvdZone
            // 
            this.cmbDvdZone.DisplayMember = "Text";
            this.cmbDvdZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDvdZone.FormattingEnabled = true;
            this.cmbDvdZone.Location = new System.Drawing.Point(105, 50);
            this.cmbDvdZone.Name = "cmbDvdZone";
            this.cmbDvdZone.Size = new System.Drawing.Size(166, 21);
            this.cmbDvdZone.TabIndex = 42;
            this.cmbDvdZone.ValueMember = "Value";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "DVD Zone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Audio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Video:";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DisplayMember = "Text";
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(105, 77);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(166, 21);
            this.cmbLanguage.TabIndex = 28;
            this.cmbLanguage.ValueMember = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Language:";
            // 
            // cmbTimeZone
            // 
            this.cmbTimeZone.DisplayMember = "Text";
            this.cmbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeZone.Enabled = false;
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Location = new System.Drawing.Point(105, 23);
            this.cmbTimeZone.Name = "cmbTimeZone";
            this.cmbTimeZone.Size = new System.Drawing.Size(166, 21);
            this.cmbTimeZone.TabIndex = 26;
            this.cmbTimeZone.ValueMember = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Time Zone:";
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.groupBox1);
            this.tabSecurity.Location = new System.Drawing.Point(4, 22);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecurity.Size = new System.Drawing.Size(391, 269);
            this.tabSecurity.TabIndex = 0;
            this.tabSecurity.Text = "Security";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvRegions);
            this.groupBox1.Controls.Add(this.cmbVersion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtConfounder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHddKey);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 185);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security Settings (CAUTION)";
            // 
            // lvRegions
            // 
            this.lvRegions.CheckBoxes = true;
            this.lvRegions.HideSelection = false;
            this.lvRegions.LabelWrap = false;
            this.lvRegions.Location = new System.Drawing.Point(105, 102);
            this.lvRegions.Name = "lvRegions";
            this.lvRegions.ShowItemToolTips = true;
            this.lvRegions.Size = new System.Drawing.Size(133, 75);
            this.lvRegions.TabIndex = 25;
            this.lvRegions.UseCompatibleStateImageBehavior = false;
            this.lvRegions.View = System.Windows.Forms.View.SmallIcon;
            // 
            // cmbVersion
            // 
            this.cmbVersion.DisplayMember = "Text";
            this.cmbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Location = new System.Drawing.Point(105, 23);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(103, 21);
            this.cmbVersion.TabIndex = 24;
            this.cmbVersion.ValueMember = "Value";
            this.cmbVersion.SelectedIndexChanged += new System.EventHandler(this.cmbVersion_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Hardware Type:";
            // 
            // txtConfounder
            // 
            this.txtConfounder.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfounder.CharacterRegex = "[0-9A-F]";
            this.txtConfounder.ExactLengthRequired = 16;
            this.txtConfounder.ForceUpperCase = true;
            this.txtConfounder.InvalidColor = System.Drawing.Color.Yellow;
            this.txtConfounder.Location = new System.Drawing.Point(105, 50);
            this.txtConfounder.MaxLength = 16;
            this.txtConfounder.Name = "txtConfounder";
            this.txtConfounder.Size = new System.Drawing.Size(134, 20);
            this.txtConfounder.TabIndex = 3;
            this.txtConfounder.Text = "DDDDDDDDDDDDDDDD";
            this.txtConfounder.TextRegex = "[0-9A-F]+";
            this.txtConfounder.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confounder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Region:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HDD Key:";
            // 
            // txtHddKey
            // 
            this.txtHddKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtHddKey.CharacterRegex = "[0-9A-F]";
            this.txtHddKey.ExactLengthRequired = 32;
            this.txtHddKey.ForceUpperCase = true;
            this.txtHddKey.InvalidColor = System.Drawing.Color.Yellow;
            this.txtHddKey.Location = new System.Drawing.Point(105, 76);
            this.txtHddKey.MaxLength = 32;
            this.txtHddKey.Name = "txtHddKey";
            this.txtHddKey.Size = new System.Drawing.Size(262, 20);
            this.txtHddKey.TabIndex = 5;
            this.txtHddKey.Text = "DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD";
            this.txtHddKey.TextRegex = "[0-9A-F]+";
            this.txtHddKey.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // tabSections
            // 
            this.tabSections.Controls.Add(this.tabSecurity);
            this.tabSections.Controls.Add(this.tabFactory);
            this.tabSections.Controls.Add(this.tabGeneral);
            this.tabSections.Controls.Add(this.tabParental);
            this.tabSections.Controls.Add(this.tabLive);
            this.tabSections.Controls.Add(this.tabUnknown1);
            this.tabSections.Controls.Add(this.tabUnknown2);
            this.tabSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSections.Location = new System.Drawing.Point(0, 24);
            this.tabSections.Name = "tabSections";
            this.tabSections.SelectedIndex = 0;
            this.tabSections.Size = new System.Drawing.Size(399, 295);
            this.tabSections.TabIndex = 0;
            // 
            // tabFactory
            // 
            this.tabFactory.Controls.Add(this.groupBox2);
            this.tabFactory.Location = new System.Drawing.Point(4, 22);
            this.tabFactory.Name = "tabFactory";
            this.tabFactory.Size = new System.Drawing.Size(391, 269);
            this.tabFactory.TabIndex = 3;
            this.tabFactory.Text = "Factory";
            this.tabFactory.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmbVideoStandard);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtOnlineKey);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMacAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSerial);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 130);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factory Settings (CAUTION)";
            // 
            // cmbVideoStandard
            // 
            this.cmbVideoStandard.DisplayMember = "Text";
            this.cmbVideoStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoStandard.FormattingEnabled = true;
            this.cmbVideoStandard.Items.AddRange(new object[] {
            "NTSC-M",
            "NTSC-J",
            "PAL-I",
            "PAL-M"});
            this.cmbVideoStandard.Location = new System.Drawing.Point(105, 100);
            this.cmbVideoStandard.Name = "cmbVideoStandard";
            this.cmbVideoStandard.Size = new System.Drawing.Size(103, 21);
            this.cmbVideoStandard.TabIndex = 22;
            this.cmbVideoStandard.ValueMember = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Video Standard:";
            // 
            // txtOnlineKey
            // 
            this.txtOnlineKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtOnlineKey.CharacterRegex = "[0-9A-F]";
            this.txtOnlineKey.ExactLengthRequired = 32;
            this.txtOnlineKey.ForceUpperCase = true;
            this.txtOnlineKey.InvalidColor = System.Drawing.Color.Yellow;
            this.txtOnlineKey.Location = new System.Drawing.Point(105, 74);
            this.txtOnlineKey.MaxLength = 32;
            this.txtOnlineKey.Name = "txtOnlineKey";
            this.txtOnlineKey.Size = new System.Drawing.Size(262, 20);
            this.txtOnlineKey.TabIndex = 20;
            this.txtOnlineKey.Text = "DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD";
            this.txtOnlineKey.TextRegex = "[0-9A-F]+";
            this.txtOnlineKey.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Online Key:";
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtMacAddress.CharacterRegex = "[0-9A-F]";
            this.txtMacAddress.ExactLengthRequired = 12;
            this.txtMacAddress.ForceUpperCase = true;
            this.txtMacAddress.InvalidColor = System.Drawing.Color.Yellow;
            this.txtMacAddress.Location = new System.Drawing.Point(105, 48);
            this.txtMacAddress.MaxLength = 12;
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(103, 20);
            this.txtMacAddress.TabIndex = 18;
            this.txtMacAddress.Text = "DDDDDDDDDDDD";
            this.txtMacAddress.TextRegex = "[0-9A-F]+";
            this.txtMacAddress.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "MAC Address:";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerial.CharacterRegex = "[0-9]";
            this.txtSerial.ExactLengthRequired = 12;
            this.txtSerial.ForceUpperCase = false;
            this.txtSerial.InvalidColor = System.Drawing.Color.Yellow;
            this.txtSerial.Location = new System.Drawing.Point(105, 22);
            this.txtSerial.MaxLength = 12;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(103, 20);
            this.txtSerial.TabIndex = 16;
            this.txtSerial.Text = "000000000000";
            this.txtSerial.TextRegex = "[0-9]+";
            this.txtSerial.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Serial:";
            // 
            // tabParental
            // 
            this.tabParental.Controls.Add(this.groupBox4);
            this.tabParental.Location = new System.Drawing.Point(4, 22);
            this.tabParental.Name = "tabParental";
            this.tabParental.Size = new System.Drawing.Size(391, 269);
            this.tabParental.TabIndex = 4;
            this.tabParental.Text = "Parental";
            this.tabParental.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cmbPass4);
            this.groupBox4.Controls.Add(this.cmbPass3);
            this.groupBox4.Controls.Add(this.cmbPass2);
            this.groupBox4.Controls.Add(this.cmbPass1);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cmbMaxMovieRating);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.cmbMaxGameRating);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 106);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parental Control Settings";
            // 
            // cmbPass4
            // 
            this.cmbPass4.DisplayMember = "Text";
            this.cmbPass4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPass4.FormattingEnabled = true;
            this.cmbPass4.Location = new System.Drawing.Point(303, 77);
            this.cmbPass4.Name = "cmbPass4";
            this.cmbPass4.Size = new System.Drawing.Size(60, 21);
            this.cmbPass4.TabIndex = 41;
            this.cmbPass4.ValueMember = "Value";
            // 
            // cmbPass3
            // 
            this.cmbPass3.DisplayMember = "Text";
            this.cmbPass3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPass3.FormattingEnabled = true;
            this.cmbPass3.Location = new System.Drawing.Point(237, 77);
            this.cmbPass3.Name = "cmbPass3";
            this.cmbPass3.Size = new System.Drawing.Size(60, 21);
            this.cmbPass3.TabIndex = 40;
            this.cmbPass3.ValueMember = "Value";
            // 
            // cmbPass2
            // 
            this.cmbPass2.DisplayMember = "Text";
            this.cmbPass2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPass2.FormattingEnabled = true;
            this.cmbPass2.Location = new System.Drawing.Point(171, 77);
            this.cmbPass2.Name = "cmbPass2";
            this.cmbPass2.Size = new System.Drawing.Size(60, 21);
            this.cmbPass2.TabIndex = 39;
            this.cmbPass2.ValueMember = "Value";
            // 
            // cmbPass1
            // 
            this.cmbPass1.DisplayMember = "Text";
            this.cmbPass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPass1.FormattingEnabled = true;
            this.cmbPass1.Location = new System.Drawing.Point(105, 77);
            this.cmbPass1.Name = "cmbPass1";
            this.cmbPass1.Size = new System.Drawing.Size(60, 21);
            this.cmbPass1.TabIndex = 38;
            this.cmbPass1.ValueMember = "Value";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Passcode:";
            // 
            // cmbMaxMovieRating
            // 
            this.cmbMaxMovieRating.DisplayMember = "Text";
            this.cmbMaxMovieRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaxMovieRating.FormattingEnabled = true;
            this.cmbMaxMovieRating.Location = new System.Drawing.Point(105, 50);
            this.cmbMaxMovieRating.Name = "cmbMaxMovieRating";
            this.cmbMaxMovieRating.Size = new System.Drawing.Size(166, 21);
            this.cmbMaxMovieRating.TabIndex = 36;
            this.cmbMaxMovieRating.ValueMember = "Value";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Max Movie Rating:";
            // 
            // cmbMaxGameRating
            // 
            this.cmbMaxGameRating.DisplayMember = "Text";
            this.cmbMaxGameRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaxGameRating.FormattingEnabled = true;
            this.cmbMaxGameRating.Location = new System.Drawing.Point(105, 23);
            this.cmbMaxGameRating.Name = "cmbMaxGameRating";
            this.cmbMaxGameRating.Size = new System.Drawing.Size(166, 21);
            this.cmbMaxGameRating.TabIndex = 30;
            this.cmbMaxGameRating.ValueMember = "Value";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Max Game Rating:";
            // 
            // tabLive
            // 
            this.tabLive.Controls.Add(this.groupBox5);
            this.tabLive.Location = new System.Drawing.Point(4, 22);
            this.tabLive.Name = "tabLive";
            this.tabLive.Size = new System.Drawing.Size(391, 269);
            this.tabLive.TabIndex = 5;
            this.tabLive.Text = "Live";
            this.tabLive.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtLiveSubnet);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtLiveGateway);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtLiveDns);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtLiveAddress);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(8, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 130);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Xbox Live Settings (Deprecated)";
            // 
            // txtLiveSubnet
            // 
            this.txtLiveSubnet.BackColor = System.Drawing.SystemColors.Window;
            this.txtLiveSubnet.CharacterRegex = "[0-9\\.]";
            this.txtLiveSubnet.ExactLengthRequired = 0;
            this.txtLiveSubnet.ForceUpperCase = false;
            this.txtLiveSubnet.InvalidColor = System.Drawing.Color.Yellow;
            this.txtLiveSubnet.Location = new System.Drawing.Point(105, 100);
            this.txtLiveSubnet.MaxLength = 15;
            this.txtLiveSubnet.Name = "txtLiveSubnet";
            this.txtLiveSubnet.Size = new System.Drawing.Size(88, 20);
            this.txtLiveSubnet.TabIndex = 22;
            this.txtLiveSubnet.Text = "255.255.255.255";
            this.txtLiveSubnet.TextRegex = "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-" +
    "9][0-9]?)$";
            this.txtLiveSubnet.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Subnet Mask:";
            // 
            // txtLiveGateway
            // 
            this.txtLiveGateway.BackColor = System.Drawing.SystemColors.Window;
            this.txtLiveGateway.CharacterRegex = "[0-9\\.]";
            this.txtLiveGateway.ExactLengthRequired = 0;
            this.txtLiveGateway.ForceUpperCase = false;
            this.txtLiveGateway.InvalidColor = System.Drawing.Color.Yellow;
            this.txtLiveGateway.Location = new System.Drawing.Point(105, 74);
            this.txtLiveGateway.MaxLength = 15;
            this.txtLiveGateway.Name = "txtLiveGateway";
            this.txtLiveGateway.Size = new System.Drawing.Size(88, 20);
            this.txtLiveGateway.TabIndex = 20;
            this.txtLiveGateway.Text = "255.255.255.255";
            this.txtLiveGateway.TextRegex = "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-" +
    "9][0-9]?)$";
            this.txtLiveGateway.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Gateway:";
            // 
            // txtLiveDns
            // 
            this.txtLiveDns.BackColor = System.Drawing.SystemColors.Window;
            this.txtLiveDns.CharacterRegex = "[0-9\\.]";
            this.txtLiveDns.ExactLengthRequired = 0;
            this.txtLiveDns.ForceUpperCase = false;
            this.txtLiveDns.InvalidColor = System.Drawing.Color.Yellow;
            this.txtLiveDns.Location = new System.Drawing.Point(105, 48);
            this.txtLiveDns.MaxLength = 15;
            this.txtLiveDns.Name = "txtLiveDns";
            this.txtLiveDns.Size = new System.Drawing.Size(88, 20);
            this.txtLiveDns.TabIndex = 18;
            this.txtLiveDns.Text = "255.255.255.255";
            this.txtLiveDns.TextRegex = "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-" +
    "9][0-9]?)$";
            this.txtLiveDns.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "DNS Server:";
            // 
            // txtLiveAddress
            // 
            this.txtLiveAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtLiveAddress.CharacterRegex = "[0-9\\.]";
            this.txtLiveAddress.ExactLengthRequired = 0;
            this.txtLiveAddress.ForceUpperCase = false;
            this.txtLiveAddress.InvalidColor = System.Drawing.Color.Yellow;
            this.txtLiveAddress.Location = new System.Drawing.Point(105, 22);
            this.txtLiveAddress.MaxLength = 15;
            this.txtLiveAddress.Name = "txtLiveAddress";
            this.txtLiveAddress.Size = new System.Drawing.Size(88, 20);
            this.txtLiveAddress.TabIndex = 16;
            this.txtLiveAddress.Text = "255.255.255.255";
            this.txtLiveAddress.TextRegex = "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-" +
    "9][0-9]?)$";
            this.txtLiveAddress.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "IP Address:";
            // 
            // tabUnknown1
            // 
            this.tabUnknown1.Controls.Add(this.groupBox6);
            this.tabUnknown1.Location = new System.Drawing.Point(4, 22);
            this.tabUnknown1.Name = "tabUnknown1";
            this.tabUnknown1.Size = new System.Drawing.Size(391, 269);
            this.tabUnknown1.TabIndex = 6;
            this.tabUnknown1.Text = "Unknown";
            this.tabUnknown1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtUnknownF4);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.txtUnknownC0);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.txtPadding80);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.txtPadding70);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.txtPadding56);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.txtPadding46);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(375, 218);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Unknown Values";
            // 
            // txtUnknownF4
            // 
            this.txtUnknownF4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnknownF4.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnknownF4.CharacterRegex = "[0-9A-F]";
            this.txtUnknownF4.ExactLengthRequired = 8;
            this.txtUnknownF4.ForceUpperCase = true;
            this.txtUnknownF4.InvalidColor = System.Drawing.Color.Yellow;
            this.txtUnknownF4.Location = new System.Drawing.Point(105, 126);
            this.txtUnknownF4.MaxLength = 8;
            this.txtUnknownF4.Name = "txtUnknownF4";
            this.txtUnknownF4.Size = new System.Drawing.Size(70, 20);
            this.txtUnknownF4.TabIndex = 30;
            this.txtUnknownF4.Text = "DDDDDDDD";
            this.txtUnknownF4.TextRegex = "[0-9A-F]+";
            this.txtUnknownF4.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 129);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Unknown 0xF4:";
            // 
            // txtUnknownC0
            // 
            this.txtUnknownC0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnknownC0.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnknownC0.CharacterRegex = "[0-9A-F]";
            this.txtUnknownC0.ExactLengthRequired = 104;
            this.txtUnknownC0.ForceUpperCase = true;
            this.txtUnknownC0.InvalidColor = System.Drawing.Color.Yellow;
            this.txtUnknownC0.Location = new System.Drawing.Point(105, 152);
            this.txtUnknownC0.MaxLength = 104;
            this.txtUnknownC0.Multiline = true;
            this.txtUnknownC0.Name = "txtUnknownC0";
            this.txtUnknownC0.Size = new System.Drawing.Size(264, 58);
            this.txtUnknownC0.TabIndex = 28;
            this.txtUnknownC0.Text = "DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD" +
    "DDDDDDDDDDDDDDDDDDDDDDD";
            this.txtUnknownC0.TextRegex = "[0-9A-F]+";
            this.txtUnknownC0.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(16, 155);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(83, 13);
            this.label33.TabIndex = 27;
            this.label33.Text = "Unknown 0xC0:";
            // 
            // txtPadding80
            // 
            this.txtPadding80.BackColor = System.Drawing.SystemColors.Window;
            this.txtPadding80.CharacterRegex = "[0-9A-F]";
            this.txtPadding80.ExactLengthRequired = 16;
            this.txtPadding80.ForceUpperCase = true;
            this.txtPadding80.InvalidColor = System.Drawing.Color.Yellow;
            this.txtPadding80.Location = new System.Drawing.Point(105, 100);
            this.txtPadding80.MaxLength = 16;
            this.txtPadding80.Name = "txtPadding80";
            this.txtPadding80.Size = new System.Drawing.Size(134, 20);
            this.txtPadding80.TabIndex = 24;
            this.txtPadding80.Text = "DDDDDDDDDDDDDDDD";
            this.txtPadding80.TextRegex = "[0-9A-F]+";
            this.txtPadding80.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(24, 103);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Padding 0x80:";
            // 
            // txtPadding70
            // 
            this.txtPadding70.BackColor = System.Drawing.SystemColors.Window;
            this.txtPadding70.CharacterRegex = "[0-9A-F]";
            this.txtPadding70.ExactLengthRequired = 16;
            this.txtPadding70.ForceUpperCase = true;
            this.txtPadding70.InvalidColor = System.Drawing.Color.Yellow;
            this.txtPadding70.Location = new System.Drawing.Point(105, 74);
            this.txtPadding70.MaxLength = 16;
            this.txtPadding70.Name = "txtPadding70";
            this.txtPadding70.Size = new System.Drawing.Size(134, 20);
            this.txtPadding70.TabIndex = 22;
            this.txtPadding70.Text = "DDDDDDDDDDDDDDDD";
            this.txtPadding70.TextRegex = "[0-9A-F]+";
            this.txtPadding70.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 77);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "Padding 0x70:";
            // 
            // txtPadding56
            // 
            this.txtPadding56.BackColor = System.Drawing.SystemColors.Window;
            this.txtPadding56.CharacterRegex = "[0-9A-F]";
            this.txtPadding56.ExactLengthRequired = 8;
            this.txtPadding56.ForceUpperCase = true;
            this.txtPadding56.InvalidColor = System.Drawing.Color.Yellow;
            this.txtPadding56.Location = new System.Drawing.Point(105, 48);
            this.txtPadding56.MaxLength = 8;
            this.txtPadding56.Name = "txtPadding56";
            this.txtPadding56.Size = new System.Drawing.Size(70, 20);
            this.txtPadding56.TabIndex = 20;
            this.txtPadding56.Text = "DDDDDDDD";
            this.txtPadding56.TextRegex = "[0-9A-F]+";
            this.txtPadding56.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(24, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Padding 0x56:";
            // 
            // txtPadding46
            // 
            this.txtPadding46.BackColor = System.Drawing.SystemColors.Window;
            this.txtPadding46.CharacterRegex = "[0-9A-F]";
            this.txtPadding46.ExactLengthRequired = 4;
            this.txtPadding46.ForceUpperCase = true;
            this.txtPadding46.InvalidColor = System.Drawing.Color.Yellow;
            this.txtPadding46.Location = new System.Drawing.Point(105, 22);
            this.txtPadding46.MaxLength = 4;
            this.txtPadding46.Name = "txtPadding46";
            this.txtPadding46.Size = new System.Drawing.Size(38, 20);
            this.txtPadding46.TabIndex = 18;
            this.txtPadding46.Text = "DDDD";
            this.txtPadding46.TextRegex = "[0-9A-F]+";
            this.txtPadding46.ValidColor = System.Drawing.SystemColors.Window;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Padding 0x46:";
            // 
            // tabUnknown2
            // 
            this.tabUnknown2.Controls.Add(this.groupBox7);
            this.tabUnknown2.Location = new System.Drawing.Point(4, 22);
            this.tabUnknown2.Name = "tabUnknown2";
            this.tabUnknown2.Size = new System.Drawing.Size(391, 269);
            this.tabUnknown2.TabIndex = 7;
            this.tabUnknown2.Text = "Unknown (cont.)";
            this.tabUnknown2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.lvUnknownFC);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.lvUnknownF8);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.lvUnknownB8);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Location = new System.Drawing.Point(8, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(375, 216);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Unknown Flags";
            // 
            // lvUnknownFC
            // 
            this.lvUnknownFC.CheckBoxes = true;
            this.lvUnknownFC.HideSelection = false;
            this.lvUnknownFC.LabelWrap = false;
            this.lvUnknownFC.Location = new System.Drawing.Point(105, 150);
            this.lvUnknownFC.Name = "lvUnknownFC";
            this.lvUnknownFC.Size = new System.Drawing.Size(166, 58);
            this.lvUnknownFC.TabIndex = 50;
            this.lvUnknownFC.UseCompatibleStateImageBehavior = false;
            this.lvUnknownFC.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 153);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 13);
            this.label29.TabIndex = 49;
            this.label29.Text = "Unknown 0xFC:";
            // 
            // lvUnknownF8
            // 
            this.lvUnknownF8.CheckBoxes = true;
            this.lvUnknownF8.HideSelection = false;
            this.lvUnknownF8.LabelWrap = false;
            this.lvUnknownF8.Location = new System.Drawing.Point(105, 86);
            this.lvUnknownF8.Name = "lvUnknownF8";
            this.lvUnknownF8.Size = new System.Drawing.Size(166, 58);
            this.lvUnknownF8.TabIndex = 48;
            this.lvUnknownF8.UseCompatibleStateImageBehavior = false;
            this.lvUnknownF8.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(17, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 13);
            this.label28.TabIndex = 47;
            this.label28.Text = "Unknown 0xF8:";
            // 
            // lvUnknownB8
            // 
            this.lvUnknownB8.CheckBoxes = true;
            this.lvUnknownB8.HideSelection = false;
            this.lvUnknownB8.LabelWrap = false;
            this.lvUnknownB8.Location = new System.Drawing.Point(105, 22);
            this.lvUnknownB8.Name = "lvUnknownB8";
            this.lvUnknownB8.Size = new System.Drawing.Size(166, 58);
            this.lvUnknownB8.TabIndex = 46;
            this.lvUnknownB8.UseCompatibleStateImageBehavior = false;
            this.lvUnknownB8.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 13);
            this.label27.TabIndex = 45;
            this.label27.Text = "Unknown 0xB8:";
            // 
            // mnuArduionoProm
            // 
            this.mnuArduionoProm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.writeToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.mnuArduionoProm.Name = "mnuArduionoProm";
            this.mnuArduionoProm.Size = new System.Drawing.Size(94, 20);
            this.mnuArduionoProm.Text = "Arduino Prom";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.writeToolStripMenuItem.Text = "Write";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 319);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabSections);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Original Xbox EEPROM Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabSecurity.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSections.ResumeLayout(false);
            this.tabFactory.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabParental.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabLive.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabUnknown1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabUnknown2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.ValidatedTextBox txtConfounder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Controls.ValidatedTextBox txtHddKey;
        private System.Windows.Forms.TabControl tabSections;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTimeZone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabFactory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbVideoStandard;
        private System.Windows.Forms.Label label7;
        private Controls.ValidatedTextBox txtOnlineKey;
        private System.Windows.Forms.Label label6;
        private Controls.ValidatedTextBox txtMacAddress;
        private System.Windows.Forms.Label label5;
        private Controls.ValidatedTextBox txtSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabParental;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbPass1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbMaxMovieRating;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbMaxGameRating;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabLive;
        private System.Windows.Forms.ComboBox cmbDvdZone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private Controls.ValidatedTextBox txtLiveSubnet;
        private System.Windows.Forms.Label label11;
        private Controls.ValidatedTextBox txtLiveGateway;
        private System.Windows.Forms.Label label14;
        private Controls.ValidatedTextBox txtLiveDns;
        private System.Windows.Forms.Label label15;
        private Controls.ValidatedTextBox txtLiveAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabUnknown1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ToolStripMenuItem mnuExportTxt;
        private Controls.ValidatedTextBox txtPadding80;
        private System.Windows.Forms.Label label24;
        private Controls.ValidatedTextBox txtPadding70;
        private System.Windows.Forms.Label label23;
        private Controls.ValidatedTextBox txtPadding56;
        private System.Windows.Forms.Label label21;
        private Controls.ValidatedTextBox txtPadding46;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkDst;
        private System.Windows.Forms.ListView lvRegions;
        private ListView lvAudio;
        private ListView lvVideo;
        private ComboBox cmbPass4;
        private ComboBox cmbPass3;
        private ComboBox cmbPass2;
        private TabPage tabUnknown2;
        private GroupBox groupBox7;
        private Label label25;
        private Label label33;
        private ListView lvUnknownB8;
        private Label label27;
        private ListView lvUnknownFC;
        private Label label29;
        private ListView lvUnknownF8;
        private Label label28;
        private ToolStripMenuItem mnuReset;
        private Controls.ValidatedTextBox txtUnknownF4;
        private Controls.ValidatedTextBox txtUnknownC0;

        #region Data Bindings

        private void PopulateVersionDropdown()
        {
            cmbVersion.DataSource = new[] {
                new { Text = "Debug", Value = EepromVersion.Debug },
                new { Text = "Retail 1.0", Value = EepromVersion.RetailFirst },
                new { Text = "Retail 1.1 - 1.4", Value = EepromVersion.RetailMiddle },
                new { Text = "Retail 1.6", Value = EepromVersion.RetailLast },
                new { Text = "Unknown", Value = EepromVersion.Unknown }
            };
        }

        private void PopulateRegionCheckboxes()
        {
            // add pre-determined ones first
            lvRegions.Items.Add(new ListViewItem("North America").AddInfo(Types.Region.NorthAmerica));
            lvRegions.Items.Add(new ListViewItem("Japan").AddInfo(Types.Region.Japan));
            lvRegions.Items.Add(new ListViewItem("Europe / Australia").AddInfo(Types.Region.EuropeAustralia));
            lvRegions.Items.Add(new ListViewItem("Debug").AddInfo(Types.Region.Debug));

            // then add the unknown bits afterwards
            for (int i = 0; i < 32; i++)
            {
                if (((Types.Region)(1 << i)).ToString().StartsWith("Bit", StringComparison.OrdinalIgnoreCase))
                {
                    lvRegions.Items.Add(new ListViewItem("Bit" + i).AddInfo(1 << i));
                }
            }
        }

        private void PopulateVideoStandardDropdown()
        {
            cmbVideoStandard.DataSource = new[] {
                new { Text = "NTSC-M", Value = VideoStandard.NtscM },
                new { Text = "NTSC-J", Value = VideoStandard.NtscJ },
                new { Text = "PAL-I", Value = VideoStandard.PalI },
                new { Text = "PAL-M", Value = VideoStandard.PalM },
                new { Text = "Unknown", Value = VideoStandard.Unknown }
            };
        }

        private void PopulateDvdZoneDropdown()
        {
            cmbDvdZone.DataSource = new[] {
                new { Text = "None", Value = DvdPlaybackZone.None },
                new { Text = "Region 1", Value = DvdPlaybackZone.Region1 },
                new { Text = "Region 2", Value = DvdPlaybackZone.Region2 },
                new { Text = "Region 3", Value = DvdPlaybackZone.Region3 },
                new { Text = "Region 4", Value = DvdPlaybackZone.Region4 },
                new { Text = "Region 5", Value = DvdPlaybackZone.Region5 },
                new { Text = "Region 6", Value = DvdPlaybackZone.Region6 },
                new { Text = "Unknown", Value = DvdPlaybackZone.Unknown }
            };
        }

        private void PopulateLanguageDropdown()
        {
            cmbLanguage.DataSource = new[] {
                new { Text = "Neutral", Value = Language.Neutral },
                new { Text = "English", Value = Language.English },
                new { Text = "Japanese", Value = Language.Japanese },
                new { Text = "German", Value = Language.German },
                new { Text = "French", Value = Language.French },
                new { Text = "Spanish", Value = Language.Spanish },
                new { Text = "Italian", Value = Language.Italian },
                new { Text = "Korean", Value = Language.Korean },
                new { Text = "Chinese", Value = Language.Chinese },
                new { Text = "Portuguese", Value = Language.Portuguese },
                new { Text = "Unknown", Value = Language.Unknown }
            };
        }

        private void PopulateMaxGameRatingDropdown()
        {
            cmbMaxGameRating.DataSource = new[] {
                new { Text = "Unrated", Value = GameRating.Unrated },
                new { Text = "Adults Only", Value = GameRating.AdultsOnly },
                new { Text = "Mature", Value = GameRating.Mature },
                new { Text = "Teen", Value = GameRating.Teen },
                new { Text = "Everyone", Value = GameRating.Everyone },
                new { Text = "Kids to Adults", Value = GameRating.KidsToAdults },
                new { Text = "Early Childhood", Value = GameRating.EarlyChildhood },
                new { Text = "Unknown", Value = GameRating.Unknown }
            };
        }

        private void PopulateMaxMovieRatingDropdown()
        {
            cmbMaxMovieRating.DataSource = new[] {
                new { Text = "Unrated", Value = MovieRating.NR },
                new { Text = "NC17", Value = MovieRating.NC17 },
                new { Text = "R", Value = MovieRating.R },
                new { Text = "PG13", Value = MovieRating.PG13 },
                new { Text = "PG", Value = MovieRating.PG },
                new { Text = "G", Value = MovieRating.G },
                new { Text = "Unknown", Value = MovieRating.Unknown }
            };
        }

        private void PopulateAudioCheckboxes()
        {
            // add pre-determined ones first
            lvAudio.Items.Add(new ListViewItem("Mono").AddInfo(AudioSettings.Mono));
            lvAudio.Items.Add(new ListViewItem("Surround").AddInfo(AudioSettings.Surround));
            lvAudio.Items.Add(new ListViewItem("AC3").AddInfo(AudioSettings.AC3));
            lvAudio.Items.Add(new ListViewItem("DTS").AddInfo(AudioSettings.DTS));

            // then add the unknown bits afterwards
            for (int i = 0; i < 32; i++)
            {
                if (((AudioSettings)(1 << i)).ToString().StartsWith("Bit", StringComparison.OrdinalIgnoreCase))
                {
                    lvAudio.Items.Add(new ListViewItem("Bit" + i).AddInfo(1 << i));
                }
            }
        }

        private void PopulateVideoCheckboxes()
        {
            // add pre-determined ones first
            lvVideo.Items.Add(new ListViewItem("480p").AddInfo(VideoSettings.Resolution480p));
            lvVideo.Items.Add(new ListViewItem("720p").AddInfo(VideoSettings.Resolution720p));
            lvVideo.Items.Add(new ListViewItem("1080i").AddInfo(VideoSettings.Resolution1080i));
            lvVideo.Items.Add(new ListViewItem("Widescreen").AddInfo(VideoSettings.Widescreen));
            lvVideo.Items.Add(new ListViewItem("Letterbox").AddInfo(VideoSettings.Letterbox));
            lvVideo.Items.Add(new ListViewItem("50 Hz").AddInfo(VideoSettings.Refresh50Hz));
            lvVideo.Items.Add(new ListViewItem("60 Hz").AddInfo(VideoSettings.Refresh60Hz));

            // then add the unknown bits afterwards
            for (int i = 0; i < 32; i++)
            {
                if (((VideoSettings)(1 << i)).ToString().StartsWith("Bit", StringComparison.OrdinalIgnoreCase))
                {
                    lvVideo.Items.Add(new ListViewItem("Bit" + i).AddInfo(1 << i));
                }
            }
        }

        private void PopulateUnknownCheckboxes()
        {
            for (int i = 0; i < 32; i++)
            {
                lvUnknownB8.Items.Add(new ListViewItem("Bit" + i).AddInfo(1 << i));
                lvUnknownF8.Items.Add(new ListViewItem("Bit" + i).AddInfo(1 << i));
                lvUnknownFC.Items.Add(new ListViewItem("Bit" + i).AddInfo(1 << i));
            }
        }

        private void PopulatePasscodeDropdown(ComboBox combo)
        {
            combo.DataSource = new[] {
                new { Text = "NONE", Value = PasscodeButton.None },
                new { Text = "UP", Value = PasscodeButton.Up },
                new { Text = "DOWN", Value = PasscodeButton.Down },
                new { Text = "LEFT", Value = PasscodeButton.Left },
                new { Text = "RIGHT", Value = PasscodeButton.Right },
                new { Text = "A", Value = PasscodeButton.A },
                new { Text = "B", Value = PasscodeButton.B },
                new { Text = "X", Value = PasscodeButton.X },
                new { Text = "Y", Value = PasscodeButton.Y },
                //new { Text = "UNK1", Value = PasscodeButton.Unknown1 },
                //new { Text = "UNK2", Value = PasscodeButton.Unknown2 },
                new { Text = "LTRIG", Value = PasscodeButton.LeftTrigger },
                new { Text = "RTRIG", Value = PasscodeButton.RightTrigger },
                new { Text = "UNK", Value = PasscodeButton.Unknown }
            };
        }

        // TODO: if we can't determine tz from xbox settings, select "Unknown" and force user to select a new one before saving
        // https://www.timeanddate.com/time/zones/
        // https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
        private void PopulateTimeZoneDropdown()
        {
            cmbTimeZone.DataSource = new[] {
                new { Text = "Unknown" },
                new { Text = "America/Chicago" },   // TODO: tag with TimeZoneInfo struct
                // TODO: additional zones
            };
        }

        #endregion

        private ToolStripMenuItem mnuArduionoProm;
        private ToolStripMenuItem readToolStripMenuItem;
        private ToolStripMenuItem writeToolStripMenuItem;
        private ToolStripMenuItem configureToolStripMenuItem;
    }
}

