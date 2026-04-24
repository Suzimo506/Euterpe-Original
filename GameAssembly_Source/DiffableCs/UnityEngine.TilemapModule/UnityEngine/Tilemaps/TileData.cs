namespace UnityEngine.Tilemaps;

[NativeType]
[RequiredByNativeCode]
public struct TileData
{
	private Sprite m_Sprite; //Field offset: 0x0
	private Color m_Color; //Field offset: 0x8
	private Matrix4x4 m_Transform; //Field offset: 0x18
	private GameObject m_GameObject; //Field offset: 0x58
	private TileFlags m_Flags; //Field offset: 0x60
	private ColliderType m_ColliderType; //Field offset: 0x64

	public ColliderType colliderType
	{
		 set { } //Length: 4
	}

	public Color color
	{
		 set { } //Length: 8
	}

	public TileFlags flags
	{
		 set { } //Length: 4
	}

	public GameObject gameObject
	{
		 set { } //Length: 12
	}

	public Sprite sprite
	{
		 set { } //Length: 8
	}

	public Matrix4x4 transform
	{
		 set { } //Length: 32
	}

	public void set_colliderType(ColliderType value) { }

	public void set_color(Color value) { }

	public void set_flags(TileFlags value) { }

	public void set_gameObject(GameObject value) { }

	public void set_sprite(Sprite value) { }

	public void set_transform(Matrix4x4 value) { }

}

