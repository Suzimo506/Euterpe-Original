using System.Collections;
using Cpp2ILInjected;
using Rewired.UI.ControlMapper;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos;

[Token(Token = "0x2000225")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class ControlMapperDemoMessage : MonoBehaviour
{
	[Token(Token = "0x4000F91")]
	[FieldOffset(Offset = "0x18")]
	public ControlMapper controlMapper;

	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x20")]
	public Selectable defaultSelectable;

	[Address(RVA = "0x557790", Offset = "0x555F90", Length = "0xEF")]
	[Token(Token = "0x6001471")]
	private void Awake()
	{
	}

	[Address(RVA = "0x557A90", Offset = "0x556290", Length = "0x7")]
	[Token(Token = "0x6001472")]
	private void Start()
	{
	}

	[Address(RVA = "0x557880", Offset = "0x556080", Length = "0x8E")]
	[Token(Token = "0x6001473")]
	private void OnControlMapperClosed()
	{
	}

	[Address(RVA = "0x44DE50", Offset = "0x44C650", Length = "0x26")]
	[Token(Token = "0x6001474")]
	private void OnControlMapperOpened()
	{
	}

	[Address(RVA = "0x557980", Offset = "0x556180", Length = "0x10D")]
	[Token(Token = "0x6001475")]
	private void SelectDefault()
	{
	}

	[Address(RVA = "0x557910", Offset = "0x556110", Length = "0x65")]
	[Token(Token = "0x6001476")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x14C30", Offset = "0x14030")]
	private IEnumerator SelectDefaultDeferred()
	{
		return null;
	}

	[Token(Token = "0x6001477")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ControlMapperDemoMessage()
	{
	}
}
