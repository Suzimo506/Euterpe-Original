namespace Assets.Scripts.PeroTools.Managers;

public interface IControlable
{

	public void ChangeButton(string buttonName, string newKey, string uiName) { }

	public void CustomButton(string buttonName, string key) { }

	public float GetAxisFromUI(string axisName) { }

	public List<Int32> GetButton(MDButtonType buttonName) { }

	public List<Int32> GetButtonDown(MDButtonType buttonType) { }

	public bool GetButtonDownFromUI(string keyName) { }

	public bool GetButtonFromUI(string keyName) { }

	public List<Int32> GetButtonUp(MDButtonType buttonName) { }

	public bool GetButtonUpFromUI(string keyName) { }

	public bool GetTouchs(List<TouchControl> buffer) { }

	public void Init(string path) { }

	public void OnClickChangeButton(string buttonName, string key) { }

	public void OnClickNoKeyToChange(string buttonName) { }

	public void OnDisableController() { }

	public void SaveJsonProposal(string keyboardProposal, string handleProposal, bool isVibration) { }

	public void SetVibration(VibrationVaule vaule, DeviceHandles handles, float time) { }

	public void SwitchProposal(string proposalName) { }

	public void UpdateRepeatList(List<String> list) { }

}

