#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FCustomChannelSetup
	{
		[FieldOffset(0)]
		public ECollisionChannel Channel;
		[FieldOffset(8)]
		public FName Name;
		[FieldOffset(16)]
		public ECollisionResponse DefaultResponse;
		public bool bTraceType
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 17, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 17, 1, 0, 1, 255); } }}
			
		}
		public bool bStaticObject
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 18, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 18, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
