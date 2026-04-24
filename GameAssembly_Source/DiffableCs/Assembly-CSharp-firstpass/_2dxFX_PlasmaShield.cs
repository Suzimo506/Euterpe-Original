//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
public class _2dxFX_PlasmaShield : MonoBehaviour
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
	public Color _ColorX; //Field offset: 0x34
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float _Offset; //Field offset: 0x44
	[HideInInspector]
	private float _TimeX; //Field offset: 0x48
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float Speed; //Field offset: 0x4C
	[HideInInspector]
	public int ShaderChange; //Field offset: 0x50
	private Material tempMaterial; //Field offset: 0x58
	private Material defaultMaterial; //Field offset: 0x60
	private Image CanvasImage; //Field offset: 0x68

	public _2dxFX_PlasmaShield() { }

	private void Awake() { }

	public void CallUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

