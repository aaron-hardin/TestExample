using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFilesAPI;
using NUnit.Framework;
using Test;
using MFiles.TestSuite.MockObjectModels;

namespace UnitTests
{
    [TestFixture]
    public class Class1
    {
        [TestCase("hi")]
        [TestCase("eek")]
        public void TestMethod(string arg)
        {
            Console.WriteLine(arg);
        }

        [TestCase("asdf", "Name that makes sense")]
        public void TestChangeNameOrTitle(string name, string newName)
        {
            Program program = new Program();
            
            TestPropertyValues props = new TestPropertyValues();
            TestPropertyValue prop = new TestPropertyValue();
            prop.PropertyDef = 0;
            prop.Value = new TestTypedValue();
            prop.Value.SetValue(MFDataType.MFDatatypeText, name);
            props.Add(-1, prop);

            Assert.AreEqual(name, props.SearchForProperty(0).Value.Value);

            TestPropertyValues newProps = (TestPropertyValues)program.ChangeNameOrTitle(props, newName);
            
            Assert.AreEqual(newName, newProps.SearchForProperty(0).Value.Value);
        }

        [TestCase("jprop", 0)]
        [TestCase("jprop", -1, ExpectedException = typeof(IndexOutOfRangeException))]
        public void TestGetPropertyDefName(string name, int pid)
        {
            Console.WriteLine("Running TestGetPropertyDefName with expected name: {0} for property id {1}", name, pid);
            Program program = new Program();
            TestVault vault = new TestVault();
            TestPropertyDefAdmin jprop = new TestPropertyDefAdmin
            {
                PropertyDef = new TestPropertyDef { ID = 0, Name = "jprop" }
            };
            vault.PropertyDefOperations.AddPropertyDefAdmin(jprop);
            string propName = program.GetPropertyDefName(vault, pid);
            Assert.AreEqual(name, propName);
        }
    }
}
