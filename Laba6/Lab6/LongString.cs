using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    class LongString
    {
        public List<int> DeleteLongestSeries(List<int> list)
        {
            int seriesLength = 1;
            int seriesStart = 0;
            int maxLength = 0;
            int maxStart = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] == list[i])
                {
                    seriesLength++;
                    if (maxLength < seriesLength)
                    {
                        maxLength = seriesLength;
                        maxStart = seriesStart;
                    }
                }
                else
                {
                    seriesLength = 1;
                    seriesStart = i;
                }
            }
            list.RemoveRange(maxStart, maxLength);
            return list;
        }

        public void Output(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Read();
        }
    }
}
