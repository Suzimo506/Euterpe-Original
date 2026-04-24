//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
public class _2dxFX_EdgeColor : MonoBehaviour
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
	public Color _Color; //Field offset: 0x34
	[HideInInspector]
	public int ShaderChange; //Field offset: 0x44
	private Material tempMaterial; //Field offset: 0x48
	private Material defaultMaterial; //Field offset: 0x50
	private Image CanvasImage; //Field offset: 0x58

	public _2dxFX_EdgeColor() { }

	private void Awake() { }

	public void CallUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

