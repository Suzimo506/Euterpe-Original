//Type is in global namespace

[CreateAssetMenu]
public class STMSoundClipData : ScriptableObject
{
	internal class AutoClip
	{
		public string name; //Field offset: 0x10
		public AudioClip clip; //Field offset: 0x18

		public AutoClip() { }

	}

	public List<AutoClip> clips; //Field offset: 0x18

	public STMSoundClipData() { }

}

