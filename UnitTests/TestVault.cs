using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFilesAPI;

namespace UnitTests
{
    public class TestVault : Vault
    {
        public dynamic Async
        {
            get { throw new NotImplementedException(); }
        }

        public void ChangePassword(string OldPassword, string NewPassword)
        {
            throw new NotImplementedException();
        }

        public VaultClassGroupOperations ClassGroupOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultClassOperations ClassOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultClientOperations ClientOperations
        {
            get { throw new NotImplementedException(); }
        }

        public void CloneFrom(Vault pIVaultSource)
        {
            throw new NotImplementedException();
        }

        public int CurrentLoggedInUserID
        {
            get { throw new NotImplementedException(); }
        }

        public VaultCustomApplicationManagementOperations CustomApplicationManagementOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultDataSetOperations DataSetOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultElectronicSignatureOperations ElectronicSignatureOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultEventLogOperations EventLogOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultExtensionMethodOperations ExtensionMethodOperations
        {
            get { throw new NotImplementedException(); }
        }

        public string GetGUID()
        {
            throw new NotImplementedException();
        }

        public string GetMFilesURLForVaultRoot()
        {
            throw new NotImplementedException();
        }

        public MFilesVersion GetServerVersionOfVault()
        {
            throw new NotImplementedException();
        }

        public void LogOutSilent()
        {
            throw new NotImplementedException();
        }

        public bool LogOutWithDialogs(IntPtr ParentWindow)
        {
            throw new NotImplementedException();
        }

        public bool LoggedIn
        {
            get { throw new NotImplementedException(); }
        }

        public VaultManagementOperations ManagementOperations
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public VaultNamedACLOperations NamedACLOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultNamedValueStorageOperations NamedValueStorageOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultObjectFileOperations ObjectFileOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultObjectOperations ObjectOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultObjectPropertyOperations ObjectPropertyOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultObjectSearchOperations ObjectSearchOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultObjectTypeOperations ObjectTypeOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultPropertyDefOperations PropertyDefOperations
        {
            get { return new TestPropertyDefOperations(); }
        }

        public bool ReadOnlyAccess
        {
            get { throw new NotImplementedException(); }
        }

        public VaultScheduledJobManagementOperations ScheduledJobManagementOperations
        {
            get { throw new NotImplementedException(); }
        }

        public SessionInfo SessionInfo
        {
            get { throw new NotImplementedException(); }
        }

        public void TestConnectionToServer()
        {
            throw new NotImplementedException();
        }

        public void TestConnectionToVault()
        {
            throw new NotImplementedException();
        }

        public void TestConnectionToVaultWithTimeout(int TimeoutInMilliseconds)
        {
            throw new NotImplementedException();
        }

        public VaultTraditionalFolderOperations TraditionalFolderOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultUserGroupOperations UserGroupOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultUserOperations UserOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultUserSettingOperations UserSettingOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultValueListItemOperations ValueListItemOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultValueListOperations ValueListOperations
        {
            get { throw new NotImplementedException(); }
        }

        public Languages VaultLanguages
        {
            get { throw new NotImplementedException(); }
        }

        public VaultViewOperations ViewOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultWorkflowOperations WorkflowOperations
        {
            get { throw new NotImplementedException(); }
        }
    }
}
