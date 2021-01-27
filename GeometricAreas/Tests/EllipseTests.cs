using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static GeometricAreas.Shapes2D.Ellipse;
using static System.Math;
using System.Configuration;
using GeometricAreas.MathModels;

namespace Tests
{
    [TestClass]
    public class EllipseTests
    {
        private static readonly double Epsilon = Double.Parse(ConfigurationManager.AppSettings["epsilon"]);

        [TestMethod]
        public void TestArea()
        {
            List<List<double>> testCollection = new List<List<double>>()
            {
                new List<double>() {1,1},
                new List<double>() {2,1},
                new List<double>() {1,2}
            };
            
            foreach (var vals in testCollection)
            {
                Assert.IsTrue(Abs(Area(vals[0], vals[1]) - Area(1 / (vals[0] * vals[0]), 0, 1 / (vals[1] * vals[1]))) < Epsilon);
            }
        }
    }
}