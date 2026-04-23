using System.Collections.Generic;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;

[Token(Token = "0x2000111")]
public class MusicPackageScrollRect : FancyScrollRect<VipItemData, MusicPackageJumpGroupContext>
{
	[SerializeField]
	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x68")]
	private float cellSize;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006A2")]
	[SerializeField]
	private GameObject cellPrefab;

	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x78")]
	private List<VipItemData> listTemp;

	[Token(Token = "0x170000A3")]
	protected override float CellSize
	{
		[Address(RVA = "0x462D10", Offset = "0x461510", Length = "0x6")]
		[Token(Token = "0x60007DB")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000A4")]
	protected override GameObject CellPrefab
	{
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		[Token(Token = "0x60007DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x8C6330", Offset = "0x8C4B30", Length = "0x38")]
	protected override void Initialize()
	{
	}

	[Address(RVA = "0x5C3CB0", Offset = "0x5C24B0", Length = "0x19")]
	[Token(Token = "0x60007DE")]
	public void JumpToIndex(int index)
	{
	}

	[Address(RVA = "0x8C6370", Offset = "0x8C4B70", Length = "0x7F")]
	[Token(Token = "0x60007DF")]
	public void UpdateData(IReadOnlyList<VipItemData> items, int selectIndex = 0)
	{
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x8C63F0", Offset = "0x8C4BF0", Length = "0x75")]
	public MusicPackageScrollRect()
	{
		((FancyScrollRect<TItemData, TContext>)(object)this)._002Ector();
	}
}
