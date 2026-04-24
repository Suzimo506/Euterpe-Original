//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
public class _2dxFX_Waterfall : MonoBehaviour
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
	public Texture2D __MainTex2; //Field offset: 0x38
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float Liquid; //Field offset: 0x40
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float Speed; //Field offset: 0x44
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float EValue; //Field offset: 0x48
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float TValue; //Field offset: 0x4C
	[HideInInspector]
	public Color LightColor; //Field offset: 0x50
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float Light; //Field offset: 0x60
	[HideInInspector]
	public int ShaderChange; //Field offset: 0x64
	private Material tempMaterial; //Field offset: 0x68
	private Material defaultMaterial; //Field offset: 0x70
	private Image CanvasImage; //Field offset: 0x78

	public _2dxFX_Waterfall() { }

	private void Awake() { }

	public void CallUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

