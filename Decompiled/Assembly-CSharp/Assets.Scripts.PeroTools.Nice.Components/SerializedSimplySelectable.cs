using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Components;

[Token(Token = "0x2000608")]
public class SerializedSimplySelectable : SerializedUIBehaviour
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002229")]
	public bool interactable;

	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x400222A")]
	private bool m_GroupsAllowInteraction;

	[Token(Token = "0x400222B")]
	[FieldOffset(Offset = "0x60")]
	private readonly List<CanvasGroup> m_CanvasGroupCache;

	[Token(Token = "0x6003B12")]
	[Address(RVA = "0x9839B0", Offset = "0x9821B0", Length = "0x168")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x6003B13")]
	[Address(RVA = "0x9839A0", Offset = "0x9821A0", Length = "0xE")]
	public virtual bool IsInteractable()
	{
		return default(bool);
	}

	[Address(RVA = "0x983B20", Offset = "0x982320", Length = "0x6F")]
	[Token(Token = "0x6003B14")]
	public SerializedSimplySelectable()
	{
	}
}
