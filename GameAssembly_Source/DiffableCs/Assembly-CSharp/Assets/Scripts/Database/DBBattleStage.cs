namespace Assets.Scripts.Database;

public class DBBattleStage : BaseDatabase
{
	private int m_MapDifficulty; //Field offset: 0x10
	private int m_MusicLevel; //Field offset: 0x14
	private string m_MusicLevelStr; //Field offset: 0x18
	private int m_SelectedRole; //Field offset: 0x20
	private int m_SelectedRoleSkin; //Field offset: 0x24
	private int m_SelectedElfin; //Field offset: 0x28
	private string m_MusicFileName; //Field offset: 0x30
	private string m_MusicName; //Field offset: 0x38
	private string m_BeganScene; //Field offset: 0x40
	private int m_BeganSceneIdx; //Field offset: 0x48
	private string m_StageMapName; //Field offset: 0x50
	private string m_MusicUid; //Field offset: 0x58
	private int m_PackageJsonIndex; //Field offset: 0x60
	[CompilerGenerated]
	private bool <isTutorial>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private int <selectedMusicIndexFormAll>k__BackingField; //Field offset: 0x68

	public bool isTutorial
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string musicUid
	{
		 get { } //Length: 5
	}

	public string selectedBeganScene
	{
		 get { } //Length: 5
	}

	public int selectedBeganSceneIdx
	{
		 get { } //Length: 4
	}

	public int selectedDifficulty
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int selectedElfin
	{
		 get { } //Length: 4
	}

	public string selectedMusicFileName
	{
		 get { } //Length: 5
	}

	public private int selectedMusicIndexFormAll
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public MusicInfo selectedMusicInfo
	{
		 get { } //Length: 170
	}

	public int selectedMusicLevel
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string selectedMusicName
	{
		 get { } //Length: 5
	}

	public int selectedMusicPackageJsonIndex
	{
		 get { } //Length: 4
	}

	public int selectedRole
	{
		 get { } //Length: 4
	}

	public string selectedStageMapName
	{
		 get { } //Length: 5
	}

	public string selectMusicLevelStr
	{
		 get { } //Length: 5
	}

	public int selectRoleSkin
	{
		 get { } //Length: 4
	}

	public DBBattleStage() { }

	public virtual void AwakeInit() { }

	[CompilerGenerated]
	public bool get_isTutorial() { }

	public string get_musicUid() { }

	public string get_selectedBeganScene() { }

	public int get_selectedBeganSceneIdx() { }

	public int get_selectedDifficulty() { }

	public int get_selectedElfin() { }

	public string get_selectedMusicFileName() { }

	[CompilerGenerated]
	public int get_selectedMusicIndexFormAll() { }

	public MusicInfo get_selectedMusicInfo() { }

	public int get_selectedMusicLevel() { }

	public string get_selectedMusicName() { }

	public int get_selectedMusicPackageJsonIndex() { }

	public int get_selectedRole() { }

	public string get_selectedStageMapName() { }

	public string get_selectMusicLevelStr() { }

	public int get_selectRoleSkin() { }

	private void InitRole() { }

	public bool IsSelectElfin(int elfinIndex) { }

	public bool IsSelectRole(int roleIndex) { }

	public virtual void Release() { }

	public virtual void SceneChangedRelease(Scene preScene, Scene curScene) { }

	[CompilerGenerated]
	public void set_isTutorial(bool value) { }

	public void set_selectedDifficulty(int value) { }

	[CompilerGenerated]
	private void set_selectedMusicIndexFormAll(int value) { }

	public void set_selectedMusicLevel(int value) { }

	public void SetStageBattleInfo(string musicFileName, string musicName, string scene, int musicLevel) { }

	public virtual string ToString() { }

}

