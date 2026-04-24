using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[Token(Token = "0x20000B7")]
public class PnlVictoryControls
{
	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x10")]
	public ResolutionType resolutionType;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B4")]
	public GameObject mainPnl;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BE70", Offset = "0x9B270")]
	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x20")]
	public Button btnReset;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004B6")]
	public Button btnContinue;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004B7")]
	public Text scoreTxt;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004B8")]
	public Text highScoreTitle;

	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x40")]
	public Text highScoreTxt;

	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x48")]
	public Text diffTxt;

	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x50")]
	public Text accuracyTxt;

	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x58")]
	public Text maxComboTxt;

	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x60")]
	public GameObject tglLike;

	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x68")]
	public GameObject newBest;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF70", Offset = "0x9B370")]
	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x70")]
	public Toggle tglAdvJudgment;

	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x78")]
	public GameObject advJudgment;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40004C1")]
	public Animator advJudgmentAnimator;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0A0", Offset = "0x9B4A0")]
	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x88")]
	public GameObject detailInfoOther;

	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x90")]
	public GameObject detailInfoTouhou;

	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x98")]
	public Text perfectTxt;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40004C5")]
	public Text greatTxt;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40004C6")]
	public Text[] passTxt;

	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0xB0")]
	public Text[] missTxt;

	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0xB8")]
	public Text earlyTxt;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40004C9")]
	public Text lateTxt;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40004CA")]
	public Text getTxt;

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public PnlVictoryControls()
	{
	}
}
