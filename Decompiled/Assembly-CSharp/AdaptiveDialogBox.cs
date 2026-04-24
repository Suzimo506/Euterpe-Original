using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000D4")]
public class AdaptiveDialogBox : MonoBehaviour
{
	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text m_TxtDialog;

	[SerializeField]
	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform m_RectTransform;

	[SerializeField]
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x28")]
	private float m_MinHeight;

	[SerializeField]
	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x2C")]
	private float m_MaxHeight;

	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_DefaultFontSize;

	[Token(Token = "0x4000542")]
	private const string m_NonBreakingSpace = "\ufffd";

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000543")]
	private readonly string strPunctuation;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000544")]
	private WaitForEndOfFrame m_WaitForEndOfFrame;

	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsEnglish;

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x590750", Offset = "0x58EF50", Length = "0x1C1")]
	public void AdaptDialogBox(string txt)
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3B50", Offset = "0x2F50")]
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x5906E0", Offset = "0x58EEE0", Length = "0x65")]
	private IEnumerator AdaptDialogBoxCoroutine()
	{
		return null;
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3DA0", Offset = "0x31A0")]
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x590920", Offset = "0x58F120", Length = "0x65")]
	private IEnumerator AdaptFontSize()
	{
		return null;
	}

	[Token(Token = "0x6000605")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3FB0", Offset = "0x33B0")]
	[Address(RVA = "0x590990", Offset = "0x58F190", Length = "0x65")]
	private IEnumerator ClearUpPunctuation()
	{
		return null;
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x590A00", Offset = "0x58F200", Length = "0x77")]
	public AdaptiveDialogBox()
	{
	}
}
