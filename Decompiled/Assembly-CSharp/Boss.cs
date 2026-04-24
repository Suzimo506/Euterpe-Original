using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200004E")]
public class Boss : IPause
{
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x11")]
	private bool m_DisappearBoss;

	[Token(Token = "0x40001BD")]
	private static Boss instance;

	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_CurBossObject;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001BF")]
	private Dictionary<int, GameObject> m_BossObjects;

	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x28")]
	private int m_CurBossIndex;

	[Token(Token = "0x17000040")]
	public bool BossHasEntered
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000220")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public bool curBossIsIn
	{
		[CompilerGenerated]
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x45EE60", Offset = "0x45D660", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x45EF00", Offset = "0x45D700", Length = "0x4")]
		[Token(Token = "0x6000223")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public SpineActionController spineActionController
	{
		[CompilerGenerated]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[Token(Token = "0x6000225")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public Animator animator
	{
		[CompilerGenerated]
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x45EEF0", Offset = "0x45D6F0", Length = "0xC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public GameObject go
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x45EE70", Offset = "0x45D670", Length = "0x67")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000045")]
	public static Boss Instance
	{
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x45ECD0", Offset = "0x45D4D0", Length = "0x182")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000046")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x600022D")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x45EC10", Offset = "0x45D410", Length = "0xBE")]
	[Token(Token = "0x6000228")]
	public Boss()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x45E290", Offset = "0x45CA90", Length = "0x156")]
	public static void ReleaseReferences()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x45E4B0", Offset = "0x45CCB0", Length = "0x394")]
	public void SceneBossChange(int idx)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x45DAF0", Offset = "0x45C2F0", Length = "0xBB")]
	public void Pause(bool cor)
	{
	}

	[Address(RVA = "0x45E3F0", Offset = "0x45CBF0", Length = "0xBB")]
	[Token(Token = "0x600022F")]
	public void Resume()
	{
	}

	[Address(RVA = "0x45E850", Offset = "0x45D050", Length = "0x317")]
	[Token(Token = "0x6000230")]
	public void SetBoss()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x45EB70", Offset = "0x45D370", Length = "0x91")]
	public void SetDisappear(bool enable)
	{
	}

	[Address(RVA = "0x45DAC0", Offset = "0x45C2C0", Length = "0x20")]
	[Token(Token = "0x6000232")]
	public void InitUpdateAnim()
	{
	}

	[Address(RVA = "0x45DBB0", Offset = "0x45C3B0", Length = "0x450")]
	[Token(Token = "0x6000233")]
	public void Play(string key, bool playAnimator = true)
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x45D450", Offset = "0x45BC50", Length = "0x13D")]
	private string BossFestival(string bossFestivalName)
	{
		return null;
	}

	[Address(RVA = "0x45D590", Offset = "0x45BD90", Length = "0x52C")]
	[Token(Token = "0x6000235")]
	private void InitBossObject(string name, int scene, bool isLast = false)
	{
	}
}
