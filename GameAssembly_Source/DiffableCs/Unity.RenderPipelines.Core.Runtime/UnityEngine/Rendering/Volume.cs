namespace UnityEngine.Rendering;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Volume : MonoBehaviour
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool isGlobal; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float priority; //Field offset: 0x1C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float blendDistance; //Field offset: 0x20
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float weight; //Field offset: 0x24
	public VolumeProfile sharedProfile; //Field offset: 0x28
	private int m_PreviousLayer; //Field offset: 0x30
	private float m_PreviousPriority; //Field offset: 0x34
	private VolumeProfile m_InternalProfile; //Field offset: 0x38

	public VolumeProfile profile
	{
		 get { } //Length: 465
		 set { } //Length: 12
	}

	internal VolumeProfile profileRef
	{
		internal get { } //Length: 121
	}

	public Volume() { }

	public VolumeProfile get_profile() { }

	internal VolumeProfile get_profileRef() { }

	public bool HasInstantiatedProfile() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void set_profile(VolumeProfile value) { }

	private void Update() { }

	internal void UpdateLayer() { }

}

