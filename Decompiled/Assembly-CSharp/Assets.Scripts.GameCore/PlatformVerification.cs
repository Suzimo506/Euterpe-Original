using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore;

[Token(Token = "0x20006F9")]
public class PlatformVerification : MonoBehaviour
{
	[Address(RVA = "0x7CEA80", Offset = "0x7CD280", Length = "0x25D")]
	[Token(Token = "0x60041B5")]
	private void Start()
	{
	}

	[Token(Token = "0x60041B6")]
	[Address(RVA = "0x7CE9B0", Offset = "0x7CD1B0", Length = "0xCE")]
	private void ShowGenuineCheckFail()
	{
	}

	[Token(Token = "0x60041B7")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PlatformVerification()
	{
	}
}
