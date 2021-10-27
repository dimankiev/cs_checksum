using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

using WFCourseWork.classes;

namespace WFCourseWork {
    public partial class Calculator : Form {
        // Initially empty, then filled file information class
        static FileState file = new FileState();
        // Represents started state (was program started ?)
        static bool started = false;
        // Placeholder for hashes: MD5, SHA1, SHA256 and SHA512 respectively
        private string[] hashes = { "", "", "", "" };
        /// <summary>
        /// Represents a method, which initializes Form components
        /// </summary>
        public Calculator() {
            InitializeComponent();
        }
        /// <summary>
        /// Represents a method, which locks "Compute" button, if conditions aren't suitable
        /// </summary>
        private void buttonUnlock() {
            checksumComputeBtn.Enabled = false;
            if (!file.success && !started) return;
            if (!checksumMD5.Checked && !checksumSHA1.Checked && !checksumSHA256.Checked && !checksumSHA512.Checked) return;
            checksumComputeBtn.Enabled = true;
        }
        /// <summary>
        /// Represents a method, which updates current file and refreshes it's visual information
        /// </summary>
        /// <param name="filePath">(string) Absolute file path</param>
        private void setFile(string filePath) {
            // Initialize file handler
            file = new FileState(filePath);
            // If IO File Read operation was successful - update visual info, else - tell about error
            if (file.success) {
                started = true;
                fileSizeLabel.Text = file.size;
                fileNameBox.Text = file.name;
                filePathBox.Text = file.path;
                // If operation was successful - we have to unlock checksum controls
                checksumBox.Enabled = true;
                // Reset checksum fields
                resetChecksums();
            } else {
                // Reveal error information, if read operation wasn't successful
                MessageBox.Show(file.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Represents a method, which handles "Choose file" button click event
        /// </summary>
        /// <param name="sender">Represents button instance</param>
        /// <param name="e">Represents event instance</param>
        private void fileChooseBtn_Click(object sender, EventArgs e) {
            // Disable checksum controls, while new file is being set
            checksumBox.Enabled = false;
            // Using instance of File choose dialog, do the actions to set the file
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                // Set parameters of File dialog
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                // If file was chosen successfully, try to set the file
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    setFile(openFileDialog.FileName);
                }
            }
        }
        /// <summary>
        /// Represents a method to compute checksum by using set parameters
        /// </summary>
        /// <param name="algoCode">(string) Algorithm shortname</param>
        /// <returns>(string) Checksum or an error message</returns>
        private string Compute(string algoCode) {
            // Temporary checksum storage, i.e. result message
            string checksum;
            try {
                // Using stream of opened file, perform the computation
                using (var stream = File.OpenRead(file.path)) {
                    // Save the result of computation
                    checksum = Checksum.Compute(stream, algoCode)[0];
                }
            } catch (Exception e) {
                // Reveal error details, if there was an error
                MessageBox.Show(e.Message, "Error while computing a hash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Pass error message, instead of checksum, to fill desired algorithm checksum field
                checksum = "IO Read error";
            }
            // Return result of computation
            return checksum;
        }
        /// <summary>
        /// Perform visually assisted (via GUI) checksum computation
        /// </summary>
        /// <param name="stageNum">Current number of checksum</param>
        /// <param name="algoCheck">Instance of algorithm selector (CheckBox)</param>
        /// <param name="algoCode">Algorithm shortname</param>
        /// <param name="hashIndex">Index of algorithm checksum placeholder</param>
        /// <param name="hashsumBox">Referenced TextBox instance for desired algorithm checksum</param>
        private void VisualCompute(int stageNum, CheckBox algoCheck, string algoCode, int hashIndex, ref TextBox hashsumBox) {
            if (algoCheck.Checked) { hashes[hashIndex] = Compute(algoCode); hashsumBox.Text = hashes[hashIndex]; }
            checksumComputeProgress.Value = (100 * stageNum) / hashes.Length;
        }
        /// <summary>
        /// Represents a method to reset previous checksum computation results
        /// </summary>
        private void resetChecksums() {
            // Reset progressbar
            checksumComputeProgress.Value = 0;
            // Reset checksum computation results fields
            checksumMD5Box.Text = "";
            checksumSHA1Box.Text = "";
            checksumSHA256Box.Text = "";
            checksumSHA512Box.Text = "";
            // Reset checksum evaluation result
            checksumCompareBox.BackColor = Color.White;
        }
        /// <summary>
        /// Represents an algorithm choose event handler (CheckBox CheckState event)
        /// </summary>
        /// <param name="sender">Represents checkbox instance</param>
        /// <param name="e">Represents event instance</param>
        private void checksumAlgoChoose(object sender, EventArgs e) => buttonUnlock();
        /// <summary>
        /// Represents a method to display checksum evaluation results
        /// </summary>
        private void checksumCompare() {
            // If checksum to compare exists - evaluate them
            if (checksumCompareBox.Text.Length > 0 && checksumBox.Enabled) {
                if (hashes.Contains(checksumCompareBox.Text.ToLower()))
                { checksumCompareBox.BackColor = Color.GreenYellow; }
                else
                { checksumCompareBox.BackColor = Color.PaleVioletRed; }
            } else { checksumCompareBox.BackColor = Color.White; }
        }
        /// <summary>
        /// Represents a method to lock the forms
        /// </summary>
        /// <param name="state">(bool) Locked state (make them locked ?)</param>
        private void lockForm(bool state) { checksumBox.Enabled = !state; fileBox.Enabled = !state; }
        private void checksumComputeBtn_Click(object sender, EventArgs e) {
            // Tell that we've started computation
            checksumComputeBtn.Text = "Calculating...";
            // Reset previous checksum calculation results
            resetChecksums();
            // Lock the forms
            lockForm(true);
            // Perform visually responsive computation
            VisualCompute(1, checksumMD5, "md5", 0, ref checksumMD5Box);
            VisualCompute(2, checksumSHA1, "sha1", 1, ref checksumSHA1Box);
            VisualCompute(3, checksumSHA256, "sha256", 2, ref checksumSHA256Box);
            VisualCompute(4, checksumSHA512, "sha512", 3, ref checksumSHA512Box);
            // Compare checksums with entered checksum
            checksumCompare();
            // Unlock forms
            lockForm(false);
            // Return button text to original state
            checksumComputeBtn.Text = "Calculate";
        }
        /// <summary>
        /// Represents a handler of checksum-to-compare TextBox change event
        /// </summary>
        /// <param name="sender">Represents TextBox instance</param>
        /// <param name="e">Represents event instance</param>
        private void checksumCompareBox_TextChanged(object sender, EventArgs e) => checksumCompare();
        /// <summary>
        /// Represents a handler of about entry click event in menu
        /// </summary>
        /// <param name="sender">MenuEntry instance</param>
        /// <param name="e">Represents event instance</param>
        private void MenuAbout_Click(object sender, EventArgs e) => new AboutProgram().Show();
        /// <summary>
        /// Represents a handler of entering in Drag'n'Drop mode event
        /// </summary>
        /// <param name="sender">Represents event sender instance</param>
        /// <param name="e">Represents event instance</param>
        private void fileBox_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) { e.Effect = DragDropEffects.Copy; }
            else { e.Effect = DragDropEffects.None; }
        }
        /// <summary>
        /// Represents a handler of completion event of Drag'n'Drop operation
        /// </summary>
        /// <param name="sender">Represents event sender instance</param>
        /// <param name="e">Represents event instance</param>
        private void fileBox_DragDrop(object sender, DragEventArgs e) {
            // Split received file paths
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            // Take only first file path
            if (filePaths.Length > 0) {
                // Set new Current file
                setFile(filePaths[0]);
            }
        }
    }
}