using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000571")]
public struct GameDialogArgs
{
	[Token(Token = "0x4002016")]
	private static StringBuilder s_builder;

	[Token(Token = "0x4002017")]
	public const int DIALOG_UP = 0;

	[Token(Token = "0x4002018")]
	public const int DIALOG_DOWN = 1;

	[Token(Token = "0x4002019")]
	public const int DIALOG_TYPE_ROLE = 0;

	[Token(Token = "0x400201A")]
	public const int DIALOG_TYPE_BOSS = 1;

	[Token(Token = "0x400201B")]
	public const int DIALOG_TYPE_UI = 2;

	[Token(Token = "0x400201C")]
	[FieldOffset(Offset = "0x0")]
	public int index;

	[Token(Token = "0x400201D")]
	[FieldOffset(Offset = "0x4")]
	public decimal time;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400201E")]
	public int dialogType;

	[Token(Token = "0x400201F")]
	[FieldOffset(Offset = "0x18")]
	public int dialogIndex;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002020")]
	public string text;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002021")]
	public Color textColor;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002022")]
	public Color bgColor;

	[Token(Token = "0x4002023")]
	[FieldOffset(Offset = "0x48")]
	public float speed;

	[Token(Token = "0x4002024")]
	[FieldOffset(Offset = "0x4C")]
	public int fontSize;

	[Token(Token = "0x4002025")]
	[FieldOffset(Offset = "0x50")]
	public Vector2Int dialogSize;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002026")]
	public DialogState dialogState;

	[Token(Token = "0x4002027")]
	[FieldOffset(Offset = "0x5C")]
	public SuperTextMesh.Alignment alignment;

	[Token(Token = "0x6003850")]
	[Address(RVA = "0x656760", Offset = "0x654F60", Length = "0x9B")]
	public static Dictionary<string, List<GameDialogArgs>> Load(string str)
	{
		return null;
	}

	[Address(RVA = "0x656560", Offset = "0x654D60", Length = "0x1F0")]
	[Token(Token = "0x6003851")]
	private static void Format(Dictionary<string, List<GameDialogArgs>> argsDic)
	{
	}

	[Token(Token = "0x6003852")]
	[Address(RVA = "0x656460", Offset = "0x654C60", Length = "0xF4")]
	private void Format()
	{
	}

	[Address(RVA = "0x656210", Offset = "0x654A10", Length = "0x244")]
	[Token(Token = "0x6003853")]
	public static void FixDialogDelay(Dictionary<string, List<GameDialogArgs>> argsDic, decimal delay)
	{
	}
}
