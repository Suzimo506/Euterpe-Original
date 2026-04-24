namespace Rewired.UI.ControlMapper;

public class ThemeSettings : ScriptableObject
{
	private class CustomAnimationTriggers
	{
		[SerializeField]
		private string m_DisabledTrigger; //Field offset: 0x10
		[SerializeField]
		private string m_HighlightedTrigger; //Field offset: 0x18
		[SerializeField]
		private string m_NormalTrigger; //Field offset: 0x20
		[SerializeField]
		private string m_PressedTrigger; //Field offset: 0x28
		[SerializeField]
		private string m_SelectedTrigger; //Field offset: 0x30
		[SerializeField]
		private string m_DisabledHighlightedTrigger; //Field offset: 0x38

		public string disabledHighlightedTrigger
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public string disabledTrigger
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public string highlightedTrigger
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public string normalTrigger
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public string pressedTrigger
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public string selectedTrigger
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public CustomAnimationTriggers() { }

		public string get_disabledHighlightedTrigger() { }

		public string get_disabledTrigger() { }

		public string get_highlightedTrigger() { }

		public string get_normalTrigger() { }

		public string get_pressedTrigger() { }

		public string get_selectedTrigger() { }

		public static AnimationTriggers op_Implicit(CustomAnimationTriggers item) { }

		public void set_disabledHighlightedTrigger(string value) { }

		public void set_disabledTrigger(string value) { }

		public void set_highlightedTrigger(string value) { }

		public void set_normalTrigger(string value) { }

		public void set_pressedTrigger(string value) { }

		public void set_selectedTrigger(string value) { }

	}

	private struct CustomColorBlock
	{
		[SerializeField]
		private float m_ColorMultiplier; //Field offset: 0x0
		[SerializeField]
		private Color m_DisabledColor; //Field offset: 0x4
		[SerializeField]
		private float m_FadeDuration; //Field offset: 0x14
		[SerializeField]
		private Color m_HighlightedColor; //Field offset: 0x18
		[SerializeField]
		private Color m_NormalColor; //Field offset: 0x28
		[SerializeField]
		private Color m_PressedColor; //Field offset: 0x38
		[SerializeField]
		private Color m_SelectedColor; //Field offset: 0x48
		[SerializeField]
		private Color m_DisabledHighlightedColor; //Field offset: 0x58

		public float colorMultiplier
		{
			 get { } //Length: 5
			 set { } //Length: 5
		}

		public Color disabledColor
		{
			 get { } //Length: 11
			 set { } //Length: 8
		}

		public Color disabledHighlightedColor
		{
			 get { } //Length: 11
			 set { } //Length: 8
		}

		public float fadeDuration
		{
			 get { } //Length: 6
			 set { } //Length: 6
		}

		public Color highlightedColor
		{
			 get { } //Length: 11
			 set { } //Length: 8
		}

		public Color normalColor
		{
			 get { } //Length: 11
			 set { } //Length: 8
		}

		public Color pressedColor
		{
			 get { } //Length: 11
			 set { } //Length: 8
		}

		public Color selectedColor
		{
			 get { } //Length: 11
			 set { } //Length: 8
		}

		public float get_colorMultiplier() { }

		public Color get_disabledColor() { }

		public Color get_disabledHighlightedColor() { }

		public float get_fadeDuration() { }

		public Color get_highlightedColor() { }

		public Color get_normalColor() { }

		public Color get_pressedColor() { }

		public Color get_selectedColor() { }

		public static ColorBlock op_Implicit(CustomColorBlock item) { }

		public void set_colorMultiplier(float value) { }

		public void set_disabledColor(Color value) { }

		public void set_disabledHighlightedColor(Color value) { }

		public void set_fadeDuration(float value) { }

		public void set_highlightedColor(Color value) { }

		public void set_normalColor(Color value) { }

		public void set_pressedColor(Color value) { }

		public void set_selectedColor(Color value) { }

	}

	private struct CustomSpriteState
	{
		[SerializeField]
		private Sprite m_DisabledSprite; //Field offset: 0x0
		[SerializeField]
		private Sprite m_HighlightedSprite; //Field offset: 0x8
		[SerializeField]
		private Sprite m_PressedSprite; //Field offset: 0x10
		[SerializeField]
		private Sprite m_SelectedSprite; //Field offset: 0x18
		[SerializeField]
		private Sprite m_DisabledHighlightedSprite; //Field offset: 0x20

		public Sprite disabledHighlightedSprite
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public Sprite disabledSprite
		{
			 get { } //Length: 4
			 set { } //Length: 8
		}

