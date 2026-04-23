using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200011B")]
public class AutoDownloadMsgController : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x18")]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006DB")]
	[SerializeField]
	private GameObject m_AutoDownloadMsgObj;

	[SerializeField]
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_AutoDownloadingObj;

	[Token(Token = "0x40006DD")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_AutoDownloadCompleteObj;

	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40006DE")]
	private GameObject m_AutoDownloadFailObj;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006DF")]
	private GameObject m_CurrentObj;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600082D")]
	public AutoDownloadMsgController()
	{
	}
}
