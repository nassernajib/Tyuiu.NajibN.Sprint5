using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.NajibN.Sprint5.Task4.V14.Lib;
namespace Tyuiu.NajibN.Sprint5.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
        {
            [TestMethod]
            public void CheckedExistFile()
            {
                string path = @"C:\DataSprint5\InPutDataFileTask4V14.txt";
                FileInfo fileInfo = new FileInfo(path);
                bool fileExist = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExist);
            }
        }
    }
