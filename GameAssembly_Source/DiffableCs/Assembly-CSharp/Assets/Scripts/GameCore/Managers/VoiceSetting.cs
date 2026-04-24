namespace Assets.Scripts.GameCore.Managers;

[CreateAssetMenu]
public class VoiceSetting : SingletonScriptableObject<VoiceSetting>
{
	internal class Voice
	{
		public int index; //Field offset: 0x10
		public List<String> voiceNames; //Field offset: 0x18
		public List<String> catNames; //Field offset: 0x20

		public Voice() { }

		public Voice(Voice copy) { }

		public List<String> GetVoices(int skin) { }

	}

	[SerializeField]
	private List<Voice> applyVoices; //Field offset: 0x58
	[SerializeField]
	private List<Voice> startVoices; //Field offset: 0x60
	[SerializeField]
	private List<Voice> failVoices; //Field offset: 0x68
	[SerializeField]
	private List<Voice> victoryVoices; //Field offset: 0x70
	[SerializeField]
	private List<Voice> peroLogoVoices; //Field offset: 0x78
	[SerializeField]
	private List<Voice> hasuLogoVoices; //Field offset: 0x80
	[SerializeField]
	private List<Voice> hurtVoices; //Field offset: 0x88

	public VoiceSetting() { }

	public string GetVoice(VoiceType type, int index, int skin) { }

	public Voice GetVoiceConfig(VoiceType type, int index = -1, bool copy = true) { }

}

