using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.Menu;

[Token(Token = "0x200090F")]
public class PnlMenuAccount : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40030A3")]
	[SerializeField]
	private GameObject m_LoginImg;

	[Token(Token = "0x40030A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button m_Button;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40030A5")]
	[SerializeField]
	private Text m_TxtVersion;

	[Address(RVA = "0x6CD410", Offset = "0x6CBC10", Length = "0x149")]
	[Token(Token = "0x600523A")]
	private void Awake()
	{
	}

	[Address(RVA = "0x6CD6C0", Offset = "0x6CBEC0", Length = "0xFA")]
	[Token(Token = "0x600523B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600523C")]
	[Address(RVA = "0x6CD7C0", Offset = "0x6CBFC0", Length = "0xAC")]
	private void OnLoginChanged()
	{
	}

	[Token(Token = "0x600523D")]
	[Address(RVA = "0x6CD7C0", Offset = "0x6CBFC0", Length = "0xAC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600523E")]
	[Address(RVA = "0x6CD560", Offset = "0x6CBD60", Length = "0x157")]
	private void OnAccountClicked()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600523F")]
	public PnlMenuAccount()
	{
	}
}
