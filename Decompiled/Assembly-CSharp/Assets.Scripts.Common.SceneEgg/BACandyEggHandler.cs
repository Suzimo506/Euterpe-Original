using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common.SceneEgg;

[Token(Token = "0x200098B")]
public class BACandyEggHandler : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400343D")]
	private Transform m_RootTransform;

	[Token(Token = "0x400343E")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private float m_HidePositionX;

	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400343F")]
	private float m_ShowPositionX;

	[Token(Token = "0x4003440")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private int m_LimitShowCount;

	[Token(Token = "0x4003441")]
	[FieldOffset(Offset = "0x30")]
	private SpriteRenderer m_SpriteRenderer;

	[Token(Token = "0x4003442")]
	[FieldOffset(Offset = "0x38")]
	private int m_ShowCount;

	[Token(Token = "0x4003443")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_CanShowCheck;

	[Address(RVA = "0x6EF400", Offset = "0x6EDC00", Length = "0x60")]
	[Token(Token = "0x60056D6")]
	private void Start()
	{
	}

	[Address(RVA = "0x6EF470", Offset = "0x6EDC70", Length = "0x1BE")]
	[Token(Token = "0x60056D7")]
	private void Update()
	{
	}

	[Token(Token = "0x60056D8")]
	[Address(RVA = "0x6EF630", Offset = "0x6EDE30", Length = "0xE")]
	public BACandyEggHandler()
	{
	}
}
