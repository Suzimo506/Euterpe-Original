namespace UnityEngine.Rendering;

public struct FilteringSettings : IEquatable<FilteringSettings>
{
	private RenderQueueRange m_RenderQueueRange; //Field offset: 0x0
	private int m_LayerMask; //Field offset: 0x8
	private uint m_RenderingLayerMask; //Field offset: 0xC
	private int m_ExcludeMotionVectorObjects; //Field offset: 0x10
	private SortingLayerRange m_SortingLayerRange; //Field offset: 0x14

	public bool excludeMotionVectorObjects
	{
		 set { } //Length: 9
	}

	public FilteringSettings(Nullable<RenderQueueRange> renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = 4294967295, int excludeMotionVectorObjects = 0) { }

	public override bool Equals(FilteringSettings other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void set_excludeMotionVectorObjects(bool value) { }

}

