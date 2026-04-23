using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000140")]
public class PnlRewardMap : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007CF")]
	public Button enterBtn;

	[Token(Token = "0x6000906")]
	[Address(RVA = "0x561AA0", Offset = "0x5602A0", Length = "0x5E")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000907")]
	[Address(RVA = "0x561B00", Offset = "0x560300", Length = "0x106")]
	private void Start()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000908")]
	public PnlRewardMap()
	{
	}
}
