#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=152)]
	public partial struct FStaticMeshComponentLODInfo
	{
		public TStructArray<FPaintedVertex> PaintedVertices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FPaintedVertex>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
