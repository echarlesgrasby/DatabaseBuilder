/*
 * Project: DatabaseBuilder
 * Author: Eric C. Grasby, MSIQ
 * Contact: ecgrasby@ualr.edu
 *
 * Class Name: Form1.Designer
 *
 * Description: Code-behind for main program form
 *
 * License: GPL-3.0-or-later
 * 
 * This file is used as a utility in support of the author's dissertation work:
 * "A Domain-Specific Language Approach to Monitoring and Surveillance Operations Within Wholesale Electricity Markets"
 * It is distributed under the GNU General Public License v3.0 (GPL-3.0-or-later).
 * You should have received a copy of the GPL along with this project.
 * If not, see <https://www.gnu.org/licenses/>.
 */

namespace DatabaseBuilder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            applicationInfoToolStripMenuItem = new ToolStripMenuItem();
            citationToolStripMenuItem = new ToolStripMenuItem();
            tbControl = new TabControl();
            tbFiles = new TabPage();
            tbPublicFileListing = new DataGridView();
            tbEia860Files = new TabPage();
            label4 = new Label();
            tbWeatherFiles = new TabPage();
            btnFetchFileListings = new Button();
            txtBasePath = new TextBox();
            panel1 = new Panel();
            grbGoldLayer = new GroupBox();
            btnRebuildGoldLayer = new Button();
            btnListGoldFiles = new Button();
            txtBasePathGold = new TextBox();
            label3 = new Label();
            grbSilverLayer = new GroupBox();
            btnRebuildSilverLayer = new Button();
            btnListSilverFiles = new Button();
            txtBasePathSilver = new TextBox();
            label2 = new Label();
            grbBronzeLayer = new GroupBox();
            btnRebuildBronzeLayer = new Button();
            btnListBronzeFiles = new Button();
            txtBasePathBronze = new TextBox();
            label1 = new Label();
            grbRawLayer = new GroupBox();
            lblBaseDir = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            tbControl.SuspendLayout();
            tbFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPublicFileListing).BeginInit();
            tbEia860Files.SuspendLayout();
            tbWeatherFiles.SuspendLayout();
            panel1.SuspendLayout();
            grbGoldLayer.SuspendLayout();
            grbSilverLayer.SuspendLayout();
            grbBronzeLayer.SuspendLayout();
            grbRawLayer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1227, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(89, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { applicationInfoToolStripMenuItem, citationToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // applicationInfoToolStripMenuItem
            // 
            applicationInfoToolStripMenuItem.Name = "applicationInfoToolStripMenuItem";
            applicationInfoToolStripMenuItem.Size = new Size(159, 22);
            applicationInfoToolStripMenuItem.Text = "Application Info";
            applicationInfoToolStripMenuItem.Click += applicationInfoToolStripMenuItem_Click;
            // 
            // citationToolStripMenuItem
            // 
            citationToolStripMenuItem.Name = "citationToolStripMenuItem";
            citationToolStripMenuItem.Size = new Size(159, 22);
            citationToolStripMenuItem.Text = "Citation";
            citationToolStripMenuItem.Click += citationToolStripMenuItem_Click;
            // 
            // tbControl
            // 
            tbControl.AccessibleName = "";
            tbControl.Controls.Add(tbFiles);
            tbControl.Controls.Add(tbEia860Files);
            tbControl.Controls.Add(tbWeatherFiles);
            tbControl.Location = new Point(12, 289);
            tbControl.Name = "tbControl";
            tbControl.SelectedIndex = 0;
            tbControl.Size = new Size(1203, 480);
            tbControl.TabIndex = 2;
            // 
            // tbFiles
            // 
            tbFiles.Controls.Add(tbPublicFileListing);
            tbFiles.Location = new Point(4, 24);
            tbFiles.Name = "tbFiles";
            tbFiles.Padding = new Padding(3);
            tbFiles.Size = new Size(1195, 452);
            tbFiles.TabIndex = 0;
            tbFiles.Text = "Public Files (SPP)";
            tbFiles.UseVisualStyleBackColor = true;
            // 
            // tbPublicFileListing
            // 
            tbPublicFileListing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbPublicFileListing.Dock = DockStyle.Fill;
            tbPublicFileListing.Location = new Point(3, 3);
            tbPublicFileListing.Name = "tbPublicFileListing";
            tbPublicFileListing.ReadOnly = true;
            tbPublicFileListing.Size = new Size(1189, 446);
            tbPublicFileListing.TabIndex = 0;
            // 
            // tbEia860Files
            // 
            tbEia860Files.Controls.Add(label4);
            tbEia860Files.Location = new Point(4, 24);
            tbEia860Files.Name = "tbEia860Files";
            tbEia860Files.Padding = new Padding(3);
            tbEia860Files.Size = new Size(1195, 452);
            tbEia860Files.TabIndex = 1;
            tbEia860Files.Text = "EIA 860 Files";
            tbEia860Files.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 23);
            label4.Name = "label4";
            label4.Size = new Size(192, 15);
            label4.TabIndex = 0;
            label4.Text = "EIA 860 Files should be listed here...";
            // 
            // tbWeatherFiles
            // 
            tbWeatherFiles.Controls.Add(label5);
            tbWeatherFiles.Location = new Point(4, 24);
            tbWeatherFiles.Name = "tbWeatherFiles";
            tbWeatherFiles.Padding = new Padding(3);
            tbWeatherFiles.Size = new Size(1195, 452);
            tbWeatherFiles.TabIndex = 2;
            tbWeatherFiles.Text = "Weather Data (SPP)";
            tbWeatherFiles.UseVisualStyleBackColor = true;
            // 
            // btnFetchFileListings
            // 
            btnFetchFileListings.ForeColor = SystemColors.ActiveCaptionText;
            btnFetchFileListings.Location = new Point(6, 175);
            btnFetchFileListings.Name = "btnFetchFileListings";
            btnFetchFileListings.Size = new Size(121, 23);
            btnFetchFileListings.TabIndex = 0;
            btnFetchFileListings.Text = "Fetch File Listings";
            btnFetchFileListings.UseVisualStyleBackColor = true;
            btnFetchFileListings.Click += btnFetchFileListings_Click;
            // 
            // txtBasePath
            // 
            txtBasePath.Location = new Point(6, 63);
            txtBasePath.Name = "txtBasePath";
            txtBasePath.Size = new Size(268, 23);
            txtBasePath.TabIndex = 1;
            txtBasePath.Text = "D:\\pub_data_archive\\raw\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(grbGoldLayer);
            panel1.Controls.Add(grbSilverLayer);
            panel1.Controls.Add(grbBronzeLayer);
            panel1.Controls.Add(grbRawLayer);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1196, 240);
            panel1.TabIndex = 3;
            // 
            // grbGoldLayer
            // 
            grbGoldLayer.BackColor = Color.Gold;
            grbGoldLayer.Controls.Add(btnRebuildGoldLayer);
            grbGoldLayer.Controls.Add(btnListGoldFiles);
            grbGoldLayer.Controls.Add(txtBasePathGold);
            grbGoldLayer.Controls.Add(label3);
            grbGoldLayer.Location = new Point(899, 12);
            grbGoldLayer.Name = "grbGoldLayer";
            grbGoldLayer.Size = new Size(278, 209);
            grbGoldLayer.TabIndex = 4;
            grbGoldLayer.TabStop = false;
            grbGoldLayer.Text = "Silver Layer";
            // 
            // btnRebuildGoldLayer
            // 
            btnRebuildGoldLayer.ForeColor = SystemColors.ActiveCaptionText;
            btnRebuildGoldLayer.Location = new Point(144, 175);
            btnRebuildGoldLayer.Name = "btnRebuildGoldLayer";
            btnRebuildGoldLayer.Size = new Size(132, 23);
            btnRebuildGoldLayer.TabIndex = 6;
            btnRebuildGoldLayer.Text = "Rebuild Gold Layer";
            btnRebuildGoldLayer.UseVisualStyleBackColor = true;
            btnRebuildGoldLayer.Click += btnRebuildGoldLayer_Click;
            // 
            // btnListGoldFiles
            // 
            btnListGoldFiles.ForeColor = SystemColors.ActiveCaptionText;
            btnListGoldFiles.Location = new Point(7, 175);
            btnListGoldFiles.Name = "btnListGoldFiles";
            btnListGoldFiles.Size = new Size(121, 23);
            btnListGoldFiles.TabIndex = 5;
            btnListGoldFiles.Text = "List Gold Files\r\n";
            btnListGoldFiles.UseVisualStyleBackColor = true;
            btnListGoldFiles.Click += btnListGoldFiles_Click;
            // 
            // txtBasePathGold
            // 
            txtBasePathGold.Location = new Point(6, 63);
            txtBasePathGold.Name = "txtBasePathGold";
            txtBasePathGold.Size = new Size(268, 23);
            txtBasePathGold.TabIndex = 4;
            txtBasePathGold.Text = "D:\\pub_data_archive\\gold\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 2;
            label3.Text = "Gold Directory";
            // 
            // grbSilverLayer
            // 
            grbSilverLayer.BackColor = Color.LightSlateGray;
            grbSilverLayer.Controls.Add(btnRebuildSilverLayer);
            grbSilverLayer.Controls.Add(btnListSilverFiles);
            grbSilverLayer.Controls.Add(txtBasePathSilver);
            grbSilverLayer.Controls.Add(label2);
            grbSilverLayer.Location = new Point(600, 12);
            grbSilverLayer.Name = "grbSilverLayer";
            grbSilverLayer.Size = new Size(281, 209);
            grbSilverLayer.TabIndex = 3;
            grbSilverLayer.TabStop = false;
            grbSilverLayer.Text = "Silver Layer";
            // 
            // btnRebuildSilverLayer
            // 
            btnRebuildSilverLayer.ForeColor = SystemColors.ActiveCaptionText;
            btnRebuildSilverLayer.Location = new Point(141, 175);
            btnRebuildSilverLayer.Name = "btnRebuildSilverLayer";
            btnRebuildSilverLayer.Size = new Size(132, 23);
            btnRebuildSilverLayer.TabIndex = 5;
            btnRebuildSilverLayer.Text = "Rebuild Silver Layer\r\n";
            btnRebuildSilverLayer.UseVisualStyleBackColor = true;
            btnRebuildSilverLayer.Click += btnRebuildSilverLayer_Click;
            // 
            // btnListSilverFiles
            // 
            btnListSilverFiles.ForeColor = SystemColors.ActiveCaptionText;
            btnListSilverFiles.Location = new Point(7, 175);
            btnListSilverFiles.Name = "btnListSilverFiles";
            btnListSilverFiles.Size = new Size(121, 23);
            btnListSilverFiles.TabIndex = 4;
            btnListSilverFiles.Text = "List Silver Files\r\n";
            btnListSilverFiles.UseVisualStyleBackColor = true;
            btnListSilverFiles.Click += btnListSilverFiles_Click;
            // 
            // txtBasePathSilver
            // 
            txtBasePathSilver.Location = new Point(7, 63);
            txtBasePathSilver.Name = "txtBasePathSilver";
            txtBasePathSilver.Size = new Size(268, 23);
            txtBasePathSilver.TabIndex = 4;
            txtBasePathSilver.Text = "D:\\pub_data_archive\\silver\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 2;
            label2.Text = "Silver Directory";
            // 
            // grbBronzeLayer
            // 
            grbBronzeLayer.BackColor = Color.SaddleBrown;
            grbBronzeLayer.Controls.Add(btnRebuildBronzeLayer);
            grbBronzeLayer.Controls.Add(btnListBronzeFiles);
            grbBronzeLayer.Controls.Add(txtBasePathBronze);
            grbBronzeLayer.Controls.Add(label1);
            grbBronzeLayer.Location = new Point(303, 12);
            grbBronzeLayer.Name = "grbBronzeLayer";
            grbBronzeLayer.Size = new Size(281, 209);
            grbBronzeLayer.TabIndex = 2;
            grbBronzeLayer.TabStop = false;
            grbBronzeLayer.Text = "Bronze Layer";
            grbBronzeLayer.Enter += groupBox1_Enter_1;
            // 
            // btnRebuildBronzeLayer
            // 
            btnRebuildBronzeLayer.ForeColor = SystemColors.ActiveCaptionText;
            btnRebuildBronzeLayer.Location = new Point(134, 175);
            btnRebuildBronzeLayer.Name = "btnRebuildBronzeLayer";
            btnRebuildBronzeLayer.Size = new Size(132, 23);
            btnRebuildBronzeLayer.TabIndex = 4;
            btnRebuildBronzeLayer.Text = "Rebuild Bronze Layer";
            btnRebuildBronzeLayer.UseVisualStyleBackColor = true;
            btnRebuildBronzeLayer.Click += btnRebuildBronzeLayer_Click;
            // 
            // btnListBronzeFiles
            // 
            btnListBronzeFiles.ForeColor = SystemColors.ActiveCaptionText;
            btnListBronzeFiles.Location = new Point(7, 175);
            btnListBronzeFiles.Name = "btnListBronzeFiles";
            btnListBronzeFiles.Size = new Size(104, 23);
            btnListBronzeFiles.TabIndex = 3;
            btnListBronzeFiles.Text = "List Bronze Files\r\n";
            btnListBronzeFiles.UseVisualStyleBackColor = true;
            btnListBronzeFiles.Click += btnListBronzeFiles_Click;
            // 
            // txtBasePathBronze
            // 
            txtBasePathBronze.Location = new Point(7, 63);
            txtBasePathBronze.Name = "txtBasePathBronze";
            txtBasePathBronze.Size = new Size(268, 23);
            txtBasePathBronze.TabIndex = 3;
            txtBasePathBronze.Text = "D:\\pub_data_archive\\bronze";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 2;
            label1.Text = "Bronze Directory";
            // 
            // grbRawLayer
            // 
            grbRawLayer.BackColor = Color.Azure;
            grbRawLayer.Controls.Add(lblBaseDir);
            grbRawLayer.Controls.Add(txtBasePath);
            grbRawLayer.Controls.Add(btnFetchFileListings);
            grbRawLayer.ForeColor = SystemColors.ActiveCaptionText;
            grbRawLayer.Location = new Point(7, 12);
            grbRawLayer.Name = "grbRawLayer";
            grbRawLayer.Size = new Size(280, 209);
            grbRawLayer.TabIndex = 1;
            grbRawLayer.TabStop = false;
            grbRawLayer.Text = "Source Raw Layer";
            grbRawLayer.Enter += groupBox1_Enter;
            // 
            // lblBaseDir
            // 
            lblBaseDir.AutoSize = true;
            lblBaseDir.BackColor = Color.Transparent;
            lblBaseDir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaseDir.ForeColor = SystemColors.ActiveCaptionText;
            lblBaseDir.Location = new Point(6, 29);
            lblBaseDir.Name = "lblBaseDir";
            lblBaseDir.Size = new Size(183, 21);
            lblBaseDir.TabIndex = 2;
            lblBaseDir.Text = "Base Archive Directory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 20);
            label5.Name = "label5";
            label5.Size = new Size(332, 15);
            label5.TabIndex = 0;
            label5.Text = "Weather Data covering the SPP footprint should be listed here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 781);
            Controls.Add(panel1);
            Controls.Add(tbControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "DatabaseBuilder - Eric C Grasby - Dissertation Support - Jan 2026";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tbControl.ResumeLayout(false);
            tbFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbPublicFileListing).EndInit();
            tbEia860Files.ResumeLayout(false);
            tbEia860Files.PerformLayout();
            tbWeatherFiles.ResumeLayout(false);
            tbWeatherFiles.PerformLayout();
            panel1.ResumeLayout(false);
            grbGoldLayer.ResumeLayout(false);
            grbGoldLayer.PerformLayout();
            grbSilverLayer.ResumeLayout(false);
            grbSilverLayer.PerformLayout();
            grbBronzeLayer.ResumeLayout(false);
            grbBronzeLayer.PerformLayout();
            grbRawLayer.ResumeLayout(false);
            grbRawLayer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem applicationInfoToolStripMenuItem;
        private ToolStripMenuItem citationToolStripMenuItem;
        private TabControl tbControl;
        private TabPage tbFiles;
        private Button btnFetchFileListings;
        private TextBox txtBasePath;
        private DataGridView tbPublicFileListing;
        private TabPage tbEia860Files;
        private TabPage tbWeatherFiles;
        private Panel panel1;
        private GroupBox grbRawLayer;
        private Label lblBaseDir;
        private GroupBox grbBronzeLayer;
        private Label label1;
        private GroupBox grbGoldLayer;
        private Label label3;
        private GroupBox grbSilverLayer;
        private Label label2;
        private TextBox txtBasePathGold;
        private Button btnListGoldFiles;
        private Button btnListSilverFiles;
        private TextBox txtBasePathSilver;
        private Button btnListBronzeFiles;
        private TextBox txtBasePathBronze;
        private Button btnRebuildGoldLayer;
        private Button btnRebuildSilverLayer;
        private Button btnRebuildBronzeLayer;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label4;
        private Label label5;
    }
}
