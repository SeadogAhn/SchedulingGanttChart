using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GC4FJSP
{
using ListGanttItem = List<GanttItemType>;
    public struct GanttItemType
    {
        public string Type;
        public string Machine;
        public int Part;
        public int Step;
        public int Lot;
        public string Content;
        public int Start;
        public int End;
    }


    class GanttDataSetType
    {
        private ListGanttItem GanttData_ = new List<GanttItemType>();
        public void InitData(string strFileName)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(strFileName))
                {
                    string line;
                    sr.ReadLine(); // skip a lien
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        GanttItemType GanttItem;
                        string[] arrTemp = line.Split('|');
                        if (arrTemp.Length < 8)
                        {
                            throw new System.InvalidOperationException("File format is ablnormal.");
                        }

                        GanttItem.Type = arrTemp[0];
                        GanttItem.Machine = arrTemp[1];
                        if (arrTemp[2].Length == 0) GanttItem.Part = -1;
                        else GanttItem.Part = Int32.Parse(arrTemp[2]);
                        if (arrTemp[3].Length == 0) GanttItem.Step = -1;
                        else GanttItem.Step = Int32.Parse(arrTemp[3]);
                        if (arrTemp[4].Length == 0) GanttItem.Lot = -1;
                        else GanttItem.Lot = Int32.Parse(arrTemp[4]);
                        GanttItem.Content = arrTemp[5];
                        GanttItem.Start = Int32.Parse(arrTemp[6]);
                        GanttItem.End = Int32.Parse(arrTemp[7]);

                        GanttData_.Add(GanttItem);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show(String.Format("The file could not be read:{0}", e.Message), "File read error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<GanttItemType> GetGanttData()
        {
            return GanttData_;
        }
    }
}
