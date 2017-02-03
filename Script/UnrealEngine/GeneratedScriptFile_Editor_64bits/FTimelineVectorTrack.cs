#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FTimelineVectorTrack
	{
		/// <summary>Vector curve to be evaluated</summary>
		/// <summary>Name of property that we should update from this curve</summary>
		[FieldOffset(28)]
		public FName VectorPropertyName;
		/// <summary>Cached vector struct property pointer</summary>
		
	}
	
}
#endif
#endif
