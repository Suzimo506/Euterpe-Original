namespace Assets.Scripts.PeroTools.Nice.Actions;

public class CharVoicePlay : Action
{
	public VoiceType voiceType; //Field offset: 0x10

	public CharVoicePlay() { }

	public virtual void Execute() { }

	public static void PlayVoice(VoiceType type, int index) { }

}

