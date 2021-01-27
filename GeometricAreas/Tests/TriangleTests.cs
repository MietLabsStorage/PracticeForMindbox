using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static GeometricAreas.Shapes2D.Triangle;
using static System.Math;
using System.Configuration;
using GeometricAreas.MathModels;

namespace Tests
{
    [TestClass]
    public class TriangleTests
    {
        private static double _epsilon = Double.Parse(ConfigurationManager.AppSettings["epsilon"]);

        [TestMethod]
        public void TestArea()
        {
            List<List<double>> testCollection = new List<List<double>>()
            {
                new List<double>() {3, 4, 5, 6},
                new List<double>() {2.5, 2.5, 2.5, 2.70632938682637},
                new List<double>() {5,5,6,12}
            };
            
            foreach (var vals in testCollection)
            {
                Assert.IsTrue(Abs(Area(vals[0], vals[1], vals[2]) - vals[3]) < _epsilon);
            }
        }
        
        [TestMethod]
        public void TestGaussArea()
        {
            List<ArrayList> testCollection = new List<ArrayList>()
            {
                new ArrayList() {new Point(0,0), new Point(0,4), new Point(3,0 ),6},
                new ArrayList() {new Point(0,0), new Point(3,4), new Point(6,0 ),12}
            };
            
            foreach (var vals in testCollection)
            {
                Assert.IsTrue(Abs(GaussArea(vals[0] as Point, vals[1] as Point, vals[2] as Point) - Convert.ToDouble(vals[3])) < _epsilon);
            }
        }
        
        [TestMethod]
        public void TestRegularArea()
        {
            Assert.IsTrue(Abs(RegularTriangleArea(R: 2) - 5.1961524227) < _epsilon);
            Assert.IsTrue(Abs(RegularTriangleArea(r: 1) - 5.1961524227) < _epsilon);
            Assert.IsTrue(Abs(RegularTriangleArea(a: 2*Sqrt(3)) - 5.1961524227) < _epsilon);
        }
    }
}