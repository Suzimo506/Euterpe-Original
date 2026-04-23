using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.UI;

[Token(Token = "0x2000823")]
public class SensorModule
{
	[Token(Token = "0x4002A6C")]
	private static SensorModule s_Instance;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002A6D")]
	private Dictionary<string, IGyroscopeHandler> m_GyroscopeHandlers;

	[Token(Token = "0x6004B0B")]
	[Address(RVA = "0x61B3B0", Offset = "0x619BB0", Length = "0xC3")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6004B0C")]
	[Address(RVA = "0x91E760", Offset = "0x91CF60", Length = "0x1CF")]
	public static T GetSensorHandler<T>() where T : IGyroscopeHandler
	{
		return (T)null;
	}

	[Token(Token = "0x6004B0D")]
	[Address(RVA = "0x61B480", Offset = "0x619C80", Length = "0x221")]
	public static void Release()
	{
	}

	[Address(RVA = "0x61B6B0", Offset = "0x619EB0", Length = "0x69")]
	[Token(Token = "0x6004B0E")]
	public SensorModule()
	{
	}
}
