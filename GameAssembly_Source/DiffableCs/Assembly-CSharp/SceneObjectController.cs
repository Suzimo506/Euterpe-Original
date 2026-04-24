//Type is in global namespace

public class SceneObjectController : SingletonMonoBehaviour<SceneObjectController>
{
	private int idx; //Field offset: 0x18
	private int timeEventIndex; //Field offset: 0x1C
	private float runtime; //Field offset: 0x20
	private StageEvent eventData; //Field offset: 0x28
	private Hashtable sceneObjectPool; //Field offset: 0x40
	private AudioSource sceneAudio; //Field offset: 0x48
	private List<GameObject> dymObjectList; //Field offset: 0x50

	public Hashtable SceneObjectPool
	{
		 get { } //Length: 5
	}

	public SceneObjectController() { }

	public void ActiveObject(int idx) { }

	private GameObject CreateObj(GameObject sourceObject) { }

	public void DoObjectComeoutEvent(string nodeId) { }

	public void DoObjectOnAttackedEvent(string nodeId) { }

	public void DoObjectOnMissedEvent(string nodeId) { }

	public Hashtable get_SceneObjectPool() { }

	public List<GameObject> GetAllSceneEventObjects() { }

	public AudioSource GetAudioSource() { }

	public float GetRunTime() { }

	public void InitController(int idx, string audioLayerName = "BossLayer") { }

	public void PreLoad() { }

	private void ResetParticle(GameObject sceneObject) { }

	public void Run() { }

	public void TimerStepTrigger(object sender, uint triggerId, Object[] args) { }

}

