namespace Assets.Scripts.Database;

public class DBOther : BaseDatabase
{
	internal enum FxType
	{
		Dust = 0,
		Music = 1,
		Hp = 2,
	}

	private float m_KeyAudioVolume; //Field offset: 0x10
	private float m_VoiceAudioVolume; //Field offset: 0x14
	private string m_DustFx; //Field offset: 0x18
	private string m_MusicFx; //Field offset: 0x20
	private string m_HpFx; //Field offset: 0x28
	private AgeRange m_AgeRange; //Field offset: 0x30
	public bool screenEffectEnable; //Field offset: 0x34
	public bool isAudioVisPlay; //Field offset: 0x35

	public AgeRange ageRange
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool isAdult
	{
		 get { } //Length: 8
	}

	public bool isDjMaxScene
	{
		 get { } //Length: 171
	}

	public bool isGCScene
	{
		 get { } //Length: 171
	}

	public float KeyAudioVolume
	{
		 get { } //Length: 6
	}

	public float VoiceAudioVolume
	{
		 get { } //Length: 6
	}

	public DBOther() { }

	public virtual void AwakeInit() { }

	public AgeRange get_ageRange() { }

	public bool get_isAdult() { }

	public bool get_isDjMaxScene() { }

	public bool get_isGCScene() { }

	public float get_KeyAudioVolume() { }

	public float get_VoiceAudioVolume() { }

	public string GetFxName(FxType fxType) { }

	public virtual void Release() { }

	public void set_ageRange(AgeRange value) { }

	public void SetFxName(FxType fxType, string str) { }

}

