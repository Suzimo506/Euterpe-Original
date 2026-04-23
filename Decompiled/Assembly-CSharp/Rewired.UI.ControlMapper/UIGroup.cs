using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x200020C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class UIGroup : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000EE6")]
	[FieldOffset(Offset = "0x18")]
	private Text _label;

	[SerializeField]
	[Token(Token = "0x4000EE7")]
	[FieldOffset(Offset = "0x20")]
	private Transform _content;

	[Token(Token = "0x170003FB")]
	public string labelText
	{
		[Token(Token = "0x600135A")]
		[Address(RVA = "0xDCD100", Offset = "0xDCB900", Length = "0xA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600135B")]
		[Address(RVA = "0xDCD1B0", Offset = "0xDCB9B0", Length = "0x94")]
		set
		{
		}
	}

	[Token(Token = "0x170003FC")]
	public Transform content
	{
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0xDCD060", Offset = "0xDCB860", Length = "0x9C")]
	[Token(Token = "0x600135D")]
	public void SetLabelActive(bool state)
	{
	}

	[Token(Token = "0x600135E")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public UIGroup()
	{
	}
}
