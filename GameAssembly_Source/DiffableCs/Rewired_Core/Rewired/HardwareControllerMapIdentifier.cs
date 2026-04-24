namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal struct HardwareControllerMapIdentifier
{
	public readonly Guid guid; //Field offset: 0x0
	public readonly InputSource inputSource; //Field offset: 0x10
	public readonly InputPlatform actualInputPlatform; //Field offset: 0x14
	public readonly int variantIndex; //Field offset: 0x18

	public HardwareControllerMapIdentifier(Guid unnamed_param_0, InputSource unnamed_param_1, InputPlatform unnamed_param_2, int unnamed_param_3) { }

}

