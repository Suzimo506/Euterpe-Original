namespace UnityEngine.EventSystems;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PhysicsRaycaster : BaseRaycaster
{
	private class RaycastHitComparer : IComparer<RaycastHit>
	{
		public static RaycastHitComparer instance; //Field offset: 0x2C927A8

		private static RaycastHitComparer() { }

		public RaycastHitComparer() { }

		public override int Compare(RaycastHit x, RaycastHit y) { }

	}

	protected const int kNoEventMaskSet = -1; //Field offset: 0x0
	protected Camera m_EventCamera; //Field offset: 0x20
	[SerializeField]
	protected LayerMask m_EventMask; //Field offset: 0x28
	[SerializeField]
	protected int m_MaxRayIntersections; //Field offset: 0x2C
	protected int m_LastMaxRayIntersections; //Field offset: 0x30
	private RaycastHit[] m_Hits; //Field offset: 0x38

	public override int depth
	{
		 get { } //Length: 179
	}

	public virtual Camera eventCamera
	{
		 get { } //Length: 159
	}

	public LayerMask eventMask
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int finalEventMask
	{
		 get { } //Length: 189
	}

	public int maxRayIntersections
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	protected PhysicsRaycaster() { }

	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	public override int get_depth() { }

	public virtual Camera get_eventCamera() { }

	public LayerMask get_eventMask() { }

	public int get_finalEventMask() { }

	public int get_maxRayIntersections() { }

	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	public void set_eventMask(LayerMask value) { }

	public void set_maxRayIntersections(int value) { }

}

