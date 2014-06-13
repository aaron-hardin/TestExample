using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFilesAPI;

namespace UnitTests
{
    public class TestPropertyValues : PropertyValues
    {
        private List<TestPropertyValue> properties = new List<TestPropertyValue>();

        public void Add(int Index, PropertyValue PropertyValue)
        {
            // TODO: how to handle index?
            properties.Add((TestPropertyValue)PropertyValue);
        }

        public PropertyValues Clone()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return properties.Count; }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int PropertyDef)
        {
            for (int i = 0; i < properties.Count; i++)
            {
                if (properties[i].PropertyDef == PropertyDef)
                    return i;
            }
            return -1;
        }

        public void Remove(int Index)
        {
            throw new NotImplementedException();
        }

        public PropertyValue SearchForProperty(int PropertyDef)
        {
            for (int i = 0; i < properties.Count; i++)
            {
                if (properties[i].PropertyDef == PropertyDef)
                    return properties[i];
            }
            return null;
        }

        public PropertyValue this[int Index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
