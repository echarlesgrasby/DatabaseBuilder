/*
 * Project: DatabaseBuilder
 * Author: Eric C. Grasby, MSIQ
 * Contact: ecgrasby@ualr.edu
 *
 * Class Name: FolderUtilities
 *
 * Description: Functions that can traverse a directory structure and read all source CSV filenames into memory
 *
 * License: GPL-3.0-or-later
 * 
 * This file is used as a utility in support of the author's dissertation work:
 * "A Domain-Specific Language Approach to Monitoring and Surveillance Operations Within Wholesale Electricity Markets"
 * It is distributed under the GNU General Public License v3.0 (GPL-3.0-or-later).
 * You should have received a copy of the GPL along with this project.
 * If not, see <https://www.gnu.org/licenses/>.
 */

using DatabaseBuilder;
using System;
using System.DirectoryServices;
using System.IO;
using System.Runtime.CompilerServices;

public static class FolderUtilities
{

    public static List<String> GetAllFileDirectories(string baseDir)
    {
        List<String> dirs = new List<string>();

        try
        {
            Directory.GetDirectories(baseDir)
                .ToList<String>()
                .ForEach(dir =>{
                            if (dir.EndsWith("venv"))
                            {
                                return;
                            }
                            dirs.Add(dir);
                            dirs.AddRange(GetAllFileDirectories(dir));
                          });
        }
        catch(ArgumentException e)
        {
            MessageBox.Show(e.Message);
            return new List<string>();
        }
        catch(DirectoryNotFoundException d)
        {
            MessageBox.Show(d.Message);
            return new List<string>();
        }
        return dirs;
    }

    public static List<String> GetAllPublicFiles(List<String> dirs, string extensionMask)
    {
        List<String> files = new List<String>();
        foreach(String directory in dirs)
        {
            List<String> pubFiles = Directory.GetFiles(directory)
                .Where(ff => ff.EndsWith(extensionMask)).ToList();
            files.AddRange(pubFiles);
        }

        return files;
    }
}
