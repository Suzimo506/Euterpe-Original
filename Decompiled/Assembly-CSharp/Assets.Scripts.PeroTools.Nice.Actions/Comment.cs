using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000612")]
public class Comment : Action
{
	[SerializeField]
	[Multiline]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002241")]
	private string m_Comment;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B46")]
	public Comment()
	{
	}
}
