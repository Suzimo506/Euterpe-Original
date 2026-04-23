using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200078A")]
public class MusicInfo : BaseDataObject
{
	[Token(Token = "0x40027CF")]
	[FieldOffset(Offset = "0x20")]
	public string uid;

	[Token(Token = "0x40027D0")]
	[FieldOffset(Offset = "0x28")]
	public string name;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40027D1")]
	public string author;

	[Token(Token = "0x40027D2")]
	[FieldOffset(Offset = "0x38")]
	public string bpm;

	[Token(Token = "0x40027D3")]
	[FieldOffset(Offset = "0x40")]
	public string music;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40027D4")]
	public string demo;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40027D5")]
	public string cover;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40027D6")]
	public string hexieCover;

	[Token(Token = "0x40027D7")]
	[FieldOffset(Offset = "0x60")]
	public string noteJson;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40027D8")]
	public string scene;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40027D9")]
	public string levelDesigner;

	[Token(Token = "0x40027DA")]
	[FieldOffset(Offset = "0x78")]
	public string levelDesigner1;

	[Token(Token = "0x40027DB")]
	[FieldOffset(Offset = "0x80")]
	public string levelDesigner2;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40027DC")]
	public string levelDesigner3;

	[Token(Token = "0x40027DD")]
	[FieldOffset(Offset = "0x90")]
	public string levelDesigner4;

	[Token(Token = "0x40027DE")]
	[FieldOffset(Offset = "0x98")]
	public string levelDesigner5;

	[Token(Token = "0x40027DF")]
	[FieldOffset(Offset = "0xA0")]
	public string difficulty1;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40027E0")]
	public string difficulty2;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40027E1")]
	public string difficulty3;

	[Token(Token = "0x40027E2")]
	[FieldOffset(Offset = "0xB8")]
	public string difficulty4;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40027E3")]
	public string difficulty5;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40027E4")]
	public int callBackDifficulty1;

	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40027E5")]
	public int callBackDifficulty2;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40027E6")]
	public int callBackDifficulty3;

	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40027E7")]
	public int callBackDifficulty4;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40027E8")]
	public int callBackDifficulty5;

	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40027E9")]
	public int unlockLevel;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40027EA")]
	public bool newMusic;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40027EB")]
	protected MusicExInfo m_MusicExInfo;

	[Token(Token = "0x170006AD")]
	public string coverName
	{
		[Token(Token = "0x600468A")]
		[Address(RVA = "0x4A1470", Offset = "0x49FC70", Length = "0xCD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006AE")]
	public int musicIndex
	{
		[Token(Token = "0x600468B")]
		[Address(RVA = "0x4A15E0", Offset = "0x49FDE0", Length = "0x7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006AF")]
	public int albumIndex
	{
		[Token(Token = "0x600468C")]
		[Address(RVA = "0x4A1330", Offset = "0x49FB30", Length = "0x7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B0")]
	public int albumJsonIndex
	{
		[Token(Token = "0x600468D")]
		[Address(RVA = "0x4A1340", Offset = "0x49FB40", Length = "0x7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B1")]
	public string albumUidName
	{
		[Token(Token = "0x600468E")]
		[Address(RVA = "0x4A13E0", Offset = "0x49FBE0", Length = "0x8F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B2")]
	public string albumJsonName
	{
		[Token(Token = "0x600468F")]
		[Address(RVA = "0x4A1350", Offset = "0x49FB50", Length = "0x8F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B3")]
	public string mapName
	{
		[Token(Token = "0x6004691")]
		[Address(RVA = "0x4A1540", Offset = "0x49FD40", Length = "0x99")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B4")]
	public string musicName
	{
		[Token(Token = "0x6004692")]
		[Address(RVA = "0x4A15F0", Offset = "0x49FDF0", Length = "0x99")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004688")]
	[Address(RVA = "0x4A12B0", Offset = "0x49FAB0", Length = "0x20")]
	public override void Init(int index)
	{
	}

	[Token(Token = "0x6004689")]
	[Address(RVA = "0x4A1110", Offset = "0x49F910", Length = "0x18F")]
	private bool InitExInfo()
	{
		return default(bool);
	}

	[Address(RVA = "0x4A0D70", Offset = "0x49F570", Length = "0x88")]
	[Token(Token = "0x6004690")]
	public LocalALBUMInfo GetLocal(int language = 0)
	{
		return null;
	}

	[Token(Token = "0x6004693")]
	[Address(RVA = "0x4A0A30", Offset = "0x49F230", Length = "0x33E")]
	public string GetLevelDesignerStringByIndex(int index)
	{
		return null;
	}

	[Address(RVA = "0x4A0E60", Offset = "0x49F660", Length = "0x2A1")]
	[Token(Token = "0x6004694")]
	public string GetMusicLevelStringByDiff(int index, bool mask = true)
	{
		return null;
	}

	[Address(RVA = "0x4A0450", Offset = "0x49EC50", Length = "0x2E9")]
	[Token(Token = "0x6004695")]
	public int GetCallBackMusicLevelIntByDiff(int index, bool mask = true)
	{
		return default(int);
	}

	[Token(Token = "0x6004696")]
	[Address(RVA = "0x4A0E00", Offset = "0x49F600", Length = "0x55")]
	public int GetMusicLevelIntByDiff(int index, bool mask = true)
	{
		return default(int);
	}

	[Token(Token = "0x6004697")]
	[Address(RVA = "0x4A09E0", Offset = "0x49F1E0", Length = "0x4C")]
	public int GetDifficulty(int diff)
	{
		return default(int);
	}

	[Token(Token = "0x6004698")]
	[Address(RVA = "0x4A0740", Offset = "0x49EF40", Length = "0x299")]
	public int GetDifficultyLevel(int diff)
	{
		return default(int);
	}

	[Token(Token = "0x6004699")]
	[Address(RVA = "0x4A12D0", Offset = "0x49FAD0", Length = "0x58")]
	public void SetDifficulty(int diffIndex, int changedDiff)
	{
	}

	[Token(Token = "0x600469A")]
	[Address(RVA = "0x4A03D0", Offset = "0x49EBD0", Length = "0x70")]
	public override void ClearMaskValue()
	{
	}

	[Token(Token = "0x600469B")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public MusicInfo()
	{
	}
}
