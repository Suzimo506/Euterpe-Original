using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Serializable]
[Token(Token = "0x2000947")]
public struct VipTimeLimitedUnit
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4003287")]
	public string language;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4003288")]
	public GameObject UI_GameObject;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4003289")]
	public Text TimeLimitText;
}
