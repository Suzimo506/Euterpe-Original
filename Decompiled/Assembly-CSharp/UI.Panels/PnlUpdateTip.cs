using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Panels;

[Token(Token = "0x20001C6")]
public class PnlUpdateTip : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000CC7")]
	public PnlUpdateTip()
	{
	}
}
