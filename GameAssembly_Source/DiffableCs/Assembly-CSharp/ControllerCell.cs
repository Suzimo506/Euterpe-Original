//Type is in global namespace

public class ControllerCell : MonoBehaviour
{
	private GameObject m_Cover; //Field offset: 0x18
	private GameObject m_Reverse; //Field offset: 0x20
	private Image m_Selected; //Field offset: 0x28

	public ControllerCell() { }

	private void Awake() { }

	public void SetReverse(bool isReverse) { }

	public void SetSelectColor(Color c) { }

}

