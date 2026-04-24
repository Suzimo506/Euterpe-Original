using Cpp2ILInjected;
using UnityEngine;

namespace UI.Panels;

[Token(Token = "0x20001C7")]
public class VolumeVoiceScreenAdapts : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x18")]
	private RectTransform m_TglSettingContainer;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B2F")]
	[SerializeField]
	private RectTransform m_TglTitleVoice;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000B30")]
	private RectTransform m_TglTitleBackground;

	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x4EDD10", Offset = "0x4EC510", Length = "0x19F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public VolumeVoiceScreenAdapts()
	{
	}
}
