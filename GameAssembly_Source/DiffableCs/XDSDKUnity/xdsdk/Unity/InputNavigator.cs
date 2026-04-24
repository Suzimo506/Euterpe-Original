namespace xdsdk.Unity;

[DisallowMultipleComponent]
public class InputNavigator : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	private EventSystem system; //Field offset: 0x18
	private bool _isSelect; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnEnter; //Field offset: 0x28

	public event Action OnEnter
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public InputNavigator() { }

	[CompilerGenerated]
	public void add_OnEnter(Action value) { }

	public override void OnDeselect(BaseEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnEnter(Action value) { }

	private void Start() { }

	private void Update() { }

}

