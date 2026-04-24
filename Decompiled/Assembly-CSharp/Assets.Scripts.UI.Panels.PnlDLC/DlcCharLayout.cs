using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Serializable]
[Token(Token = "0x2000924")]
public struct DlcCharLayout
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400314F")]
	public string characterAssetKey;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4003150")]
	public RectTransform rectTransform;
}
