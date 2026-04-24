namespace UnityEngine.EventSystems;

public struct RaycastResult
{
	private GameObject m_GameObject; //Field offset: 0x0
	public BaseRaycaster module; //Field offset: 0x8
	public float distance; //Field offset: 0x10
	public float index; //Field offset: 0x14
	public int depth; //Field offset: 0x18
	public int sortingLayer; //Field offset: 0x1C
	public int sortingOrder; //Field offset: 0x20
	public Vector3 worldPosition; //Field offset: 0x24
	public Vector3 worldNormal; //Field offset: 0x30
	public Vector2 screenPosition; //Field offset: 0x3C
	public int displayIndex; //Field offset: 0x44

	public GameObject gameObject
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public bool isValid
	{
		 get { } //Length: 158
	}

	public void Clear() { }

	public GameObject get_gameObject() { }

	public bool get_isValid() { }

	public void set_gameObject(GameObject value) { }

	public virtual string ToString() { }

}

