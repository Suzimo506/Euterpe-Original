using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common;

[Token(Token = "0x200097E")]
public class InovkeItemByResolution : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003402")]
	public bool invokeOn4x3;

	[Token(Token = "0x4003403")]
	[FieldOffset(Offset = "0x19")]
	public bool invokeOnOther;

	[Token(Token = "0x6005674")]
	[Address(RVA = "0x701B00", Offset = "0x700300", Length = "0x93")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005675")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public InovkeItemByResolution()
	{
	}
}
