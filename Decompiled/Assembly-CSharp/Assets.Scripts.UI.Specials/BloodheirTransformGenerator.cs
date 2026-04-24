using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x200086D")]
public class BloodheirTransformGenerator : MonoBehaviour
{
	[Token(Token = "0x4002C0E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator m_BuroAnimator;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002C0F")]
	[SerializeField]
	private CharacterApply m_CharacterApply;

	[Token(Token = "0x4002C10")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_BloodheirTransformAsset;

	[Token(Token = "0x4002C11")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_BloodheirTransformObj;

	[Token(Token = "0x6004D10")]
	[Address(RVA = "0x60BE70", Offset = "0x60A670", Length = "0x1B6")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D11")]
	[Address(RVA = "0x60C030", Offset = "0x60A830", Length = "0xCA")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004D12")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public BloodheirTransformGenerator()
	{
	}
}
