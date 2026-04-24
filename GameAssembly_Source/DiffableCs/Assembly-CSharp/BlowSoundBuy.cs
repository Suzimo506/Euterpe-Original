//Type is in global namespace

public class BlowSoundBuy : MonoBehaviour
{
	[SerializeField]
	private GameObject m_SoundBuyTipPMD; //Field offset: 0x18
	[SerializeField]
	private GameObject m_SoundBuyTipPC; //Field offset: 0x20
	[SerializeField]
	private Button m_ConfirmBtn; //Field offset: 0x28

	public BlowSoundBuy() { }

	private void Awake() { }

	private void CheckPlatform() { }

	private void SwitchToDlc() { }

}

