using System.Collections.Generic;
using Cpp2ILInjected;
using FormulaBase;
using GameLogic;

namespace Assets.Factorys;

[Token(Token = "0x2000569")]
public class TimeNodeOrderFactory
{
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x8EF70", Offset = "0x8E370")]
	[Token(Token = "0x4001FEC")]
	private static readonly decimal precision;

	[Token(Token = "0x4001FED")]
	private const int pressing_range = 50;

	[Token(Token = "0x4001FEE")]
	[FieldOffset(Offset = "0x10")]
	private TimeNodeOrder tempNodeOrder;

	[Token(Token = "0x4001FEF")]
	[FieldOffset(Offset = "0x18")]
	private TimeNodeOrder prevTimeNodeOrder;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001FF0")]
	private decimal lastTnoTime;

	[Token(Token = "0x4001FF1")]
	[FieldOffset(Offset = "0x30")]
	private int lastTnoIndex;

	[Token(Token = "0x4001FF2")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, List<TimeNodeOrder>> timeOrderBuffer;

	[Token(Token = "0x4001FF3")]
	[FieldOffset(Offset = "0x40")]
	private List<MusicData> m_MusicDatas;

	[Token(Token = "0x6003819")]
	[Address(RVA = "0x59C620", Offset = "0x59AE20", Length = "0xE")]
	private TimeNodeOrderFactory()
	{
	}

	[Token(Token = "0x600381A")]
	[Address(RVA = "0x59BF70", Offset = "0x59A770", Length = "0xA2")]
	public static TimeNodeOrderResult GetTimeNodeOrder(List<MusicData> musicDatas)
	{
		return default(TimeNodeOrderResult);
	}

	[Token(Token = "0x600381B")]
	[Address(RVA = "0x59B6A0", Offset = "0x599EA0", Length = "0x6CC")]
	private void CreateTimeNodeOrder(List<MusicData> musicDatas)
	{
	}

	[Token(Token = "0x600381C")]
	[Address(RVA = "0x59BD70", Offset = "0x59A570", Length = "0x1FB")]
	private MusicData FindPressHeader(MusicData pressMd)
	{
		return default(MusicData);
	}

	[Address(RVA = "0x59A000", Offset = "0x598800", Length = "0xAF")]
	[Token(Token = "0x600381D")]
	private TimeNodeOrder CheckTnoEqual()
	{
		return null;
	}

	[Address(RVA = "0x59C2D0", Offset = "0x59AAD0", Length = "0x23C")]
	[Token(Token = "0x600381E")]
	private void RangeFixed(ref MusicData md)
	{
	}

	[Address(RVA = "0x59C180", Offset = "0x59A980", Length = "0x14D")]
	[Token(Token = "0x600381F")]
	private void NoteSort()
	{
	}

	[Token(Token = "0x6003820")]
	[Address(RVA = "0x59C020", Offset = "0x59A820", Length = "0x155")]
	private void LongNoteSort(List<TimeNodeOrder> tnos)
	{
	}

	[Token(Token = "0x6003821")]
	[Address(RVA = "0x59A8C0", Offset = "0x5990C0", Length = "0x9C1")]
	private void CreateNoteTicks(int leftRange, int rightRange, MusicData md)
	{
	}

	[Token(Token = "0x6003822")]
	[Address(RVA = "0x59A0B0", Offset = "0x5988B0", Length = "0x801")]
	private void CreateMulingTicks(int leftRange, int rightRange, MusicData md)
	{
	}

	[Token(Token = "0x6003823")]
	[Address(RVA = "0x59B290", Offset = "0x599A90", Length = "0x40C")]
	private void CreatePressingTimeNodeOrder(MusicData md)
	{
	}

	[Token(Token = "0x6003824")]
	[Address(RVA = "0x599D50", Offset = "0x598550", Length = "0x30")]
	private void AddLongPressingTno(int tick)
	{
	}

	[Token(Token = "0x6003825")]
	[Address(RVA = "0x59C510", Offset = "0x59AD10", Length = "0x9D")]
	private void RefreshMulLastTime(decimal lastTick, int index)
	{
	}

	[Token(Token = "0x6003826")]
	[Address(RVA = "0x599D80", Offset = "0x598580", Length = "0x189")]
	private void AddTimeNodeOrder(int tick)
	{
	}

	[Token(Token = "0x6003827")]
	[Address(RVA = "0x599F10", Offset = "0x598710", Length = "0xEB")]
	private void AddTno(int tick, TimeNodeOrder tno)
	{
	}
}
