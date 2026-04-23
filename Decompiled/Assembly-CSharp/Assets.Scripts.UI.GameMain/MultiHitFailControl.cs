using Cpp2ILInjected;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x2000897")]
public class MultiHitFailControl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002CB0")]
	[SerializeField]
	private SpriteRenderer m_MultiHitSr;

	[Token(Token = "0x4002CB1")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private TextMeshPro m_Tmp;

	[Token(Token = "0x4002CB2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_FailOrder;

	[Address(RVA = "0x5B12E0", Offset = "0x5AFAE0", Length = "0x9D")]
	[Token(Token = "0x6004DE1")]
	private void Start()
	{
	}

	[Token(Token = "0x6004DE2")]
	[Address(RVA = "0x5B1240", Offset = "0x5AFA40", Length = "0x93")]
	private void OnFail()
	{
	}

	[Token(Token = "0x6004DE3")]
	[Address(RVA = "0x5B11A0", Offset = "0x5AF9A0", Length = "0x9D")]
	private void OnDestory()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004DE4")]
	public MultiHitFailControl()
	{
	}
}
