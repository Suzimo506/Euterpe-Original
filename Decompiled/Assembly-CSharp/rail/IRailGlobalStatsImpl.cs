using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200023C")]
public class IRailGlobalStatsImpl : RailObject, IRailGlobalStats, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600282F")]
	internal IRailGlobalStatsImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002830")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailGlobalStatsImpl()
	{
	}

	[Address(RVA = "0xD2B6A0", Offset = "0xD29EA0", Length = "0x65")]
	[Token(Token = "0x6002831")]
	public virtual RailResult AsyncRequestGlobalStats(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2B890", Offset = "0xD2A090", Length = "0x75")]
	[Token(Token = "0x6002832")]
	public virtual RailResult GetGlobalStatValue(string name, out long data)
	{
		System.Runtime.CompilerServices.Unsafe.As<long, @null>(ref data) = null;
		return default(RailResult);
	}

	[Token(Token = "0x6002833")]
	[Address(RVA = "0xD2B910", Offset = "0xD2A110", Length = "0x75")]
	public virtual RailResult GetGlobalStatValue(string name, out double data)
	{
		System.Runtime.CompilerServices.Unsafe.As<double, @null>(ref data) = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD2B800", Offset = "0xD2A000", Length = "0x8B")]
	[Token(Token = "0x6002834")]
	public virtual RailResult GetGlobalStatValueHistory(string name, long[] global_stats_data, uint data_size, out int num_global_stats)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref num_global_stats) = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD2B770", Offset = "0xD29F70", Length = "0x8B")]
	[Token(Token = "0x6002835")]
	public virtual RailResult GetGlobalStatValueHistory(string name, double[] global_stats_data, uint data_size, out int num_global_stats)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref num_global_stats) = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD2B710", Offset = "0xD29F10", Length = "0x55")]
	[Token(Token = "0x6002836")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x6002837")]
	[Address(RVA = "0xD2B990", Offset = "0xD2A190", Length = "0x55")]
	public virtual void Release()
	{
	}
}
