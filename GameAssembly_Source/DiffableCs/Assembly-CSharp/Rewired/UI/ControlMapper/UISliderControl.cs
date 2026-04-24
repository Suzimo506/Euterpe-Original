namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class UISliderControl : UIControl
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Action cancelCallback; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal void <SetCancelCallback>b__0() { }

		internal void <SetCancelCallback>b__1(BaseEventData data) { }

	}

	public Image iconImage; //Field offset: 0x28
	public Slider slider; //Field offset: 0x30
	private bool _showIcon; //Field offset: 0x38
	private bool _showSlider; //Field offset: 0x39

	public bool showIcon
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	public bool showSlider
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	public UISliderControl() { }

	public bool get_showIcon() { }

	public bool get_showSlider() { }

	public void set_showIcon(bool value) { }

	public void set_showSlider(bool value) { }

	public virtual void SetCancelCallback(Action cancelCallback) { }

}

