using Cpp2ILInjected;
using PeroTools2.PeroString;
using TMPro;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000691")]
public static class PeroStringUtils
{
	[Token(Token = "0x6003DC1")]
	[Address(RVA = "0x92FD90", Offset = "0x92E590", Length = "0xED")]
	public static void SetPeroText(this Text text, PeroString peroString, bool refreshLayout = false)
	{
	}

	[Address(RVA = "0x92FCF0", Offset = "0x92E4F0", Length = "0x9A")]
	[Token(Token = "0x6003DC2")]
	public static void SetPeroText(this TMP_Text text, PeroString peroString)
	{
	}
}
