using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static GeometricAreas.Shapes2D.Polygon;
using static System.Math;
using System.Configuration;
using GeometricAreas.MathModels;

namespace Tests
{
    [TestClass]
    public class PolygonTests
    {
        private static readonly double Epsilon = Double.Parse(ConfigurationManager.AppSettings["epsilon"]);

        [TestMethod]
        public void TestPickArea()
        {
            List<List<double>> testCollection = new List<List<double>>()
            {
                new List<double>() {8, 1, 4},
                new List<double>() {5, 3, 4.5},
                new List<double>() {3, 1, 1.5}
            };
            System.Console.WriteLine("*");
            foreach (var vals in testCollection)
            {
                Assert.IsTrue(Abs(PickArea((int)vals[1], (int)vals[0]) - vals[2]) < Epsilon);
            }
        }
    }
}