using System.Collections.Generic;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000644")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
public class EffectManager : Singleton<EffectManager>, IPause
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002340")]
	private readonly List<Effect> m_Effects;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002341")]
	private GameObject m_Center;

	[Token(Token = "0x1700059E")]
	public GameObject center
	{
		[Address(RVA = "0x7591B0", Offset = "0x7579B0", Length = "0x98")]
		[Token(Token = "0x6003C63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059F")]
	public Effect Item
	{
		[Token(Token = "0x6003C64")]
		[Address(RVA = "0x7590F0", Offset = "0x7578F0", Length = "0xB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A0")]
	public bool IsGlobal
	{
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		[Token(Token = "0x6003C66")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x7583F0", Offset = "0x756BF0", Length = "0x14A")]
	[Token(Token = "0x6003C62")]
	private void Init()
	{
	}

	[Token(Token = "0x6003C65")]
	[Address(RVA = "0x758540", Offset = "0x756D40", Length = "0xEF")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6003C67")]
	[Address(RVA = "0x758C40", Offset = "0x757440", Length = "0xEF")]
	public void Resume()
	{
	}

	[Token(Token = "0x6003C68")]
	[Address(RVA = "0x7589B0", Offset = "0x7571B0", Length = "0xDE")]
	public void Preload(string[] preloadUids, int preload = 5, int capacity = -1, Transform parent = null)
	{
	}

	[Token(Token = "0x6003C69")]
	[Address(RVA = "0x758B60", Offset = "0x757360", Length = "0xDE")]
	public void Preload(GameObject[] gos, int preload = 5, int capacity = -1, Transform parent = null)
	{
	}

	[Token(Token = "0x6003C6A")]
	[Address(RVA = "0x758A90", Offset = "0x757290", Length = "0xC2")]
	public Effect Preload(string uid, int preload = 5, int capacity = -1, Transform parent = null)
	{
		return null;
	}

	[Address(RVA = "0x7588D0", Offset = "0x7570D0", Length = "0xD5")]
	[Token(Token = "0x6003C6B")]
	public Effect Preload(GameObject go, int preload = 5, int capacity = -1, Transform parent = null)
	{
		return null;
	}

	[Token(Token = "0x6003C6C")]
	[Address(RVA = "0x758630", Offset = "0x756E30", Length = "0xE7")]
	public GameObject Play(string uid, int preload = 5, int capacity = -1, Transform parent = null)
	{
		return null;
	}

	[Token(Token = "0x6003C6D")]
	[Address(RVA = "0x758720", Offset = "0x756F20", Length = "0xE3")]
	public GameObject Play(GameObject go, int preload = 5, int capacity = -1, Transform parent = null)
	{
		return null;
	}

	[Token(Token = "0x6003C6E")]
	[Address(RVA = "0x758810", Offset = "0x757010", Length = "0xB7")]
	public GameObject Play(Effect effect)
	{
		return null;
	}

	[Token(Token = "0x6003C6F")]
	[Address(RVA = "0x759010", Offset = "0x757810", Length = "0x6A")]
	public void Unload(string uid)
	{
	}

	[Address(RVA = "0x758FA0", Offset = "0x7577A0", Length = "0x62")]
	[Token(Token = "0x6003C70")]
	public void Unload(Effect effect)
	{
	}

	[Address(RVA = "0x758E90", Offset = "0x757690", Length = "0x102")]
	[Token(Token = "0x6003C71")]
	public void UnloadAll()
	{
	}

	[Address(RVA = "0x759080", Offset = "0x757880", Length = "0x6E")]
	[Token(Token = "0x6003C72")]
	public EffectManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
