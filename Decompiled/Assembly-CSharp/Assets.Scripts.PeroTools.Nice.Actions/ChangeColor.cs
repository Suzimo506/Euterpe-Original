using System.Reflection;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000610")]
public class ChangeColor : Action
{
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002236")]
	private string m_Path;

	[Token(Token = "0x4002237")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Color m_Color;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002238")]
	[SerializeField]
	private float m_Duration;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002239")]
	[SerializeField]
	private Ease m_Ease;

	[Token(Token = "0x400223A")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private object m_SourceObject;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400223B")]
	[HideInInspector]
	private Renderer m_Renderer;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400223C")]
	private Material m_Material;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400223D")]
	private MemberInfo m_SetMemberInfo;

	[Token(Token = "0x400223E")]
	[FieldOffset(Offset = "0x50")]
	private MemberInfo m_GetMemberInfo;

	[Token(Token = "0x400223F")]
	[FieldOffset(Offset = "0x58")]
	private Tween m_Tween;

	[Token(Token = "0x17000581")]
	public override float duration
	{
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x73BB00", Offset = "0x73A300", Length = "0x6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003B3C")]
	[Address(RVA = "0x73B300", Offset = "0x739B00", Length = "0x1F6")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003B3D")]
	[Address(RVA = "0x73B500", Offset = "0x739D00", Length = "0x3F3")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x73B900", Offset = "0x73A100", Length = "0x39")]
	[Token(Token = "0x6003B3E")]
	public override void Pause()
	{
	}

	[Token(Token = "0x6003B3F")]
	[Address(RVA = "0x73B940", Offset = "0x73A140", Length = "0x4E")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6003B40")]
	[Address(RVA = "0x73BAE0", Offset = "0x73A2E0", Length = "0x15")]
	public ChangeColor()
	{
	}
}
