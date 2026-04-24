//Type is in global namespace

[CreateAssetMenu]
public class STMQuadData : ScriptableObject
{
	public Texture texture; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool silhouette; //Field offset: 0x20
	public FilterMode filterMode; //Field offset: 0x24
	public int columns; //Field offset: 0x28
	public int rows; //Field offset: 0x2C
	public int iconIndex; //Field offset: 0x30
	public float animDelay; //Field offset: 0x34
	public Int32[] frames; //Field offset: 0x38
	public Vector2 size; //Field offset: 0x40
	public Vector3 offset; //Field offset: 0x48
	public float advance; //Field offset: 0x54

	public Vector3 BottomLeftVert
	{
		 get { } //Length: 216
	}

	public Vector3 BottomRightVert
	{
		 get { } //Length: 218
	}

	public Vector3 TopLeftVert
	{
		 get { } //Length: 218
	}

	public Vector3 TopRightVert
	{
		 get { } //Length: 220
	}

	private Vector2 uvSize
	{
		private get { } //Length: 71
	}

	public STMQuadData() { }

	private void FixColumnCount() { }

	public Vector3 get_BottomLeftVert() { }

	public Vector3 get_BottomRightVert() { }

	public Vector3 get_TopLeftVert() { }

	public Vector3 get_TopRightVert() { }

	private Vector2 get_uvSize() { }

	private void OnValidate() { }

	public Vector2 UvBottomLeft(float myTime) { }

	public Vector2 UvBottomRight(float myTime) { }

	private Vector2 UvOffset(float myTime) { }

	public Vector2 UvTopLeft(float myTime) { }

	public Vector2 UvTopRight(float myTime) { }

}

