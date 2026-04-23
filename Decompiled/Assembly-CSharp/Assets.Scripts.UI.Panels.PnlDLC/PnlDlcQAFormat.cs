using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[ExecuteInEditMode]
[Token(Token = "0x2000943")]
public class PnlDlcQAFormat : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400323C")]
	private Text m_Text;

	[Token(Token = "0x400323D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_IsMusePlus;

	[TextArea]
	[Attribute(Name = "HeaderAttribute", RVA = "0x98380", Offset = "0x97780")]
	[Token(Token = "0x400323E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_English;

	[SerializeField]
	[TextArea]
	[Attribute(Name = "HeaderAttribute", RVA = "0x998E0", Offset = "0x98CE0")]
	[Token(Token = "0x400323F")]
	[FieldOffset(Offset = "0x30")]
	private string m_ChineseS;

	[Token(Token = "0x4003240")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x999E0", Offset = "0x98DE0")]
	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[TextArea]
	private string m_ChineseT;

	[Attribute(Name = "HeaderAttribute", RVA = "0x99AC0", Offset = "0x98EC0")]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4003241")]
	[TextArea]
	[SerializeField]
	private string m_Japanese;

	[Token(Token = "0x4003242")]
	[FieldOffset(Offset = "0x48")]
	[TextArea]
	[Attribute(Name = "HeaderAttribute", RVA = "0x99BF0", Offset = "0x98FF0")]
	[SerializeField]
	private string m_Korean;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4003243")]
	private Dictionary<string, string> m_ReplaceDict;

	[Token(Token = "0x4003244")]
	[FieldOffset(Offset = "0x58")]
	private string[] m_SpecialWelcome;

	[Token(Token = "0x4003245")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, string> m_Language;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4003246")]
	private readonly List<CheckRoleItemParams> m_ExcludeProduct;

	[Token(Token = "0x600542C")]
	[Address(RVA = "0x82BAB0", Offset = "0x82A2B0", Length = "0x2B0")]
	private string SongCount()
	{
		return null;
	}

	[Address(RVA = "0x82B3C0", Offset = "0x829BC0", Length = "0x1D8")]
	[Token(Token = "0x600542D")]
	private int GetTimeoutCount()
	{
		return default(int);
	}

	[Address(RVA = "0x82B1C0", Offset = "0x8299C0", Length = "0x1FD")]
	[Token(Token = "0x600542E")]
	private int GetDLCCount()
	{
		return default(int);
	}

	[Address(RVA = "0x82AF60", Offset = "0x829760", Length = "0x123")]
	[Token(Token = "0x600542F")]
	private string CharacterCount()
	{
		return null;
	}

	[Address(RVA = "0x82B090", Offset = "0x829890", Length = "0x123")]
	[Token(Token = "0x6005430")]
	private string ElfinCount()
	{
		return null;
	}

	[Token(Token = "0x6005431")]
	[Address(RVA = "0x82BD70", Offset = "0x82A570", Length = "0x17B")]
	private string WelcomeCount()
	{
		return null;
	}

	[Address(RVA = "0x82B5A0", Offset = "0x829DA0", Length = "0x165")]
	[Token(Token = "0x6005432")]
	private string InterludeCount()
	{
		return null;
	}

	[Address(RVA = "0x82A8B0", Offset = "0x8290B0", Length = "0x6A8")]
	[Token(Token = "0x6005433")]
	private void Awake()
	{
	}

	[Address(RVA = "0x82B710", Offset = "0x829F10", Length = "0x398")]
	[Token(Token = "0x6005434")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005435")]
	[Address(RVA = "0x82BEF0", Offset = "0x82A6F0", Length = "0x10F")]
	public PnlDlcQAFormat()
	{
	}
}
