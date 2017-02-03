#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USCS_Node
	{
		static readonly int ComponentTemplate__Offset;
		public UActorComponent ComponentTemplate
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ComponentTemplate__Offset); if (v == IntPtr.Zero)return null; UActorComponent retValue = new UActorComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CookedComponentInstancingData__Offset;
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData
		{
			get{ CheckIsValid();return (FBlueprintCookedComponentInstancingData)Marshal.PtrToStructure(_this.Get()+CookedComponentInstancingData__Offset, typeof(FBlueprintCookedComponentInstancingData));}
			
		}
		
		static readonly int VariableName__Offset;
		public FName VariableName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+VariableName__Offset, typeof(FName));}
			
		}
		
		static readonly int AttachToName__Offset;
		public FName AttachToName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AttachToName__Offset, typeof(FName));}
			
		}
		
		static readonly int ParentComponentOrVariableName__Offset;
		public FName ParentComponentOrVariableName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParentComponentOrVariableName__Offset, typeof(FName));}
			
		}
		
		static readonly int ParentComponentOwnerClassName__Offset;
		public FName ParentComponentOwnerClassName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParentComponentOwnerClassName__Offset, typeof(FName));}
			
		}
		
		static readonly int bIsParentComponentNative__Offset;
		public bool bIsParentComponentNative
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsParentComponentNative__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ChildNodes__Offset;
		public TObjectArray<USCS_Node>  ChildNodes
		{
					get{ CheckIsValid();return new TObjectArray<USCS_Node>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildNodes__Offset, false);}
			
		}
		
		static readonly int MetaDataArray__Offset;
		public TStructArray<FBPVariableMetaDataEntry> MetaDataArray
		{
			get{ CheckIsValid();return new TStructArray<FBPVariableMetaDataEntry>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MetaDataArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MetaDataArray__Offset, false);}
			
		}
		
		static readonly int VariableGuid__Offset;
		public FGuid VariableGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+VariableGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int bIsFalseRoot__Offset;
		public bool bIsFalseRoot
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFalseRoot__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsNative__Offset;
		public bool bIsNative
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsNative__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int NativeComponentName__Offset;
		public FName NativeComponentName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+NativeComponentName__Offset, typeof(FName));}
			
		}
		
		static readonly int bVariableNameAutoGenerated__Offset;
		public bool bVariableNameAutoGenerated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVariableNameAutoGenerated__Offset, 1, 0, 1, 255);}
			
		}
		
		static USCS_Node()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SCS_Node");
			ComponentTemplate__Offset=GetPropertyOffset(NativeClassPtr,"ComponentTemplate");
			CookedComponentInstancingData__Offset=GetPropertyOffset(NativeClassPtr,"CookedComponentInstancingData");
			VariableName__Offset=GetPropertyOffset(NativeClassPtr,"VariableName");
			AttachToName__Offset=GetPropertyOffset(NativeClassPtr,"AttachToName");
			ParentComponentOrVariableName__Offset=GetPropertyOffset(NativeClassPtr,"ParentComponentOrVariableName");
			ParentComponentOwnerClassName__Offset=GetPropertyOffset(NativeClassPtr,"ParentComponentOwnerClassName");
			bIsParentComponentNative__Offset=GetPropertyOffset(NativeClassPtr,"bIsParentComponentNative");
			ChildNodes__Offset=GetPropertyOffset(NativeClassPtr,"ChildNodes");
			MetaDataArray__Offset=GetPropertyOffset(NativeClassPtr,"MetaDataArray");
			VariableGuid__Offset=GetPropertyOffset(NativeClassPtr,"VariableGuid");
			bIsFalseRoot__Offset=GetPropertyOffset(NativeClassPtr,"bIsFalseRoot");
			bIsNative__Offset=GetPropertyOffset(NativeClassPtr,"bIsNative");
			NativeComponentName__Offset=GetPropertyOffset(NativeClassPtr,"NativeComponentName");
			bVariableNameAutoGenerated__Offset=GetPropertyOffset(NativeClassPtr,"bVariableNameAutoGenerated");
			
		}
		
	}
	
}
#endif
#endif
