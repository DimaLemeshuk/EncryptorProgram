using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lr1__BIS_.Classes
{
    public static class FileWork
    {
        public static void WriteToFile(string path, string text)
        {
            
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(text);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        public static string ReadFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string text = reader.ReadToEnd();
                    return text;
                }
            }
            catch
            { 
                return null;
            }

        }

        public static bool OpenFile(string path)
        {
            try
            {
                Process.Start(path);
                return true;
            }
            catch
            {
                return false;
            }
                
        }

        public static string GetFilePathMenu()
        {
            string path = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                }
            }

            return path;
        }

        public static string SaveFileMenu()
        {
            string path = "";

            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.DefaultExt = ".txt";

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    path = SFD.FileName;
                }
            }

            return path;
        }
    }
}

