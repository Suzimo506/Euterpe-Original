//Type is in global namespace

public class ChangeFeverValue : MonoBehaviour
{
	private Text m_Text; //Field offset: 0x18
	private Slider m_Slider; //Field offset: 0x20
	public Animator feverAnim; //Field offset: 0x28

	public ChangeFeverValue() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnFever(object sender, object reciever, Object[] args) { }

	private void OnFeverFail() { }

	private void OnFeverMax(object sender, object reciever, Object[] args) { }

	private void OnFeverRateChange(object sender, object reciever, Object[] args) { }

}

