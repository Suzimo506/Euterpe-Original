namespace UnityEngine.UI;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GraphicRaycaster : BaseRaycaster
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Graphic> <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Raycast>b__24_0(Graphic g1, Graphic g2) { }

	}

	internal enum BlockingObjects
	{
		None = 0,
		TwoD = 1,
		ThreeD = 2,
		All = 3,
	}

	protected const int kNoEventMaskSet = -1; //Field offset: 0x0
	private static readonly List<Graphic> s_SortedGraphics; //Field offset: 0x0
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private bool m_IgnoreReversedGraphics; //Field offset: 0x20
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private BlockingObjects m_BlockingObjects; //Field offset: 0x24
	[SerializeField]
	protected LayerMask m_BlockingMask; //Field offset: 0x28
	private Canvas m_Canvas; //Field offset: 0x30
	private List<Graphic> m_RaycastResults; //Field offset: 0x38

	public BlockingObjects blockingObjects
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	private Canvas canvas
	{
		private get { } //Length: 147
	}

	public virtual Camera eventCamera
	{
		 get { } //Length: 336
	}

	public bool ignoreReversedGraphics
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public virtual int renderOrderPriority
	{
		 get { } //Length: 95
	}

	public virtual int sortOrderPriority
	{
		 get { } //Length: 80
	}

	private static GraphicRaycaster() { }

	protected GraphicRaycaster() { }

	public BlockingObjects get_blockingObjects() { }

	private Canvas get_canvas() { }

	public virtual Camera get_eventCamera() { }

	public bool get_ignoreReversedGraphics() { }

	public virtual int get_renderOrderPriority() { }

	public virtual int get_sortOrderPriority() { }

	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	public void set_blockingObjects(BlockingObjects value) { }

	public void set_ignoreReversedGraphics(bool value) { }

}

