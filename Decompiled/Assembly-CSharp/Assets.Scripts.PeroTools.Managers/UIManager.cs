using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000654")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
public class UIManager : Singleton<UIManager>
{
	[Token(Token = "0x400239C")]
	[FieldOffset(Offset = "0x10")]
	private EventSystem m_Es;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400239D")]
	private GameObject m_PreSelected;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400239E")]
	private List<GameObject> m_PnlGameObjects;

	[Token(Token = "0x400239F")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform m_RectTransform;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40023A1")]
	private readonly Stack<GameObject> m_InactiveStack;

	[Token(Token = "0x170005BA")]
	public Camera camera
	{
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6003D00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003D01")]
		[CompilerGenerated]
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x170005BB")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x7679B0", Offset = "0x7661B0", Length = "0x1CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BC")]
	public GameObject top
	{
		[Address(RVA = "0x767BB0", Offset = "0x7663B0", Length = "0x15A")]
		[Token(Token = "0x6003D03")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BD")]
	public float scale
	{
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x767B80", Offset = "0x766380", Length = "0x2E")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005BE")]
	public GameObject peek
	{
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x767810", Offset = "0x766010", Length = "0x51")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BF")]
	public string[] pnlNames
	{
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x767870", Offset = "0x766070", Length = "0x139")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C0")]
	public GameObject Item
	{
		[Address(RVA = "0x767740", Offset = "0x765F40", Length = "0xC6")]
		[Token(Token = "0x6003D07")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x767560", Offset = "0x765D60", Length = "0x64")]
	[Token(Token = "0x6003D08")]
	public void Push(Object pnlGO)
	{
	}

	[Token(Token = "0x6003D09")]
	[Address(RVA = "0x767490", Offset = "0x765C90", Length = "0xCD")]
	public void Pop(Object pnlGO)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003D0A")]
	public void Init()
	{
	}

	[Address(RVA = "0x767680", Offset = "0x765E80", Length = "0xBE")]
	[Token(Token = "0x6003D0B")]
	public UIManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}

	[Token(Token = "0x6003D0C")]
	[Address(RVA = "0x7671E0", Offset = "0x7659E0", Length = "0x2A0")]
	private void InitEachScene()
	{
	}

	[Token(Token = "0x6003D0D")]
	[Address(RVA = "0x7670A0", Offset = "0x7658A0", Length = "0x13B")]
	private void AutoResetSelectedObj(float arg0)
	{
	}

	[Token(Token = "0x6003D0E")]
	[Address(RVA = "0x7675D0", Offset = "0x765DD0", Length = "0x95")]
	public static void SetNull()
	{
	}
}
