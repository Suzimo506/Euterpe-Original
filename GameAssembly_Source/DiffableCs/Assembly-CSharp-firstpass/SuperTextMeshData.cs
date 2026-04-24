//Type is in global namespace

[CreateAssetMenu]
public class SuperTextMeshData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<STMWaveData, String> <>9__38_0; //Field offset: 0x8
		public static Func<STMWaveData, STMWaveData> <>9__38_1; //Field offset: 0x10
		public static Func<STMJitterData, String> <>9__38_2; //Field offset: 0x18
		public static Func<STMJitterData, STMJitterData> <>9__38_3; //Field offset: 0x20
		public static Func<STMDrawAnimData, String> <>9__38_4; //Field offset: 0x28
		public static Func<STMDrawAnimData, STMDrawAnimData> <>9__38_5; //Field offset: 0x30
		public static Func<STMColorData, String> <>9__38_6; //Field offset: 0x38
		public static Func<STMColorData, STMColorData> <>9__38_7; //Field offset: 0x40
		public static Func<STMGradientData, String> <>9__38_8; //Field offset: 0x48
		public static Func<STMGradientData, STMGradientData> <>9__38_9; //Field offset: 0x50
		public static Func<STMTextureData, String> <>9__38_10; //Field offset: 0x58
		public static Func<STMTextureData, STMTextureData> <>9__38_11; //Field offset: 0x60
		public static Func<STMDelayData, String> <>9__38_12; //Field offset: 0x68
		public static Func<STMDelayData, STMDelayData> <>9__38_13; //Field offset: 0x70
		public static Func<STMVoiceData, String> <>9__38_14; //Field offset: 0x78
		public static Func<STMVoiceData, STMVoiceData> <>9__38_15; //Field offset: 0x80
		public static Func<STMFontData, String> <>9__38_16; //Field offset: 0x88
		public static Func<STMFontData, STMFontData> <>9__38_17; //Field offset: 0x90
		public static Func<STMSoundClipData, String> <>9__38_18; //Field offset: 0x98
		public static Func<STMSoundClipData, STMSoundClipData> <>9__38_19; //Field offset: 0xA0
		public static Func<STMAudioClipData, String> <>9__38_20; //Field offset: 0xA8
		public static Func<STMAudioClipData, STMAudioClipData> <>9__38_21; //Field offset: 0xB0
		public static Func<STMQuadData, String> <>9__38_22; //Field offset: 0xB8
		public static Func<STMQuadData, STMQuadData> <>9__38_23; //Field offset: 0xC0
		public static Func<STMMaterialData, String> <>9__38_24; //Field offset: 0xC8
		public static Func<STMMaterialData, STMMaterialData> <>9__38_25; //Field offset: 0xD0
		public static Func<STMAutoClipData, String> <>9__38_26; //Field offset: 0xD8
		public static Func<STMAutoClipData, STMAutoClipData> <>9__38_27; //Field offset: 0xE0
		public static Func<STMDelayData, String> <>9__38_28; //Field offset: 0xE8
		public static Func<STMDelayData, STMDelayData> <>9__38_29; //Field offset: 0xF0

		private static <>c() { }

		public <>c() { }

		internal string <RebuildDictionaries>b__38_0(STMWaveData x) { }

		internal STMWaveData <RebuildDictionaries>b__38_1(STMWaveData x) { }

		internal string <RebuildDictionaries>b__38_10(STMTextureData x) { }

		internal STMTextureData <RebuildDictionaries>b__38_11(STMTextureData x) { }

		internal string <RebuildDictionaries>b__38_12(STMDelayData x) { }

		internal STMDelayData <RebuildDictionaries>b__38_13(STMDelayData x) { }

		internal string <RebuildDictionaries>b__38_14(STMVoiceData x) { }

		internal STMVoiceData <RebuildDictionaries>b__38_15(STMVoiceData x) { }

		internal string <RebuildDictionaries>b__38_16(STMFontData x) { }

		internal STMFontData <RebuildDictionaries>b__38_17(STMFontData x) { }

		internal string <RebuildDictionaries>b__38_18(STMSoundClipData x) { }

		internal STMSoundClipData <RebuildDictionaries>b__38_19(STMSoundClipData x) { }

		internal string <RebuildDictionaries>b__38_2(STMJitterData x) { }

		internal string <RebuildDictionaries>b__38_20(STMAudioClipData x) { }

		internal STMAudioClipData <RebuildDictionaries>b__38_21(STMAudioClipData x) { }

		internal string <RebuildDictionaries>b__38_22(STMQuadData x) { }

		internal STMQuadData <RebuildDictionaries>b__38_23(STMQuadData x) { }

		internal string <RebuildDictionaries>b__38_24(STMMaterialData x) { }

		internal STMMaterialData <RebuildDictionaries>b__38_25(STMMaterialData x) { }

		internal string <RebuildDictionaries>b__38_26(STMAutoClipData x) { }

		internal STMAutoClipData <RebuildDictionaries>b__38_27(STMAutoClipData x) { }

		internal string <RebuildDictionaries>b__38_28(STMDelayData x) { }

		internal STMDelayData <RebuildDictionaries>b__38_29(STMDelayData x) { }

		internal STMJitterData <RebuildDictionaries>b__38_3(STMJitterData x) { }

		internal string <RebuildDictionaries>b__38_4(STMDrawAnimData x) { }

		internal STMDrawAnimData <RebuildDictionaries>b__38_5(STMDrawAnimData x) { }

		internal string <RebuildDictionaries>b__38_6(STMColorData x) { }

		internal STMColorData <RebuildDictionaries>b__38_7(STMColorData x) { }

		internal string <RebuildDictionaries>b__38_8(STMGradientData x) { }

		internal STMGradientData <RebuildDictionaries>b__38_9(STMGradientData x) { }

	}

	[HideInInspector]
	public bool textDataEditMode; //Field offset: 0x18
	[HideInInspector]
	public bool showEffectsFoldout; //Field offset: 0x19
	[HideInInspector]
	public bool showWavesFoldout; //Field offset: 0x1A
	public Dictionary<String, STMWaveData> waves; //Field offset: 0x20
	[HideInInspector]
	public bool showJittersFoldout; //Field offset: 0x28
	public Dictionary<String, STMJitterData> jitters; //Field offset: 0x30
	[HideInInspector]
	public bool showDrawAnimsFoldout; //Field offset: 0x38
	public Dictionary<String, STMDrawAnimData> drawAnims; //Field offset: 0x40
	[HideInInspector]
	public bool showTextColorFoldout; //Field offset: 0x48
	[HideInInspector]
	public bool showColorsFoldout; //Field offset: 0x49
	public Dictionary<String, STMColorData> colors; //Field offset: 0x50
	[HideInInspector]
	public bool showGradientsFoldout; //Field offset: 0x58
	public Dictionary<String, STMGradientData> gradients; //Field offset: 0x60
	[HideInInspector]
	public bool showTexturesFoldout; //Field offset: 0x68
	public Dictionary<String, STMTextureData> textures; //Field offset: 0x70
	[HideInInspector]
	public bool showInlineFoldout; //Field offset: 0x78
	[HideInInspector]
	public bool showDelaysFoldout; //Field offset: 0x79
	public Dictionary<String, STMDelayData> delays; //Field offset: 0x80
	[HideInInspector]
	public bool showVoicesFoldout; //Field offset: 0x88
	public Dictionary<String, STMVoiceData> voices; //Field offset: 0x90
	[HideInInspector]
	public bool showFontsFoldout; //Field offset: 0x98
	public Dictionary<String, STMFontData> fonts; //Field offset: 0xA0
	[HideInInspector]
	public bool showSoundClipsFoldout; //Field offset: 0xA8
	public Dictionary<String, STMSoundClipData> soundClips; //Field offset: 0xB0
	[HideInInspector]
	public bool showAudioClipsFoldout; //Field offset: 0xB8
	public Dictionary<String, STMAudioClipData> audioClips; //Field offset: 0xC0
	[HideInInspector]
	public bool showQuadsFoldout; //Field offset: 0xC8
	public Dictionary<String, STMQuadData> quads; //Field offset: 0xD0
	[HideInInspector]
	public bool showMaterialsFoldout; //Field offset: 0xD8
	public Dictionary<String, STMMaterialData> materials; //Field offset: 0xE0
	[HideInInspector]
	public bool showAutomaticFoldout; //Field offset: 0xE8
	[HideInInspector]
	public bool showAutoClipsFoldout; //Field offset: 0xE9
	public Dictionary<String, STMAutoClipData> autoClips; //Field offset: 0xF0
	[HideInInspector]
	public bool showAutoDelaysFoldout; //Field offset: 0xF8
	public Dictionary<String, STMDelayData> autoDelays; //Field offset: 0x100
	[HideInInspector]
	public bool showMasterFoldout; //Field offset: 0x108
	public bool disableAnimatedText; //Field offset: 0x109
	public string autoVoice; //Field offset: 0x110

	public SuperTextMeshData() { }

	public void RebuildDictionaries() { }

}

