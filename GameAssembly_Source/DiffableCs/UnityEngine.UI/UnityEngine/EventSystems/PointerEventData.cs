namespace UnityEngine.EventSystems;

public class PointerEventData : BaseEventData
{
	internal enum FramePressState
	{
		Pressed = 0,
		Released = 1,
		PressedAndReleased = 2,
		NotChanged = 3,
	}

	internal enum InputButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
	}

	[CompilerGenerated]
	private GameObject <pointerEnter>k__BackingField; //Field offset: 0x20
	private GameObject m_PointerPress; //Field offset: 0x28
	[CompilerGenerated]
	private GameObject <lastPress>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GameObject <rawPointerPress>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GameObject <pointerDrag>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private RaycastResult <pointerPressRaycast>k__BackingField; //Field offset: 0x90
	public List<GameObject> hovered; //Field offset: 0xD8
	[CompilerGenerated]
	private bool <eligibleForClick>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private int <pointerId>k__BackingField; //Field offset: 0xE4
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private Vector2 <delta>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private Vector2 <pressPosition>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Vector3 <worldPosition>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private Vector3 <worldNormal>k__BackingField; //Field offset: 0x10C
	[CompilerGenerated]
	private float <clickTime>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private int <clickCount>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private Vector2 <scrollDelta>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private bool <useDragThreshold>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private bool <dragging>k__BackingField; //Field offset: 0x129
	[CompilerGenerated]
	private InputButton <button>k__BackingField; //Field offset: 0x12C

	public InputButton button
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public int clickCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float clickTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public Vector2 delta
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool dragging
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool eligibleForClick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Camera enterEventCamera
	{
		 get { } //Length: 148
	}

	public private GameObject lastPress
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public RaycastResult pointerCurrentRaycast
	{
		[CompilerGenerated]
		 get { } //Length: 48
		[CompilerGenerated]
		 set { } //Length: 51
	}

	public GameObject pointerDrag
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public GameObject pointerEnter
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public int pointerId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public GameObject pointerPress
	{
		 get { } //Length: 5
		 set { } //Length: 158
	}

	public RaycastResult pointerPressRaycast
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		 set { } //Length: 54
	}

	public Vector2 position
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Camera pressEventCamera
	{
		 get { } //Length: 154
	}

	public Vector2 pressPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public GameObject rawPointerPress
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Vector2 scrollDelta
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool useDragThreshold
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[Obsolete]
	public Vector3 worldNormal
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	[Obsolete]
	public Vector3 worldPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public PointerEventData(EventSystem eventSystem) { }

	[CompilerGenerated]
	public InputButton get_button() { }

	[CompilerGenerated]
	public int get_clickCount() { }

	[CompilerGenerated]
	public float get_clickTime() { }

	[CompilerGenerated]
	public Vector2 get_delta() { }

	[CompilerGenerated]
	public bool get_dragging() { }

	[CompilerGenerated]
	public bool get_eligibleForClick() { }

	public Camera get_enterEventCamera() { }

	[CompilerGenerated]
	public GameObject get_lastPress() { }

	[CompilerGenerated]
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGenerated]
	public GameObject get_pointerDrag() { }

	[CompilerGenerated]
	public GameObject get_pointerEnter() { }

	[CompilerGenerated]
	public int get_pointerId() { }

	public GameObject get_pointerPress() { }

	[CompilerGenerated]
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGenerated]
	public Vector2 get_position() { }

	public Camera get_pressEventCamera() { }

	[CompilerGenerated]
	public Vector2 get_pressPosition() { }

	[CompilerGenerated]
	public GameObject get_rawPointerPress() { }

	[CompilerGenerated]
	public Vector2 get_scrollDelta() { }

	[CompilerGenerated]
	public bool get_useDragThreshold() { }

	[CompilerGenerated]
	public Vector3 get_worldNormal() { }

	[CompilerGenerated]
	public Vector3 get_worldPosition() { }

	public bool IsPointerMoving() { }

	public bool IsScrolling() { }

	[CompilerGenerated]
	public void set_button(InputButton value) { }

	[CompilerGenerated]
	public void set_clickCount(int value) { }

	[CompilerGenerated]
	public void set_clickTime(float value) { }

	[CompilerGenerated]
	public void set_delta(Vector2 value) { }

	[CompilerGenerated]
	public void set_dragging(bool value) { }

	[CompilerGenerated]
	public void set_eligibleForClick(bool value) { }

	[CompilerGenerated]
	private void set_lastPress(GameObject value) { }

	[CompilerGenerated]
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGenerated]
	public void set_pointerDrag(GameObject value) { }

	[CompilerGenerated]
	public void set_pointerEnter(GameObject value) { }

	[CompilerGenerated]
	public void set_pointerId(int value) { }

	public void set_pointerPress(GameObject value) { }

	[CompilerGenerated]
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGenerated]
	public void set_position(Vector2 value) { }

	[CompilerGenerated]
	public void set_pressPosition(Vector2 value) { }

	[CompilerGenerated]
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGenerated]
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGenerated]
	public void set_useDragThreshold(bool value) { }

	[CompilerGenerated]
	public void set_worldNormal(Vector3 value) { }

	[CompilerGenerated]
	public void set_worldPosition(Vector3 value) { }

	public virtual string ToString() { }

}

