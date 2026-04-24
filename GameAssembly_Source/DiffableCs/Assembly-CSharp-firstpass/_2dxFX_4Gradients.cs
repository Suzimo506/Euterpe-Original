//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
public class _2dxFX_4Gradients : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial; //Field offset: 0x18
	[HideInInspector]
	public bool ActiveChange; //Field offset: 0x20
	private string shader; //Field offset: 0x28
	[HideInInspector]
	public Color _Color1; //Field offset: 0x30
	[HideInInspector]
	public Color _Color2; //Field offset: 0x40
	[HideInInspector]
	public Color _Color3; //Field offset: 0x50
	[HideInInspector]
	public Color _Color4; //Field offset: 0x60
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float _Alpha; //Field offset: 0x70
	[HideInInspector]
	public int ShaderChange; //Field offset: 0x74
	private Material tempMaterial; //Field offset: 0x78
	private Material defaultMaterial; //Field offset: 0x80
	private Image CanvasImage; //Field offset: 0x88

	public _2dxFX_4Gradients() { }

	private void Awake() { }

	public void CallUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

