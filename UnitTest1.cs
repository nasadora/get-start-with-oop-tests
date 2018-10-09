using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GetStartWithOOPTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var emps = GetHRSampleDataWithID();
            foreach (var emp in emps)
            {
                Console.WriteLine(HR.Utilites.CommonUtility.GetFullname(emp));
            }
            Console.WriteLine();
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.GetFullname());
            }
        }
    }
}
