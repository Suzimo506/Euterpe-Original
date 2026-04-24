//Type is in global namespace

public class CreditScroller : MonoBehaviour
{
	public Camera uguiCamera; //Field offset: 0x18
	public GameObject uguiScrollView; //Field offset: 0x20
	public GameObject uguiScrollRect; //Field offset: 0x28
	public GameObject uguiContent; //Field offset: 0x30
	public GameObject uguiScrollbar; //Field offset: 0x38
	private Scrollbar scrollbar; //Field offset: 0x40
	private Tweener scrollbarTween; //Field offset: 0x48
	private float tweenFloat; //Field offset: 0x50
	private bool isAutoScrolling; //Field offset: 0x54
	private bool touchInside; //Field offset: 0x55
	private float currentStart; //Field offset: 0x58
	private float easeInA; //Field offset: 0x5C
	private float easeInB; //Field offset: 0x60
	private float easeStart; //Field offset: 0x64
	private int fingerID; //Field offset: 0x68
	private float initialTime; //Field offset: 0x6C
	private float mathHelperA; //Field offset: 0x70
	private float mathHelperB; //Field offset: 0x74
	private float percentage; //Field offset: 0x78
	private float time; //Field offset: 0x7C
	private bool letsGo; //Field offset: 0x80
	private ScrollRect srComponent; //Field offset: 0x88
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float scrollSpeed; //Field offset: 0x90
	public float initialDelay; //Field offset: 0x94

	public CreditScroller() { }

	[CompilerGenerated]
	private float <AutoScrolling>b__32_0() { }

	[CompilerGenerated]
	private void <AutoScrolling>b__32_1(float x) { }

	[CompilerGenerated]
	private float <InitialEaseIn>b__29_0() { }

	[CompilerGenerated]
	private void <InitialEaseIn>b__29_1(float x) { }

	[CompilerGenerated]
	private float <InitialScroll>b__30_0() { }

	[CompilerGenerated]
	private void <InitialScroll>b__30_1(float x) { }

	[CompilerGenerated]
	private float <PressReleased>b__31_0() { }

	[CompilerGenerated]
	private void <PressReleased>b__31_1(float x) { }

	private void AutoScrollEnd() { }

	private void AutoScrolling() { }

	private void Awake() { }

	private void DelayedSetup() { }

	private void InitialEaseIn() { }

	private void InitialScroll() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void PressReleased() { }

	private void Update() { }

}

