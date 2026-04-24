//Type is in global namespace

public class CameraBloomSettings : MonoBehaviour
{
	[SerializeField]
	private bool m_OverrideSettings; //Field offset: 0x18
	[SerializeField]
	private BloomSettings m_Settings; //Field offset: 0x20

	public bool isActive
	{
		 get { } //Length: 37
	}

	public bool overrideSettings
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public BloomSettings settings
	{
		 get { } //Length: 5
	}

	public CameraBloomSettings() { }

	public bool get_isActive() { }

	public bool get_overrideSettings() { }

	public BloomSettings get_settings() { }

	public void set_overrideSettings(bool value) { }

}

