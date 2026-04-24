using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x2000834")]
public class StageBackgroundCachedDataManager
{
	[Token(Token = "0x4002ABC")]
	private const string bg_key = "PreviewdBgList";

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002ABD")]
	private List<int> m_CachedBgList;

	[Token(Token = "0x6004B85")]
	[Address(RVA = "0x6011E0", Offset = "0x5FF9E0", Length = "0x115")]
	public StageBackgroundCachedDataManager()
	{
	}

	[Address(RVA = "0x601110", Offset = "0x5FF910", Length = "0x53")]
	[Token(Token = "0x6004B86")]
	public bool IsNewBg(int bgId)
	{
		return default(bool);
	}

	[Address(RVA = "0x600AE0", Offset = "0x5FF2E0", Length = "0x1A8")]
	[Token(Token = "0x6004B87")]
	public void AddNewBg(int bgId)
	{
	}

	[Token(Token = "0x6004B88")]
	[Address(RVA = "0x600C90", Offset = "0x5FF490", Length = "0x267")]
	public bool CheckHasNewBg()
	{
		return default(bool);
	}

	[Token(Token = "0x6004B89")]
	[Address(RVA = "0x600F00", Offset = "0x5FF700", Length = "0x141")]
	public void ClearExchangedBgs(List<int> exchangedBgs)
	{
	}

	[Address(RVA = "0x601050", Offset = "0x5FF850", Length = "0xB4")]
	[Token(Token = "0x6004B8A")]
	private void GetCachedSelectableBgData()
	{
	}

	[Address(RVA = "0x601170", Offset = "0x5FF970", Length = "0x6E")]
	[Token(Token = "0x6004B8B")]
	private void SaveSelectableBgData()
	{
	}
}
