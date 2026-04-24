namespace UnityEngine.PostProcessing;

public sealed class MaterialFactory : IDisposable
{
	private Dictionary<String, Material> m_Materials; //Field offset: 0x10

	public MaterialFactory() { }

	public override void Dispose() { }

	public Material Get(string shaderName) { }

}

