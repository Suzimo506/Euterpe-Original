namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class InputRow : MonoBehaviour
{
	public Text label; //Field offset: 0x18
	[CompilerGenerated]
	private ButtonInfo[] <buttons>k__BackingField; //Field offset: 0x20
	private int rowIndex; //Field offset: 0x28
	private Action<Int32, ButtonInfo> inputFieldActivatedCallback; //Field offset: 0x30

	public private ButtonInfo[] buttons
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public InputRow() { }

	[CompilerGenerated]
	public ButtonInfo[] get_buttons() { }

	public void Initialize(int rowIndex, string label, Action<Int32, ButtonInfo> inputFieldActivatedCallback) { }

	public void OnButtonActivated(ButtonInfo buttonInfo) { }

	[CompilerGenerated]
	private void set_buttons(ButtonInfo[] value) { }

}

