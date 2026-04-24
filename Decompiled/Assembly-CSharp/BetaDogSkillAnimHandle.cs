using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000059")]
public class BetaDogSkillAnimHandle : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000222")]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000223")]
	private bool m_IsSwitchEmoji;

	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x24")]
	private float m_CurTime;

	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x28")]
	private int m_CurEmojiID;

	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x2C")]
	private float m_SwitchEmojiTime;

	[Token(Token = "0x4000227")]
	private const float m_DieStandbyTime = 4.116f;

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x5FBA70", Offset = "0x5FA270", Length = "0xC0")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5FBCF0", Offset = "0x5FA4F0", Length = "0xDB")]
	[Token(Token = "0x60002B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x5FBB90", Offset = "0x5FA390", Length = "0xA2")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x5FBB40", Offset = "0x5FA340", Length = "0x4E")]
	[Token(Token = "0x60002B2")]
	private void OnBetaDogSkillTrigger(object sender, object reciever, params object[] args)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x5FBC40", Offset = "0x5FA440", Length = "0xA0")]
	private void ShowBetaDogEmoji()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x5FBDD0", Offset = "0x5FA5D0", Length = "0x77")]
	public BetaDogSkillAnimHandle()
	{
	}
}
