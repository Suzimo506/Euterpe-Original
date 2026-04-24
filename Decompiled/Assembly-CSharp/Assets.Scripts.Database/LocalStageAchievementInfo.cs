using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E8")]
public class LocalStageAchievementInfo : BaseDataObject
{
	[Token(Token = "0x400296B")]
	[FieldOffset(Offset = "0x20")]
	public string[] easy;

	[Token(Token = "0x400296C")]
	[FieldOffset(Offset = "0x28")]
	public string[] normal;

	[Token(Token = "0x400296D")]
	[FieldOffset(Offset = "0x30")]
	public string[] hard;

	[Token(Token = "0x400296E")]
	[FieldOffset(Offset = "0x38")]
	public string[] special;

	[Token(Token = "0x6004820")]
	[Address(RVA = "0x49FFF0", Offset = "0x49E7F0", Length = "0xD6")]
	public void GetDiffByIndex(int index, List<string> buffer, bool clear = false)
	{
	}

	[Token(Token = "0x6004821")]
	[Address(RVA = "0x4A00D0", Offset = "0x49E8D0", Length = "0xCC")]
	public string[] GetDiffByName(string name)
	{
		return null;
	}

	[Token(Token = "0x6004822")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalStageAchievementInfo()
	{
	}
}
