namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CustomSlider : Slider, ICustomSelectable, ICancelHandler, IEventSystemHandler
{
	[SerializeField]
	private Sprite _disabledHighlightedSprite; //Field offset: 0x160
	[SerializeField]
	private Color _disabledHighlightedColor; //Field offset: 0x168
	[SerializeField]
	private string _disabledHighlightedTrigger; //Field offset: 0x178
	[SerializeField]
	private bool _autoNavUp; //Field offset: 0x180
	[SerializeField]
	private bool _autoNavDown; //Field offset: 0x181
	[SerializeField]
	private bool _autoNavLeft; //Field offset: 0x182
	[SerializeField]
	private bool _autoNavRight; //Field offset: 0x183
	private bool isHighlightDisabled; //Field offset: 0x184
	[CompilerGenerated]
	private UnityAction _CancelEvent; //Field offset: 0x188

	private event UnityAction _CancelEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public override event UnityAction CancelEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public override bool autoNavDown
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public override bool autoNavLeft
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public override bool autoNavRight
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public override bool autoNavUp
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public override Color disabledHighlightedColor
	{
		 get { } //Length: 14
		 set { } //Length: 11
	}

	public override Sprite disabledHighlightedSprite
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	public override string disabledHighlightedTrigger
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	private bool isDisabled
	{
		private get { } //Length: 30
	}

	public CustomSlider() { }

	[CompilerGenerated]
	private void add__CancelEvent(UnityAction value) { }

	public override void add_CancelEvent(UnityAction value) { }

	private void DoSpriteSwap(Sprite newSprite) { }

	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	private void EvaluateHightlightDisabled(bool isSelected) { }

	public virtual Selectable FindSelectableOnDown() { }

	public virtual Selectable FindSelectableOnLeft() { }

	public virtual Selectable FindSelectableOnRight() { }

	public virtual Selectable FindSelectableOnUp() { }

	public override bool get_autoNavDown() { }

	public override bool get_autoNavLeft() { }

	public override bool get_autoNavRight() { }

	public override bool get_autoNavUp() { }

	public override Color get_disabledHighlightedColor() { }

	public override Sprite get_disabledHighlightedSprite() { }

	public override string get_disabledHighlightedTrigger() { }

	private bool get_isDisabled() { }

	public override void OnCancel(BaseEventData eventData) { }

	protected virtual void OnCanvasGroupChanged() { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	[CompilerGenerated]
	private void remove__CancelEvent(UnityAction value) { }

	public override void remove_CancelEvent(UnityAction value) { }

	public override void set_autoNavDown(bool value) { }

	public override void set_autoNavLeft(bool value) { }

	public override void set_autoNavRight(bool value) { }

	public override void set_autoNavUp(bool value) { }

	public override void set_disabledHighlightedColor(Color value) { }

	public override void set_disabledHighlightedSprite(Sprite value) { }

	public override void set_disabledHighlightedTrigger(string value) { }

	private void StartColorTween(Color targetColor, bool instant) { }

	private void TriggerAnimation(string triggername) { }

}

