using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B3")]
public class DefaultTalkBubble : BaseTalkBubble
{
	[Token(Token = "0x4002D6E")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private Animator m_Animator;

	[Token(Token = "0x4002D6F")]
	[FieldOffset(Offset = "0x68")]
	private float m_EndTime;

	[Token(Token = "0x6004EB2")]
	[Address(RVA = "0x5AC8A0", Offset = "0x5AB0A0", Length = "0x42")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004EB3")]
	[Address(RVA = "0x5AC8F0", Offset = "0x5AB0F0", Length = "0x53")]
	public override void EndTalk()
	{
	}

	[Address(RVA = "0x5AC950", Offset = "0x5AB150", Length = "0x8F")]
	[Token(Token = "0x6004EB4")]
	public override void SetTalkTxt(string txt)
	{
	}

	[Token(Token = "0x6004EB5")]
	[Address(RVA = "0x462D10", Offset = "0x461510", Length = "0x6")]
	public override float GetEndTime()
	{
		return default(float);
	}

	[Token(Token = "0x6004EB6")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public DefaultTalkBubble()
	{
	}
}
