using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D8")]
public class PnlMessage : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002E3F")]
	public GameObject task;

	[Token(Token = "0x4002E40")]
	[FieldOffset(Offset = "0x20")]
	public GameObject achievement;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002E41")]
	public GameObject stageAchievement;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002E42")]
	public GameObject unlockLevel;

	[Token(Token = "0x4002E43")]
	[FieldOffset(Offset = "0x38")]
	public GameObject unlockRole;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002E44")]
	public GameObject unlockElfin;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002E45")]
	public GameObject unlockLoading;

	[Token(Token = "0x4002E46")]
	[FieldOffset(Offset = "0x50")]
	public GameObject unlockWelcome;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002E47")]
	public GameObject rank;

	[Token(Token = "0x4002E48")]
	[FieldOffset(Offset = "0x60")]
	public GameObject unlockHead;

	[Token(Token = "0x4002E49")]
	[FieldOffset(Offset = "0x68")]
	public Transform layout;

	[Token(Token = "0x4002E4A")]
	[FieldOffset(Offset = "0x70")]
	public Button btnDone;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002E4B")]
	public float gap;

	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4002E4C")]
	public float closeGap;

	[Token(Token = "0x6004FBF")]
	[Address(RVA = "0x67B240", Offset = "0x679A40", Length = "0x3FB")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004FC0")]
	[Address(RVA = "0x67B0D0", Offset = "0x6798D0", Length = "0x162")]
	public void FinishMessage()
	{
	}

	[Token(Token = "0x6004FC1")]
	[Address(RVA = "0x67B640", Offset = "0x679E40", Length = "0x15")]
	public PnlMessage()
	{
	}
}
