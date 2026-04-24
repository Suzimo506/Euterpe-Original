namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class UIControlSet : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Action<Int32, Single> valueChangedCallback; //Field offset: 0x10
		public UISliderControl control; //Field offset: 0x18
		public Action<Int32> cancelCallback; //Field offset: 0x20

		public <>c__DisplayClass6_0() { }

		internal void <CreateSlider>b__0(float value) { }

		internal void <CreateSlider>b__1() { }

	}

	[SerializeField]
	private Text title; //Field offset: 0x18
	private Dictionary<Int32, UIControl> _controls; //Field offset: 0x20

	private Dictionary<Int32, UIControl> controls
	{
		private get { } //Length: 110
	}

	public UIControlSet() { }

	public UISliderControl CreateSlider(GameObject prefab, Sprite icon, float minValue, float maxValue, Action<Int32, Single> valueChangedCallback, Action<Int32> cancelCallback) { }

	private Dictionary<Int32, UIControl> get_controls() { }

	public T GetControl(int uniqueId) { }

	public void SetTitle(string text) { }

}

