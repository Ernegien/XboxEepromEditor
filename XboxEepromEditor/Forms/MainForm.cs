using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using XboxEepromEditor.Controls;
using XboxEepromEditor.Extensions;
using XboxEepromEditor.Types;

namespace XboxEepromEditor.Forms
{
    // TODO: textbox.AutoSize = false; then set textbox height to 23 to match combobox height, or set multiline = true
    // https://stackoverflow.com/questions/5853073/change-the-textbox-height/17326753#17326753

    // TODO: logging, global exception handler, menu shortcuts, timezones, general cleanup

    public partial class MainForm : Form
    {
        Eeprom _eeprom = new Eeprom();

        public MainForm()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;

            Text += " (" + Assembly.GetExecutingAssembly().GetName().Version.ToString() + ") BETA";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateVersionDropdown();
            PopulateRegionCheckboxes();
            PopulateVideoStandardDropdown();
            PopulateTimeZoneDropdown();
            PopulateDvdZoneDropdown();
            PopulateLanguageDropdown();
            PopulateMaxGameRatingDropdown();
            PopulateMaxMovieRatingDropdown();
            PopulateAudioCheckboxes();
            PopulateVideoCheckboxes();
            PopulatePasscodeDropdown(cmbPass1);
            PopulatePasscodeDropdown(cmbPass2);
            PopulatePasscodeDropdown(cmbPass3);
            PopulatePasscodeDropdown(cmbPass4);
            PopulateUnknownCheckboxes();

            UpdateFormFromEeprom();
        }

        private void UpdateFormFromEeprom()
        {
            cmbVersion.SelectedValue = _eeprom.Version;
            txtConfounder.Text = _eeprom.Confounder.ToHexString();
            txtHddKey.Text = _eeprom.HddKey.ToHexString();
            foreach (ListViewItem item in lvRegions.Items)
            {
                item.Checked = _eeprom.Region.HasFlag((Types.Region)item.Tag);
            }

            txtSerial.Text = _eeprom.Serial;
            txtMacAddress.Text = _eeprom.MacAddress.ToHexString();
            txtOnlineKey.Text = _eeprom.OnlineKey.ToHexString();

            cmbVideoStandard.SelectedValue = _eeprom.VideoStandard;
            if (cmbVideoStandard.SelectedValue == null)
            {
                cmbVideoStandard.SelectedValue = VideoStandard.Unknown;
            }

            // TODO: time zone / dst

            cmbDvdZone.SelectedValue = _eeprom.DvdPlaybackZone;
            if (cmbDvdZone.SelectedValue == null)
            {
                cmbDvdZone.SelectedValue = DvdPlaybackZone.Unknown;
            }

            cmbLanguage.SelectedValue = _eeprom.Language;
            if (cmbLanguage.SelectedValue == null)
            {
                cmbLanguage.SelectedValue = Language.Unknown;
            }

            foreach (ListViewItem item in lvAudio.Items)
            {
                item.Checked = _eeprom.AudioSettings.HasFlag((AudioSettings)item.Tag);
            }
            foreach (ListViewItem item in lvVideo.Items)
            {
                item.Checked = _eeprom.VideoSettings.HasFlag((VideoSettings)item.Tag);
            }

            cmbMaxGameRating.SelectedValue = _eeprom.ParentalControlGameRating;
            if (cmbMaxGameRating.SelectedValue == null)
            {
                cmbMaxGameRating.SelectedValue = GameRating.Unknown;
            }

            cmbMaxMovieRating.SelectedValue = _eeprom.ParentalControlMovieRating;
            if (cmbMaxMovieRating.SelectedValue == null)
            {
                cmbMaxMovieRating.SelectedValue = MovieRating.Unknown;
            }

            cmbPass1.SelectedValue = (PasscodeButton)((_eeprom.ParentalControlPasscode & 0xF000) >> 12);
            if (cmbPass1.SelectedValue == null)
            {
                cmbPass1.SelectedValue = PasscodeButton.Unknown;
            }

            cmbPass2.SelectedValue = (PasscodeButton)((_eeprom.ParentalControlPasscode & 0xF00) >> 8);
            if (cmbPass2.SelectedValue == null)
            {
                cmbPass2.SelectedValue = PasscodeButton.Unknown;
            }

            cmbPass3.SelectedValue = (PasscodeButton)((_eeprom.ParentalControlPasscode & 0xF0) >> 4);
            if (cmbPass3.SelectedValue == null)
            {
                cmbPass3.SelectedValue = PasscodeButton.Unknown;
            }

            cmbPass4.SelectedValue = (PasscodeButton)(_eeprom.ParentalControlPasscode & 0xF);
            if (cmbPass4.SelectedValue == null)
            {
                cmbPass4.SelectedValue = PasscodeButton.Unknown;
            }

            txtLiveAddress.Text = _eeprom.LiveAddress.ToString();
            txtLiveDns.Text = _eeprom.LiveDns.ToString();
            txtLiveGateway.Text = _eeprom.LiveGateway.ToString();
            txtLiveSubnet.Text = _eeprom.LiveSubnet.ToString();

            txtPadding46.Text = BitConverter.GetBytes(_eeprom.UnknownPadding).ToHexString();
            txtPadding56.Text = BitConverter.GetBytes(_eeprom.UnknownPadding2).ToHexString();
            txtPadding70.Text = _eeprom.UnknownPadding3.ToHexString();
            txtPadding80.Text = _eeprom.UnknownPadding4.ToHexString();
            txtUnknownC0.Text = _eeprom.MiscData.ToHexString();
            txtUnknownF4.Text = BitConverter.GetBytes(_eeprom.UnknownValueF4).ToHexString();

            foreach (ListViewItem item in lvUnknownB8.Items)
            {
                item.Checked = _eeprom.UnknownFlagsB8.HasFlag((UnknownFlags)item.Tag);
            }
            foreach (ListViewItem item in lvUnknownF8.Items)
            {
                item.Checked = _eeprom.UnknownFlagsF8.HasFlag((UnknownFlags)item.Tag);
            }
            foreach (ListViewItem item in lvUnknownFC.Items)
            {
                item.Checked = _eeprom.UnknownFlagsFC.HasFlag((UnknownFlags)item.Tag);
            }
        }
        
