using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Tutorial;

[Token(Token = "0x200082D")]
public class TutorialVoicePlay : MonoBehaviour
{
	[Token(Token = "0x4002A97")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip tutorialAudioClip;

	[Token(Token = "0x6004B47")]
	[Address(RVA = "0x6069A0", Offset = "0x6051A0", Length = "0x92")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004B48")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public TutorialVoicePlay()
	{
	}
}
