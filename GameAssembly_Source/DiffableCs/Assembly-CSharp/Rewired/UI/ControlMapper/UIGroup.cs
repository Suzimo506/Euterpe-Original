namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class UIGroup : MonoBehaviour
{
	[SerializeField]
	private Text _label; //Field offset: 0x18
	[SerializeField]
	private Transform _content; //Field offset: 0x20

	public Transform content
	{
		 get { } //Length: 5
	}

	public string labelText
	{
		 get { } //Length: 160
		 set { } //Length: 148
	}

	public UIGroup() { }

	public Transform get_content() { }

	public string get_labelText() { }

	public void set_labelText(string value) { }

	public void SetLabelActive(bool state) { }

}