		public Sprite highlightedSprite
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public Sprite pressedSprite
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public Sprite selectedSprite
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public Sprite get_disabledHighlightedSprite() { }

		public Sprite get_disabledSprite() { }

		public Sprite get_highlightedSprite() { }

		public Sprite get_pressedSprite() { }

		public Sprite get_selectedSprite() { }

		public static SpriteState op_Implicit(CustomSpriteState item) { }

		public void set_disabledHighlightedSprite(Sprite value) { }

		public void set_disabledSprite(Sprite value) { }

		public void set_highlightedSprite(Sprite value) { }

		public void set_pressedSprite(Sprite value) { }

		public void set_selectedSprite(Sprite value) { }

	}

	private enum FontStyleOverride
	{
		Default = 0,
		Normal = 1,
		Bold = 2,
		Italic = 3,
		BoldAndItalic = 4,
	}

	private class ImageSettings
	{
		[SerializeField]
		private Color _color; //Field offset: 0x10
		[SerializeField]
		private Sprite _sprite; //Field offset: 0x20
		[SerializeField]
		private Material _materal; //Field offset: 0x28
		[SerializeField]
		private Type _type; //Field offset: 0x30
		[SerializeField]
		private bool _preserveAspect; //Field offset: 0x34
		[SerializeField]
		private bool _fillCenter; //Field offset: 0x35
		[SerializeField]
		private FillMethod _fillMethod; //Field offset: 0x38
		[SerializeField]
		private float _fillAmout; //Field offset: 0x3C
		[SerializeField]
		private bool _fillClockwise; //Field offset: 0x40
		[SerializeField]
		private int _fillOrigin; //Field offset: 0x44

		public Color color
		{
			 get { } //Length: 11
		}

		public float fillAmout
		{
			 get { } //Length: 6
		}

		public bool fillCenter
		{
			 get { } //Length: 5
		}

		public bool fillClockwise
		{
			 get { } //Length: 5
		}

		public FillMethod fillMethod
		{
			 get { } //Length: 4
		}

		public int fillOrigin
		{
			 get { } //Length: 4
		}

		public Material materal
		{
			 get { } //Length: 5
		}

		public bool preserveAspect
		{
			 get { } //Length: 5
		}

		public Sprite sprite
		{
			 get { } //Length: 5
		}

		public Type type
		{
			 get { } //Length: 4
		}

		public ImageSettings() { }

		public override void CopyTo(Image image) { }

		public Color get_color() { }

		public float get_fillAmout() { }

		public bool get_fillCenter() { }

		public bool get_fillClockwise() { }

		public FillMethod get_fillMethod() { }

		public int get_fillOrigin() { }

		public Material get_materal() { }

		public bool get_preserveAspect() { }

		public Sprite get_sprite() { }

		public Type get_type() { }

	}

	private class ScrollbarSettings : SelectableSettings_Base
	{
		[SerializeField]
		private ImageSettings _handleImageSettings; //Field offset: 0xB0
		[SerializeField]
		private ImageSettings _backgroundImageSettings; //Field offset: 0xB8

		public ImageSettings background
		{
			 get { } //Length: 8
		}

		public ImageSettings handle
		{
			 get { } //Length: 8
		}

		public ScrollbarSettings() { }

		private void Apply(Scrollbar item) { }

		public virtual void Apply(Selectable item) { }

		public ImageSettings get_background() { }

		public ImageSettings get_handle() { }

	}

	private class SelectableSettings : SelectableSettings_Base
	{
		[SerializeField]
		private ImageSettings _imageSettings; //Field offset: 0xB0

		public ImageSettings imageSettings
		{
			 get { } //Length: 8
		}

		public SelectableSettings() { }

		public virtual void Apply(Selectable item) { }

		public ImageSettings get_imageSettings() { }

	}

	private abstract class SelectableSettings_Base
	{
		[SerializeField]
		protected Transition _transition; //Field offset: 0x10
		[SerializeField]
		protected CustomColorBlock _colors; //Field offset: 0x14
		[SerializeField]
		protected CustomSpriteState _spriteState; //Field offset: 0x80
		[SerializeField]
		protected CustomAnimationTriggers _animationTriggers; //Field offset: 0xA8

		public CustomAnimationTriggers animationTriggers
		{
			 get { } //Length: 8
		}

		public CustomColorBlock selectableColors
		{
			 get { } //Length: 61
		}

		public CustomSpriteState spriteState
		{
			 get { } //Length: 134
		}

