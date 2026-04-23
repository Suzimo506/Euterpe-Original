using System;
using Assets.Scripts.PeroTools.Nice.Actions;
using Cpp2ILInjected;
using Sirenix.OdinInspector;

[Token(Token = "0x20001AC")]
public class WelcomeBtnLogin : SerializedMonoBehaviour
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A75")]
	public Popup peAsk;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A76")]
	public bool line;

	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x68")]
	public Popup nsAsk;

	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsAndroid;

	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x4000A79")]
	private bool m_IsNS;

	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x4000A7A")]
	private bool m_Invoke;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A7B")]
	private System.Action m_EggActionBeforeEnter;

	[Address(RVA = "0xD31FC0", Offset = "0xD307C0", Length = "0x1A0")]
	[Token(Token = "0x6000C0C")]
	private void Awake()
	{
	}

	[Address(RVA = "0xD32470", Offset = "0xD30C70", Length = "0x12")]
	[Token(Token = "0x6000C0D")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0xD31F40", Offset = "0xD30740", Length = "0x76")]
	[Token(Token = "0x6000C0E")]
	private void AddEggActionBeforeEnter(System.Action eggAction)
	{
	}

	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0xD32300", Offset = "0xD30B00", Length = "0xE")]
	public void OnClick()
	{
	}

	[Address(RVA = "0xD32170", Offset = "0xD30970", Length = "0x18C")]
	[Token(Token = "0x6000C10")]
	private void EnterMainScene()
	{
	}

	[Address(RVA = "0xD32310", Offset = "0xD30B10", Length = "0x158")]
	[Token(Token = "0x6000C11")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public WelcomeBtnLogin()
	{
	}
}
