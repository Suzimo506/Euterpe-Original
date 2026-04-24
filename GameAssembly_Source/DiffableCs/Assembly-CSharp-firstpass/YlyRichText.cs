//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class YlyRichText : MaskableGraphic, ILayoutElement, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
	private class AssetData
	{
		public string assetPath; //Field offset: 0x10
		public int aType; //Field offset: 0x18
		public object obj; //Field offset: 0x20
		public float x; //Field offset: 0x28
		public float y; //Field offset: 0x2C
		public float width; //Field offset: 0x30
		public float height; //Field offset: 0x34

		public AssetData() { }

	}

	private class CalcCharData
	{
		public int i; //Field offset: 0x10
		public int blockType; //Field offset: 0x14
		public int blockLen; //Field offset: 0x18
		public float charX; //Field offset: 0x1C
		public float charW; //Field offset: 0x20
		public int lastBlockType; //Field offset: 0x24
		public Color sclr; //Field offset: 0x28
		public Color eclr; //Field offset: 0x38
		public float advanceX; //Field offset: 0x48
		public float offcharX; //Field offset: 0x4C
		public FontStyle fontStyle; //Field offset: 0x50
		public int fontSize; //Field offset: 0x54
		public bool isSpaceOrTabChar; //Field offset: 0x58
		public WireData underWireData; //Field offset: 0x60
		public WireData deleteWireData; //Field offset: 0x68
		public AssetData assetData; //Field offset: 0x70
		public LinkData linkData; //Field offset: 0x78
		public LineData linedata; //Field offset: 0x80

		public CalcCharData() { }

	}

	private class CharData
	{
		public CharType cType; //Field offset: 0x10
		public UIVertex[] vertices; //Field offset: 0x18

		public CharData() { }

	}

	private enum CharType
	{
		Normal = 0,
		UnderWire = 1,
		DeleteWire = 2,
	}

	private class LineData
	{
		public float x; //Field offset: 0x10
		public float y; //Field offset: 0x14
		public float z; //Field offset: 0x18
		public float width; //Field offset: 0x1C
		public float height; //Field offset: 0x20
		public float charMaxHeight; //Field offset: 0x24
		public float charMinY; //Field offset: 0x28
		public float charMaxY; //Field offset: 0x2C
		public YlyRichText ylyRichText; //Field offset: 0x30
		public List<CharData> charDatas; //Field offset: 0x38
		public List<AssetData> assetDatas; //Field offset: 0x40
		public List<LinkData> linkDatas; //Field offset: 0x48

		public LineData() { }

		public void AddAssetData(AssetData assetData, float emoteX) { }

		public void AddCharData(char cstr, CharacterInfo ci, float charBeginX, float charEndX, Color32 topColor, Color32 bottomColor) { }

		public void AddLinkData(LinkData linkData, float endX) { }

		public bool AddWireData(WireData wireData) { }

		public void OnFinish() { }

		public void OnPopulateCharMesh(ref VertexHelper vh, ref int j) { }

	}

	private class LinkData
	{
		public Rect rect; //Field offset: 0x10
		public string arg; //Field offset: 0x20

		public LinkData() { }

	}

	private class WireData
	{
		public WireType wireType; //Field offset: 0x10
		public float beginX; //Field offset: 0x14
		public float endX; //Field offset: 0x18
		public Color32 uColor; //Field offset: 0x1C
		public int fontSize; //Field offset: 0x20

		public WireData() { }

	}

	private enum WireType
	{
		UnderWire = 0,
		DeleteWire = 1,
	}

	public static string emotePngPathFormat; //Field offset: 0x0
	public static string animEmotePrefabPathFormat; //Field offset: 0x8
	public static string cIconPngPathFormat; //Field offset: 0x10
	public StringDelegate onLinkClick; //Field offset: 0xC8
	[SerializeField]
	[TextArea]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string m_Text; //Field offset: 0xD0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Font m_Font; //Field offset: 0xD8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int m_FontSize; //Field offset: 0xE0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float m_LineHeght; //Field offset: 0xE4
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float m_LineSpacing; //Field offset: 0xE8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float m_OffCharX; //Field offset: 0xEC
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_IsCustomWidthToNewLine; //Field offset: 0xF0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float m_CustomWidthToNewLine; //Field offset: 0xF4
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_IsNeedOutLine; //Field offset: 0xF8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Color32 m_OutLineColor; //Field offset: 0xFC
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Color32 m_TColor; //Field offset: 0x100
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_IsAutoAdaptiveWidthHeight; //Field offset: 0x104
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private HorizontalWrapMode m_HorizontalOverflow; //Field offset: 0x108
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private VerticalWrapMode m_VerticalOverflow; //Field offset: 0x10C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TextAnchor m_Alignment; //Field offset: 0x110
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_EnableRichText; //Field offset: 0x114
	private List<LineData> m_Lines; //Field offset: 0x118
	private Dictionary<String, AssetData> m_AssetDataDict; //Field offset: 0x120
	private float m_PreferredHeight; //Field offset: 0x128
	private float m_PreferredWidth; //Field offset: 0x12C
	private Int32[] m_StrMask; //Field offset: 0x130
	private Dictionary<Int32, String> m_ParamDict; //Field offset: 0x138
	private Dictionary<String, Int32> m_PreLoadAssetDic; //Field offset: 0x140
	private string m_ParsedText; //Field offset: 0x148
	private string m_RefHeightGoName; //Field offset: 0x150
	private bool m_IsFontTextureDirty; //Field offset: 0x158
	private bool m_IsPopulateMeshDone; //Field offset: 0x159
	private bool m_IsDrag; //Field offset: 0x15A

	public TextAnchor alignment
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	public virtual Color color
	{
		 get { } //Length: 43
		 set { } //Length: 60
	}

	public float customWidthToNewLine
	{
		 get { } //Length: 9
		 set { } //Length: 15
	}

	public bool enableRichText
	{
		 get { } //Length: 8
		 set { } //Length: 37
	}

	public override float flexibleHeight
	{
		 get { } //Length: 9
	}

	public override float flexibleWidth
	{
		 get { } //Length: 9
	}

	public Font font
	{
		 get { } //Length: 8
		 set { } //Length: 39
	}

	public int fontSize
	{
		 get { } //Length: 7
		 set { } //Length: 23
	}

	public HorizontalWrapMode horizontalOverflow
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	public bool isAutoAdaptiveWidthHeight
	{
		 get { } //Length: 8
		 set { } //Length: 13
	}

	public bool isCustomWidthToNewLine
	{
		 get { } //Length: 8
		 set { } //Length: 13
	}

	public bool isNeedOutLine
	{
		 get { } //Length: 8
		 set { } //Length: 13
	}

	public override int layoutPriority
	{
		 get { } //Length: 3
	}

	public float lineHeght
	{
		 get { } //Length: 9
		 set { } //Length: 15
	}

	public float lineSpacing
	{
		 get { } //Length: 9
		 set { } //Length: 15
	}

	public virtual Texture mainTexture
	{
		 get { } //Length: 489
	}

	public override float minHeight
	{
		 get { } //Length: 4
	}

	public override float minWidth
	{
		 get { } //Length: 4
	}

	public float offCharX
	{
		 get { } //Length: 9
		 set { } //Length: 15
	}

	public Color32 outLineColor
	{
		 get { } //Length: 7
		 set { } //Length: 23
	}

	public override float preferredHeight
	{
		 get { } //Length: 9
	}

	public override float preferredWidth
	{
		 get { } //Length: 9
	}

	public string text
	{
		 get { } //Length: 8
		 set { } //Length: 184
	}

	public VerticalWrapMode verticalOverflow
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	private static YlyRichText() { }

	protected YlyRichText() { }

	private void CalcAlign() { }

	private void CalcBoldBegin(CalcCharData ccData) { }

	private void CalcBoldEnd(CalcCharData ccData) { }

	private void CalcCIcon(CalcCharData ccData, ref CharacterInfo ci) { }

	private bool CalcColorBegin(CalcCharData ccData) { }

	private void CalcColorEnd(CalcCharData ccData) { }

	private void CalcDelLineBegin(CalcCharData ccData) { }

	private void CalcDelLineEnd(CalcCharData ccData) { }

	private void CalcEmote(CalcCharData ccData, ref CharacterInfo ci) { }

	private bool CalcFontSizeBegin(CalcCharData ccData) { }

	private void CalcFontSizeEnd(CalcCharData ccData) { }

	private void CalcItalicBegin(CalcCharData ccData) { }

	private void CalcItalicEnd(CalcCharData ccData) { }

	private bool CalcLinkBegin(CalcCharData ccData) { }

	private bool CalcLinkEnd(CalcCharData ccData) { }

	private bool CalcNewLine(CalcCharData ccData, int strLen, ref float totalWidth, ref float totalHeight) { }

	private void CalcNormalChar(CalcCharData ccData, ref CharacterInfo ci) { }

	private void CalcPic(CalcCharData ccData, ref CharacterInfo ci) { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	private void CalcUnderLineBegin(CalcCharData ccData) { }

	private bool CalcUnderLineEnd(CalcCharData ccData) { }

	private void ClearAssetGo() { }

	private void FontTextureRebuilt(Font changedFont) { }

	public TextAnchor get_alignment() { }

	public virtual Color get_color() { }

	public float get_customWidthToNewLine() { }

	public bool get_enableRichText() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	public Font get_font() { }

	public int get_fontSize() { }

	public HorizontalWrapMode get_horizontalOverflow() { }

	public bool get_isAutoAdaptiveWidthHeight() { }

	public bool get_isCustomWidthToNewLine() { }

	public bool get_isNeedOutLine() { }

	public override int get_layoutPriority() { }

	public float get_lineHeght() { }

	public float get_lineSpacing() { }

	public virtual Texture get_mainTexture() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public float get_offCharX() { }

	public Color32 get_outLineColor() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	public string get_text() { }

	public VerticalWrapMode get_verticalOverflow() { }

	private object LoadAsset(string assetPath, Type assetType) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	protected virtual void OnRectTransformDimensionsChange() { }

	private void ParseText() { }

	private void PreLoadAsset() { }

	public void set_alignment(TextAnchor value) { }

	public virtual void set_color(Color value) { }

	public void set_customWidthToNewLine(float value) { }

	public void set_enableRichText(bool value) { }

	public void set_font(Font value) { }

	public void set_fontSize(int value) { }

	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	public void set_isAutoAdaptiveWidthHeight(bool value) { }

	public void set_isCustomWidthToNewLine(bool value) { }

	public void set_isNeedOutLine(bool value) { }

	public void set_lineHeght(float value) { }

	public void set_lineSpacing(float value) { }

	public void set_offCharX(float value) { }

	public void set_outLineColor(Color32 value) { }

	public void set_text(string value) { }

	public void set_verticalOverflow(VerticalWrapMode value) { }

	protected virtual void Start() { }

	private void Update() { }

	private void UpdateAssetGo() { }

	private void UpdateLines() { }

}

