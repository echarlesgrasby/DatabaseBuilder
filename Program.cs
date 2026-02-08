/*
 * Project: DatabaseBuilder
 * Author: Eric C. Grasby, MSIQ
 * Contact: ecgrasby@ualr.edu
 *
 * Class Name: Program.cs
 *
 * Description: Main entry point for DatabaseBuilder.exe
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
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}