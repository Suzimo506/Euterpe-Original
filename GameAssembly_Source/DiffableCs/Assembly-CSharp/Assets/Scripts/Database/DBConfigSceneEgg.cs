namespace Assets.Scripts.Database;

public class DBConfigSceneEgg : BaseDBConfigObject
{
	private List<SceneEggInfo> m_Items; //Field offset: 0x38

	protected private List<SceneEggInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigSceneEgg() { }

	public void CheckSceneEgg(string musicId, int albumId, int roleId, List<Int32> buffer) { }

	public virtual void Deserialize(string str) { }

	protected List<SceneEggInfo> get_list() { }

	private void set_list(List<SceneEggInfo> value) { }

}

