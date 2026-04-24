namespace UnityEngine.TextCore.LowLevel;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public struct GlyphPairAdjustmentRecord
{
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x0
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x14
	[SerializeField]
	private FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x28

	public FontFeatureLookupFlags featureLookupFlags
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public GlyphAdjustmentRecord firstAdjustmentRecord
	{
		 get { } //Length: 16
		 set { } //Length: 13
	}

	public GlyphAdjustmentRecord secondAdjustmentRecord
	{
		 get { } //Length: 17
		 set { } //Length: 14
	}

	public GlyphPairAdjustmentRecord(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord) { }

	public FontFeatureLookupFlags get_featureLookupFlags() { }

	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	public void set_firstAdjustmentRecord(GlyphAdjustmentRecord value) { }

	public void set_secondAdjustmentRecord(GlyphAdjustmentRecord value) { }

}

