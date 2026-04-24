//Type is in global namespace

[CreateAssetMenu]
public class STMTextureData : ScriptableObject
{
	public Texture texture; //Field offset: 0x18
	public FilterMode filterMode; //Field offset: 0x20
	public bool relativeToLetter; //Field offset: 0x24
	public bool scaleWithText; //Field offset: 0x25
	public Vector2 tiling; //Field offset: 0x28
	public Vector2 offset; //Field offset: 0x30
	public Vector2 scrollSpeed; //Field offset: 0x38

	public STMTextureData() { }

}

