using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static GeometricAreas.Shapes2D.Circle;
using static System.Math;
using System.Configuration;
using GeometricAreas.MathModels;

namespace Tests
{
    [TestClass]
    public class CircleTest
    {
        private static readonly double Epsilon = Double.Parse(ConfigurationManager.AppSettings["epsilon"]);

        [TestMethod]
        public void TestArea()
        {
            List<List<double>> testCollection = new List<List<double>>()
            {
                new List<double>() {1, PI},
                new List<double>() {2, 4*PI},
                new List<double>() {3, 9*PI}
            };
            
            foreach (var vals in testCollection)
            {
                Assert.IsTrue(Abs(Area(vals[0]) - vals[1]) < Epsilon);
            }
        }
        
        [TestMethod]
        public void TestSegmentArea()
        {
            List<List<double>> testCollection = new List<List<double>>()
            {
                new List<double>() {1, PI/2, PI/4},
                new List<double>() {1, PI/4, PI/8},
                new List<double>() {1, PI*2/3, PI/3}
            };
            
            foreach (var vals in testCollection)
            {
                Assert.IsTrue(Abs(SegmentArea(vals[0], vals[1]) - vals[2]) < Epsilon);
            }
        }
    }
}