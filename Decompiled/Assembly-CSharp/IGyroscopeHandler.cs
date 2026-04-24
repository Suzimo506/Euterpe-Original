using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200009F")]
public interface IGyroscopeHandler
{
	[Token(Token = "0x17000075")]
	bool IsGyroscopeAvailable
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x60004EB")]
		get;
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x60004EC")]
		set;
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60004ED")]
	Vector2 GetDeviceAttitudeWithoutYRotation();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60004EE")]
	Vector3 GetDeviceAttitude();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60004EF")]
	float GetDeviceRotateAcceleration();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60004F0")]
	void Release();
}
