#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A component that spawns an Actor when registered, and destroys it when unregistered.</summary>
	public partial class UChildActorComponent
	{
		static readonly int ChildActorClass__Offset;
		/// <summary>The class of Actor to spawn</summary>
		public TSubclassOf<AActor>  ChildActorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ChildActorClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ChildActorClass__Offset, value); }
			
		}
		
		static readonly int ChildActor__Offset;
		/// <summary>The actor that we spawned and own</summary>
		public AActor ChildActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ChildActor__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static UChildActorComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ChildActorComponent");
			ChildActorClass__Offset=GetPropertyOffset(NativeClassPtr,"ChildActorClass");
			ChildActor__Offset=GetPropertyOffset(NativeClassPtr,"ChildActor");
			
		}
		
	}
	
}
#endif
#endif
