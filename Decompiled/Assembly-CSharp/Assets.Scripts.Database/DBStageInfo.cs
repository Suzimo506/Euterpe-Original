using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using GameLogic;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000810")]
public class DBStageInfo : BaseDatabase
{
	[Token(Token = "0x4002A04")]
	[FieldOffset(Offset = "0x10")]
	public bool invokeLoaded;

	[Token(Token = "0x4002A05")]
	[FieldOffset(Offset = "0x18")]
	private StageInfo m_StageInfo;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002A0B")]
	private decimal m_Delay;

	[Token(Token = "0x4002A0C")]
	[FieldOffset(Offset = "0x58")]
	private float m_Bpm;

	[Token(Token = "0x17000762")]
	public string md5
	{
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x102F240", Offset = "0x102DA40", Length = "0x97")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000763")]
	public string mapName
	{
		[Token(Token = "0x6004906")]
		[Address(RVA = "0x102F230", Offset = "0x102DA30", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000764")]
	public float bpm
	{
		[Token(Token = "0x6004907")]
		[Address(RVA = "0x102F020", Offset = "0x102D820", Length = "0x8C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000765")]
	public float runtimeBpm
	{
		[Address(RVA = "0x44A090", Offset = "0x448890", Length = "0x6")]
		[Token(Token = "0x6004908")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		[Token(Token = "0x6004909")]
		[Address(RVA = "0xDC8720", Offset = "0xDC6F20", Length = "0x6")]
		set
		{
		}
	}

	[Token(Token = "0x17000766")]
	public decimal delay
	{
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x102F0B0", Offset = "0x102D8B0", Length = "0x91")]
		get
		{
			return default(decimal);
		}
	}

	[Token(Token = "0x17000767")]
	public float floatDelay
	{
		[Token(Token = "0x600490B")]
		[Address(RVA = "0x102F150", Offset = "0x102D950", Length = "0xD4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000768")]
	public List<SceneEvent> sceneEvents
	{
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600490C")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x600490D")]
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000769")]
	public Dictionary<string, List<GameDialogArgs>> sceneDialogEvents
	{
		[CompilerGenerated]
		[Token(Token = "0x600490E")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600490F")]
		[CompilerGenerated]
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700076A")]
	public Dictionary<decimal, List<GameDialogArgs>> sceneDialogDictionary
	{
		[CompilerGenerated]
		[Token(Token = "0x6004910")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x45EEF0", Offset = "0x45D6F0", Length = "0xC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700076B")]
	public List<MusicData> oriMusicList
	{
		[Token(Token = "0x6004912")]
		[Address(RVA = "0x102F2E0", Offset = "0x102DAE0", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700076C")]
	public List<MusicData> musicList
	{
		[CompilerGenerated]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6004913")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004914")]
		[Address(RVA = "0x4434D0", Offset = "0x441CD0", Length = "0xC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6004915")]
	[Address(RVA = "0x4434D0", Offset = "0x441CD0", Length = "0xC")]
	public void SetRuntimeMusicData(List<MusicData> data)
	{
	}

	[Token(Token = "0x6004916")]
	[Address(RVA = "0x102EA20", Offset = "0x102D220", Length = "0x400")]
	private void DialogDataToDic(Dictionary<string, List<GameDialogArgs>> dialogDic)
	{
	}

	[Address(RVA = "0x102EEE0", Offset = "0x102D6E0", Length = "0x48")]
	[Token(Token = "0x6004917")]
	public void SetDialogArgs(Dictionary<string, List<GameDialogArgs>> dialogArgs, bool isRefresh)
	{
	}

	[Token(Token = "0x6004918")]
	[Address(RVA = "0x102EEC0", Offset = "0x102D6C0", Length = "0x1C")]
	public void SetBaseData(decimal delay, float bpm, List<SceneEvent> events)
	{
	}

	[Address(RVA = "0x102EF30", Offset = "0x102D730", Length = "0x8D")]
	[Token(Token = "0x6004919")]
	public void SetStageInfo(StageInfo info)
	{
	}

	[Token(Token = "0x600491A")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x102EE30", Offset = "0x102D630", Length = "0x8A")]
	[Token(Token = "0x600491B")]
	public override void Release()
	{
	}

	[Token(Token = "0x600491C")]
	[Address(RVA = "0x102EFC0", Offset = "0x102D7C0", Length = "0x51")]
	public DBStageInfo()
	{
	}
}