        private void UpdateEepromFromForm()
        {
            _eeprom.Version = (EepromVersion)cmbVersion.SelectedValue;
            if ((EepromVersion)cmbVersion.SelectedValue != EepromVersion.Unknown)
            {
                _eeprom.Confounder = txtConfounder.Text.FromHexStringToBytes();
                _eeprom.HddKey = txtHddKey.Text.FromHexStringToBytes();
                _eeprom.Region = (Region)GetListViewFlagValue(lvRegions);
            }

            _eeprom.Serial = txtSerial.Text;
            _eeprom.MacAddress = txtMacAddress.Text.FromHexStringToBytes();
            _eeprom.OnlineKey = txtOnlineKey.Text.FromHexStringToBytes();
            var videoStandard = (VideoStandard)cmbVideoStandard.SelectedValue;
            if (videoStandard != VideoStandard.Unknown)
            {
                _eeprom.VideoStandard = videoStandard;
            }

            _eeprom.DvdPlaybackZone = (DvdPlaybackZone)cmbDvdZone.SelectedValue;
            var language = (Language)cmbLanguage.SelectedValue;
            if (language != Language.Neutral)
            {
                _eeprom.Language = language;
            }
            _eeprom.VideoSettings = (VideoSettings)GetListViewFlagValue(lvVideo);
            _eeprom.AudioSettings = (AudioSettings)GetListViewFlagValue(lvAudio);

            var gameRating = (GameRating)cmbMaxGameRating.SelectedValue;
            if (gameRating != GameRating.Unknown)
            {
                _eeprom.ParentalControlGameRating = gameRating;
            }

            var movieRating = (MovieRating)cmbMaxMovieRating.SelectedValue;
            if (movieRating != MovieRating.Unknown)
            {
                _eeprom.ParentalControlMovieRating = movieRating;
            }

            uint passcode = 0;
            var pass1 = (PasscodeButton)cmbPass1.SelectedValue;
            if (pass1 != PasscodeButton.Unknown)
            {
                passcode |= (passcode & 0x0FFF) | (uint)pass1 << 12;
            }
            var pass2 = (PasscodeButton)cmbPass2.SelectedValue;
            if (pass2 != PasscodeButton.Unknown)
            {
                passcode |= (passcode & 0xF0FF) | (uint)pass2 << 8;
            }
            var pass3 = (PasscodeButton)cmbPass3.SelectedValue;
            if (pass3 != PasscodeButton.Unknown)
            {
                passcode |= (passcode & 0xFF0F) | (uint)pass3 << 4;
            }
            var pass4 = (PasscodeButton)cmbPass4.SelectedValue;
            if (pass4 != PasscodeButton.Unknown)
            {
                passcode |= (passcode & 0xFFF0) | (uint)pass4;
            }
            _eeprom.ParentalControlPasscode = passcode;

            IPAddress.TryParse(txtLiveAddress.Text, out IPAddress liveAddr);
            _eeprom.LiveAddress = liveAddr;

            IPAddress.TryParse(txtLiveDns.Text, out IPAddress liveDns);
            _eeprom.LiveDns = liveDns;

            IPAddress.TryParse(txtLiveGateway.Text, out IPAddress liveGateway);
            _eeprom.LiveGateway = liveGateway;

            IPAddress.TryParse(txtLiveSubnet.Text, out IPAddress liveSubnet);
            _eeprom.LiveSubnet = liveSubnet;

            _eeprom.UnknownPadding = BitConverter.ToUInt16(txtPadding46.Text.FromHexStringToBytes(), 0);
            _eeprom.UnknownPadding2 = BitConverter.ToUInt32(txtPadding56.Text.FromHexStringToBytes(), 0);
            _eeprom.UnknownPadding3 = txtPadding70.Text.FromHexStringToBytes();
            _eeprom.UnknownPadding4 = txtPadding80.Text.FromHexStringToBytes();

            _eeprom.UnknownValueF4 = BitConverter.ToUInt32(txtUnknownF4.Text.FromHexStringToBytes(), 0);
            _eeprom.MiscData = txtUnknownC0.Text.FromHexStringToBytes();

            _eeprom.UnknownFlagsB8 = (UnknownFlags)GetListViewFlagValue(lvUnknownB8);
            _eeprom.UnknownFlagsF8 = (UnknownFlags)GetListViewFlagValue(lvUnknownF8);
            _eeprom.UnknownFlagsFC = (UnknownFlags)GetListViewFlagValue(lvUnknownFC);
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // remind the user that the security section can't be saved if the encryption type is unknown
            bool readOnlySecurity = (EepromVersion)cmbVersion.SelectedValue != EepromVersion.Unknown;
            txtConfounder.Enabled = readOnlySecurity;
            txtHddKey.Enabled = readOnlySecurity;
            lvRegions.Enabled = readOnlySecurity;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Xbox EEPROM (*.bin) |*.bin";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _eeprom = new Eeprom(ofd.FileName);
                    UpdateFormFromEeprom();
                }
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            if (!ValidateFormData())
                return;

