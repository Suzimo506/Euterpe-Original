using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008E2")]
public class ApplyShow
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002F34")]
	public string animApply;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002F35")]
	public string animNoApply;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002F36")]
	public GameObject applyShowObject;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002F37")]
	public Animator m_Anim;

	[Token(Token = "0x4002F38")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_OutPlayCoroutine;

	[Address(RVA = "0x6C06D0", Offset = "0x6BEED0", Length = "0x116")]
	[Token(Token = "0x6005095")]
	private bool IsAnimiatorFinish()
	{
		return default(bool);
	}

	[Address(RVA = "0x6C07F0", Offset = "0x6BEFF0", Length = "0x242")]
	[Token(Token = "0x6005096")]
	public void PlayApply(bool apply)
	{
	}

	[Address(RVA = "0x6C0A40", Offset = "0x6BF240", Length = "0x94")]
	[Token(Token = "0x6005097")]
	private void PlayFadeIn()
	{
	}

	[Address(RVA = "0x6C0AE0", Offset = "0x6BF2E0", Length = "0x94")]
	[Token(Token = "0x6005098")]
	private void PlayFadeOut()
	{
	}

	[Token(Token = "0x6005099")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ApplyShow()
	{
	}
}
