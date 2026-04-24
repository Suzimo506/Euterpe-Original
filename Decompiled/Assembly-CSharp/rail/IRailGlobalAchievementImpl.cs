using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200023B")]
public class IRailGlobalAchievementImpl : RailObject, IRailGlobalAchievement, IRailComponent
{
	[Token(Token = "0x6002828")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailGlobalAchievementImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002829")]
	~IRailGlobalAchievementImpl()
	{
	}

	[Address(RVA = "0xD2B3A0", Offset = "0xD29BA0", Length = "0x65")]
	[Token(Token = "0x600282A")]
	public virtual RailResult AsyncRequestAchievement(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2B5C0", Offset = "0xD29DC0", Length = "0x75")]
	[Token(Token = "0x600282B")]
	public virtual RailResult GetGlobalAchievedPercent(string name, out double percent)
	{
		System.Runtime.CompilerServices.Unsafe.As<double, @null>(ref percent) = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD2B470", Offset = "0xD29C70", Length = "0x141")]
	[Token(Token = "0x600282C")]
	public virtual RailResult GetGlobalAchievedPercentDescending(int index, out string name, out double percent)
	{
		name = null;
		System.Runtime.CompilerServices.Unsafe.As<double, @null>(ref percent) = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD2B410", Offset = "0xD29C10", Length = "0x55")]
	[Token(Token = "0x600282D")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0xD2B640", Offset = "0xD29E40", Length = "0x55")]
	[Token(Token = "0x600282E")]
	public virtual void Release()
	{
	}
}
