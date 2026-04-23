using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000989")]
public class PosAutoAdapter : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003434")]
	private RectTransform m_RectTransform;

	[Token(Token = "0x4003435")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private Vector2 m_FourThreePos;

	[SerializeField]
	[Token(Token = "0x4003436")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 m_SixteenNinePos;

	[Token(Token = "0x4003437")]
	[FieldOffset(Offset = "0x30")]
	private float m_PerPosX;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4003438")]
	private float m_PerPosY;

	[Address(RVA = "0x702610", Offset = "0x700E10", Length = "0x2F")]
	[Token(Token = "0x60056CE")]
	private void Awake()
	{
	}

	[Token(Token = "0x60056CF")]
	[Address(RVA = "0x702680", Offset = "0x700E80", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60056D0")]
	[Address(RVA = "0x702610", Offset = "0x700E10", Length = "0x2F")]
	private void GetPerPos()
	{
	}

	[Token(Token = "0x60056D1")]
	[Address(RVA = "0x702540", Offset = "0x700D40", Length = "0xC7")]
	private void Adapt()
	{
	}

	[Token(Token = "0x60056D2")]
	[Address(RVA = "0x702640", Offset = "0x700E40", Length = "0x35")]
	private void ForceAdapt()
	{
	}

	[Token(Token = "0x60056D3")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PosAutoAdapter()
	{
	}
}
