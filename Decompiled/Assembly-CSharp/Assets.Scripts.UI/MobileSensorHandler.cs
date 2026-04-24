using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI;

[Token(Token = "0x2000822")]
public class MobileSensorHandler : IGyroscopeHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002A6B")]
	private bool m_IsGyroscopeAvailable;

	[Token(Token = "0x17000839")]
	public bool IsGyroscopeAvailable
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x6004B04")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x6C23C0", Offset = "0x6C0BC0", Length = "0x31")]
		[Token(Token = "0x6004B05")]
		set
		{
		}
	}

	[Token(Token = "0x6004B06")]
	[Address(RVA = "0x6C2150", Offset = "0x6C0950", Length = "0x195")]
	public Vector2 GetDeviceAttitudeWithoutYRotation()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6004B07")]
	[Address(RVA = "0x6C22F0", Offset = "0x6C0AF0", Length = "0x65")]
	public Vector3 GetDeviceAttitude()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004B08")]
	[Address(RVA = "0x6C2360", Offset = "0x6C0B60", Length = "0x52")]
	public float GetDeviceRotateAcceleration()
	{
		return default(float);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6004B09")]
	public void Release()
	{
	}

	[Token(Token = "0x6004B0A")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public MobileSensorHandler()
	{
	}
}
