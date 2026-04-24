using Cpp2ILInjected;
using PeroTools2.PeroString;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000176")]
public class ChangeScoreValue : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000943")]
	public Text text;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000944")]
	public TextMeshProUGUI gcText;

	[Token(Token = "0x4000945")]
	[FieldOffset(Offset = "0x28")]
	public Text djmaxText;

	[Token(Token = "0x4000946")]
	[FieldOffset(Offset = "0x30")]
	public Text arkNightText;

	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] scores;

	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] apIcons;

	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x3B5A0", Offset = "0x3A9A0")]
	[Token(Token = "0x4000949")]
	public GameObject imgRampageSkill;

	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x3B630", Offset = "0x3AA30")]
	public GameObject imgCarrotRobotSkill;

	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x58")]
	private int m_Index;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400094C")]
	private int m_SceneIdx;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400094D")]
	private PeroString m_PeroString;

	[Address(RVA = "0x464C20", Offset = "0x463420", Length = "0x243")]
	[Token(Token = "0x6000AC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x4653C0", Offset = "0x463BC0", Length = "0xCC")]
	private void SetApIcons(bool enable)
	{
	}

	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x465200", Offset = "0x463A00", Length = "0xBD")]
	private void OnJudged(uint result)
	{
	}

	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x464E70", Offset = "0x463670", Length = "0x26F")]
	public void InitUi()
	{
	}

	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x4650E0", Offset = "0x4638E0", Length = "0x118")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4652C0", Offset = "0x463AC0", Length = "0xFD")]
	[Token(Token = "0x6000AC9")]
	private void OnScoreChange(int score)
	{
	}

	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ChangeScoreValue()
	{
	}
}
