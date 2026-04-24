namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class OnFancyScrollViewCellUpdate : Event
{
	public bool isInViewport; //Field offset: 0x70
	private Animator m_Animator; //Field offset: 0x78
	private int m_StoreHash; //Field offset: 0x80
	private VariableBehaviour m_Variables; //Field offset: 0x88
	[CompilerGenerated]
	private Action<Int32> onDataIndexChanged; //Field offset: 0x90
	[CompilerGenerated]
	private bool <isPlaceHolder>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private float <animPos>k__BackingField; //Field offset: 0x9C

	public event Action<Int32> onDataIndexChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private float animPos
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public bool isPlaceHolder
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public OnFancyScrollViewCellUpdate() { }

	[CompilerGenerated]
	public void add_onDataIndexChanged(Action<Int32> value) { }

	[CompilerGenerated]
	public float get_animPos() { }

	[CompilerGenerated]
	public bool get_isPlaceHolder() { }

	public int GetDataIndex() { }

	public bool GetVisible() { }

	public void Init() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_onDataIndexChanged(Action<Int32> value) { }

	[CompilerGenerated]
	private void set_animPos(float value) { }

	[CompilerGenerated]
	public void set_isPlaceHolder(bool value) { }

	public void SetVisible(bool visible) { }

	public void UpdateData(int dataInd) { }

	public void UpdatePosition(int animHash, float position) { }

}

