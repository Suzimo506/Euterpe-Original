//Type is in global namespace

public class SceneSurpriseController : MonoBehaviour
{
	public List<GameObject> cytusOnSurpriseObjs; //Field offset: 0x18
	public List<GameObject> cytusOffSurpriseObjs; //Field offset: 0x20
	public List<GameObject> waccaOnSurpriseObjs; //Field offset: 0x28
	public List<GameObject> waccaOffSurpriseObjs; //Field offset: 0x30
	public List<GameObject> leafOnSurpriseObjs; //Field offset: 0x38
	public List<GameObject> leafOffSurpriseObjs; //Field offset: 0x40
	public List<GameObject> touhouOnSurpriseObjs; //Field offset: 0x48
	public List<GameObject> touhouOffSurpriseObjs; //Field offset: 0x50
	public bool isCytusOrWacca; //Field offset: 0x58
	public List<GameObject> cytusOrWaccaOnSurpriseObj; //Field offset: 0x60
	public List<GameObject> cytusOrWaccaOffSurpriseObj; //Field offset: 0x68

	public SceneSurpriseController() { }

	private bool CheckObjs(List<GameObject> objs) { }

	public void Init() { }

	private void SceneEggHandle(List<Int32> sceneEggIdsBuffer) { }

	private void SetListAllActive(List<GameObject> objs, bool isActive = true) { }

	private void SetSceneEgg(List<GameObject> onObjs, List<GameObject> offObjs) { }

}

