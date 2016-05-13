using System;
using System.IO;
using System.Windows.Forms;

namespace DirectoryCreator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBrowseParentDirectory_Click(object sender, EventArgs e)
        {
            var parentDirResult = parentFolderBrowserDialog.ShowDialog();
            if (parentDirResult == DialogResult.OK)
            {
                txtParentDirectory.Text = parentFolderBrowserDialog.SelectedPath;
                btnGo.Enabled = true;
                txtDirectoryNames.Enabled = true;
            }
            else
            {
                btnGo.Enabled = false;
                txtDirectoryNames.Enabled = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            txtDirectoryNames.Enabled = false;

            txtLogs.Text = String.Format("1. Select parent directory.{0}2. Add directory names in separate lines{0}3. Click 'Go'.", Environment.NewLine);
        }

        private void txtParentDirectory_TextChanged(object sender, EventArgs e)
        {
            if (txtParentDirectory.Text.Equals(String.Empty))
            {
                btnGo.Enabled = false;
                txtDirectoryNames.Enabled = false;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtLogs.Text = String.Empty;
            string sequenceFormat = String.Empty;
            int sequence = Int32.MinValue;

            if (String.IsNullOrWhiteSpace(txtParentDirectory.Text))
            {
                errorProvider.SetError(txtParentDirectory, "Field cannot be empty.");
                txtLogs.AppendText(String.Format("Operation cancelled because of invalid parent directory value.{0}", Environment.NewLine));
                return;
            }

            if (String.IsNullOrWhiteSpace(txtDirectoryNames.Text))
            {
                errorProvider.SetError(txtDirectoryNames, "Field cannot be empty.");
                txtLogs.AppendText(String.Format("Operation cancelled because of invali directory names.{0}", Environment.NewLine));
                return;
            }

            if (!String.IsNullOrWhiteSpace(txtSequenceSeed.Text) && !Int32.TryParse(txtSequenceSeed.Text, out sequence))
            {
                errorProvider.SetError(txtSequenceSeed, "Field cannot be empty.");
                txtLogs.AppendText(String.Format("Operation cancelled because of invalid sequence seed value.{0}", Environment.NewLine));
                return;
            }

            if (!String.IsNullOrWhiteSpace(txtSequenceFormat.Text))
            {
                sequenceFormat = String.Concat("{0:", txtSequenceFormat.Text, "}");
                try
                {
                    //Check if formatter value is valid or not
                    string.Format(sequenceFormat, 1);
                }
                catch (Exception)
                {
                    txtLogs.AppendText(String.Format("Operation cancelled because of invalid sequence formatter value.{0}", Environment.NewLine));
                    return;
                }
            }

            var directoryNames = txtDirectoryNames.Lines;
            var parentDirectory = txtParentDirectory.Text;
            bool hasSequencePrefix = checkBoxSequenceNumber.Checked && sequence != Int32.MinValue;
            var separator = txtSeparator.Text;

            foreach (var directoryName in directoryNames)
            {
                var newDirectoryName = hasSequencePrefix
                    ? String.Format("{0}{1}{2}", String.Format(sequenceFormat, sequence++), separator, directoryName) : directoryName;
                var fullDirectorypath = Path.Combine(parentDirectory,  newDirectoryName);

                if (!Directory.Exists(fullDirectorypath))
                {
                    Directory.CreateDirectory(fullDirectorypath);
                    txtLogs.AppendText(String.Format("Created {0}{1}", fullDirectorypath, Environment.NewLine));
                }
                else
                {
                    txtLogs.AppendText(String.Format("Skipped {0}, already exists{1}", fullDirectorypath, Environment.NewLine));
                }
            }
        }
    }
}
