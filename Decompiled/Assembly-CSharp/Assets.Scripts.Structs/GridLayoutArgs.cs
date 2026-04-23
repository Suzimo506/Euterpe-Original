using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x2000575")]
public struct GridLayoutArgs
{
	[Token(Token = "0x4002031")]
	[FieldOffset(Offset = "0x0")]
	public Vector2 cellSize;

	[Token(Token = "0x4002032")]
	[FieldOffset(Offset = "0x8")]
	public Vector2Int paddingLR;

	[Token(Token = "0x4002033")]
	[FieldOffset(Offset = "0x10")]
	public Vector2Int paddingTB;

	[Token(Token = "0x4002034")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 spacing;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002035")]
	public GridLayoutGroup.Corner startCorner;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4002036")]
	public GridLayoutGroup.Axis startAxis;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002037")]
	public TextAnchor childAlignment;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002038")]
	public GridLayoutGroup.Constraint constraint;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002039")]
	public int constraintCount;

	[Token(Token = "0x600385C")]
	[Address(RVA = "0x656B40", Offset = "0x655340", Length = "0x1AA")]
	public void SetGridLayout(GridLayoutGroup layout)
	{
	}
}
