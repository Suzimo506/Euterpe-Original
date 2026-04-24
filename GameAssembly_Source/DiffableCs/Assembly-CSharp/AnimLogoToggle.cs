//Type is in global namespace

public class AnimLogoToggle : MonoBehaviour
{
	public GameObject peroperoAnimLogoObj; //Field offset: 0x18
	public GameObject eroeroAnimLogoObj; //Field offset: 0x20
	public GameObject rhythmdoctorAnimLogoObj; //Field offset: 0x28
	private DateTime nowDateTime; //Field offset: 0x30
	private Voice m_PeroLogoVoices; //Field offset: 0x38

	public AnimLogoToggle() { }

	private void Awake() { }

	private bool FirstUseSfxHandler(string firstOpenEventName, bool isContainYear = false) { }

	private void LogoSfxHandler() { }

	private void OnEnable() { }

}

