//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
public class _2dxFX_GrassMultiFX : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial; //Field offset: 0x18
	[HideInInspector]
	public bool ActiveChange; //Field offset: 0x20
	private string shader; //Field offset: 0x28
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float _Alpha; //Field offset: 0x30
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float Heat; //Field offset: 0x34
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float Speed; //Field offset: 0x38
	private AnimationCurve Wind; //Field offset: 0x40
	private float WindTime1; //Field offset: 0x48
	private float WindTime2; //Field offset: 0x4C
	private float WindTime3; //Field offset: 0x50
	private float WindTime4; //Field offset: 0x54
	[HideInInspector]
	public int ShaderChange; //Field offset: 0x58
	private Material tempMaterial; //Field offset: 0x60
	private Material defaultMaterial; //Field offset: 0x68
	private Image CanvasImage; //Field offset: 0x70

	public _2dxFX_GrassMultiFX() { }

	private void Awake() { }

	public void CallUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

