#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FWidgetAnimationBinding
	{
		[FieldOffset(0)]
		public FName WidgetName;
		[FieldOffset(8)]
		public FName SlotWidgetName;
		[FieldOffset(16)]
		public FGuid AnimationGuid;
		public bool bIsRootWidget
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
