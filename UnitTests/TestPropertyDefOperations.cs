using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFilesAPI;

namespace UnitTests
{
    public class TestPropertyDefOperations : VaultPropertyDefOperations
    {
        public PropertyDefAdmin AddPropertyDefAdmin(PropertyDefAdmin PropertyDefAdmin, TypedValue ResetLastUsedValue = null)
        {
            throw new NotImplementedException();
        }

        public PropertyDef GetBuiltInPropertyDef(MFBuiltInPropertyDef PropertyDefType)
        {
            throw new NotImplementedException();
        }

        public PropertyDef GetPropertyDef(int PropertyDef)
        {
            if(PropertyDef < 0)
                throw new IndexOutOfRangeException("Out of range");
            PropertyDef prop = new PropertyDef { Name = "jprop", ID = PropertyDef };
            //prop.ThisIsConflictPD = true;
            return prop;
            // TODO: throw new NotImplementedException();
        }

        public PropertyDefAdmin GetPropertyDefAdmin(int PropertyDef)
        {
            throw new NotImplementedException();
        }

        public int GetPropertyDefIDByAlias(string Alias)
        {
            throw new NotImplementedException();
        }

        public int GetPropertyDefIDByGUID(string PropertyDefGUID)
        {
            throw new NotImplementedException();
        }

        public PropertyDefs GetPropertyDefs()
        {
            throw new NotImplementedException();
        }

        public PropertyDefsAdmin GetPropertyDefsAdmin()
        {
            throw new NotImplementedException();
        }

        public void RemovePropertyDefAdmin(int PropertyDef, bool CopyToAnotherPropertyDef = false, int TargetPropertyDef = 0, bool Append = false, bool DeleteFromClassesIfNecessary = false)
        {
            throw new NotImplementedException();
        }

        public void UpdatePropertyDefAdmin(PropertyDefAdmin PropertyDefAdmin, TypedValue ResetLastUsedValue = null)
        {
            throw new NotImplementedException();
        }

        public void UpdatePropertyDefWithAutomaticPermissionsAdmin(PropertyDefAdmin PropertyDefAdmin, TypedValue ResetLastUsedValue = null, bool AutomaticPermissionsForcedActive = false)
        {
            throw new NotImplementedException();
        }
    }
}
