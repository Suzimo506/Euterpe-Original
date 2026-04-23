using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Datas;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using UnityEngine;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000819")]
public static class DataHelper
{
	[Token(Token = "0x4002A4D")]
	private static DataManager s_DataManager;

	[Token(Token = "0x4002A4E")]
	private static Dictionary<string, IData> m_DicLevelConfig;

	[Token(Token = "0x4002A4F")]
	public static bool isVipCurrentUnlock;

	[Token(Token = "0x170007A9")]
	public static List<IData> messages
	{
		[Token(Token = "0x60049D9")]
		[Address(RVA = "0x1035290", Offset = "0x1033A90", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007AA")]
	public static List<string> tasks
	{
		[Token(Token = "0x60049DA")]
		[Address(RVA = "0x1036F50", Offset = "0x1035750", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007AB")]
	public static List<string> fullComboMusic
	{
		[Token(Token = "0x60049DB")]
		[Address(RVA = "0x1032AB0", Offset = "0x10312B0", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007AC")]
	public static Dictionary<string, IData> dicLevelConfig
	{
		[Token(Token = "0x60049DC")]
		[Address(RVA = "0x1032100", Offset = "0x1030900", Length = "0x244")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007AD")]
	public static List<IData> levelConfigDatas
	{
		[Token(Token = "0x60049DD")]
		[Address(RVA = "0x10350A0", Offset = "0x10338A0", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x60049DE")]
		[Address(RVA = "0x103A980", Offset = "0x1039180", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007AE")]
	private static CurLevelConfigState m_CurLeveState
	{
		[Address(RVA = "0x10351E0", Offset = "0x10339E0", Length = "0xA7")]
		[Token(Token = "0x60049DF")]
		get
		{
			return default(CurLevelConfigState);
		}
	}

	[Token(Token = "0x170007AF")]
	public static bool isUseRandomLevelConfig
	{
		[Token(Token = "0x60049E0")]
		[Address(RVA = "0x1034EC0", Offset = "0x10336C0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60049E1")]
		[Address(RVA = "0x103A820", Offset = "0x1039020", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007B0")]
	public static int originSelectedRoleIndex
	{
		[Token(Token = "0x60049E2")]
		[Address(RVA = "0x1035630", Offset = "0x1033E30", Length = "0x94")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170007B1")]
	public static int originSelectedElfinIndex
	{
		[Token(Token = "0x60049E3")]
		[Address(RVA = "0x1035590", Offset = "0x1033D90", Length = "0x94")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170007B2")]
	public static int selectedRoleIndex
	{
		[Token(Token = "0x60049E4")]
		[Address(RVA = "0x10367A0", Offset = "0x1034FA0", Length = "0x3ED")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x103B8F0", Offset = "0x103A0F0", Length = "0x220")]
		[Token(Token = "0x60049E5")]
		set
		{
		}
	}

	[Token(Token = "0x170007B3")]
	public static int selectedElfinIndex
	{
		[Address(RVA = "0x1035DF0", Offset = "0x10345F0", Length = "0x3F4")]
		[Token(Token = "0x60049E6")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x103B1A0", Offset = "0x10399A0", Length = "0x220")]
		[Token(Token = "0x60049E7")]
		set
		{
		}
	}

	[Token(Token = "0x170007B4")]
	[Obsolete]
	public static float sfxVolume
	{
		[Token(Token = "0x60049E8")]
		[Address(RVA = "0x1036C30", Offset = "0x1035430", Length = "0x94")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60049E9")]
		[Address(RVA = "0x103BBE0", Offset = "0x103A3E0", Length = "0xC5")]
		set
		{
		}
	}

	[Token(Token = "0x170007B5")]
	[Obsolete]
	public static float hitSfxVolume
	{
		[Token(Token = "0x60049EA")]
		[Address(RVA = "0x1033A50", Offset = "0x1032250", Length = "0x94")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60049EB")]
		[Address(RVA = "0x10396D0", Offset = "0x1037ED0", Length = "0xC5")]
		set
		{
		}
	}

	[Obsolete]
	[Token(Token = "0x170007B6")]
	public static float voiceVolume
	{
		[Token(Token = "0x60049EC")]
		[Address(RVA = "0x1037770", Offset = "0x1035F70", Length = "0x94")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60049ED")]
		[Address(RVA = "0x103C1D0", Offset = "0x103A9D0", Length = "0xC5")]
		set
		{
		}
	}

	[Token(Token = "0x170007B7")]
	[Obsolete]
	public static float bgmVolume
	{
		[Address(RVA = "0x1031DE0", Offset = "0x10305E0", Length = "0x94")]
		[Token(Token = "0x60049EE")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60049EF")]
		[Address(RVA = "0x10382C0", Offset = "0x1036AC0", Length = "0xC5")]
		set
		{
		}
	}

	[Token(Token = "0x170007B8")]
	public static bool isAutoFever
	{
		[Token(Token = "0x60049F0")]
		[Address(RVA = "0x1033C30", Offset = "0x1032430", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60049F1")]
		[Address(RVA = "0x1039920", Offset = "0x1038120", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007B9")]
	public static bool isFirstFinishedTutorial
	{
		[Token(Token = "0x60049F2")]
		[Address(RVA = "0x1033E10", Offset = "0x1032610", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60049F3")]
		[Address(RVA = "0x1039B60", Offset = "0x1038360", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007BA")]
	public static bool isNoFirstOpenBulletin
	{
		[Token(Token = "0x60049F4")]
		[Address(RVA = "0x1034190", Offset = "0x1032990", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60049F5")]
		[Address(RVA = "0x1039F20", Offset = "0x1038720", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007BB")]
	public static bool isSelectFullMode
	{
		[Token(Token = "0x60049F6")]
		[Address(RVA = "0x10344B0", Offset = "0x1032CB0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x103A2E0", Offset = "0x1038AE0", Length = "0xBD")]
		[Token(Token = "0x60049F7")]
		set
		{
		}
	}

	[Obsolete]
	[Token(Token = "0x170007BC")]
	public static string selectedAlbumUid
	{
		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x1035CB0", Offset = "0x10344B0", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x60049F9")]
		[Address(RVA = "0x103B040", Offset = "0x1039840", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007BD")]
	public static string userLanguage
	{
		[Address(RVA = "0x10373B0", Offset = "0x1035BB0", Length = "0x94")]
		[Token(Token = "0x60049FA")]
		get
		{
			return null;
		}
		[Token(Token = "0x60049FB")]
		[Address(RVA = "0x103BF50", Offset = "0x103A750", Length = "0x94")]
		set
		{
		}
	}

	[Token(Token = "0x170007BE")]
	public static List<string> collections
	{
		[Token(Token = "0x60049FC")]
		[Address(RVA = "0x1031F20", Offset = "0x1030720", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007BF")]
	public static List<string> hides
	{
		[Token(Token = "0x60049FD")]
		[Address(RVA = "0x1033870", Offset = "0x1032070", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C0")]
	public static List<string> history
	{
		[Token(Token = "0x60049FE")]
		[Address(RVA = "0x10339B0", Offset = "0x10321B0", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C1")]
	public static int selectedMusicIndexInAllList
	{
		[Address(RVA = "0x1036330", Offset = "0x1034B30", Length = "0x94")]
		[Token(Token = "0x60049FF")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x103B550", Offset = "0x1039D50", Length = "0xBB")]
		[Token(Token = "0x6004A00")]
		set
		{
		}
	}

	[Token(Token = "0x170007C2")]
	public static string selectedMusicUid
	{
		[Token(Token = "0x6004A01")]
		[Address(RVA = "0x1036510", Offset = "0x1034D10", Length = "0x14A")]
		get
		{
			return null;
		}
	}

	[Obsolete]
	[Token(Token = "0x170007C3")]
	public static int selectedMusicIndex
	{
		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x10363D0", Offset = "0x1034BD0", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x103B610", Offset = "0x1039E10", Length = "0xBB")]
		[Token(Token = "0x6004A03")]
		set
		{
		}
	}

	[Token(Token = "0x170007C4")]
	public static string selectedMusicUidFromInfoList
	{
		[Address(RVA = "0x1036470", Offset = "0x1034C70", Length = "0x94")]
		[Token(Token = "0x6004A04")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A05")]
		[Address(RVA = "0x103B6D0", Offset = "0x1039ED0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007C5")]
	public static int selectedAlbumTagIndex
	{
		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x1035C10", Offset = "0x1034410", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x103AF80", Offset = "0x1039780", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x170007C6")]
	public static int selectedDifficulty
	{
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x1035D50", Offset = "0x1034550", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x103B0E0", Offset = "0x10398E0", Length = "0xBB")]
		[Token(Token = "0x6004A09")]
		set
		{
		}
	}

	[Token(Token = "0x170007C7")]
	public static List<int> useLoadingIndex
	{
		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x10371D0", Offset = "0x10359D0", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C8")]
	public static List<int> useWelcomeIndex
	{
		[Token(Token = "0x6004A0B")]
		[Address(RVA = "0x1037270", Offset = "0x1035A70", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C9")]
	public static int selectedItemIndex
	{
		[Token(Token = "0x6004A0C")]
		[Address(RVA = "0x1036290", Offset = "0x1034A90", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x103B490", Offset = "0x1039C90", Length = "0xBB")]
		[Token(Token = "0x6004A0D")]
		set
		{
		}
	}

	[Token(Token = "0x170007CA")]
	public static List<IData> items
	{
		[Address(RVA = "0x1035000", Offset = "0x1033800", Length = "0x94")]
		[Token(Token = "0x6004A0E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CB")]
	public static string itemVersion
	{
		[Token(Token = "0x6004A0F")]
		[Address(RVA = "0x1034F60", Offset = "0x1033760", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A10")]
		[Address(RVA = "0x103A8E0", Offset = "0x10390E0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007CC")]
	public static string PeroUid
	{
		[Address(RVA = "0x10317C0", Offset = "0x102FFC0", Length = "0x94")]
		[Token(Token = "0x6004A12")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A13")]
		[Address(RVA = "0x1037CE0", Offset = "0x10364E0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007CD")]
	public static string playerUUid
	{
		[Token(Token = "0x6004A14")]
		[Address(RVA = "0x10356D0", Offset = "0x1033ED0", Length = "0x17B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CE")]
	public static bool IsAnchorMode
	{
		[Token(Token = "0x6004A15")]
		[Address(RVA = "0x1031670", Offset = "0x102FE70", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x1037B50", Offset = "0x1036350", Length = "0xBD")]
		[Token(Token = "0x6004A16")]
		set
		{
		}
	}

	[Token(Token = "0x170007CF")]
	public static bool IsAnchorModeShowUnuseIsOn
	{
		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x10315D0", Offset = "0x102FDD0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A18")]
		[Address(RVA = "0x1037A90", Offset = "0x1036290", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007D0")]
	public static int Level
	{
		[Token(Token = "0x6004A19")]
		[Address(RVA = "0x1031710", Offset = "0x102FF10", Length = "0xAA")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0x1037C10", Offset = "0x1036410", Length = "0xC1")]
		set
		{
		}
	}

	[Token(Token = "0x170007D1")]
	public static List<string> firstOpenEvent
	{
		[Address(RVA = "0x10328D0", Offset = "0x10310D0", Length = "0x94")]
		[Token(Token = "0x6004A1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D2")]
	public static string loginCountry
	{
		[Address(RVA = "0x1035140", Offset = "0x1033940", Length = "0x94")]
		[Token(Token = "0x6004A1D")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x103AA20", Offset = "0x1039220", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007D3")]
	public static Vector2Int difficultyLevel
	{
		[Address(RVA = "0x1032350", Offset = "0x1030B50", Length = "0x114")]
		[Token(Token = "0x6004A1F")]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x10384D0", Offset = "0x1036CD0", Length = "0x13D")]
		set
		{
		}
	}

	[Token(Token = "0x170007D4")]
	public static int selectedPnlMusicTabIndex
	{
		[Token(Token = "0x6004A21")]
		[Address(RVA = "0x1036660", Offset = "0x1034E60", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A22")]
		[Address(RVA = "0x103B770", Offset = "0x1039F70", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x170007D5")]
	public static bool isNew
	{
		[Token(Token = "0x6004A23")]
		[Address(RVA = "0x10340F0", Offset = "0x10328F0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A24")]
		[Address(RVA = "0x1039E60", Offset = "0x1038660", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007D6")]
	public static List<IData> rewardItems
	{
		[Token(Token = "0x6004A25")]
		[Address(RVA = "0x10358F0", Offset = "0x10340F0", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D7")]
	public static List<IData> unlockStages
	{
		[Token(Token = "0x6004A26")]
		[Address(RVA = "0x1037130", Offset = "0x1035930", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D8")]
	public static bool isUnlockBudgetCore
	{
		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x1034D80", Offset = "0x1033580", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x103A6A0", Offset = "0x1038EA0", Length = "0xBD")]
		[Token(Token = "0x6004A28")]
		set
		{
		}
	}

	[Token(Token = "0x170007D9")]
	public static bool isUnlockBudgetVol1
	{
		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x1034E20", Offset = "0x1033620", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x103A760", Offset = "0x1038F60", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007DA")]
	public static List<IData> headItems
	{
		[Address(RVA = "0x10337D0", Offset = "0x1031FD0", Length = "0x94")]
		[Token(Token = "0x6004A2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007DB")]
	public static bool isGetFoolDayAwardHead
	{
		[Address(RVA = "0x1033EB0", Offset = "0x10326B0", Length = "0x94")]
		[Token(Token = "0x6004A2C")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x1039C20", Offset = "0x1038420", Length = "0xBD")]
		[Token(Token = "0x6004A2D")]
		set
		{
		}
	}

	[Token(Token = "0x170007DC")]
	public static List<IData> stickerItems
	{
		[Address(RVA = "0x1036EB0", Offset = "0x10356B0", Length = "0x94")]
		[Token(Token = "0x6004A2E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007DD")]
	public static int selectedHeadIndex
	{
		[Address(RVA = "0x10361F0", Offset = "0x10349F0", Length = "0x94")]
		[Token(Token = "0x6004A30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x103B3D0", Offset = "0x1039BD0", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x170007DE")]
	public static int selectedStickerIndex
	{
		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x1036B90", Offset = "0x1035390", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x103BB20", Offset = "0x103A320", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x170007DF")]
	public static int selectedAchBgId
	{
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x1035B70", Offset = "0x1034370", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x103AEC0", Offset = "0x10396C0", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x170007E0")]
	public static int selectedRecordBgIndex
	{
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x1036700", Offset = "0x1034F00", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x103B830", Offset = "0x103A030", Length = "0xBB")]
		[Token(Token = "0x6004A37")]
		set
		{
		}
	}

	[Token(Token = "0x170007E1")]
	public static bool isShowRecordRankMsg
	{
		[Token(Token = "0x6004A38")]
		[Address(RVA = "0x1034AB0", Offset = "0x10332B0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A39")]
		[Address(RVA = "0x103A3A0", Offset = "0x1038BA0", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007E2")]
	public static List<IData> recentPassLevelData
	{
		[Token(Token = "0x6004A3A")]
		[Address(RVA = "0x1035850", Offset = "0x1034050", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E3")]
	public static bool isSelectedMusicUnlock
	{
		[Token(Token = "0x6004A3B")]
		[Address(RVA = "0x1034550", Offset = "0x1032D50", Length = "0x427")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170007E4")]
	public static List<IData> highest
	{
		[Token(Token = "0x6004A3C")]
		[Address(RVA = "0x1033910", Offset = "0x1032110", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E5")]
	public static bool isUnlockAllMaster
	{
		[Token(Token = "0x6004A3D")]
		[Address(RVA = "0x1034CE0", Offset = "0x10334E0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A3E")]
		[Address(RVA = "0x103A5E0", Offset = "0x1038DE0", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007E6")]
	public static bool isUnlockAllBaseAlbum
	{
		[Token(Token = "0x6004A3F")]
		[Address(RVA = "0x1034BF0", Offset = "0x10333F0", Length = "0xE2")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x103A520", Offset = "0x1038D20", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007E7")]
	public static List<string> unlockMasters
	{
		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x1037090", Offset = "0x1035890", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E8")]
	public static bool isSelectedUnlockMaster
	{
		[Token(Token = "0x6004A44")]
		[Address(RVA = "0x1034980", Offset = "0x1033180", Length = "0x122")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170007E9")]
	public static List<string> stageAchievements
	{
		[Token(Token = "0x6004A45")]
		[Address(RVA = "0x1036E10", Offset = "0x1035610", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EA")]
	public static List<string> achievements
	{
		[Token(Token = "0x6004A46")]
		[Address(RVA = "0x1031A40", Offset = "0x1030240", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EB")]
	public static bool isReverse
	{
		[Token(Token = "0x6004A47")]
		[Address(RVA = "0x1034410", Offset = "0x1032C10", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A48")]
		[Address(RVA = "0x103A220", Offset = "0x1038A20", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007EC")]
	public static bool isTouchReverse
	{
		[Token(Token = "0x6004A49")]
		[Address(RVA = "0x1034B50", Offset = "0x1033350", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x103A460", Offset = "0x1038C60", Length = "0xBD")]
		[Token(Token = "0x6004A4A")]
		set
		{
		}
	}

	[Token(Token = "0x170007ED")]
	public static bool isLeftRight
	{
		[Token(Token = "0x6004A4B")]
		[Address(RVA = "0x1033F50", Offset = "0x1032750", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A4C")]
		[Address(RVA = "0x1039CE0", Offset = "0x10384E0", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007EE")]
	public static bool isAdvancedJudge
	{
		[Token(Token = "0x6004A4D")]
		[Address(RVA = "0x1033B90", Offset = "0x1032390", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x1039860", Offset = "0x1038060", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007EF")]
	public static bool displayApIcon
	{
		[Token(Token = "0x6004A4F")]
		[Address(RVA = "0x1032470", Offset = "0x1030C70", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x1038610", Offset = "0x1036E10", Length = "0xBD")]
		[Token(Token = "0x6004A50")]
		set
		{
		}
	}

	[Token(Token = "0x170007F0")]
	public static string nickname
	{
		[Token(Token = "0x6004A51")]
		[Address(RVA = "0x10353D0", Offset = "0x1033BD0", Length = "0x71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A52")]
		[Address(RVA = "0x103AB60", Offset = "0x1039360", Length = "0x91")]
		set
		{
		}
	}

	[Token(Token = "0x170007F1")]
	public static string auth
	{
		[Token(Token = "0x6004A53")]
		[Address(RVA = "0x1031B80", Offset = "0x1030380", Length = "0x71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A54")]
		[Address(RVA = "0x1038040", Offset = "0x1036840", Length = "0x76")]
		set
		{
		}
	}

	[Token(Token = "0x170007F2")]
	public static string userAuth
	{
		[Address(RVA = "0x1037310", Offset = "0x1035B10", Length = "0x94")]
		[Token(Token = "0x6004A55")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A56")]
		[Address(RVA = "0x103BEB0", Offset = "0x103A6B0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007F3")]
	public static string userOAID
	{
		[Token(Token = "0x6004A57")]
		[Address(RVA = "0x1037450", Offset = "0x1035C50", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A58")]
		[Address(RVA = "0x103BFF0", Offset = "0x103A7F0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007F4")]
	public static string xdsdkAccessToken
	{
		[Token(Token = "0x6004A59")]
		[Address(RVA = "0x10379F0", Offset = "0x10361F0", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A5A")]
		[Address(RVA = "0x103C340", Offset = "0x103AB40", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007F5")]
	public static List<IData> brightnesses
	{
		[Address(RVA = "0x1031E80", Offset = "0x1030680", Length = "0x94")]
		[Token(Token = "0x6004A5B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F6")]
	public static int battleSfxType
	{
		[Token(Token = "0x6004A5C")]
		[Address(RVA = "0x1031D40", Offset = "0x1030540", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A5D")]
		[Address(RVA = "0x1038200", Offset = "0x1036A00", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x170007F7")]
	public static bool isMenuTip
	{
		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x1034050", Offset = "0x1032850", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0x1039DA0", Offset = "0x10385A0", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007F8")]
	public static bool isOnLogoVoice
	{
		[Address(RVA = "0x1034230", Offset = "0x1032A30", Length = "0x94")]
		[Token(Token = "0x6004A60")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x1039FE0", Offset = "0x10387E0", Length = "0xBD")]
		[Token(Token = "0x6004A61")]
		set
		{
		}
	}

	[Token(Token = "0x170007F9")]
	public static bool isBackgroundVoiceOn
	{
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x1033CD0", Offset = "0x10324D0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x10399E0", Offset = "0x10381E0", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x170007FA")]
	public static bool isRankExpand
	{
		[Token(Token = "0x6004A64")]
		[Address(RVA = "0x1034370", Offset = "0x1032B70", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x103A160", Offset = "0x1038960", Length = "0xBD")]
		[Token(Token = "0x6004A65")]
		set
		{
		}
	}

	[Token(Token = "0x170007FB")]
	public static List<IData> roleSkinSettings
	{
		[Token(Token = "0x6004A66")]
		[Address(RVA = "0x1035AD0", Offset = "0x10342D0", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007FC")]
	public static List<bool> roleLoveSetting
	{
		[Address(RVA = "0x1035990", Offset = "0x1034190", Length = "0x94")]
		[Token(Token = "0x6004A67")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x103AD80", Offset = "0x1039580", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007FD")]
	public static List<bool> roleRandomSetting
	{
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x1035A30", Offset = "0x1034230", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x103AE20", Offset = "0x1039620", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x170007FE")]
	public static List<bool> elfinLoveSetting
	{
		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x1032510", Offset = "0x1030D10", Length = "0x94")]
		get
		{
			return null;
		}
		[Address(RVA = "0x10386D0", Offset = "0x1036ED0", Length = "0x99")]
		[Token(Token = "0x6004A6C")]
		set
		{
		}
	}

	[Token(Token = "0x170007FF")]
	public static List<bool> elfinRandomSetting
	{
		[Address(RVA = "0x10325B0", Offset = "0x1030DB0", Length = "0x94")]
		[Token(Token = "0x6004A6D")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x1038770", Offset = "0x1036F70", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x17000800")]
	public static List<string> forceSelectedHistory
	{
		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x1032970", Offset = "0x1031170", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000801")]
	public static string findKeyword
	{
		[Address(RVA = "0x1032830", Offset = "0x1031030", Length = "0x94")]
		[Token(Token = "0x6004A70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x1038A30", Offset = "0x1037230", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x17000802")]
	public static bool isAccountRankBanShow
	{
		[Address(RVA = "0x1033AF0", Offset = "0x10322F0", Length = "0x94")]
		[Token(Token = "0x6004A72")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x10397A0", Offset = "0x1037FA0", Length = "0xBD")]
		[Token(Token = "0x6004A73")]
		set
		{
		}
	}

	[Token(Token = "0x17000803")]
	public static string musicAdditionalConditionData
	{
		[Address(RVA = "0x1035330", Offset = "0x1033B30", Length = "0x94")]
		[Token(Token = "0x6004A74")]
		get
		{
			return null;
		}
		[Address(RVA = "0x103AAC0", Offset = "0x10392C0", Length = "0x99")]
		[Token(Token = "0x6004A75")]
		set
		{
		}
	}

	[Token(Token = "0x17000804")]
	public static string specialUnlockedMusicUids
	{
		[Address(RVA = "0x1036D70", Offset = "0x1035570", Length = "0x94")]
		[Token(Token = "0x6004A76")]
		get
		{
			return null;
		}
		[Address(RVA = "0x103BD70", Offset = "0x103A570", Length = "0x99")]
		[Token(Token = "0x6004A77")]
		set
		{
		}
	}

	[Token(Token = "0x17000805")]
	public static List<int> accountPermissions
	{
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x10319A0", Offset = "0x10301A0", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A79")]
		[Address(RVA = "0x1037F00", Offset = "0x1036700", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x17000806")]
	public static List<int> devicePermissions
	{
		[Address(RVA = "0x1032060", Offset = "0x1030860", Length = "0x94")]
		[Token(Token = "0x6004A7A")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A7B")]
		[Address(RVA = "0x1038430", Offset = "0x1036C30", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x17000807")]
	public static List<int> thirdPartyPermissions
	{
		[Address(RVA = "0x1036FF0", Offset = "0x10357F0", Length = "0x94")]
		[Token(Token = "0x6004A7C")]
		get
		{
			return null;
		}
		[Address(RVA = "0x103BE10", Offset = "0x103A610", Length = "0x99")]
		[Token(Token = "0x6004A7D")]
		set
		{
		}
	}

	[Token(Token = "0x17000808")]
	public static bool showExorcistTrumpetSound
	{
		[Token(Token = "0x6004A7E")]
		[Address(RVA = "0x1036CD0", Offset = "0x10354D0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A7F")]
		[Address(RVA = "0x103BCB0", Offset = "0x103A4B0", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x17000809")]
	public static bool isRacerOnMadState
	{
		[Token(Token = "0x6004A80")]
		[Address(RVA = "0x10342D0", Offset = "0x1032AD0", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A81")]
		[Address(RVA = "0x103A0A0", Offset = "0x10388A0", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x1700080A")]
	public static bool isBloodheirBig
	{
		[Address(RVA = "0x1033D70", Offset = "0x1032570", Length = "0x94")]
		[Token(Token = "0x6004A82")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x1039AA0", Offset = "0x10382A0", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x1700080B")]
	public static int feverTheme
	{
		[Token(Token = "0x6004A84")]
		[Address(RVA = "0x1032790", Offset = "0x1030F90", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A85")]
		[Address(RVA = "0x1038970", Offset = "0x1037170", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x1700080C")]
	public static int feverThemeMode
	{
		[Address(RVA = "0x10326F0", Offset = "0x1030EF0", Length = "0x94")]
		[Token(Token = "0x6004A86")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x10388B0", Offset = "0x10370B0", Length = "0xBB")]
		[Token(Token = "0x6004A87")]
		set
		{
		}
	}

	[Token(Token = "0x1700080D")]
	public static bool isLogin
	{
		[Token(Token = "0x6004A89")]
		[Address(RVA = "0x1033FF0", Offset = "0x10327F0", Length = "0x5C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700080E")]
	public static bool hasReadTutorial
	{
		[Token(Token = "0x6004A8A")]
		[Address(RVA = "0x1033730", Offset = "0x1031F30", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A8B")]
		[Address(RVA = "0x1039610", Offset = "0x1037E10", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x1700080F")]
	public static bool hasPopupNewPlayerPackageTips
	{
		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x1033690", Offset = "0x1031E90", Length = "0x94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x1039550", Offset = "0x1037D50", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x17000810")]
	public static string utcTimeBecomeRegressionPlayer
	{
		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x10374F0", Offset = "0x1035CF0", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A8F")]
		[Address(RVA = "0x103C090", Offset = "0x103A890", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x17000811")]
	public static string activedVip
	{
		[Token(Token = "0x6004A90")]
		[Address(RVA = "0x1031AE0", Offset = "0x10302E0", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A91")]
		[Address(RVA = "0x1037FA0", Offset = "0x10367A0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x17000812")]
	public static string vipExpirationTimeString
	{
		[Token(Token = "0x6004A92")]
		[Address(RVA = "0x1037590", Offset = "0x1035D90", Length = "0x94")]
		get
		{
			return null;
		}
		[Address(RVA = "0x103C130", Offset = "0x103A930", Length = "0x99")]
		[Token(Token = "0x6004A93")]
		set
		{
		}
	}

	[Token(Token = "0x17000813")]
	public static DateTime vipExpirationTime
	{
		[Token(Token = "0x6004A94")]
		[Address(RVA = "0x1037630", Offset = "0x1035E30", Length = "0x130")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x17000814")]
	public static int fps
	{
		[Token(Token = "0x6004A95")]
		[Address(RVA = "0x1032A10", Offset = "0x1031210", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x1038AD0", Offset = "0x10372D0", Length = "0xBB")]
		[Token(Token = "0x6004A96")]
		set
		{
		}
	}

	[Token(Token = "0x17000815")]
	public static int offset
	{
		[Address(RVA = "0x10354F0", Offset = "0x1033CF0", Length = "0x94")]
		[Token(Token = "0x6004A97")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A98")]
		[Address(RVA = "0x103ACC0", Offset = "0x10394C0", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000816")]
	public static int offsetTvMode
	{
		[Token(Token = "0x6004A99")]
		[Address(RVA = "0x1035450", Offset = "0x1033C50", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A9A")]
		[Address(RVA = "0x103AC00", Offset = "0x1039400", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000817")]
	public static List<string> weekFreeMusicUids
	{
		[Token(Token = "0x6004A9B")]
		[Address(RVA = "0x1037810", Offset = "0x1036010", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000818")]
	public static string weekFreeUpdatedAt
	{
		[Address(RVA = "0x1037950", Offset = "0x1036150", Length = "0x94")]
		[Token(Token = "0x6004A9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A9D")]
		[Address(RVA = "0x103C2A0", Offset = "0x103AAA0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x17000819")]
	public static List<string> weekFreeToDlcMusicPacks
	{
		[Token(Token = "0x6004A9E")]
		[Address(RVA = "0x10378B0", Offset = "0x10360B0", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081A")]
	public static DateTime accountLoginDateTime
	{
		[Token(Token = "0x6004A9F")]
		[Address(RVA = "0x1031860", Offset = "0x1030060", Length = "0x94")]
		get
		{
			return default(DateTime);
		}
		[Address(RVA = "0x1037D80", Offset = "0x1036580", Length = "0xBD")]
		[Token(Token = "0x6004AA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700081B")]
	public static DateTime accountLogoutDateTime
	{
		[Address(RVA = "0x1031900", Offset = "0x1030100", Length = "0x94")]
		[Token(Token = "0x6004AA1")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6004AA2")]
		[Address(RVA = "0x1037E40", Offset = "0x1036640", Length = "0xBD")]
		set
		{
		}
	}

	[Token(Token = "0x1700081C")]
	public static List<int> feverExchangeIndexs
	{
		[Token(Token = "0x6004AA3")]
		[Address(RVA = "0x1032650", Offset = "0x1030E50", Length = "0x94")]
		get
		{
			return null;
		}
		[Address(RVA = "0x1038810", Offset = "0x1037010", Length = "0x99")]
		[Token(Token = "0x6004AA4")]
		set
		{
		}
	}

	[Token(Token = "0x1700081D")]
	public static List<int> battleSfxExchangeIndexs
	{
		[Token(Token = "0x6004AA5")]
		[Address(RVA = "0x1031CA0", Offset = "0x10304A0", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004AA6")]
		[Address(RVA = "0x1038160", Offset = "0x1036960", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x1700081E")]
	public static List<int> backgroundExchangeIds
	{
		[Address(RVA = "0x1031C00", Offset = "0x1030400", Length = "0x94")]
		[Token(Token = "0x6004AA7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0x10380C0", Offset = "0x10368C0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x1700081F")]
	public static int globalAchiLongFinishCount
	{
		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x10332D0", Offset = "0x1031AD0", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x1039190", Offset = "0x1037990", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000820")]
	public static int globalAchiBlockCount
	{
		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x1032B50", Offset = "0x1031350", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x1038B90", Offset = "0x1037390", Length = "0xBB")]
		[Token(Token = "0x6004AAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000821")]
	public static int globalAchiBossNearCount
	{
		[Address(RVA = "0x1032C90", Offset = "0x1031490", Length = "0x94")]
		[Token(Token = "0x6004AAD")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x1038D10", Offset = "0x1037510", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000822")]
	public static int globalAchiNoteHitCount
	{
		[Token(Token = "0x6004AAF")]
		[Address(RVA = "0x10334B0", Offset = "0x1031CB0", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AB0")]
		[Address(RVA = "0x1039310", Offset = "0x1037B10", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000823")]
	public static int globalAchiHideNoteCount
	{
		[Address(RVA = "0x1033230", Offset = "0x1031A30", Length = "0x94")]
		[Token(Token = "0x6004AB1")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x10390D0", Offset = "0x10378D0", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000824")]
	public static int globalAchiBloodCount
	{
		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x1032BF0", Offset = "0x10313F0", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x1038C50", Offset = "0x1037450", Length = "0xBB")]
		[Token(Token = "0x6004AB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000825")]
	public static int globalAchiMusicCount
	{
		[Token(Token = "0x6004AB5")]
		[Address(RVA = "0x1033410", Offset = "0x1031C10", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AB6")]
		[Address(RVA = "0x1039250", Offset = "0x1037A50", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000826")]
	public static int globalAchiPressingCount
	{
		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x10335F0", Offset = "0x1031DF0", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x1039490", Offset = "0x1037C90", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000827")]
	public static List<IData> globalAchiFailCount
	{
		[Address(RVA = "0x10330F0", Offset = "0x10318F0", Length = "0x94")]
		[Token(Token = "0x6004AB9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000828")]
	public static int globalAchiPassCount
	{
		[Address(RVA = "0x1033550", Offset = "0x1031D50", Length = "0x94")]
		[Token(Token = "0x6004ABA")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004ABB")]
		[Address(RVA = "0x10393D0", Offset = "0x1037BD0", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x17000829")]
	public static List<string> globalAchiEasyPass
	{
		[Token(Token = "0x6004ABC")]
		[Address(RVA = "0x1032D30", Offset = "0x1031530", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700082A")]
	public static List<string> globalAchiHardPass
	{
		[Token(Token = "0x6004ABD")]
		[Address(RVA = "0x1033190", Offset = "0x1031990", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700082B")]
	public static List<string> globalAchiMasterPass
	{
		[Token(Token = "0x6004ABE")]
		[Address(RVA = "0x1033370", Offset = "0x1031B70", Length = "0x94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700082C")]
	public static int globalAchiEvaluateDPassCount
	{
		[Token(Token = "0x6004ABF")]
		[Address(RVA = "0x1032FB0", Offset = "0x10317B0", Length = "0x94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AC0")]
		[Address(RVA = "0x1039010", Offset = "0x1037810", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x1700082D")]
	public static int globalAchiEvaluateCPassCount
	{
		[Address(RVA = "0x1032F10", Offset = "0x1031710", Length = "0x94")]
		[Token(Token = "0x6004AC1")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AC2")]
		[Address(RVA = "0x1038F50", Offset = "0x1037750", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x1700082E")]
	public static int globalAchiEvaluateBPassCount
	{
		[Address(RVA = "0x1032E70", Offset = "0x1031670", Length = "0x94")]
		[Token(Token = "0x6004AC3")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AC4")]
		[Address(RVA = "0x1038E90", Offset = "0x1037690", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x1700082F")]
	public static int globalAchiEvaluateAPassCount
	{
		[Address(RVA = "0x1032DD0", Offset = "0x10315D0", Length = "0x94")]
		[Token(Token = "0x6004AC5")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x1038DD0", Offset = "0x10375D0", Length = "0xBB")]
		[Token(Token = "0x6004AC6")]
		set
		{
		}
	}

	[Token(Token = "0x17000830")]
	public static List<string> globalAchiFailCharacters
	{
		[Address(RVA = "0x1033050", Offset = "0x1031850", Length = "0x94")]
		[Token(Token = "0x6004AC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000831")]
	public static string daveFishData
	{
		[Token(Token = "0x6004ACA")]
		[Address(RVA = "0x1031FC0", Offset = "0x10307C0", Length = "0x94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x1038390", Offset = "0x1036B90", Length = "0x99")]
		set
		{
		}
	}

	[Address(RVA = "0x10315A0", Offset = "0x102FDA0", Length = "0x2F")]
	[Token(Token = "0x60049D7")]
	static DataHelper()
	{
	}

	[Token(Token = "0x60049D8")]
	[Address(RVA = "0x1031540", Offset = "0x102FD40", Length = "0x60")]
	public static void SetDataManager(DataManager dataManager)
	{
	}

	[Address(RVA = "0x10314B0", Offset = "0x102FCB0", Length = "0x8B")]
	[Token(Token = "0x6004A11")]
	public static void Save()
	{
	}

	[Token(Token = "0x6004A1C")]
	[Address(RVA = "0x10303D0", Offset = "0x102EBD0", Length = "0xB5")]
	public static bool AddFirstOpenEvent(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A2F")]
	[Address(RVA = "0x10312E0", Offset = "0x102FAE0", Length = "0x1CD")]
	public static bool IsStickerOwned(int stickerIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A42")]
	[Address(RVA = "0x1030490", Offset = "0x102EC90", Length = "0x3BC")]
	public static bool CheckMusicUnlockMaster(MusicInfo musicInfo, bool fastCheck)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A43")]
	[Address(RVA = "0x1030850", Offset = "0x102F050", Length = "0x3C0")]
	public static bool CheckMusicUnlockMaster(MusicInfo musicInfo, bool fastCheck, ref bool isUnlockByPlay)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A88")]
	[Address(RVA = "0x1030FF0", Offset = "0x102F7F0", Length = "0x2E5")]
	public static float GetVolume(PeroAudioType type)
	{
		return default(float);
	}

	[Token(Token = "0x6004AC8")]
	[Address(RVA = "0x1030C20", Offset = "0x102F420", Length = "0x1C3")]
	public static int GetTargetEvaluateTotalNum(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6004AC9")]
	[Address(RVA = "0x1030DF0", Offset = "0x102F5F0", Length = "0x1F8")]
	public static int GetTotalHideLevelPassNum()
	{
		return default(int);
	}
}
