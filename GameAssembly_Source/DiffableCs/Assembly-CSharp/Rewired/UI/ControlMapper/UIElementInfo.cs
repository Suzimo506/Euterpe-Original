namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class UIElementInfo : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	public string identifier; //Field offset: 0x18
	public int intData; //Field offset: 0x20
	public Text text; //Field offset: 0x28
	[CompilerGenerated]
	private Action<GameObject> OnSelectedEvent; //Field offset: 0x30

	public event Action<GameObject> OnSelectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected UIElementInfo() { }

	[CompilerGenerated]
	public void add_OnSelectedEvent(Action<GameObject> value) { }

	public override void OnSelect(BaseEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnSelectedEvent(Action<GameObject> value) { }

}

