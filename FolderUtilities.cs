using DatabaseBuilder;
using System;
using System.DirectoryServices;
using System.IO;
using System.Runtime.CompilerServices;

public static class FolderUtilities
{

    public static List<String> dirs = new List<String>();
    public static List<String> files = new List<String>();

    public static List<String> GetAllFileDirectories(string baseDir)
    {
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
                            GetAllFileDirectories(dir);
                          });
        }
        catch(ArgumentException e)
        {
            MessageBox.Show(e.Message);
            return new List<string>();
        }

        return dirs;
    }

    public static List<String> GetAllPublicCsvFiles()
    {
        foreach(String directory in dirs)
        {
            List<String> pubFiles = Directory.GetFiles(directory, "*.CSV").ToList();
            files.AddRange(pubFiles);
        }
        return files;
    }
}
