﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.NajibN.Sprint5.Task5.V21.Lib;

namespace Tyuiu.NajibN.Sprint5.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        
            {
                DataService ds = new DataService();
                string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";

                FileInfo fl = new FileInfo(path);
                bool fle = fl.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fle);
            }
        } } 
