using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000AD")]
public class FailBarrage : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000492")]
	public Text[] barrages;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000493")]
	public SchemeEntry languageEntry;

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x44A1A0", Offset = "0x4489A0", Length = "0x4E3")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x44A690", Offset = "0x448E90", Length = "0x167")]
	private void Test()
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public FailBarrage()
	{
	}
}
