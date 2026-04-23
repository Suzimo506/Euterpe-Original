using System.Collections.Generic;
using Assets.Scripts.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000EA")]
public class MenuSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40005DA")]
	[SerializeField]
	private Toggle[] m_PcOptions;

	[SerializeField]
	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0x120")]
	private Toggle[] m_NsOptions;

	[Token(Token = "0x40005DC")]
	[SerializeField]
	[FieldOffset(Offset = "0x128")]
	private Toggle[] m_MobileOptions;

	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x40005DD")]
	private GameObject[] m_ActivePnls;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40005DE")]
	private Toggle[] m_Panels;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40005DF")]
	private Dictionary<Toggle, GameObject> m_Pnls;

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x8C18D0", Offset = "0x8C00D0", Length = "0x9B")]
	public override bool IsThisUiManager()
	{
		return default(bool);
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x8C2400", Offset = "0x8C0C00", Length = "0x12A")]
	public void SetOn(MenuType type, bool forceNotify = false)
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x8C22C0", Offset = "0x8C0AC0", Length = "0x131")]
	public void SetOff(MenuType type, bool forceNotify = false)
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x8C1970", Offset = "0x8C0170", Length = "0x43A")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x8C2020", Offset = "0x8C0820", Length = "0x241")]
	private void OnToggleChanged(int listIndex, int index, bool isOn)
	{
	}

	[Address(RVA = "0x8C1F40", Offset = "0x8C0740", Length = "0xD2")]
	[Token(Token = "0x60006D1")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x8C1E60", Offset = "0x8C0660", Length = "0xD2")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x8C2270", Offset = "0x8C0A70", Length = "0x43")]
	[Token(Token = "0x60006D3")]
	public void SaveData()
	{
	}

	[Address(RVA = "0x8C2530", Offset = "0x8C0D30", Length = "0x30")]
	[Token(Token = "0x60006D4")]
	private void ShowOrHideTglGroup(bool value)
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x8C1DB0", Offset = "0x8C05B0", Length = "0xA9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public MenuSelect()
	{
	}
}
