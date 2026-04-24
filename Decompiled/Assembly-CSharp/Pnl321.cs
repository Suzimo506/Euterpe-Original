using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B4")]
public class Pnl321 : MonoBehaviour
{
	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip m_Pause321;

	[SerializeField]
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x20")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x4F96A0", Offset = "0x4F7EA0", Length = "0xF1")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x4F97A0", Offset = "0x4F7FA0", Length = "0xBE")]
	private void Resume()
	{
	}

	[Address(RVA = "0x4F9680", Offset = "0x4F7E80", Length = "0x1D")]
	[Token(Token = "0x6000550")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public Pnl321()
	{
	}
}
