using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TestKMP.Models.Utils
{
    public class DataSet
    {
        public List<string> listData(string path)
        {
            List<string> listA = new List<string>();
            using (var reader = new StreamReader(path))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    //listB.Add(values[1]);
                }
            }
            return listA;
        }
        public string textData(string path)
        {
            string text = "";
            using (var reader = new StreamReader(path))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                   // var values = line.Split(',');

                    text = text + line + "\n";
                }
            }
            return text;
        }
    }
}