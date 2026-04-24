using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Database;

[Token(Token = "0x200080B")]
public class DBLevelConfig : BaseDatabase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40029DB")]
	private bool m_Init;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40029DC")]
	private List<bool> m_LoveElfinOrigin;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40029DD")]
	private List<string> m_LoveElfinAddNow;

	[Token(Token = "0x40029DE")]
	[FieldOffset(Offset = "0x28")]
	private List<string> m_LoveElfinRemovedNow;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40029DF")]
	private List<string> m_LoveElfinPost;

	[Token(Token = "0x40029E1")]
	[FieldOffset(Offset = "0x40")]
	private (Sprite, Sprite) m_CurLevelConfigSprtes;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40029E2")]
	private (string, string) m_CurLevelSelectName;

	[Token(Token = "0x40029E3")]
	[FieldOffset(Offset = "0x60")]
	private List<int> elfinRandomPool;

	[Token(Token = "0x40029E4")]
	[FieldOffset(Offset = "0x68")]
	private List<int> roleRandomPool;

	[Token(Token = "0x40029E7")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Token(Token = "0x1700074B")]
	public CurLevelConfigState curLevelConfigState
	{
		[CompilerGenerated]
		[Token(Token = "0x60048B7")]
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		get
		{
			return default(CurLevelConfigState);
		}
		[CompilerGenerated]
		[Token(Token = "0x60048B8")]
		[Address(RVA = "0x597050", Offset = "0x595850", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700074C")]
	private static Dictionary<string, IData> m_DicLevelConfig
	{
		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x10282D0", Offset = "0x1026AD0", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074D")]
	private static List<IData> m_LevelConfigDatas
	{
		[Address(RVA = "0x1028320", Offset = "0x1026B20", Length = "0x48")]
		[Token(Token = "0x60048BA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074E")]
	private static List<bool> roleRandomSetting
	{
		[Token(Token = "0x60048BB")]
		[Address(RVA = "0x1028370", Offset = "0x1026B70", Length = "0xD7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074F")]
	private static List<bool> elfinRandomSetting
	{
		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x10281F0", Offset = "0x10269F0", Length = "0xD7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000750")]
	public int curRandomSelectRoleIndex
	{
		[CompilerGenerated]
		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x4D0B40", Offset = "0x4CF340", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60048BE")]
		[Address(RVA = "0x7044D0", Offset = "0x702CD0", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000751")]
	public int curRandomSelectElfinIndex
	{
		[CompilerGenerated]
		[Token(Token = "0x60048BF")]
		[Address(RVA = "0x42C7D0", Offset = "0x42AFD0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Address(RVA = "0x42CA10", Offset = "0x42B210", Length = "0x4")]
		[Token(Token = "0x60048C0")]
		private set
		{
		}
	}

	[Address(RVA = "0x1026440", Offset = "0x1024C40", Length = "0x101")]
	[Token(Token = "0x60048B4")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60048B5")]
	[Address(RVA = "0x1028070", Offset = "0x1026870", Length = "0x171")]
	public DBLevelConfig()
	{
	}

	[Token(Token = "0x60048B6")]
	[Address(RVA = "0x1027550", Offset = "0x1025D50", Length = "0x483")]
	public override void Release()
	{
	}

	[Token(Token = "0x60048C1")]
	[Address(RVA = "0x1026040", Offset = "0x1024840", Length = "0x3F1")]
	public void AddLevelConfigData(int roleIndex, int elfinIndex, bool isJumpInvalidElfinIndex = false, string musicDiffUid = null)
	{
	}

	[Address(RVA = "0x10279E0", Offset = "0x10261E0", Length = "0x298")]
	[Token(Token = "0x60048C2")]
	public void RemoveCurLevelConfig(string targetDiffUid)
	{
	}

	[Address(RVA = "0x10273F0", Offset = "0x1025BF0", Length = "0x155")]
	[Token(Token = "0x60048C3")]
	private void RefreshLevelConfigCachedData()
	{
	}

	[Address(RVA = "0x1027C80", Offset = "0x1026480", Length = "0x7D")]
	[Token(Token = "0x60048C4")]
	public void ResetCurLevelConfig()
	{
	}

	[Address(RVA = "0x1027D00", Offset = "0x1026500", Length = "0x306")]
	[Token(Token = "0x60048C5")]
	public bool ResetRandomSetting()
	{
		return default(bool);
	}

	[Address(RVA = "0x1026550", Offset = "0x1024D50", Length = "0x21C")]
	[Token(Token = "0x60048C6")]
	public bool CanUseRandomLevelConfig()
	{
		return default(bool);
	}

	[Address(RVA = "0x1026770", Offset = "0x1024F70", Length = "0x108")]
	[Token(Token = "0x60048C7")]
	public void CheckStageRandomConfig()
	{
	}

	[Token(Token = "0x60048C8")]
	[Address(RVA = "0x1027120", Offset = "0x1025920", Length = "0x119")]
	private bool IsDataUnlock(int index, string type)
	{
		return default(bool);
	}

	[Token(Token = "0x60048C9")]
	[Address(RVA = "0x597050", Offset = "0x595850", Length = "0x4")]
	public void ChangeState(CurLevelConfigState tempState)
	{
	}

	[Address(RVA = "0x1026880", Offset = "0x1025080", Length = "0x2F1")]
	[Token(Token = "0x60048CA")]
	public (Sprite, Sprite) GetCurLevelConfigSprites()
	{
		return default((Sprite, Sprite));
	}

	[Address(RVA = "0x1026B80", Offset = "0x1025380", Length = "0x386")]
	[Token(Token = "0x60048CB")]
	public (string, string) GetCurLevelNames()
	{
		return default((string, string));
	}

	[Token(Token = "0x60048CC")]
	[Address(RVA = "0x1027040", Offset = "0x1025840", Length = "0xD4")]
	public bool IsCurLevelConfigSameToDefault()
	{
		return default(bool);
	}

	[Address(RVA = "0x1026F10", Offset = "0x1025710", Length = "0x123")]
	[Token(Token = "0x60048CD")]
	public static Sprite GetSprite(string key)
	{
		return null;
	}

	[Token(Token = "0x60048CE")]
	[Address(RVA = "0x1027240", Offset = "0x1025A40", Length = "0x1A0")]
	private void OnDestroy()
	{
	}
}
