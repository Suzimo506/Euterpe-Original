using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008AE")]
public class RankCell : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002D5F")]
	public Text txtNumber;

	[Token(Token = "0x4002D60")]
	[FieldOffset(Offset = "0x20")]
	public Text txtPlayerName;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002D61")]
	public Text txtScore;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002D62")]
	public Text txtAcc;

	[Token(Token = "0x6004E98")]
	[Address(RVA = "0x5B2DD0", Offset = "0x5B15D0", Length = "0x106")]
	public void SetValue(int number, string nickName, int score, float acc)
	{
	}

	[Token(Token = "0x6004E99")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public RankCell()
	{
	}
}
