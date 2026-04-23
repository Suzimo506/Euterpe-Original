using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI;

[Token(Token = "0x2000828")]
public class PnlNavigation : UISelectManage
{
	[Token(Token = "0x4002A7F")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Button m_BtnOption;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4002A80")]
	[SerializeField]
	private Button m_BtnRole;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4002A81")]
	[SerializeField]
	private Button m_BtnElfin;

	[SerializeField]
	[Token(Token = "0x4002A82")]
	[FieldOffset(Offset = "0x130")]
	private Button m_BtnTrove;

	[SerializeField]
	[Token(Token = "0x4002A83")]
	[FieldOffset(Offset = "0x138")]
	private Button m_BtnAchv;

	[Token(Token = "0x4002A84")]
	private static GameObject s_Shine;

	[Token(Token = "0x4002A85")]
	private static MenuType m_LastType;

	[Token(Token = "0x4002A86")]
	private static MenuType m_Type;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4002A87")]
	[SerializeField]
	private GameObject m_Shine;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4002A88")]
	[SerializeField]
	private PnlMenu m_PnlMenu;

	[Address(RVA = "0x4C5310", Offset = "0x4C3B10", Length = "0x526")]
	[Token(Token = "0x6004B1E")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6004B1F")]
	[Address(RVA = "0x4C5F30", Offset = "0x4C4730", Length = "0x165")]
	public static void UnlockNew(MenuType t)
	{
	}

	[Token(Token = "0x6004B20")]
	[Address(RVA = "0x4C5030", Offset = "0x4C3830", Length = "0x1AF")]
	public static void ClearNewTip(MenuType menuType)
	{
	}

	[Address(RVA = "0x4C51E0", Offset = "0x4C39E0", Length = "0x61")]
	[Token(Token = "0x6004B21")]
	public override bool IsThisUiManager()
	{
		return default(bool);
	}

	[Token(Token = "0x6004B22")]
	[Address(RVA = "0x4C5E40", Offset = "0x4C4640", Length = "0x83")]
	private void PlayClickSfx()
	{
	}

	[Token(Token = "0x6004B23")]
	[Address(RVA = "0x4C5ED0", Offset = "0x4C46D0", Length = "0x5B")]
	public static void SetLastType(MenuType type)
	{
	}

	[Token(Token = "0x6004B24")]
	[Address(RVA = "0x4C5960", Offset = "0x4C4160", Length = "0x9B")]
	public void OnOpenOptionByMenuType(MenuType menuType, MenuType menuOffType)
	{
	}

	[Token(Token = "0x6004B25")]
	[Address(RVA = "0x4C5A00", Offset = "0x4C4200", Length = "0x302")]
	private void OnOptionClicked()
	{
	}

	[Token(Token = "0x6004B26")]
	[Address(RVA = "0x4C5D10", Offset = "0x4C4510", Length = "0x63")]
	private void OnRoleClicked()
	{
	}

	[Token(Token = "0x6004B27")]
	[Address(RVA = "0x4C58F0", Offset = "0x4C40F0", Length = "0x63")]
	private void OnElfinClicked()
	{
	}

	[Address(RVA = "0x4C5D80", Offset = "0x4C4580", Length = "0xB6")]
	[Token(Token = "0x6004B28")]
	private void OnTroveClicked()
	{
	}

	[Token(Token = "0x6004B29")]
	[Address(RVA = "0x4C5250", Offset = "0x4C3A50", Length = "0xB6")]
	private void OnAchvClicked()
	{
	}

	[Token(Token = "0x6004B2A")]
	[Address(RVA = "0x4C5840", Offset = "0x4C4040", Length = "0xA9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004B2B")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlNavigation()
	{
	}
}
