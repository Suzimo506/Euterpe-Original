using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.UI;

[Attribute(Name = "RequireComponent", RVA = "0x93F10", Offset = "0x93310")]
[Token(Token = "0x20005AE")]
public class ContentSizeFitter : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002111")]
	public int minSize;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4002112")]
	public int childSize;

	[Token(Token = "0x4002113")]
	[FieldOffset(Offset = "0x20")]
	public int gap;

	[Token(Token = "0x4002114")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform m_RectTransform;

	[Token(Token = "0x4002115")]
	[FieldOffset(Offset = "0x30")]
	private UnityEngine.UI.ContentSizeFitter m_ContentSizeFitter;

	[Address(RVA = "0x975BE0", Offset = "0x9743E0", Length = "0x1BA")]
	[Token(Token = "0x600392A")]
	private void Awake()
	{
	}

	[Token(Token = "0x600392B")]
	[Address(RVA = "0x975FF0", Offset = "0x9747F0", Length = "0x39")]
	private void Update()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600392C")]
	public ContentSizeFitter()
	{
	}
}
