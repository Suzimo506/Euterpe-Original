using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI;

[Attribute(Name = "RequireComponent", RVA = "0x16CC0", Offset = "0x160C0")]
[Token(Token = "0x200082C")]
public class ToggleAnimation : MonoBehaviour
{
	[Token(Token = "0x4002A91")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Toggle m_Toggle;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4002A92")]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002A93")]
	private int m_HashOn;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002A94")]
	private int m_HashOff;

	[Token(Token = "0x4002A95")]
	[FieldOffset(Offset = "0x30")]
	private bool? m_PrevState;

	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4002A96")]
	public bool dontForceRefresh;

	[Token(Token = "0x6004B42")]
	[Address(RVA = "0x604200", Offset = "0x602A00", Length = "0xF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004B43")]
	[Address(RVA = "0x604300", Offset = "0x602B00", Length = "0xC6")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x6043D0", Offset = "0x602BD0", Length = "0x140")]
	[Token(Token = "0x6004B44")]
	public void OnValueChangeWithoutNotifity(bool isOn)
	{
	}

	[Address(RVA = "0x6043D0", Offset = "0x602BD0", Length = "0x140")]
	[Token(Token = "0x6004B45")]
	private void OnValueChange(bool state)
	{
	}

	[Token(Token = "0x6004B46")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ToggleAnimation()
	{
	}
}
