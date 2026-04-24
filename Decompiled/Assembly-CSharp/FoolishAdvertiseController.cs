using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200017B")]
public class FoolishAdvertiseController : MonoBehaviour
{
	[Token(Token = "0x4000963")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	protected float m_ShowTime;

	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Button m_BtnJump;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000965")]
	[SerializeField]
	protected Button m_BtnClose;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000966")]
	[SerializeField]
	protected Animator m_Animator;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000967")]
	[SerializeField]
	protected MeshRenderer m_MeshRenderer;

	[Address(RVA = "0x44ECA0", Offset = "0x44D4A0", Length = "0xDA")]
	[Token(Token = "0x6000AE3")]
	private void Awake()
	{
	}

	[Address(RVA = "0x44ED80", Offset = "0x44D580", Length = "0x11F")]
	[Token(Token = "0x6000AE4")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x44ED80", Offset = "0x44D580", Length = "0x11F")]
	[Token(Token = "0x6000AE5")]
	protected void ShowAnimByLanguage()
	{
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x44EEA0", Offset = "0x44D6A0", Length = "0x1E")]
	public void SetShowMeshRenderActive(bool value)
	{
	}

	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0x44DE50", Offset = "0x44C650", Length = "0x26")]
	protected virtual void Close()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000AE8")]
	protected virtual void OnBtnJumpClicked()
	{
	}

	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public FoolishAdvertiseController()
	{
	}
}
