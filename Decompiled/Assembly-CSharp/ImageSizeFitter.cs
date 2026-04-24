using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name = "RequireComponent", RVA = "0x171A0", Offset = "0x165A0")]
[Token(Token = "0x200010A")]
public class ImageSizeFitter : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400068E")]
	public Text targetText;

	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x20")]
	private Image m_BackgroundImage;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000690")]
	private RectTransform m_ImageRectTransform;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000691")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x17220", Offset = "0x16620")]
	public float offsetUpAndDown;

	[Attribute(Name = "TooltipAttribute", RVA = "0x17300", Offset = "0x16700")]
	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x34")]
	public float offsetWidth;

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x5C6C70", Offset = "0x5C5470", Length = "0x14B")]
	private void OnEnable()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x17360", Offset = "0x16760")]
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x5C6DC0", Offset = "0x5C55C0", Length = "0x65")]
	private IEnumerator WaitFormOneframeAneChangeSize()
	{
		return null;
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x5C6B60", Offset = "0x5C5360", Length = "0x10F")]
	public void ChangeSize()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60007C7")]
	public ImageSizeFitter()
	{
	}
}
