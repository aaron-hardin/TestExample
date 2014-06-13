using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFilesAPI;

namespace UnitTests
{
    class TestObjectPropertyOperations : VaultObjectPropertyOperations
    {
        public AccessControlList GenerateAutomaticPermissionsFromPropertyValues(PropertyValues PropertyValues)
        {
            throw new NotImplementedException();
        }

        public WorkflowAssignment GetAssignment_DEPRECATED(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public PropertyValues GetProperties(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public string GetPropertiesAsXML(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public PropertyValuesForDisplay GetPropertiesForDisplay(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public NamedValues GetPropertiesForMetadataSync(ObjVer ObjVer, MFMetadataSyncFormat Format)
        {
            throw new NotImplementedException();
        }

        public PropertyValuesOfMultipleObjects GetPropertiesOfMultipleObjects(ObjVers ObjectVersions)
        {
            throw new NotImplementedException();
        }

        public PropertyValuesWithIconClues GetPropertiesWithIconClues(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public PropertyValuesWithIconCluesOfMultipleObjects GetPropertiesWithIconCluesOfMultipleObjects(ObjVers ObjectVersions)
        {
            throw new NotImplementedException();
        }

        public PropertyValue GetProperty(ObjVer ObjVer, int Property)
        {
            throw new NotImplementedException();
        }

        public VersionComment GetVersionComment(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public VersionComments GetVersionCommentHistory(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionWorkflowState GetWorkflowState(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties MarkAssignmentComplete(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties RemoveProperty(ObjVer ObjVer, int Property)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAllProperties(ObjVer ObjVer, bool AllowModifyingCheckedInObject, PropertyValues PropertyValues)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAllPropertiesWithPermissions(ObjVer ObjVer, bool AllowModifyingCheckedInObject, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList ACLProvided = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAllPropertiesWithPermissionsEx(ObjVer ObjVer, bool AllowModifyingCheckedInObject, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode, AccessControlList ACLProvided, [System.Runtime.InteropServices.OptionalAttribute][System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.IDispatch)][System.Runtime.CompilerServices.IDispatchConstantAttribute]object ElectronicSignature)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAllPropertiesWithPermissionsEx(ObjVer ObjVer, bool AllowModifyingCheckedInObject, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList ACLProvided = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAssignment_DEPRECATED(ObjVer ObjVer, WorkflowAssignment Assignment)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetCreationInfoAdmin(ObjVer ObjVer, bool UpdateCreatedBy, TypedValue CreatedBy, bool UpdateCreated, TypedValue CreatedUtc)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetLastModificationInfoAdmin(ObjVer ObjVer, bool UpdateLastModifiedBy, TypedValue LastModifiedBy, bool UpdateLastModified, TypedValue LastModifiedUtc)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetProperties(ObjVer ObjVer, PropertyValues PropertyValues)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndPropertiesOfMultipleObjects SetPropertiesOfMultipleObjects(SetPropertiesParamsOfMultipleObjects SetPropertiesParamsOfObjects)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetPropertiesWithPermissions(ObjVer ObjVer, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList ACLProvided = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetPropertiesWithPermissionsEx(ObjVer ObjVer, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode, AccessControlList ACLProvided, [System.Runtime.InteropServices.OptionalAttribute][System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.IDispatch)][System.Runtime.CompilerServices.IDispatchConstantAttribute]object ElectronicSignature)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetPropertiesWithPermissionsEx(ObjVer ObjVer, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList ACLProvided = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetProperty(ObjVer ObjVer, PropertyValue PropertyValue)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetVersionComment(ObjVer ObjVer, PropertyValue VersionComment)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetWorkflowState(ObjVer ObjVer, ObjectVersionWorkflowState WorkflowState)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetWorkflowStateEx(ObjVer ObjVer, ObjectVersionWorkflowState WorkflowState, [System.Runtime.InteropServices.OptionalAttribute][System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.IDispatch)][System.Runtime.CompilerServices.IDispatchConstantAttribute]object ElectronicSignature)
        {
            throw new NotImplementedException();
        }
    }
}
