using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A8")]
public class TutorialEvaluate : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A54")]
	[SerializeField]
	private GameObject m_EvaluateA;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A55")]
	[SerializeField]
	private GameObject m_EvaluateB;

	[SerializeField]
	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_EvaluateC;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A57")]
	[SerializeField]
	private Animator m_UITutorialAnimator;

	[Address(RVA = "0x520660", Offset = "0x51EE60", Length = "0x1A8")]
	[Token(Token = "0x6000BF1")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000BF2")]
	public TutorialEvaluate()
	{
	}
}
