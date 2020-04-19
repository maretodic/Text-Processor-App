using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            throw new NotImplementedException();
        }

        private void folderSearchButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                searchStringInput.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchInput = searchStringInput.Text;
            bool isPathValid = CheckFolders(searchStringInput.Text);
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

        private void ScanFiles(string searchInput)
        {
            throw new NotImplementedException();
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

        private void viewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
