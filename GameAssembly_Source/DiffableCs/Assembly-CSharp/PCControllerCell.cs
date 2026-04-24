//Type is in global namespace

public class PCControllerCell : MonoBehaviour
{
	private GameObject m_Cover; //Field offset: 0x18
	private GameObject m_Reverse; //Field offset: 0x20
	private Image m_Selected; //Field offset: 0x28
	public GameObject controllerTypePS4; //Field offset: 0x30
	public GameObject controllerTypeXBox; //Field offset: 0x38
	public GameObject controllerTypeNs; //Field offset: 0x40
	private GameObject m_CurrentControllerType; //Field offset: 0x48

	public PCControllerCell() { }

	private void Awake() { }

	private void OnEnable() { }

	public void SetReverse(bool isReverse) { }

	public void SetSelectColor(Color c) { }

}

