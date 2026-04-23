using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200012F")]
public class PnlPrivacyPolicy : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400076B")]
	public Button btnOnPrivacyPolicy;

	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x20")]
	public Button btnOnPermission;

	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine m_PermissionCoroutine;

	[Address(RVA = "0x560450", Offset = "0x55EC50", Length = "0x86")]
	[Token(Token = "0x600088A")]
	private void Start()
	{
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void OnPrivacyPolicy()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600088C")]
	private void OnPermission()
	{
	}

	[Address(RVA = "0x560310", Offset = "0x55EB10", Length = "0x13C")]
	[Token(Token = "0x600088D")]
	private int GetSDKInt()
	{
		return default(int);
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600088E")]
	public PnlPrivacyPolicy()
	{
	}
}
