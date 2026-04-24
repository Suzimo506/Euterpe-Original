//Type is in global namespace

public class CircleExpansionController : MonoBehaviour
{
	private Material material; //Field offset: 0x18
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float density; //Field offset: 0x20
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float circleRange; //Field offset: 0x24
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float thickness; //Field offset: 0x28
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float speed; //Field offset: 0x2C
	private float m_Speed; //Field offset: 0x30
	private float m_Density; //Field offset: 0x34
	private float m_CircleRange; //Field offset: 0x38
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float circleRangeTime; //Field offset: 0x3C
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float thicknessTime; //Field offset: 0x40

	public CircleExpansionController() { }

	private void Awake() { }

	private void Update() { }

}

