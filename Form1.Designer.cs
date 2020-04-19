namespace TextProcessor
{
    partial class Form1
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
            this.caseSensitiveBox = new System.Windows.Forms.CheckBox();
            this.folderSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.extensionCombo = new System.Windows.Forms.ComboBox();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.stringLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.searchStringInput = new System.Windows.Forms.TextBox();
            this.folderPathInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caseSensitiveBox
            // 
            this.caseSensitiveBox.AutoSize = true;
            this.caseSensitiveBox.Location = new System.Drawing.Point(368, 102);
            this.caseSensitiveBox.Name = "caseSensitiveBox";
            this.caseSensitiveBox.Size = new System.Drawing.Size(94, 17);
            this.caseSensitiveBox.TabIndex = 3;
            this.caseSensitiveBox.Text = "Case sensitive";
            this.caseSensitiveBox.UseVisualStyleBackColor = true;
            // 
            // folderSearchButton
            // 
            this.folderSearchButton.Location = new System.Drawing.Point(78, 134);
            this.folderSearchButton.Name = "folderSearchButton";
            this.folderSearchButton.Size = new System.Drawing.Size(115, 32);
            this.folderSearchButton.TabIndex = 1;
            this.folderSearchButton.Text = "Select a folder";
            this.folderSearchButton.UseVisualStyleBackColor = true;
            this.folderSearchButton.Click += new System.EventHandler(this.folderSearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(615, 134);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 32);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // extensionCombo
            // 
            this.extensionCombo.FormattingEnabled = true;
            this.extensionCombo.Location = new System.Drawing.Point(303, 99);
            this.extensionCombo.Name = "extensionCombo";
            this.extensionCombo.Size = new System.Drawing.Size(59, 21);
            this.extensionCombo.TabIndex = 2;
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(78, 192);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(652, 193);
            this.listViewDisplay.TabIndex = 4;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File path";
            this.columnHeader1.Width = 459;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Repetition number";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File containing string: ";
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Location = new System.Drawing.Point(190, 176);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(35, 13);
            this.stringLabel.TabIndex = 6;
            this.stringLabel.Text = "label2";
            this.stringLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search string:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Folder path: ";
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expLabel.Location = new System.Drawing.Point(75, 18);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(384, 24);
            this.expLabel.TabIndex = 9;
            this.expLabel.Text = "Select a folder and enter search string to start";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(344, 391);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(115, 32);
            this.viewButton.TabIndex = 10;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // searchStringInput
            // 
            this.searchStringInput.Location = new System.Drawing.Point(580, 97);
            this.searchStringInput.Name = "searchStringInput";
            this.searchStringInput.Size = new System.Drawing.Size(150, 20);
            this.searchStringInput.TabIndex = 4;
            // 
            // folderPathInput
            // 
            this.folderPathInput.Location = new System.Drawing.Point(79, 99);
            this.folderPathInput.Name = "folderPathInput";
            this.folderPathInput.Size = new System.Drawing.Size(218, 20);
            this.folderPathInput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.folderPathInput);
            this.Controls.Add(this.searchStringInput);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extensionCombo);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.folderSearchButton);
            this.Controls.Add(this.caseSensitiveBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox caseSensitiveBox;
        private System.Windows.Forms.Button folderSearchButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox extensionCombo;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.TextBox searchStringInput;
        private System.Windows.Forms.TextBox folderPathInput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

