using ArcadeController.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI;

[Token(Token = "0x200053B")]
public abstract class PageAbstractHandler : MonoBehaviour, IArcadeKeyHandler
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001F68")]
	protected bool m_IsDisableCancel;

	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4001F69")]
	[SerializeField]
	protected bool m_IsUniversal;

	[SerializeField]
	[Token(Token = "0x4001F6A")]
	[FieldOffset(Offset = "0x1A")]
	protected bool m_IsBtnCancelBack;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001F6B")]
	[SerializeField]
	protected Button m_BtnCancel;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001F6C")]
	[SerializeField]
	protected bool m_IsBtnEnterBack;

	[SerializeField]
	[Token(Token = "0x4001F6D")]
	[FieldOffset(Offset = "0x30")]
	protected Button m_BtnEnter;

	[SerializeField]
	[Token(Token = "0x4001F6E")]
	[FieldOffset(Offset = "0x38")]
	protected Button m_BtnOption;

	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001F6F")]
	private bool m_IsAddJumpKey;

	[Token(Token = "0x4001F70")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool m_IsUseKeyName;

	[SerializeField]
	[Token(Token = "0x4001F71")]
	[FieldOffset(Offset = "0x48")]
	private string m_AddKeyName;

	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001F72")]
	private PageCancelType m_PageCancelType;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001F73")]
	[SerializeField]
	private string m_JumpKeyName;

	[Token(Token = "0x6003761")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	protected PageAbstractHandler()
	{
	}
}
