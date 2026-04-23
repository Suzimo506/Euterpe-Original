using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Datas;
using Cpp2ILInjected;

[Token(Token = "0x2000022")]
public class SavedRoleElfinConfigModel : DataModel
{
	[Token(Token = "0x400009A")]
	public const int max_config_count = 10;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009B")]
	private List<(int, int)> m_SavedConfigs;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x18")]
	private DataManager m_DataManager;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x20")]
	private DBConfigCharacter m_DBCharaConfig;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009E")]
	private DBConfigElfin m_DBElfinConfig;

	[Token(Token = "0x400009F")]
	public static int SelectedCharacterIndex;

	[Token(Token = "0x40000A0")]
	public static int SelectedElfinIndex;

	[Token(Token = "0x1700001E")]
	public List<(int, int)> SavedConfigs
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60000DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x6258C0", Offset = "0x6240C0", Length = "0x6E")]
	public static void ClearSelections()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x625AF0", Offset = "0x6242F0", Length = "0x2EB")]
	public override void Init()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x625E50", Offset = "0x624650", Length = "0x98")]
	public void RefreshConfigs(List<SavedLevelConfigData> savedItemDataList)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x625EF0", Offset = "0x6246F0", Length = "0x1BA")]
	public void SaveConfigs()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x625930", Offset = "0x624130", Length = "0x32")]
	public void GetCharacterInfoByIdx(int idx, out CharacterInfo characterInfo)
	{
		characterInfo = null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x625970", Offset = "0x624170", Length = "0x32")]
	public void GetElfinInfoByIdx(int idx, out ElfinInfo elfinInfo)
	{
		elfinInfo = null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x625770", Offset = "0x623F70", Length = "0x140")]
	public bool CheckRoleIsUnlocked(int roleIdx)
	{
		return default(bool);
	}

	[Address(RVA = "0x625520", Offset = "0x623D20", Length = "0x140")]
	[Token(Token = "0x60000E4")]
	public bool CheckElfinIsUnlocked(int elfinIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x625670", Offset = "0x623E70", Length = "0xF9")]
	public bool CheckRoleIsUnlocked(CharacterInfo characterInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x625420", Offset = "0x623C20", Length = "0xF9")]
	public bool CheckElfinIsUnlocked(ElfinInfo elfinInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x626130", Offset = "0x624930", Length = "0x7F")]
	public static void SetSavedPresetEnable(bool isEnable)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x625A50", Offset = "0x624250", Length = "0x90")]
	public static bool GetSavedPresetEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x625DE0", Offset = "0x6245E0", Length = "0x6A")]
	public static bool IsSpecialStage()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x6261B0", Offset = "0x6249B0", Length = "0xB2")]
	public void TryGetLevelConfigTipShowState(out bool isShowed, out bool isExist)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isShowed) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isExist) = null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x6259B0", Offset = "0x6241B0", Length = "0x90")]
	public bool GetLevelConfigTipHasShowed()
	{
		return default(bool);
	}

	[Address(RVA = "0x6260B0", Offset = "0x6248B0", Length = "0x7F")]
	[Token(Token = "0x60000EC")]
	public void SetLevelConfigTipHasShowed(bool isShow)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public SavedRoleElfinConfigModel()
	{
	}
}
