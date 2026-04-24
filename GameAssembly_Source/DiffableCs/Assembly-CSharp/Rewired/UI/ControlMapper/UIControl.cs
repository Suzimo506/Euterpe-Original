namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class UIControl : MonoBehaviour
{
	private static int _uidCounter; //Field offset: 0x0
	public Text title; //Field offset: 0x18
	private int _id; //Field offset: 0x20
	private bool _showTitle; //Field offset: 0x24

	public int id
	{
		 get { } //Length: 4
	}

	public bool showTitle
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	public UIControl() { }

	private void Awake() { }

	public int get_id() { }

	public bool get_showTitle() { }

	private static int GetNextUid() { }

	public void set_showTitle(bool value) { }

	public override void SetCancelCallback(Action cancelCallback) { }

}

