using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000185")]
public class LoadingImg : MonoBehaviour
{
	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0x18")]
	public GameObject simpleIllus;

	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x20")]
	public GameObject specialIllus;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000986")]
	public GameObject specialIllusfor43;

	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x30")]
	public GameObject verySpecialIllus;

	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0x38")]
	public GameObject squareIllus;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000989")]
	public CanvasGroup maskUp;

	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x48")]
	public CanvasGroup maskDown;

	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x8B9E60", Offset = "0x8B8660", Length = "0x7E9")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public LoadingImg()
	{
	}
}
