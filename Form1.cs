using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listViewDisplay.DoubleClick += new EventHandler(ListViewDisplay_DoubleClick);
            listViewDisplay.KeyDown += ListViewDisplay_KeyDown;
            searchButton.KeyDown += SearchButton_KeyDown;

            extensionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            extensionCombo.Items.Add("txt");
            extensionCombo.Items.Add("csv");
            extensionCombo.SelectedItem = "txt";
        }

        private void SearchButton_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListViewDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListViewDisplay_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void folderSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
