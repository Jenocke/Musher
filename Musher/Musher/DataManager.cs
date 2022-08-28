using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Musher
{
    internal static class DataManager
    {
        private static readonly MusherChipControlEntities musherChipControlEntities = new MusherChipControlEntities();
        public static void ProcessArrivals(string filePath)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(filePath))
                {
                    long staffChipID = 056000000000001;
                    long staffChipID2 = 056000000000002;
                    long staffChipID3 = 056000000000003;
                    string line = "";
                    long currentWatch = 0;
                    while ((line = fileReader.ReadLine()) != null)
                    {
                        //if end of file
                        if (string.Compare(line, 0, "End", 0, 3) == 0)
                        { break; }
                        else
                        {
                            int index = line.IndexOf(" ");
                            long chipID = Int64.Parse(line.Substring(0, index));
                            line = line.Remove(0, index + 1);
                            index = line.IndexOf(" ");
                            int date = Int32.Parse(line.Substring(0, index));

                            //find if entry is already in database
                            var rows = musherChipControlEntities.Arrivals_Table.Where(a=> a.WatchID == chipID).ToList();
                            if(rows.Count() == 0)
                            {
                                var arrival = new Arrivals_Table();

                                arrival.WatchID = chipID;
                                arrival.ArrivalDay1 = date;
                                arrival.ArrivalDay2 = 0;
                                musherChipControlEntities.Arrivals_Table.Add(arrival);
                                musherChipControlEntities.SaveChanges();
                                currentWatch = chipID;
                            }
                            else if (rows.Count() == 1)
                            {
                                if (rows[0].ArrivalDay1 != date)
                                {
                                    rows[0].ArrivalDay2 = date;
                                    musherChipControlEntities.SaveChanges();
                                    currentWatch = chipID;
                                }
                            }
                            while (true)
                            {
                                line = fileReader.ReadLine();
                                index = line.IndexOf(" ");
                                chipID = Int64.Parse(line.Substring(0, index));
                                if (chipID == staffChipID || chipID == staffChipID2 || chipID == staffChipID3)
                                { break; }
                                else
                                {
                                    var dog = new DogsTable();

                                    dog.DogChip = chipID;
                                    dog.LinkedMusher = currentWatch;
                                    musherChipControlEntities.DogsTable.Add(dog);
                                    musherChipControlEntities.SaveChanges();

                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
