using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006EF")]
public class DynamicColor : SerializedMonoBehaviour
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002539")]
	[Attribute(Name = "VariableAttribute", RVA = "0x719E0", Offset = "0x70DE0")]
	public IVariable source;

	[Space]
	[Attribute(Name = "TooltipAttribute", RVA = "0x71CB0", Offset = "0x710B0")]
	[Token(Token = "0x400253A")]
	[FieldOffset(Offset = "0x60")]
	public float timeLength;

	[Token(Token = "0x400253B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x71F00", Offset = "0x71300")]
	[FieldOffset(Offset = "0x68")]
	public Gradient gradient;

	[Token(Token = "0x400253C")]
	[FieldOffset(Offset = "0x70")]
	private float m_PassTime;

	[Address(RVA = "0xC6F060", Offset = "0xC6D860", Length = "0x132")]
	[Token(Token = "0x6004171")]
	private void Update()
	{
	}

	[Token(Token = "0x6004172")]
	[Address(RVA = "0xC6F1A0", Offset = "0xC6D9A0", Length = "0xE")]
	public DynamicColor()
	{
	}
}