		public Transition transition
		{
			 get { } //Length: 4
		}

		protected SelectableSettings_Base() { }

		public override void Apply(Selectable item) { }

		public CustomAnimationTriggers get_animationTriggers() { }

		public CustomColorBlock get_selectableColors() { }

		public CustomSpriteState get_spriteState() { }

		public Transition get_transition() { }

	}

	private class SliderSettings : SelectableSettings_Base
	{
		[SerializeField]
		private ImageSettings _handleImageSettings; //Field offset: 0xB0
		[SerializeField]
		private ImageSettings _fillImageSettings; //Field offset: 0xB8
		[SerializeField]
		private ImageSettings _backgroundImageSettings; //Field offset: 0xC0

		public ImageSettings backgroundImageSettings
		{
			 get { } //Length: 8
		}

		public ImageSettings fillImageSettings
		{
			 get { } //Length: 8
		}

		public ImageSettings handleImageSettings
		{
			 get { } //Length: 8
		}

		public SliderSettings() { }

		private void Apply(Slider item) { }

		public virtual void Apply(Selectable item) { }

		public ImageSettings get_backgroundImageSettings() { }

		public ImageSettings get_fillImageSettings() { }

		public ImageSettings get_handleImageSettings() { }

	}

	private class TextSettings
	{
		[SerializeField]
		private Color _color; //Field offset: 0x10
		[SerializeField]
		private Font _font; //Field offset: 0x20
		[SerializeField]
		private FontStyleOverride _style; //Field offset: 0x28
		[SerializeField]
		private float _sizeMultiplier; //Field offset: 0x2C
		[SerializeField]
		private float _lineSpacing; //Field offset: 0x30

		public Color color
		{
			 get { } //Length: 11
		}

		public Font font
		{
			 get { } //Length: 5
		}

		public float lineSpacing
		{
			 get { } //Length: 6
		}

		public float sizeMultiplier
		{
			 get { } //Length: 6
		}

		public FontStyleOverride style
		{
			 get { } //Length: 4
		}

		public TextSettings() { }

		public Color get_color() { }

		public Font get_font() { }

		public float get_lineSpacing() { }

		public float get_sizeMultiplier() { }

		public FontStyleOverride get_style() { }

	}

	[SerializeField]
	private ImageSettings _mainWindowBackground; //Field offset: 0x18
	[SerializeField]
	private ImageSettings _popupWindowBackground; //Field offset: 0x20
	[SerializeField]
	private ImageSettings _areaBackground; //Field offset: 0x28
	[SerializeField]
	private SelectableSettings _selectableSettings; //Field offset: 0x30
	[SerializeField]
	private SelectableSettings _buttonSettings; //Field offset: 0x38
	[SerializeField]
	private SelectableSettings _inputGridFieldSettings; //Field offset: 0x40
	[SerializeField]
	private ScrollbarSettings _scrollbarSettings; //Field offset: 0x48
	[SerializeField]
	private SliderSettings _sliderSettings; //Field offset: 0x50
	[SerializeField]
	private ImageSettings _invertToggle; //Field offset: 0x58
	[SerializeField]
	private Color _invertToggleDisabledColor; //Field offset: 0x60
	[SerializeField]
	private ImageSettings _calibrationBackground; //Field offset: 0x70
	[SerializeField]
	private ImageSettings _calibrationValueMarker; //Field offset: 0x78
	[SerializeField]
	private ImageSettings _calibrationRawValueMarker; //Field offset: 0x80
	[SerializeField]
	private ImageSettings _calibrationZeroMarker; //Field offset: 0x88
	[SerializeField]
	private ImageSettings _calibrationCalibratedZeroMarker; //Field offset: 0x90
	[SerializeField]
	private ImageSettings _calibrationDeadzone; //Field offset: 0x98
	[SerializeField]
	private TextSettings _textSettings; //Field offset: 0xA0
	[SerializeField]
	private TextSettings _buttonTextSettings; //Field offset: 0xA8
	[SerializeField]
	private TextSettings _inputGridFieldTextSettings; //Field offset: 0xB0

	public ThemeSettings() { }

	public void Apply(ElementInfo[] elementInfo) { }

	private void Apply(string themeClass, Component component) { }

	private void Apply(string themeClass, Selectable item) { }

	private void Apply(string themeClass, Image item) { }

	private void Apply(string themeClass, Text item) { }

	private void Apply(string themeClass, UIImageHelper item) { }

	private static FontStyle GetFontStyle(FontStyleOverride style) { }

}

