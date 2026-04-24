namespace Assets.Scripts.GameCore.Interface;

public interface IInputKeyBinding
{

	public UISelectManage GetPanelOrder
	{
		 get { } //Length: 0
	}

	public bool IsOnCurrentPanel
	{
		 get { } //Length: 0
	}

	public UISelectManage get_GetPanelOrder() { }

	public bool get_IsOnCurrentPanel() { }

	public void SetPanelOrder(UISelectManage uiManage) { }

}

