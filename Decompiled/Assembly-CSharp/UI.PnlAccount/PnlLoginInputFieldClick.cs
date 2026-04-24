using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.PnlAccount;

[Token(Token = "0x20001BA")]
public class PnlLoginInputFieldClick : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ABC")]
	protected InputField m_InputField;

	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x20")]
	private bool m_LastFocuse;

	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onFocus;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000ABF")]
	public UnityEvent onNoFocus;

	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void OnStart()
	{
	}

	[Address(RVA = "0x4DB6E0", Offset = "0x4D9EE0", Length = "0x5B")]
	[Token(Token = "0x6000C51")]
	private void Start()
	{
	}

	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x4DB740", Offset = "0x4D9F40", Length = "0x49")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlLoginInputFieldClick()
	{
	}
}
