using System;
using System.Collections.Generic;
using System.Windows;
namespace Point2DChart {
    public class ChartViewModel {
        List<DataPoint> dataPoints;
        public List<DataPoint> DataPoints {
            get {
                if (dataPoints == null) {
                    dataPoints = new List<DataPoint> {
                            new DataPoint (new DateTime(2019, 1, 1), 7.2),
                            new DataPoint (new DateTime(2019, 2, 1), 8.3),
                            new DataPoint (new DateTime(2019, 3, 1), 12.2),
                            new DataPoint (new DateTime(2019, 4, 1), 15.6),
                            new DataPoint (new DateTime(2019, 5, 1), 19.6),
                            new DataPoint (new DateTime(2019, 6, 1), 22.7),
                            new DataPoint (new DateTime(2019, 7, 1), 25.2),
                            new DataPoint (new DateTime(2019, 8, 1), 25),
                            new DataPoint (new DateTime(2019, 9, 1), 21.1),
                            new DataPoint (new DateTime(2019, 10, 1), 16.3),
                            new DataPoint (new DateTime(2019, 11, 1), 10.8),
                            new DataPoint (new DateTime(2019, 12, 1), 7.5)
                };
                }
                return dataPoints;
            }
        }
    }
    public class DataPoint {
        public DateTime Time { get; set; }
        public double Value { get; set; }
        public DataPoint(DateTime time, double value) {
            this.Time = time;
            this.Value = value;
        }
    }
}