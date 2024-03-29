﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeExcercise
{
    public class PrintPetReport
    {
        public void PrintReport(IEnumerable<IPet> pets, string filename)
        {
            List<string> entries = new List<string>();
            entries.Add("Owners name,Date Joined Practice,Number Of Visits,Number of Lives");
            foreach (var p in pets)
            {
                var entry = string.Join(" ", p.FirstName, p.LastName) + p.JoinedPractice + "," + p.NumberOfVisits;
                if (p is Cat)
                {
                    var cat = p as Cat;
                    entry += "," + cat.numberOfLives;
                }

                entries.Add(entry);
            }
            File.WriteAllLines(filename, entries.ToArray());
        }
    }

}
