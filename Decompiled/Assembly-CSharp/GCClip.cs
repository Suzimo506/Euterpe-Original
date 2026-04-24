using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002E")]
public class GCClip : MonoBehaviour
{
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x18")]
	public int idx;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000DD")]
	private float m_ClipValue;

	[Token(Token = "0x40000DE")]
	private const float interval = 6.7f;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x28")]
	private float m_SizePower;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x2C")]
	private float m_MinSize;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x30")]
	private DBOther m_DbOther;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000E3")]
	public float updateInterval;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x3C")]
	private int m_PassFrame;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x40")]
	private float m_PassTime;

	[Address(RVA = "0x8403E0", Offset = "0x83EBE0", Length = "0x3C")]
	[Token(Token = "0x600010B")]
	private void Reset()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x840420", Offset = "0x83EC20", Length = "0xE1")]
	private void Start()
	{
	}

	[Address(RVA = "0x8405E0", Offset = "0x83EDE0", Length = "0x150")]
	[Token(Token = "0x600010D")]
	private void Update()
	{
	}

	[Address(RVA = "0x840510", Offset = "0x83ED10", Length = "0xC9")]
	[Token(Token = "0x600010E")]
	private void UpAudioVisualization()
	{
	}

	[Address(RVA = "0x8401A0", Offset = "0x83E9A0", Length = "0x230")]
	[Token(Token = "0x600010F")]
	private void OnAudioVisualization()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x840740", Offset = "0x83EF40", Length = "0x1C")]
	public GCClip()
	{
	}
}
