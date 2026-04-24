namespace Assets.Scripts.PeroTools.Managers;

public abstract class Controller : IControlable
{
	public T configs; //Field offset: 0x0

	protected Controller`1() { }

	public override void ChangeButton(string buttonName, string newKey, string uiName) { }

	public override void CustomButton(string buttonName, string key) { }

	public override float GetAxisFromUI(string axisName) { }

	public abstract List<Int32> GetButton(MDButtonType buttonName) { }

	public abstract List<Int32> GetButtonDown(MDButtonType buttonName) { }

	public override bool GetButtonDownFromUI(string keyName) { }

	public override bool GetButtonFromUI(string keyName) { }

	protected abstract bool GetButtonProposal(MDButtonType buttonName) { }

	public abstract List<Int32> GetButtonUp(MDButtonType buttonName) { }

	public override bool GetButtonUpFromUI(string keyName) { }

	public override bool GetTouchs(List<TouchControl> buffer) { }

	public override void Init(string path) { }

	public override void LoadAssets(string fileName) { }

	public override void OnClickChangeButton(string buttonName, string key) { }

	public override void OnClickNoKeyToChange(string buttonName) { }

	public override void OnDisableController() { }

	public override void OnInit() { }

	public override void SaveJsonProposal(string keyboardProposal, string handleProposal, bool isVibration) { }

	public override void SetVibration(VibrationVaule vaule, DeviceHandles handles, float time) { }

	public override void SwitchProposal(string proposalName) { }

	public override void UpdateRepeatList(List<String> list) { }

}

