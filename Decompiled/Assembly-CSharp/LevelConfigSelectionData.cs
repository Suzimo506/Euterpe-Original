using System;
using Cpp2ILInjected;

[Token(Token = "0x2000147")]
public class LevelConfigSelectionData
{
	[Token(Token = "0x2000A2E")]
	public enum SelectionType
	{
		[Token(Token = "0x400363B")]
		EditSavedConfig,
		[Token(Token = "0x400363C")]
		StageSelect
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007F2")]
	public SelectionType selectionType;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40007F3")]
	public bool isSetSelectInfo;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007F4")]
	public int selectedCharacterIndex;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40007F5")]
	public int selectedElfinIndex;

	[Token(Token = "0x40007F6")]
	[FieldOffset(Offset = "0x20")]
	public Action<int[]> OnConfigApplied;

	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x28")]
	public Action OnConfigCanceled;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600093B")]
	public LevelConfigSelectionData()
	{
	}
}
