namespace UnityEngine.Rendering;

public struct DrawingSettings : IEquatable<DrawingSettings>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <shaderPassNames>e__FixedBuffer
	{
		public int FixedElementField; //Field offset: 0x0

	}

	public static readonly int maxShaderPasses; //Field offset: 0x0
	private SortingSettings m_SortingSettings; //Field offset: 0x0
	[FixedBuffer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal <shaderPassNames>e__FixedBuffer shaderPassNames; //Field offset: 0xE0
	private PerObjectData m_PerObjectData; //Field offset: 0x120
	private DrawRendererFlags m_Flags; //Field offset: 0x124
	private int m_OverrideMaterialInstanceId; //Field offset: 0x128
	private int m_OverrideMaterialPassIndex; //Field offset: 0x12C
	private int m_MainLightIndex; //Field offset: 0x130
	private int m_UseSrpBatcher; //Field offset: 0x134

	public bool enableDynamicBatching
	{
		 set { } //Length: 31
	}

	public bool enableInstancing
	{
		 set { } //Length: 31
	}

	public int mainLightIndex
	{
		 set { } //Length: 7
	}

	public Material overrideMaterial
	{
		 set { } //Length: 55
	}

	public int overrideMaterialPassIndex
	{
		 set { } //Length: 7
	}

	public PerObjectData perObjectData
	{
		 set { } //Length: 7
	}

	private static DrawingSettings() { }

	public DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	public override bool Equals(DrawingSettings other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public ShaderTagId GetShaderPassName(int index) { }

	public void set_enableDynamicBatching(bool value) { }

	public void set_enableInstancing(bool value) { }

	public void set_mainLightIndex(int value) { }

	public void set_overrideMaterial(Material value) { }

	public void set_overrideMaterialPassIndex(int value) { }

	public void set_perObjectData(PerObjectData value) { }

	public void SetShaderPassName(int index, ShaderTagId shaderPassName) { }

}

