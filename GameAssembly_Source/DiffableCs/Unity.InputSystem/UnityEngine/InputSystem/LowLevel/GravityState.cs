namespace UnityEngine.InputSystem.LowLevel;

internal struct GravityState : IInputStateTypeInfo
{
	[InputControl]
	public Vector3 gravity; //Field offset: 0x0

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public static FourCC kFormat
	{
		 get { } //Length: 53
	}

	public override FourCC get_format() { }

	public static FourCC get_kFormat() { }

}

