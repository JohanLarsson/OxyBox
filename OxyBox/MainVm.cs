using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OxyPlot;

namespace OxyBox
{
    public class MainVm
    {
        public MainVm()
        {
            Line1 = Enumerable.Range(0, 360).Select(x => new DataPoint(x, Math.Sin(x * Math.PI / 180))).ToList();
            Line2 = Enumerable.Range(0, 360).Select(x => new DataPoint(x, Math.Sin((45 + x) * Math.PI / 180))).ToList();
        }

        public IReadOnlyList<DataPoint> Line2 { get; set; }

        public IReadOnlyList<DataPoint> Line1 { get; set; }
    }
}
