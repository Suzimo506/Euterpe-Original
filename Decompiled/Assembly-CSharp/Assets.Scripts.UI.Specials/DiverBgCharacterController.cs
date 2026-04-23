using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000872")]
public class DiverBgCharacterController : MonoBehaviour
{
	[Token(Token = "0x4002C21")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SkeletonAnimation m_Animation;

	[SerializeField]
	[Token(Token = "0x4002C22")]
	[FieldOffset(Offset = "0x20")]
	private string m_StartName;

	[Token(Token = "0x4002C23")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_StandbyName;

	[SerializeField]
	[Token(Token = "0x4002C24")]
	[FieldOffset(Offset = "0x30")]
	private string m_EndName;

	[SerializeField]
	[Token(Token = "0x4002C25")]
	[FieldOffset(Offset = "0x38")]
	private int m_CharacterIndex;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4002C26")]
	private bool m_IsPlaying;

	[Token(Token = "0x6004D25")]
	[Address(RVA = "0x60E660", Offset = "0x60CE60", Length = "0xA9")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D26")]
	[Address(RVA = "0x60E820", Offset = "0x60D020", Length = "0xA9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004D27")]
	[Address(RVA = "0x60E710", Offset = "0x60CF10", Length = "0x67")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004D28")]
	[Address(RVA = "0x60E780", Offset = "0x60CF80", Length = "0x9B")]
	private void OnCharacterTalk(int characterIndex)
	{
	}

	[Address(RVA = "0x60E8D0", Offset = "0x60D0D0", Length = "0x7E")]
	[Token(Token = "0x6004D29")]
	private void PlayAnimation()
	{
	}

	[Token(Token = "0x6004D2A")]
	[Address(RVA = "0x60E710", Offset = "0x60CF10", Length = "0x67")]
	private void EndAnimation()
	{
	}

	[Token(Token = "0x6004D2B")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DiverBgCharacterController()
	{
	}
}
