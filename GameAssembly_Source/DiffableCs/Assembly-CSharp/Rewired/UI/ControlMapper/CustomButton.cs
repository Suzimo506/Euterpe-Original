namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CustomButton : Button, ICustomSelectable, ICancelHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <OnFinishSubmit>d__51 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CustomButton <>4__this; //Field offset: 0x20
		private float <fadeTime>5__2; //Field offset: 0x28
		private float <elapsedTime>5__3; //Field offset: 0x2C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <OnFinishSubmit>d__51(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private Sprite _disabledHighlightedSprite; //Field offset: 0x100
	[SerializeField]
	private Color _disabledHighlightedColor; //Field offset: 0x108
	[SerializeField]
	private string _disabledHighlightedTrigger; //Field offset: 0x118
	[SerializeField]
	private bool _autoNavUp; //Field offset: 0x120
	[SerializeField]
	private bool _autoNavDown; //Field offset: 0x121
	[SerializeField]
	private bool _autoNavLeft; //Field offset: 0x122
	[SerializeField]
	private bool _autoNavRight; //Field offset: 0x123
	private bool isHighlightDisabled; //Field offset: 0x124
	[CompilerGenerated]
	private UnityAction _CancelEvent; //Field offset: 0x128

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

	public CustomButton() { }

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

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator OnFinishSubmit() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	private void Press() { }

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

