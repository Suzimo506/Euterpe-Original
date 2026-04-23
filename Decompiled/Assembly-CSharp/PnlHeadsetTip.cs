using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200011A")]
public class PnlHeadsetTip : MonoBehaviour
{
	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_TxtSuggest;

	[SerializeField]
	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_TxtInformation;

	[SerializeField]
	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_TxtInformation_WeGame;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006D9")]
	[SerializeField]
	private GameObject m_TxtInformation_Switch_CN;

	[Address(RVA = "0x79FCE0", Offset = "0x79E4E0", Length = "0x5F")]
	[Token(Token = "0x600082A")]
	private void Awake()
	{
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0x79FCE0", Offset = "0x79E4E0", Length = "0x5F")]
	private void DisableAll()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600082C")]
	public PnlHeadsetTip()
	{
	}
}