            UpdateEepromFromForm();

            if ((EepromVersion)cmbVersion.SelectedValue == EepromVersion.Unknown)
            {
                MessageBox.Show("The security section will not be updated while the version is unknown. This may be desired if editing an EEPROM version not supported by this tool.", "Unknown EEPROM Version",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Xbox EEPROM (*.bin) |*.bin";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _eeprom.Save(sfd.FileName);
                }
            }
        }

        private void mnuExportTxt_Click(object sender, EventArgs e)
        {
            if (!ValidateFormData())
                return;

            // generate textual output from entered form data
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("# Generated by " + Text);
            sb.AppendLine();
            sb.AppendLine("=================================================");
            sb.AppendLine("===Security Settings=============================");
            sb.AppendLine("=================================================");
            sb.AppendLine();
            sb.AppendFormat("Hardware Type: {0}\r\n", cmbVersion.Text);
            sb.AppendFormat("Confounder: {0}\r\n", txtConfounder.Text);
            sb.AppendFormat("HDD Key: {0}\r\n", txtHddKey.Text);
            sb.AppendFormat("Region: {0}\r\n", GetChecklistFlagString(lvRegions));
            sb.AppendLine();
            sb.AppendLine("=================================================");
            sb.AppendLine("===Factory Settings==============================");
            sb.AppendLine("=================================================");
            sb.AppendLine();
            sb.AppendFormat("Serial: {0}\r\n", txtSerial.Text);
            sb.AppendFormat("MAC Address: {0}\r\n", txtMacAddress.Text);
            sb.AppendFormat("Online Key: {0}\r\n", txtOnlineKey.Text);
            sb.AppendFormat("Video Standard: {0}\r\n", cmbVideoStandard.Text);
            sb.AppendLine();
            sb.AppendLine("=================================================");
            sb.AppendLine("===General Settings==============================");
            sb.AppendLine("=================================================");
            sb.AppendLine();
            sb.AppendFormat("Time Zone: {0}\r\n", cmbTimeZone.Text);
            sb.AppendFormat("Daylight Savings?: {0}\r\n", chkDst.Checked ? "Yes" : "No");
            sb.AppendFormat("DVD Zone: {0}\r\n", cmbDvdZone.Text);
            sb.AppendFormat("Language: {0}\r\n", cmbLanguage.Text);
            sb.AppendFormat("Video Options: {0}\r\n", GetChecklistFlagString(lvVideo));
            sb.AppendFormat("Audio Options: {0}\r\n", GetChecklistFlagString(lvAudio));
            sb.AppendLine();
            sb.AppendLine("=================================================");
            sb.AppendLine("===Parental Control Settings=====================");
            sb.AppendLine("=================================================");
            sb.AppendLine();
            sb.AppendFormat("Max Game Rating: {0}\r\n", cmbMaxGameRating.Text);
            sb.AppendFormat("Max Movie Rating: {0}\r\n", cmbMaxMovieRating.Text);
            sb.AppendFormat("Passcode: {0} {1} {2} {3}\r\n", cmbPass1.Text, cmbPass2.Text, cmbPass3.Text, cmbPass4.Text);
            sb.AppendLine();
            sb.AppendLine("=================================================");
            sb.AppendLine("===Live Settings (deprecated)====================");
            sb.AppendLine("=================================================");
            sb.AppendLine();
            sb.AppendFormat("IP Address: {0}\r\n", txtLiveAddress.Text);
            sb.AppendFormat("DNS Server: {0}\r\n", txtLiveDns.Text);
            sb.AppendFormat("Gateway: {0}\r\n", txtLiveGateway.Text);
            sb.AppendFormat("Subnet Mask: {0}\r\n", txtLiveSubnet.Text);
            sb.AppendLine();
            sb.AppendLine("=================================================");
            sb.AppendLine("===Unknown Settings==============================");
            sb.AppendLine("=================================================");
            sb.AppendLine();
            sb.AppendFormat("Padding 0x46: {0}\r\n", txtPadding46.Text);
            sb.AppendFormat("Padding 0x56: {0}\r\n", txtPadding56.Text);
            sb.AppendFormat("Padding 0x70: {0}\r\n", txtPadding70.Text);
            sb.AppendFormat("Padding 0x80: {0}\r\n", txtPadding80.Text);
            sb.AppendFormat("Value 0xF4: {0}\r\n", txtUnknownF4.Text);
            sb.AppendFormat("Data 0xC0: {0}\r\n", txtUnknownC0.Text);
            sb.AppendFormat("Flags 0xB8: {0}\r\n", GetChecklistFlagString(lvUnknownB8));
            sb.AppendFormat("Flags 0xF8: {0}\r\n", GetChecklistFlagString(lvUnknownF8));
            sb.AppendFormat("Flags 0xFC: {0}\r\n", GetChecklistFlagString(lvUnknownFC));

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text File (*.txt) |*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, sb.ToString());
                }
            }
        }

        private bool ValidateFormData()
        {
            bool isValid = this.FindAllChildrenByType<ValidatedTextBox>().All(x => x.IsValid);

            if (!isValid)
            {
                MessageBox.Show("Operation aborted, please review validation errors.", "Validation Error(s)",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private string GetChecklistFlagString(ListView lv)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in lv.Items)
            {
                if (item.Checked)
                    sb.AppendFormat("{0} | ", item.Text);
            }
            var result = sb.ToString().TrimEnd(new char[] { ' ', '|' });
            return string.IsNullOrWhiteSpace(result) ? "None" : result;
        }

        private int GetListViewFlagValue(ListView lv)
        {
            int flags = 0;

            foreach (ListViewItem item in lv.Items)
            {
                if (item.Checked)
                {
                    flags |= (int)item.Tag;
                }
            }
            return flags;
        }

        private void mnuReset_Click(object sender, EventArgs e)
        {
            _eeprom = new Eeprom();
            UpdateFormFromEeprom();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/Ernegien/XboxEepromEditor";

            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    Process.Start(url);
                }
            }
            catch
            {
                MessageBox.Show(url, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles uncaught exceptions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            // TODO: log full messages and truncate messagebox contents
            if (e.ExceptionObject is Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(e.ExceptionObject.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Environment.Exit(1);
        }
    }
}
