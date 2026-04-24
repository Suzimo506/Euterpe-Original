using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000131")]
public class PnlRecord : MonoBehaviour
{
	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x18")]
	public Text txtScore;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000780")]
	public Text txtGrade;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000781")]
	public Text txtCombo;

	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x30")]
	public Text txtAccuracy;

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x38")]
	public Text txtClear;

	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x40")]
	public Color[] gradeColor;

	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x48")]
	public Color fullComboColor;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000786")]
	public GameObject imgIconFc;

	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x561570", Offset = "0x55FD70", Length = "0x521")]
	public void RefreshRecord()
	{
	}

	[Address(RVA = "0x561380", Offset = "0x55FB80", Length = "0x1E2")]
	[Token(Token = "0x60008A2")]
	private void Clear()
	{
	}

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlRecord()
	{
	}
}
