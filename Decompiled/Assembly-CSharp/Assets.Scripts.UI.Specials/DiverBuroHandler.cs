using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000873")]
public class DiverBuroHandler : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002C27")]
	private Assets.Scripts.Database.CharacterInfo m_CharacterInfo;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002C28")]
	private CharacterFestivalVoiceInfo m_FestivalVoiceInfo;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002C29")]
	private GameObject m_PnlDaveFishViewAsset;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002C2A")]
	private GameObject m_PnlDaveFishViewObj;

	[Token(Token = "0x4002C2B")]
	[FieldOffset(Offset = "0x38")]
	private bool m_Init;

	[Token(Token = "0x6004D2C")]
	[Address(RVA = "0x60EB50", Offset = "0x60D350", Length = "0x290")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D2D")]
	[Address(RVA = "0x60F270", Offset = "0x60DA70", Length = "0x144")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004D2E")]
	[Address(RVA = "0x60EDF0", Offset = "0x60D5F0", Length = "0x474")]
	private void ChangeExpression(int bgIndex)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004D2F")]
	public DiverBuroHandler()
	{
	}
}
