using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000611")]
public class CharVoicePlay : Action
{
	[Token(Token = "0x4002240")]
	[FieldOffset(Offset = "0x10")]
	public VoiceType voiceType;

	[Address(RVA = "0x73BB10", Offset = "0x73A310", Length = "0x180")]
	[Token(Token = "0x6003B43")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003B44")]
	[Address(RVA = "0x73BCB0", Offset = "0x73A4B0", Length = "0x146")]
	public static void PlayVoice(VoiceType type, int index)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B45")]
	public CharVoicePlay()
	{
	}
}
