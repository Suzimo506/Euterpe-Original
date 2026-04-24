//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
public class _2dxFX_Distortion_Additive : MonoBehaviour
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
	public float _OffsetX; //Field offset: 0x34
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float _OffsetY; //Field offset: 0x38
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float _DistanceX; //Field offset: 0x3C
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float _DistanceY; //Field offset: 0x40
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float _WaveTimeX; //Field offset: 0x44
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float _WaveTimeY; //Field offset: 0x48
	[HideInInspector]
	public bool AutoPlayWaveX; //Field offset: 0x4C
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float AutoPlaySpeedX; //Field offset: 0x50
	[HideInInspector]
	public bool AutoPlayWaveY; //Field offset: 0x54
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float AutoPlaySpeedY; //Field offset: 0x58
	[HideInInspector]
	public bool AutoRandom; //Field offset: 0x5C
	[HideInInspector]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float AutoRandomRange; //Field offset: 0x60
	[HideInInspector]
	public int ShaderChange; //Field offset: 0x64
	private Material tempMaterial; //Field offset: 0x68
	private Material defaultMaterial; //Field offset: 0x70
	private Image CanvasImage; //Field offset: 0x78

	public _2dxFX_Distortion_Additive() { }

	private void Awake() { }

	public void CallUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

