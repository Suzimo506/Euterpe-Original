using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000D7")]
public class BattleSfxSelect : UISelectManage
{
	[Token(Token = "0x20009F7")]
	public struct BattleSfxLock
	{
		[Token(Token = "0x4003592")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003593")]
		public Button btnBattleSfxLock;
	}

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000552")]
	public Text txtBattleSfxLabel;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000553")]
	public Button btnCancel;

	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x128")]
	public Color highLight;

	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0x138")]
	public Color normal;

	[Attribute(Name = "HeaderAttribute", RVA = "0x60F0", Offset = "0x54F0")]
	[Token(Token = "0x4000556")]
	[SerializeField]
	[FieldOffset(Offset = "0x148")]
	private List<Toggle> m_BattleSfx;

	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private List<BattleSfxLock> m_BattleSfxLocks;

	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000558")]
	public GameObject notBuyCatTip;

	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000559")]
	public GameObject notBuyErrorTip;

	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x168")]
	public GameObject notBuyMusclemanTip;

	[Token(Token = "0x400055B")]
	[SerializeField]
	[FieldOffset(Offset = "0x170")]
	private RectTransform m_Content;

	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	private UISetColor[] m_UiSetColors;

	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x180")]
	private bool m_IsFirstShowBuyCatTip;

	[FieldOffset(Offset = "0x181")]
	[Token(Token = "0x400055E")]
	private bool m_IsFirstShowBuyErrorTip;

	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x182")]
	private bool m_IsFirstShowBuyMusclemanTip;

	[Token(Token = "0x17000082")]
	private bool m_IsBuyNekoSfx
	{
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x5FBA20", Offset = "0x5FA220", Length = "0x4B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000083")]
	private bool m_IsBuyErrorSfx
	{
		[Address(RVA = "0x5FB830", Offset = "0x5FA030", Length = "0xBD")]
		[Token(Token = "0x6000613")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000084")]
	private bool m_IsBuyMutownSfx
	{
		[Address(RVA = "0x5FB9B0", Offset = "0x5FA1B0", Length = "0x66")]
		[Token(Token = "0x6000614")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000085")]
	private bool m_IsBuyMusclemanSfx
	{
		[Address(RVA = "0x5FB8F0", Offset = "0x5FA0F0", Length = "0xBD")]
		[Token(Token = "0x6000615")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x5FA480", Offset = "0x5F8C80", Length = "0xA0")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x5FA9A0", Offset = "0x5F91A0", Length = "0xF0")]
	public override void OnDisablePnl()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x5FAAA0", Offset = "0x5F92A0", Length = "0xC5")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x5FA900", Offset = "0x5F9100", Length = "0x9C")]
	[Token(Token = "0x6000619")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x5FAB70", Offset = "0x5F9370", Length = "0xAC")]
	[Token(Token = "0x600061A")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x5F9CE0", Offset = "0x5F84E0", Length = "0xFF")]
	[Token(Token = "0x600061B")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Address(RVA = "0x5FAC20", Offset = "0x5F9420", Length = "0x1DF")]
	[Token(Token = "0x600061C")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x5FB520", Offset = "0x5F9D20", Length = "0x133")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x5F9EB0", Offset = "0x5F86B0", Length = "0x48F")]
	[Token(Token = "0x600061E")]
	private void InitBattleSfx()
	{
	}

	[Address(RVA = "0x5F9DE0", Offset = "0x5F85E0", Length = "0xCE")]
	[Token(Token = "0x600061F")]
	private void ExchangeHandle()
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x5FB0B0", Offset = "0x5F98B0", Length = "0x1B0")]
	private void ResetSelectedBattleSfx(bool notBuyNeko, bool notBuyError, bool notBuyMutown, bool notBuyMuscleman)
	{
	}

	[Address(RVA = "0x5F9A90", Offset = "0x5F8290", Length = "0x24F")]
	[Token(Token = "0x6000621")]
	private void AddListenForBattleSfx()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x5FA530", Offset = "0x5F8D30", Length = "0x3CA")]
	private void OnBattleSfxToggle(int index, bool isOn)
	{
	}

	[Address(RVA = "0x5FAE00", Offset = "0x5F9600", Length = "0xCC")]
	[Token(Token = "0x6000623")]
	private void PlayBattleSfxDemo(int index)
	{
	}

	[Address(RVA = "0x5FA340", Offset = "0x5F8B40", Length = "0x13D")]
	[Token(Token = "0x6000624")]
	private void MarkIsFirstBuyTip(int index, ref int battleSfxType)
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x5FB660", Offset = "0x5F9E60", Length = "0x1CA")]
	private void ShowBlowBuyTips(int index)
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x5FB270", Offset = "0x5F9A70", Length = "0x12F")]
	private void SetFocusColor(GameObject go, bool enable)
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x5FB3A0", Offset = "0x5F9BA0", Length = "0xE9")]
	private void SetSelectImage(GameObject currentObj)
	{
	}

	[Address(RVA = "0x5FB490", Offset = "0x5F9C90", Length = "0x86")]
	[Token(Token = "0x6000628")]
	private void SetSelectText(GameObject currentObj)
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x5FB010", Offset = "0x5F9810", Length = "0x9C")]
	private void RegisterEvent()
	{
	}

	[Address(RVA = "0x5FA900", Offset = "0x5F9100", Length = "0x9C")]
	[Token(Token = "0x600062A")]
	private void UnregisterEvent()
	{
	}

	[Address(RVA = "0x5FAED0", Offset = "0x5F96D0", Length = "0x130")]
	[Token(Token = "0x600062B")]
	private void RefreshBattleSfxTitle()
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x600062C")]
	public BattleSfxSelect()
	{
	}
}
