namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class ScriptableRendererFeature : ScriptableObject
{
	[HideInInspector]
	[SerializeField]
	private bool m_Active; //Field offset: 0x18

	public bool isActive
	{
		 get { } //Length: 5
	}

	protected ScriptableRendererFeature() { }

	public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public abstract void Create() { }

	public bool get_isActive() { }

	private void OnEnable() { }

	private void OnValidate() { }

	public void SetActive(bool active) { }

}

