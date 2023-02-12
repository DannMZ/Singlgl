using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LogsForUsr
{
    public sealed class Singleton
    {
        //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        /*string Loc = @"D:\" + "Log.log";*/
        static string Loc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Log.log";/**/
        private static readonly Singleton instance = new Singleton();

        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public void write_in_file(string Text)
        {
            //using (StreamReader readtext = new StreamReader(Loc + "Log.log")){readText = readtext.ReadLine();}
            // using (StreamWriter writer = new StreamWriter(Loc + "Log.log")){writer.WriteLine(Text);writer.Close();}
            string readText = File.ReadAllText(Loc); ;
            readText += "\n" + Text;
            File.WriteAllText(Loc, readText);
        }
        public void End()
        {
            string readText = File.ReadAllText(Loc); ;
            readText += "\nSession End time: " + DateTime.Today.ToString();
            File.WriteAllText(Loc, readText);
        }
        public static Singleton Instance
        {
            get
            {
                File.WriteAllText(Loc, "Session START time: " + DateTime.Today.ToString());
                return instance;
            }
        }
    }
}
