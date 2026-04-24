namespace Assets.Scripts.Database;

public class DBStageInfo : BaseDatabase
{
	public bool invokeLoaded; //Field offset: 0x10
	private StageInfo m_StageInfo; //Field offset: 0x18
	[CompilerGenerated]
	private float <runtimeBpm>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List<SceneEvent> <sceneEvents>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Dictionary<String, List`1<GameDialogArgs>> <sceneDialogEvents>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Dictionary<Decimal, List`1<GameDialogArgs>> <sceneDialogDictionary>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private List<MusicData> <musicList>k__BackingField; //Field offset: 0x40
	private decimal m_Delay; //Field offset: 0x48
	private float m_Bpm; //Field offset: 0x58

	public float bpm
	{
		 get { } //Length: 140
	}

	public decimal delay
	{
		 get { } //Length: 145
	}

	public float floatDelay
	{
		 get { } //Length: 212
	}

	public string mapName
	{
		 get { } //Length: 15
	}

	public string md5
	{
		 get { } //Length: 151
	}

	public private List<MusicData> musicList
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public List<MusicData> oriMusicList
	{
		 get { } //Length: 15
	}

	public float runtimeBpm
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public Dictionary<Decimal, List`1<GameDialogArgs>> sceneDialogDictionary
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Dictionary<String, List`1<GameDialogArgs>> sceneDialogEvents
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public List<SceneEvent> sceneEvents
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public DBStageInfo() { }

	public virtual void AwakeInit() { }

	private void DialogDataToDic(Dictionary<String, List`1<GameDialogArgs>> dialogDic) { }

	public float get_bpm() { }

	public decimal get_delay() { }

	public float get_floatDelay() { }

	public string get_mapName() { }

	public string get_md5() { }

	[CompilerGenerated]
	public List<MusicData> get_musicList() { }

	public List<MusicData> get_oriMusicList() { }

	[CompilerGenerated]
	public float get_runtimeBpm() { }

	[CompilerGenerated]
	public Dictionary<Decimal, List`1<GameDialogArgs>> get_sceneDialogDictionary() { }

	[CompilerGenerated]
	public Dictionary<String, List`1<GameDialogArgs>> get_sceneDialogEvents() { }

	[CompilerGenerated]
	public List<SceneEvent> get_sceneEvents() { }

	public virtual void Release() { }

	[CompilerGenerated]
	private void set_musicList(List<MusicData> value) { }

	[CompilerGenerated]
	public void set_runtimeBpm(float value) { }

	[CompilerGenerated]
	protected void set_sceneDialogDictionary(Dictionary<Decimal, List`1<GameDialogArgs>> value) { }

	[CompilerGenerated]
	protected void set_sceneDialogEvents(Dictionary<String, List`1<GameDialogArgs>> value) { }

	[CompilerGenerated]
	protected void set_sceneEvents(List<SceneEvent> value) { }

	public void SetBaseData(decimal delay, float bpm, List<SceneEvent> events) { }

	public void SetDialogArgs(Dictionary<String, List`1<GameDialogArgs>> dialogArgs, bool isRefresh) { }

	public void SetRuntimeMusicData(List<MusicData> data) { }

	public void SetStageInfo(StageInfo info) { }

}

