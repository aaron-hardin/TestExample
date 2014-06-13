using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFilesAPI;
using NUnit.Framework;

namespace Test
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MFilesServerApplication server = new MFilesServerApplication();
            server.Connect();
            Vault vault = server.LogInToVault("{B567121D-E666-4333-904F-D4EB81D66FDC}");

            //PropertyDefAdmin pda = vault.PropertyDefOperations.GetPropertyDefAdmin(1165);
            //Console.WriteLine(pda.PropertyDef.GUID);
            //Clipboard.SetText(pda.PropertyDef.GUID);
            ValueListItems classes =
                vault.ValueListItemOperations.GetValueListItems((int)MFBuiltInValueList.MFBuiltInValueListClasses);
            foreach (ValueListItem vl in classes)
            {
                Console.WriteLine(vl.Name + " " + vl.ItemGUID);
            }
            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        public void FakeTest()
        {
            MFilesServerApplication server = new MFilesServerApplication();
            server.Connect();
            Vault vault = server.LogInToVault("{82FB2FA4-6FBE-4546-A200-11CEF3DF2169}");

            PropertyDefAdmin ownerChangeElement = vault.PropertyDefOperations.GetPropertyDefAdmin(1213);
            ownerChangeElement.SemanticAliases.Value = "M-Files.Property.OwnerChangeElement";
            ownerChangeElement.PropertyDef.Name = "Owner (Change Element)";
            vault.PropertyDefOperations.UpdatePropertyDefAdmin(ownerChangeElement);

            PropertyDefAdmin ownerChangeRequest = vault.PropertyDefOperations.GetPropertyDefAdmin(1229);
            ownerChangeRequest.SemanticAliases.Value = "M-Files.Property.OwnerChangeRequest";
            ownerChangeRequest.PropertyDef.Name = "Owner (Change Request)";
            vault.PropertyDefOperations.UpdatePropertyDefAdmin(ownerChangeRequest);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        public PropertyValues ChangeNameOrTitle(PropertyValues props, string newName)
        {
            PropertyValue prop = new PropertyValue{PropertyDef = 0};
            prop.Value.SetValue(MFDataType.MFDatatypeText, newName);
            if(props.IndexOf(0) == -1)
                props.Add(-1, prop);
            else
            {
                props.SearchForProperty(0).Value.SetValue(MFDataType.MFDatatypeText, newName);
            }
            return props;
        }

        public string GetPropertyDefName(Vault vault, int propertyId)
        {
            return vault.PropertyDefOperations.GetPropertyDef(propertyId).Name;
        }

    }
}
