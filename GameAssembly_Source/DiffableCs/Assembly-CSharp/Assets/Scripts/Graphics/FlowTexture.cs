namespace Assets.Scripts.Graphics;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
public class FlowTexture : MonoBehaviour
{
	public Texture flowTexture; //Field offset: 0x18
	public Vector2 scale; //Field offset: 0x20
	public Color flowTextureColor; //Field offset: 0x28
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float flowSpeedX; //Field offset: 0x38
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float flowSpeedY; //Field offset: 0x3C
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float offsetX; //Field offset: 0x40
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float offsetY; //Field offset: 0x44
	public Shader shader; //Field offset: 0x48
	private Material m_Material; //Field offset: 0x50
	private int m_FlowTexId; //Field offset: 0x58
	private int m_FlowColorId; //Field offset: 0x5C
	private int m_FlowScaleXId; //Field offset: 0x60
	private int m_FlowScaleYId; //Field offset: 0x64
	private int m_SpeedXId; //Field offset: 0x68
	private int m_SpeedYId; //Field offset: 0x6C
	private int m_OffsetXId; //Field offset: 0x70
	private int m_OffsetYId; //Field offset: 0x74

	public FlowTexture() { }

	public void SetParas() { }

	private void Start() { }

}

