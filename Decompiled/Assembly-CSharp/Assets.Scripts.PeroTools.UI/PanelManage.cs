using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005B5")]
public class PanelManage
{
	[Token(Token = "0x4002156")]
	private static bool s_IsInputEnable;

	[Token(Token = "0x4002157")]
	private static List<UISelectManage> s_UiSelectManagers;

	[Token(Token = "0x4002158")]
	private static UISelectManage m_UISelectManager;

	[Token(Token = "0x4002159")]
	public static bool isblockAllKey;

	[Token(Token = "0x600394F")]
	[Address(RVA = "0x9813B0", Offset = "0x97FBB0", Length = "0x104")]
	public PanelManage()
	{
	}

	[Token(Token = "0x6003950")]
	[Address(RVA = "0x980C80", Offset = "0x97F480", Length = "0xDA")]
	public static UISelectManage Peek(int index = 0)
	{
		return null;
	}

	[Token(Token = "0x6003951")]
	[Address(RVA = "0x9811F0", Offset = "0x97F9F0", Length = "0xB2")]
	private static void Pop(int index = 0)
	{
	}

	[Address(RVA = "0x980BB0", Offset = "0x97F3B0", Length = "0xCA")]
	[Token(Token = "0x6003952")]
	public static bool IsThisUiManager(UISelectManage uiManager)
	{
		return default(bool);
	}

	[Address(RVA = "0x980A30", Offset = "0x97F230", Length = "0xBF")]
	[Token(Token = "0x6003953")]
	public static void DisableInput(object sender, object reciever, object[] args)
	{
	}

	[Address(RVA = "0x980AF0", Offset = "0x97F2F0", Length = "0xBF")]
	[Token(Token = "0x6003954")]
	public static void EnableInput(object sender, object reciever, object[] args)
	{
	}

	[Address(RVA = "0x9812B0", Offset = "0x97FAB0", Length = "0x75")]
	[Token(Token = "0x6003955")]
	public static void PushPanel(UISelectManage manager)
	{
	}

	[Address(RVA = "0x981100", Offset = "0x97F900", Length = "0xE2")]
	[Token(Token = "0x6003956")]
	public static bool PopPanel(UISelectManage manager, int deep = 1)
	{
		return default(bool);
	}

	[Token(Token = "0x6003957")]
	[Address(RVA = "0x980F60", Offset = "0x97F760", Length = "0x19D")]
	public static bool PopAll(UISelectManage manager)
	{
		return default(bool);
	}

	[Token(Token = "0x6003958")]
	[Address(RVA = "0x980D60", Offset = "0x97F560", Length = "0x1FF")]
	public static bool PopAllPopup(UISelectManage parent)
	{
		return default(bool);
	}
}
