namespace ZenFulcrum.EmbeddedBrowser;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PointerUIMesh : PointerUIBase
{
	protected MeshCollider meshCollider; //Field offset: 0xC8
	protected Dictionary<Int32, RaycastHit> rayHits; //Field offset: 0xD0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public LayerMask layerMask; //Field offset: 0xD8

	public PointerUIMesh() { }

	public virtual void Awake() { }

	public virtual void GetCurrentHitLocation(out Vector3 pos, out Quaternion rot) { }

	protected virtual Vector2 MapPointerToBrowser(Vector2 screenPosition, int pointerId) { }

	protected virtual Vector2 MapRayToBrowser(Ray worldRay, int pointerId) { }

}

