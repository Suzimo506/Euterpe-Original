using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000198")]
public class DragLineVisual
{
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x43C80", Offset = "0x43080")]
	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x10")]
	public LineRenderer lineRenderer;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A17")]
	public Color drawingColor;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A18")]
	public Color successColor;

	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0x38")]
	public Color failColor;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A1A")]
	private bool m_VisualIsActive;

	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0x445980", Offset = "0x444180", Length = "0x92")]
	public void SetVisualActive(bool isActive)
	{
	}

	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0x445A20", Offset = "0x444220", Length = "0x64")]
	public void StartLineVisuals(Vector3 pointPos)
	{
	}

	[Address(RVA = "0x445A90", Offset = "0x444290", Length = "0xDD")]
	[Token(Token = "0x6000B9F")]
	public void UpdateLineDrawing(List<Vector3> drawnPoints)
	{
	}

	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x445B70", Offset = "0x444370", Length = "0xCD")]
	public void UpdateLineVisuals(DrawState status)
	{
	}

	[Address(RVA = "0x445C40", Offset = "0x444440", Length = "0x86")]
	[Token(Token = "0x6000BA1")]
	public void UpdateResultColor(bool isSuccess)
	{
	}

	[Address(RVA = "0x445CD0", Offset = "0x4444D0", Length = "0x51")]
	[Token(Token = "0x6000BA2")]
	public DragLineVisual()
	{
	}
}
