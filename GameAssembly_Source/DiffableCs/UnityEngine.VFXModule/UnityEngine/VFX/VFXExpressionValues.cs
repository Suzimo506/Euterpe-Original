namespace UnityEngine.VFX;

[NativeType]
[RequiredByNativeCode]
public class VFXExpressionValues
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	private VFXExpressionValues() { }

	[RequiredByNativeCode]
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) { }

}

