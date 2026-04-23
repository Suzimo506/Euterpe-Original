using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x2000885")]
public class PnlOffsetAskTips : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002C74")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_PnlOffsetOption;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002C75")]
	[SerializeField]
	private Button m_BtnYes;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4002C76")]
	private Button m_BtnNo;

	[Address(RVA = "0x5FD590", Offset = "0x5FBD90", Length = "0xD5")]
	[Token(Token = "0x6004D9A")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x5FD730", Offset = "0x5FBF30", Length = "0x9D")]
	[Token(Token = "0x6004D9B")]
	private void OnYesClicked()
	{
	}

	[Address(RVA = "0x5FD670", Offset = "0x5FBE70", Length = "0xBB")]
	[Token(Token = "0x6004D9C")]
	private void OnNoClicked()
	{
	}

	[Address(RVA = "0x5FD4B0", Offset = "0x5FBCB0", Length = "0xD5")]
	[Token(Token = "0x6004D9D")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x5FD7D0", Offset = "0x5FBFD0", Length = "0x68")]
	[Token(Token = "0x6004D9E")]
	private void SendTAData(string result)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004D9F")]
	public PnlOffsetAskTips()
	{
	}
}
