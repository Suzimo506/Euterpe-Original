//Type is in global namespace

public class BulletinTitleScroller : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public BulletinTitleScroller <>4__this; //Field offset: 0x10
		public int selectIndex; //Field offset: 0x18
		public DOGetter<Single> <>9__1; //Field offset: 0x20
		public DOSetter<Single> <>9__2; //Field offset: 0x28

		public <>c__DisplayClass8_0() { }

		internal void <OnValueChange>b__0() { }

		internal float <OnValueChange>b__1() { }

		internal void <OnValueChange>b__2(float x) { }

	}

	public Scrollbar scrollbar; //Field offset: 0x18
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int ignoreCount; //Field offset: 0x20
	private int m_ChildCount; //Field offset: 0x24
	private Single[] m_ScrollBarValue; //Field offset: 0x28
	private bool m_IsPress; //Field offset: 0x30
	private ToggleGroup m_ToggleGroup; //Field offset: 0x38

	public BulletinTitleScroller() { }

	private void Awake() { }

	public void OnValueChange(int selectIndex) { }

	private void Update() { }

}

