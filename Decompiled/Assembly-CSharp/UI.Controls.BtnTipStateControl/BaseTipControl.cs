using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Controls.BtnTipStateControl;

[Token(Token = "0x20001D3")]
public abstract class BaseTipControl : MonoBehaviour
{
	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void SetTipState(Func<bool> invoke)
	{
	}

	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected BaseTipControl()
	{
	}
}
