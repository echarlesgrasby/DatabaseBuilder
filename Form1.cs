/*
 * Project: DatabaseBuilder
 * Author: Eric C. Grasby, MSIQ
 * Contact: ecgrasby@ualr.edu
 *
 * Class Name: Form1
 *
 * Description: Code to support main program operations from Form1.cs
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

    public partial class Form1 : Form
    {
        List<String> pubFiles = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void citationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DatabaseBuilder Application\nVersion: v0.1\nAuthor: Eric C. Grasby, MSIQ\n\n" +
                            "This application is built in support of a dissertation (A Domain-Specific Language" +
                            "Approach to Monitoring and Surveillance Within Wholesale Electricity Markets)");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFetchFileListings_Click(object sender, EventArgs e)
        {
            List<String> directories = FolderUtilities.GetAllFileDirectories(txtBasePath.Text.Trim());
            string output = string.Empty;
            foreach (String directory in directories)
            {
                output += directory + "\n";
            }

            this.pubFiles = FolderUtilities.GetAllPublicCsvFiles(directories);
            this.fillFolderListing();
        }

        private void fillFolderListing()
        {
            try
            {
                tbPublicFileListing.UseWaitCursor = true;
                var files2List = this.pubFiles.Select(f => new FileItem
                {
                    FileName = Path.GetFileName(f),
                    FullPath = f
                }).ToList();


                tbPublicFileListing.DataSource = files2List;
                tbPublicFileListing.AutoResizeColumns();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                tbPublicFileListing.UseWaitCursor = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnListBronzeFiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List Bronze files..");
        }

        private void btnRebuildBronzeLayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rebuilding Bronze layer..");
        }

        private void btnListSilverFiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List Silver files..");
        }

        private void btnRebuildSilverLayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rebuilding Silver layer..");
        }

        private void btnListGoldFiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List Gold files..");
        }

        private void btnRebuildGoldLayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rebuilding Gold layer..");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
