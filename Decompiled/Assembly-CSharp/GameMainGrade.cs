using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000AF")]
public class GameMainGrade : MonoBehaviour
{
	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] gradeObjects;

	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsCustom;

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x5BD140", Offset = "0x5BB940", Length = "0x10A")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x5BD080", Offset = "0x5BB880", Length = "0xB6")]
	[Token(Token = "0x6000534")]
	public void CustomGrade(int evaluate)
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x45D400", Offset = "0x45BC00", Length = "0x5")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public GameMainGrade()
	{
	}
}
