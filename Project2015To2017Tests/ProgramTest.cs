using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2015To2017;

namespace Project2015To2017Tests
{
	[TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ValidatesFileIsWritable()
        {
	        var progress = new Progress<string>(x => { });

            File.SetAttributes("TestFiles\\readonly.testcsproj", FileAttributes.ReadOnly);
            Assert.IsFalse(ProjectConverter.Validate(new FileInfo("TestFiles\\readonly.testcsproj"), progress));
        }

        [TestMethod]
        public void ValidatesFileExists()
        {
			
	        var progress = new Progress<string>(x => { });

            Assert.IsFalse(ProjectConverter.Validate(new FileInfo("TestFiles\\nonexistent.testcsproj"), progress));
        }
    }
}
