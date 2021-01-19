using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singleton
{
    public sealed class FileStreamSingleton
    {
        private static readonly Lazy<FileStreamSingleton> instance = new Lazy<FileStreamSingleton>(() => new FileStreamSingleton());

        public string FilePath { get; }
        public string Text { get; set; }

        private FileStreamSingleton() {
            FilePath = "tasks.txt";
        }

        public static FileStreamSingleton getInstance() {
            return instance.Value;
        }

        public void WriteTask(string text) {
            Text += text;
        }

        public void Save() {
            using (var writer = new StreamWriter(new FileStream(FilePath, FileMode.Append, FileAccess.Write))) {
                writer.WriteLine(Text);
                Text = "";
            }
        }

        public void ReadText() {
            if (File.Exists(FilePath))
            {
                string alltext = "";
                using (var reader = new StreamReader(FilePath)) {
                    alltext = reader.ReadToEnd();
                    Console.WriteLine(alltext);
                }
            }
        }
    }
}
