#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UChildActorComponent
	{
		static readonly int ChildActorClass__Offset;
		public TSubclassOf<AActor>  ChildActorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ChildActorClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ChildActorClass__Offset, value); }
			
		}
		
		static readonly int ChildActor__Offset;
		public AActor ChildActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ChildActor__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ChildActorTemplate__Offset;
		public AActor ChildActorTemplate
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ChildActorTemplate__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ChildActorTemplate__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ChildActorTemplate__Offset, value._this.Get()); }
			
		}
		
		static UChildActorComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ChildActorComponent");
			ChildActorClass__Offset=GetPropertyOffset(NativeClassPtr,"ChildActorClass");
			ChildActor__Offset=GetPropertyOffset(NativeClassPtr,"ChildActor");
			ChildActorTemplate__Offset=GetPropertyOffset(NativeClassPtr,"ChildActorTemplate");
			
		}
		
	}
	
}
#endif
#endif