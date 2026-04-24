//Type is in global namespace

public class OldTvSample : MonoBehaviour
{
	public MeshRenderer renderer; //Field offset: 0x18
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int downSample; //Field offset: 0x20
	public FilterMode filterMode; //Field offset: 0x24
	private SkeletonAnimation skeletonAnimation; //Field offset: 0x28
	private Camera m_Camera; //Field offset: 0x30
	private CommandBuffer m_Buffer; //Field offset: 0x38
	private Material m_DownSampleMat; //Field offset: 0x40
	private string startEventName; //Field offset: 0x48
	private string endEventName; //Field offset: 0x50
	private int m_ScreenId; //Field offset: 0x58
	private int m_ScreenId2; //Field offset: 0x5C
	private int m_TexId; //Field offset: 0x60
	private int m_ObjectInfoId; //Field offset: 0x64

	public OldTvSample() { }

	private void Awake() { }

	private void HandleSpineEvent(TrackEntry trackEntry, Event e) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void OnUpdateRenderInfo() { }

	public void Refresh() { }

}

