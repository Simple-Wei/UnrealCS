#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FTimelineLinearColorTrack
	{
		[FieldOffset(24)]
		public FName LinearColorPropertyName;
		
	}
	
}
#endif
#endif
