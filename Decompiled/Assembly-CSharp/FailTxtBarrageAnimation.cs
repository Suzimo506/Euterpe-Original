using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000AE")]
public class FailTxtBarrageAnimation : MonoBehaviour
{
	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform m_RectTransform;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000495")]
	[SerializeField]
	private Vector3 m_StartPos;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000496")]
	[SerializeField]
	private float m_TargetPosX;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000497")]
	[SerializeField]
	private float m_StartDelay;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000498")]
	[SerializeField]
	private float m_Duration;

	[Address(RVA = "0x44A970", Offset = "0x449170", Length = "0xA4")]
	[Token(Token = "0x600052E")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x44AA20", Offset = "0x449220", Length = "0xB2")]
	public void Test()
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x44A880", Offset = "0x449080", Length = "0xDA")]
	private void LoopAnimation()
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x44A960", Offset = "0x449160", Length = "0xE")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000532")]
	public FailTxtBarrageAnimation()
	{
	}
}
