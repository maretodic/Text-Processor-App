using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessor
{
    public partial class Form1 : Form
    {
        List<string> filePathList;
        string searchString;
        int counter;
        public Form1()
        {
            InitializeComponent();
            listViewDisplay.DoubleClick += new EventHandler(ListViewDisplay_DoubleClick);
            listViewDisplay.KeyDown += ListViewDisplay_KeyDown;
            searchStringInput.KeyDown += SearchStringInput_KeyDown;

            extensionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            extensionCombo.Items.Add("txt");
            extensionCombo.Items.Add("csv");
            extensionCombo.SelectedItem = "txt";
        }

        private void SearchStringInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchButton_Click(this, new EventArgs());
            }
        }

        private void ListViewDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                viewButton_Click(this, new EventArgs());
            }
        }

        private void ListViewDisplay_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", listViewDisplay.SelectedItems[0].Text);
        }

        private void folderSearchButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPathInput.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchInput = searchStringInput.Text;
            bool isPathValid = CheckFolders(folderPathInput.Text);
            if (!isPathValid)
            {
                MessageBox.Show("Invalid folder path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(searchInput))
            {
                MessageBox.Show("Please enter search string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ScanFiles(searchInput);
            }
        }
        private bool CheckFolders(string folderPath)
        {
            filePathList = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            if (!directoryInfo.Exists)
            {
                return false;
            }
            else
            {
                string fileExtension = "*." + extensionCombo.SelectedItem.ToString();
                foreach (var path in directoryInfo.EnumerateFiles(fileExtension, SearchOption.AllDirectories))
                {
                    filePathList.Add(path.FullName);
                }
                return true;
            }
        }

        private void ScanFiles(string searchInput)
        {
            foreach (var path in filePathList)
            {
                string readLine;
                counter = 0;
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((readLine = sr.ReadLine()) != null)
                    {
                        string[] words = readLine.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (caseSensitiveBox.Checked)
                        {
                            counter += words.Count(w => w == searchInput);
                        }
                        else counter += words.Count(w => w.ToLowerInvariant() == searchInput.ToLowerInvariant());
                    }
                }

                if (counter == 0)
                {
                    MessageBox.Show("No files match your criteria", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    stringLabel.Text = "\"" + searchInput + "\"";
                    stringLabel.Visible = true;
                    ListViewItem listViewItem = new ListViewItem(path);
                    listViewItem.SubItems.Add(counter.ToString());
                    listViewDisplay.Items.Add(listViewItem);

                }

            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
