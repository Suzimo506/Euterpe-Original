using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000099")]
public class IndependentScale : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000443")]
	private bool m_LowResolutionAdaptation;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x20")]
	private CanvasScaler m_CanvasScaler;

	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform m_RectTransform;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000446")]
	private Vector2 m_OriginalSizeDelta;

	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_OriginalAnchorPosition;

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x5C7800", Offset = "0x5C6000", Length = "0x25E")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5C7A60", Offset = "0x5C6260", Length = "0x7")]
	[Token(Token = "0x60004D3")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x5C75D0", Offset = "0x5C5DD0", Length = "0x228")]
	[Token(Token = "0x60004D4")]
	private void ApplyFixedScalingAndPosition()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60004D5")]
	public IndependentScale()
	{
	}
}
