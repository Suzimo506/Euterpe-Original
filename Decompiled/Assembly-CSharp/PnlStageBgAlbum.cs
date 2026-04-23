using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000190")]
public class PnlStageBgAlbum : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009D5")]
	public Animator animator;

	[Token(Token = "0x40009D6")]
	private const string anim_in = "BgAlbumIn";

	[Token(Token = "0x40009D7")]
	private const string anima_out = "BgAlbumOut";

	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x563580", Offset = "0x561D80", Length = "0x5F")]
	private void PlayAnimator(bool isIn)
	{
	}

	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x5635E0", Offset = "0x561DE0", Length = "0x8B")]
	public void SetBgEnable(bool enable)
	{
	}

	[Address(RVA = "0x44DE50", Offset = "0x44C650", Length = "0x26")]
	[Token(Token = "0x6000B56")]
	public void OnBgOutFinish()
	{
	}

	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlStageBgAlbum()
	{
	}
}
