using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F5")]
public class PnlAccountDeleteInfo : BaseMessageBox
{
	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0xF0")]
	public Text txtDeleteAccountInfoYes;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000615")]
	public Button btnDeleteAccountInfoYes;

	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x100")]
	public Text txtDeleteAccountInfoBindNumber;

	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x108")]
	public GameObject imgBg;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000618")]
	private int m_TotalTime;

	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x118")]
	private string m_DeleteAccount;

	[Address(RVA = "0x4F9B50", Offset = "0x4F8350", Length = "0x12E")]
	[Token(Token = "0x6000731")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x4F9E10", Offset = "0x4F8610", Length = "0x123")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x4F9C80", Offset = "0x4F8480", Length = "0x18C")]
	[Token(Token = "0x6000733")]
	private void OnDeleteAccountData()
	{
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x4F9F40", Offset = "0x4F8740", Length = "0x12C")]
	private void ResetAll()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11850", Offset = "0x10C50")]
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x4FA070", Offset = "0x4F8870", Length = "0x65")]
	private IEnumerator Time()
	{
		return null;
	}

	[Address(RVA = "0x4FA4D0", Offset = "0x4F8CD0", Length = "0x11")]
	[Token(Token = "0x6000736")]
	public PnlAccountDeleteInfo()
	{
	}
}
