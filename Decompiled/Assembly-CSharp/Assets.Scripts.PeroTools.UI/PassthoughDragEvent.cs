using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005B6")]
public class PassthoughDragEvent : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Attribute(Name = "TooltipAttribute", RVA = "0x94730", Offset = "0x93B30")]
	[Token(Token = "0x400215A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject passTarget;

	[Token(Token = "0x400215B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x94840", Offset = "0x93C40")]
	[FieldOffset(Offset = "0x20")]
	public bool includeChildrens;

	[Address(RVA = "0x981660", Offset = "0x97FE60", Length = "0x199")]
	[Token(Token = "0x600395A")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600395B")]
	[Address(RVA = "0x9814C0", Offset = "0x97FCC0", Length = "0x199")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600395C")]
	[Address(RVA = "0x981800", Offset = "0x980000", Length = "0x199")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600395D")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PassthoughDragEvent()
	{
	}
}
