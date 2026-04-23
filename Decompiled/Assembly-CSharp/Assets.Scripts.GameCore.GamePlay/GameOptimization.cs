using System.Collections.Generic;
using Cpp2ILInjected;
using FormulaBase;
using GameLogic;

namespace Assets.Scripts.GameCore.GamePlay;

[Token(Token = "0x200072E")]
public class GameOptimization
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40025BB")]
	private List<int> m_OptimizationList;

	[Token(Token = "0x600429F")]
	[Address(RVA = "0x78F100", Offset = "0x78D900", Length = "0x156")]
	public static void BlockPunchOptimization(List<TimeNodeOrder> tnos, ref byte punchResult, ref MusicData punchMd)
	{
	}

	[Token(Token = "0x60042A0")]
	[Address(RVA = "0x78F960", Offset = "0x78E160", Length = "0x3A2")]
	public static void PunchTouchGet(ref byte punchResult, ref MusicData punchMd)
	{
	}

	[Address(RVA = "0x78EA50", Offset = "0x78D250", Length = "0x6A4")]
	[Token(Token = "0x60042A1")]
	public static void BlockJumpOptimization(List<TimeNodeOrder> tnos)
	{
	}

	[Address(RVA = "0x78F8F0", Offset = "0x78E0F0", Length = "0x64")]
	[Token(Token = "0x60042A2")]
	public void Init()
	{
	}

	[Address(RVA = "0x78FD10", Offset = "0x78E510", Length = "0x12")]
	[Token(Token = "0x60042A3")]
	public void Release()
	{
	}

	[Address(RVA = "0x78F260", Offset = "0x78DA60", Length = "0x2EC")]
	[Token(Token = "0x60042A4")]
	public bool BlockPunch_OR_Optimization(List<TimeNodeOrder> tnos, TimeNodeOrder punchTno)
	{
		return default(bool);
	}

	[Address(RVA = "0x78FD30", Offset = "0x78E530", Length = "0x23E")]
	[Token(Token = "0x60042A5")]
	public bool TouchPunch_OR_Optimization(List<TimeNodeOrder> tnos, TimeNodeOrder punchTno)
	{
		return default(bool);
	}

	[Address(RVA = "0x78F550", Offset = "0x78DD50", Length = "0x39F")]
	[Token(Token = "0x60042A6")]
	public static void BlockTouchOptimization(List<TimeNodeOrder> tnos, TimeNodeOrder punchTno)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60042A7")]
	public GameOptimization()
	{
	}
}
