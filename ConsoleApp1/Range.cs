using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LAB06
{
    internal class Range
    {
        private int start;
        public int Start
        {
            get { return start; }
            set
            {
                if (value > finish)
                {
                    throw new ArgumentException("Начало отрезка не может быть больше конца.");
                }
                start = value;
            }
        }

        private int finish;
        public int Finish
        {
            get { return this.finish; }

            set
            {
                if (value < start)
                {
                    throw new ArgumentException("Конец отрезка не может быть меньше начала.");
                }
                finish = value;
            }
        }

        public Range(int start, int finish)
        {
            if (start > finish) 
                throw new ArgumentException("Начало отрезка не может быть больше конца.");

            this.start = start;
            this.finish = finish;
        }

        private bool IsIntersect(Range other)
        {
            return this.Start <= other.Finish && other.Start <= this.Finish;
        }

        public static Range operator +(Range r1, Range r2)
        {
            if (!r1.IsIntersect(r2))
            { 
                throw new ArgumentException("Отрезки не пересекаются.");
            }

            int newStart = Math.Min(r1.Start, r2.Start);
            int newFinish = Math.Max(r1.Finish, r2.Finish);
            return new Range(newStart, newFinish);
        }

        public static Range operator -(Range r1, Range r2)
        {
            if (!r1.IsIntersect(r2))
            {
                throw new ArgumentException("Отрезки не пересекаются.");
            }

            int newStart = Math.Max(r1.Start, r2.Start);
            int newFinish = Math.Min(r1.Finish, r2.Finish);
            return new Range(newStart, newFinish);
        }

        public override string ToString()
        {
            string arrayStr = "";
            for (int i = Start; i <= Finish; i++)
            {
                arrayStr += i;
                if (i < Finish) arrayStr += ", ";
            }

            return $"Range ({Start}, {Finish}), [{arrayStr}]";
        }
    }
}
