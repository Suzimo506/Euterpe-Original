using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A7")]
public class GameMainPnlTutorial : MonoBehaviour
{
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x18")]
	public GameObject pcTutorial;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A52")]
	public GameObject mobileTutorial;

	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x28")]
	public GameObject nsTutorial;

	[Address(RVA = "0x5BDCE0", Offset = "0x5BC4E0", Length = "0x191")]
	[Token(Token = "0x6000BEF")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public GameMainPnlTutorial()
	{
	}
}
