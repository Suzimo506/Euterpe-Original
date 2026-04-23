using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200024C")]
public class IRailPlayerStatsImpl : RailObject, IRailPlayerStats, IRailComponent
{
	[Token(Token = "0x60028C3")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailPlayerStatsImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60028C4")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailPlayerStatsImpl()
	{
	}

	[Address(RVA = "0x369A20", Offset = "0x368220", Length = "0xEB")]
	[Token(Token = "0x60028C5")]
	public virtual RailID GetRailID()
	{
		return null;
	}

	[Token(Token = "0x60028C6")]
	[Address(RVA = "0x369800", Offset = "0x368000", Length = "0xDD")]
	public virtual RailResult AsyncRequestStats(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x369B10", Offset = "0x368310", Length = "0xED")]
	[Token(Token = "0x60028C7")]
	public virtual RailResult GetStatValue(string name, out int data)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref data) = null;
		return default(RailResult);
	}

	[Token(Token = "0x60028C8")]
	[Address(RVA = "0x369C00", Offset = "0x368400", Length = "0xED")]
	public virtual RailResult GetStatValue(string name, out double data)
	{
		System.Runtime.CompilerServices.Unsafe.As<double, @null>(ref data) = null;
		return default(RailResult);
	}

	[Address(RVA = "0x369F00", Offset = "0x368700", Length = "0xED")]
	[Token(Token = "0x60028C9")]
	public virtual RailResult SetStatValue(string name, int data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x369E10", Offset = "0x368610", Length = "0xED")]
	[Token(Token = "0x60028CA")]
	public virtual RailResult SetStatValue(string name, double data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028CB")]
	[Address(RVA = "0x369FF0", Offset = "0x3687F0", Length = "0xED")]
	public virtual RailResult UpdateAverageStatValue(string name, double data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028CC")]
	[Address(RVA = "0x3698E0", Offset = "0x3680E0", Length = "0xDD")]
	public virtual RailResult AsyncStoreStats(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x369D50", Offset = "0x368550", Length = "0xB5")]
	[Token(Token = "0x60028CD")]
	public virtual RailResult ResetAllStats()
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028CE")]
	[Address(RVA = "0x3699C0", Offset = "0x3681C0", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0x369CF0", Offset = "0x3684F0", Length = "0x55")]
	[Token(Token = "0x60028CF")]
	public virtual void Release()
	{
	}
}
