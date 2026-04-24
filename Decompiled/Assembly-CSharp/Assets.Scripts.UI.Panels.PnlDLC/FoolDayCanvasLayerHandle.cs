using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000928")]
public class FoolDayCanvasLayerHandle : FoolDayHandle
{
	[Token(Token = "0x400315E")]
	[FieldOffset(Offset = "0x18")]
	public Canvas canvas;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400315F")]
	public GraphicRaycaster graphicRaycaster;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003160")]
	public string sortingLayerName;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003161")]
	public bool usePresetOrder;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4003162")]
	public int order;

	[Token(Token = "0x6005314")]
	[Address(RVA = "0x42E1B0", Offset = "0x42C9B0", Length = "0x5B")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6005315")]
	[Address(RVA = "0x42E210", Offset = "0x42CA10", Length = "0x46")]
	public FoolDayCanvasLayerHandle()
	{
	}
}
