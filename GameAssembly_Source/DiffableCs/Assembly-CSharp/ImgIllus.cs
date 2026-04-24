//Type is in global namespace

public class ImgIllus : MonoBehaviour
{
	private Image m_IllusImg; //Field offset: 0x18
	[HideInInspector]
	public string imageName; //Field offset: 0x20

	public ImgIllus() { }

	private void Awake() { }

	private void OnEnable() { }

}

