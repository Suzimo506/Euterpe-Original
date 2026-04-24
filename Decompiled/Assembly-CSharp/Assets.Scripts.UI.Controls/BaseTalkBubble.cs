using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B1")]
public abstract class BaseTalkBubble : SerializedMonoBehaviour
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002D69")]
	[SerializeField]
	protected AdaptiveDialogBox m_AdaptiveDialogBox;

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6004EA7")]
	public abstract void SetTalkTxt(string txt);

	[Token(Token = "0x6004EA8")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void EndTalk();

	[Token(Token = "0x6004EA9")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract float GetEndTime();

	[Token(Token = "0x6004EAA")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	protected BaseTalkBubble()
	{
	}
}
