using Cpp2ILInjected;
using UnityEngine;

namespace Account;

[Token(Token = "0x2000560")]
public class ActiveWith : MonoBehaviour
{
	[Token(Token = "0x4001FBD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Address(RVA = "0x441700", Offset = "0x43FF00", Length = "0x20")]
	[Token(Token = "0x60037CC")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x7741F0", Offset = "0x7729F0", Length = "0x20")]
	[Token(Token = "0x60037CD")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60037CE")]
	public ActiveWith()
	{
	}
}
