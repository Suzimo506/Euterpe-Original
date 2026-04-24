using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200096C")]
public class PnlRoleTalkBubble : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40033B8")]
	[SerializeField]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40033B9")]
	private int m_ShowHash;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40033BA")]
	private int m_CloseHash;

	[Token(Token = "0x40033BB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text m_Talk;

	[Token(Token = "0x40033BC")]
	[FieldOffset(Offset = "0x30")]
	private float m_EndTime;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40033BD")]
	private bool m_Init;

	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x40033BE")]
	private bool m_IsClose;

	[Token(Token = "0x17000901")]
	public float endAnimTime
	{
		[Address(RVA = "0x643E30", Offset = "0x642630", Length = "0x79")]
		[Token(Token = "0x6005604")]
		get
		{
			return default(float);
		}
	}

	[Address(RVA = "0x643C60", Offset = "0x642460", Length = "0x6E")]
	[Token(Token = "0x6005605")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005606")]
	[Address(RVA = "0x643D50", Offset = "0x642550", Length = "0xDB")]
	public void ShowTalk(string txt)
	{
	}

	[Token(Token = "0x6005607")]
	[Address(RVA = "0x643D20", Offset = "0x642520", Length = "0x2A")]
	public void Close()
	{
	}

	[Token(Token = "0x6005608")]
	[Address(RVA = "0x643CD0", Offset = "0x6424D0", Length = "0x45")]
	public void CloseTalk()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005609")]
	public PnlRoleTalkBubble()
	{
	}
}
