using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UI;

[Token(Token = "0x200082A")]
public class SetSelectedUIElement : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002A8C")]
	public GameObject firstSelected;

	[Token(Token = "0x4002A8D")]
	[FieldOffset(Offset = "0x20")]
	public float delay;

	[Token(Token = "0x4002A8E")]
	[FieldOffset(Offset = "0x28")]
	public Button btnClose;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002A8F")]
	private EventSystem m_EventSystem;

	[Token(Token = "0x6004B39")]
	[Address(RVA = "0x61B720", Offset = "0x619F20", Length = "0xF3")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004B3A")]
	[Address(RVA = "0x61BA10", Offset = "0x61A210", Length = "0x84")]
	private void OnUIClose()
	{
	}

	[Token(Token = "0x6004B3B")]
	[Address(RVA = "0x61B900", Offset = "0x61A100", Length = "0x100")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004B3C")]
	[Address(RVA = "0x61B820", Offset = "0x61A020", Length = "0xD2")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004B3D")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public SetSelectedUIElement()
	{
	}
}
