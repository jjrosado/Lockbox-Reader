using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Data;

namespace LRLogic
{
    public class Utilities
    {
        public static string VerifyLength(string value, int maxLength)
        {
            if (value.Trim() == "")
            {
                return ("XXXXXXXXXXXXXXXXXXXXXXX").Substring(0, maxLength);
            }
            return value;
        }

        public static void WriteFile(string file, string data)
        {
            Utilities.CsvRow rows = new Utilities.CsvRow();
            rows.Add(data);
            using (Utilities.CsvFileWriter writer = new LRLogic.Utilities.CsvFileWriter(file))
            {
                writer.WriteRow(rows);
                writer.Close();
            }
        }
        public static void CopyFile(string fileName)
        {
            string fileToMove = ConfigurationManager.AppSettings["Files"].ToString() + fileName;
            string processedFolder = ConfigurationManager.AppSettings["FilesProcessed"].ToString() + fileName;

            if (File.Exists(processedFolder))
            {
                File.Delete(processedFolder);
            }

            File.Copy(fileToMove, processedFolder);
        }

        public class CsvRow : List<string>
        {
            public string LineText { get; set; }
        }

        public class CsvFileWriter : StreamWriter
        {
            public CsvFileWriter(Stream stream)
                : base(stream)
            {
            }

            public CsvFileWriter(string filename)
                : base(filename)
            {
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="row"></param>
            public void WriteRow(CsvRow row)
            {
                StringBuilder builder = new StringBuilder();
                foreach (string value in row)
                {
                    // Add separator if this isn't the first value
                    if (builder.Length > 0)
                        builder.Append(',');

                    builder.Append(value.Replace("X",""));
                }
                row.LineText = builder.ToString();
                WriteLine(row.LineText);
                
            }
        }
    }
}
