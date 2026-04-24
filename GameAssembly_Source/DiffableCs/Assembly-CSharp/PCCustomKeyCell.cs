//Type is in global namespace

public class PCCustomKeyCell : MonoBehaviour
{
	public bool dontFadeBaseImg; //Field offset: 0x18
	public Image objImg; //Field offset: 0x20
	public Image imgSpecialButton; //Field offset: 0x28
	public Text txtKey; //Field offset: 0x30
	public Text txtKeySetting; //Field offset: 0x38
	public Text txtKeyNo; //Field offset: 0x40
	public Image imgSelected; //Field offset: 0x48
	private keyType m_BtnType; //Field offset: 0x50

	public PCCustomKeyCell() { }

	[CompilerGenerated]
	private void <OnClickToSendInfo>b__9_0() { }

	private void Awake() { }

	private void CheckActive(GameObject showObj) { }

	private void CheckKeyType() { }

	public keyType GetBtnType() { }

	public void OnClickToSendInfo() { }

	public void SetKeyToKey(string keyName) { }

	public void SetKeyToNo() { }

	public void SetKeyToSetting() { }

	public void SetKeyToSpecial(string keyName) { }

}

