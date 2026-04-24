using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000782")]
public class DBBattleStage : BaseDatabase
{
	[Token(Token = "0x40027AC")]
	[FieldOffset(Offset = "0x10")]
	private int m_MapDifficulty;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40027AD")]
	private int m_MusicLevel;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40027AE")]
	private string m_MusicLevelStr;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40027AF")]
	private int m_SelectedRole;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40027B0")]
	private int m_SelectedRoleSkin;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40027B1")]
	private int m_SelectedElfin;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40027B2")]
	private string m_MusicFileName;

	[Token(Token = "0x40027B3")]
	[FieldOffset(Offset = "0x38")]
	private string m_MusicName;

	[Token(Token = "0x40027B4")]
	[FieldOffset(Offset = "0x40")]
	private string m_BeganScene;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40027B5")]
	private int m_BeganSceneIdx;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40027B6")]
	private string m_StageMapName;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40027B7")]
	private string m_MusicUid;

	[Token(Token = "0x40027B8")]
	[FieldOffset(Offset = "0x60")]
	private int m_PackageJsonIndex;

	[Token(Token = "0x40027B9")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<int, DaveFishData> m_DiveFishDatas;

	[Token(Token = "0x17000696")]
	public bool isTutorial
	{
		[CompilerGenerated]
		[Token(Token = "0x6004642")]
		[Address(RVA = "0x6F3AF0", Offset = "0x6F22F0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x6F3BC0", Offset = "0x6F23C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6004641")]
		set
		{
		}
	}

	[Token(Token = "0x17000697")]
	public int selectedMusicIndexFormAll
	{
		[Address(RVA = "0x42C7D0", Offset = "0x42AFD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6004644")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x6004643")]
		[Address(RVA = "0x42CA10", Offset = "0x42B210", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000698")]
	public MusicInfo selectedMusicInfo
	{
		[Token(Token = "0x6004645")]
		[Address(RVA = "0x6F3B10", Offset = "0x6F2310", Length = "0xAA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000699")]
	public string selectedStageMapName
	{
		[Token(Token = "0x6004646")]
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069A")]
	public string selectedMusicFileName
	{
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[Token(Token = "0x6004647")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069B")]
	public string selectedMusicName
	{
		[Token(Token = "0x6004648")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069C")]
	public string selectedBeganScene
	{
		[Token(Token = "0x6004649")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069D")]
	public int selectedBeganSceneIdx
	{
		[Token(Token = "0x600464A")]
		[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700069E")]
	public string selectMusicLevelStr
	{
		[Token(Token = "0x600464B")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069F")]
	public int selectedMusicPackageJsonIndex
	{
		[Address(RVA = "0x429C30", Offset = "0x428430", Length = "0x4")]
		[Token(Token = "0x600464C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A0")]
	public string musicUid
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[Token(Token = "0x600464D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A1")]
	public int selectedDifficulty
	{
		[Token(Token = "0x600464E")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600464F")]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170006A2")]
	public int selectedMusicLevel
	{
		[Token(Token = "0x6004650")]
		[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x494A20", Offset = "0x493220", Length = "0x4")]
		[Token(Token = "0x6004651")]
		set
		{
		}
	}

	[Token(Token = "0x170006A3")]
	public int selectedRole
	{
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		[Token(Token = "0x6004652")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A4")]
	public int selectRoleSkin
	{
		[Token(Token = "0x6004653")]
		[Address(RVA = "0x42D1F0", Offset = "0x42B9F0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A5")]
	public int selectedElfin
	{
		[Token(Token = "0x6004654")]
		[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A6")]
	public Dictionary<int, DaveFishData> diveFishDatas
	{
		[Token(Token = "0x6004655")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004656")]
		[Address(RVA = "0x5C14A0", Offset = "0x5BFCA0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6004657")]
	[Address(RVA = "0x6F36B0", Offset = "0x6F1EB0", Length = "0x7")]
	public bool IsSelectRole(int roleIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6004658")]
	[Address(RVA = "0x6F36A0", Offset = "0x6F1EA0", Length = "0x7")]
	public bool IsSelectElfin(int elfinIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6004659")]
	[Address(RVA = "0x6F3480", Offset = "0x6F1C80", Length = "0x8")]
	public void ChangeRoleContingently(int roleIndex, int roleSkin = 0)
	{
	}

	[Token(Token = "0x600465A")]
	[Address(RVA = "0x4879F0", Offset = "0x4861F0", Length = "0x4")]
	public void ChangeElfinContingently(int elfinIndex)
	{
	}

	[Address(RVA = "0x6F36D0", Offset = "0x6F1ED0", Length = "0xBE")]
	[Token(Token = "0x600465B")]
	public void SetStageBattleInfo(string musicFileName, string musicName, string scene, int musicLevel)
	{
	}

	[Address(RVA = "0x6F32A0", Offset = "0x6F1AA0", Length = "0x1D1")]
	[Token(Token = "0x600465C")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x6F3490", Offset = "0x6F1C90", Length = "0x206")]
	[Token(Token = "0x600465D")]
	private void InitRole()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600465E")]
	public override void SceneChangedRelease(Scene preScene, Scene curScene)
	{
	}

	[Address(RVA = "0x6F36C0", Offset = "0x6F1EC0", Length = "0x8")]
	[Token(Token = "0x600465F")]
	public override void Release()
	{
	}

	[Token(Token = "0x6004660")]
	[Address(RVA = "0x6F3790", Offset = "0x6F1F90", Length = "0x2C3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004661")]
	[Address(RVA = "0x6F3A60", Offset = "0x6F2260", Length = "0x87")]
	public DBBattleStage()
	{
	}
}
