namespace Assets.Scripts.PeroTools.UI;

public class PanelManage
{
	private static bool s_IsInputEnable; //Field offset: 0x0
	private static List<UISelectManage> s_UiSelectManagers; //Field offset: 0x8

	private static PanelManage() { }

	public PanelManage() { }

	public static void DisableInput(object sender, object reciever, Object[] args) { }

	public static void EnableInput(object sender, object reciever, Object[] args) { }

	public static bool IsThisUiManager(UISelectManage uiManager) { }

	public static UISelectManage Peek(int index = 0) { }

	private static void Pop(int index = 0) { }

	public static bool PopAll(UISelectManage manager) { }

	public static bool PopAllPopup(UISelectManage parent) { }

	public static bool PopPanel(UISelectManage manager, int deep = 1) { }

	public static void PushPanel(UISelectManage manager) { }

}

