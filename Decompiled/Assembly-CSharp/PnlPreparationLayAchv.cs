using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200012E")]
public class PnlPreparationLayAchv : MonoBehaviour
{
	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] achvGamobjects;

	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x20")]
	public Text[] achvTexts;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000767")]
	public Image[] achvTrophys;

	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x30")]
	public Animator[] achvAnimators;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000769")]
	public Sprite imgTrophy;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400076A")]
	public Sprite imgTrophyGray;

	[Address(RVA = "0x55FDA0", Offset = "0x55E5A0", Length = "0x567")]
	[Token(Token = "0x6000888")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000889")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlPreparationLayAchv()
	{
	}
}
