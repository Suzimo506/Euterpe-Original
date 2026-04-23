using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Serializable]
[Token(Token = "0x2000206")]
public class ThemeSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000A9C")]
	private abstract class SelectableSettings_Base
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40037D4")]
		protected Selectable.Transition _transition;

		[SerializeField]
		[Token(Token = "0x40037D5")]
		[FieldOffset(Offset = "0x14")]
		protected CustomColorBlock _colors;

		[SerializeField]
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40037D6")]
		protected CustomSpriteState _spriteState;

		[SerializeField]
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40037D7")]
		protected CustomAnimationTriggers _animationTriggers;

		[Token(Token = "0x17000A05")]
		public Selectable.Transition transition
		{
			[Token(Token = "0x6005B32")]
			[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
			get
			{
				return default(Selectable.Transition);
			}
		}

		[Token(Token = "0x17000A06")]
		public CustomColorBlock selectableColors
		{
			[Address(RVA = "0xDCA280", Offset = "0xDC8A80", Length = "0x3D")]
			[Token(Token = "0x6005B33")]
			get
			{
				return default(CustomColorBlock);
			}
		}

		[Token(Token = "0x17000A07")]
		public CustomSpriteState spriteState
		{
			[Token(Token = "0x6005B34")]
			[Address(RVA = "0xDCA2C0", Offset = "0xDC8AC0", Length = "0x86")]
			get
			{
				return default(CustomSpriteState);
			}
		}

		[Token(Token = "0x17000A08")]
		public CustomAnimationTriggers animationTriggers
		{
			[Token(Token = "0x6005B35")]
			[Address(RVA = "0x460250", Offset = "0x45EA50", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xDC9D10", Offset = "0xDC8510", Length = "0x562")]
		[Token(Token = "0x6005B36")]
		public virtual void Apply(Selectable item)
		{
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005B37")]
		protected SelectableSettings_Base()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A9D")]
	private class SelectableSettings : SelectableSettings_Base
	{
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40037D8")]
		[SerializeField]
		private ImageSettings _imageSettings;

		[Token(Token = "0x17000A09")]
		public ImageSettings imageSettings
		{
			[Address(RVA = "0x49A8E0", Offset = "0x4990E0", Length = "0x8")]
			[Token(Token = "0x6005B38")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xDC9C20", Offset = "0xDC8420", Length = "0xE1")]
		[Token(Token = "0x6005B39")]
		public override void Apply(Selectable item)
		{
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005B3A")]
		public SelectableSettings()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A9E")]
	private class SliderSettings : SelectableSettings_Base
	{
		[Token(Token = "0x40037D9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ImageSettings _handleImageSettings;

		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Token(Token = "0x40037DA")]
		private ImageSettings _fillImageSettings;

		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40037DB")]
		[SerializeField]
		private ImageSettings _backgroundImageSettings;

		[Token(Token = "0x17000A0A")]
		public ImageSettings handleImageSettings
		{
			[Token(Token = "0x6005B3B")]
			[Address(RVA = "0x49A8E0", Offset = "0x4990E0", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0B")]
		public ImageSettings fillImageSettings
		{
			[Token(Token = "0x6005B3C")]
			[Address(RVA = "0x49A890", Offset = "0x499090", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0C")]
		public ImageSettings backgroundImageSettings
		{
			[Token(Token = "0x6005B3D")]
			[Address(RVA = "0x49A8D0", Offset = "0x4990D0", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xDCA3E0", Offset = "0xDC8BE0", Length = "0x21C")]
		[Token(Token = "0x6005B3E")]
		private void Apply(Slider item)
		{
		}

		[Address(RVA = "0xDCA350", Offset = "0xDC8B50", Length = "0x8C")]
		[Token(Token = "0x6005B3F")]
		public override void Apply(Selectable item)
		{
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005B40")]
		public SliderSettings()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A9F")]
	private class ScrollbarSettings : SelectableSettings_Base
	{
		[SerializeField]
		[Token(Token = "0x40037DC")]
		[FieldOffset(Offset = "0xB0")]
		private ImageSettings _handleImageSettings;

		[SerializeField]
		[Token(Token = "0x40037DD")]
		[FieldOffset(Offset = "0xB8")]
		private ImageSettings _backgroundImageSettings;

		[Token(Token = "0x17000A0D")]
		public ImageSettings handle
		{
			[Token(Token = "0x6005B41")]
			[Address(RVA = "0x49A8E0", Offset = "0x4990E0", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0E")]
		public ImageSettings background
		{
			[Address(RVA = "0x49A890", Offset = "0x499090", Length = "0x8")]
			[Token(Token = "0x6005B42")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xDC9B00", Offset = "0xDC8300", Length = "0x112")]
		[Token(Token = "0x6005B43")]
		private void Apply(Scrollbar item)
		{
		}

		[Token(Token = "0x6005B44")]
		[Address(RVA = "0xDC9970", Offset = "0xDC8170", Length = "0x18F")]
		public override void Apply(Selectable item)
		{
		}

		[Token(Token = "0x6005B45")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public ScrollbarSettings()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000AA0")]
	private class ImageSettings
	{
		[SerializeField]
		[Token(Token = "0x40037DE")]
		[FieldOffset(Offset = "0x10")]
		private Color _color;

		[SerializeField]
		[Token(Token = "0x40037DF")]
		[FieldOffset(Offset = "0x20")]
		private Sprite _sprite;

		[Token(Token = "0x40037E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material _materal;

		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Token(Token = "0x40037E1")]
		private Image.Type _type;

		[SerializeField]
		[Token(Token = "0x40037E2")]
		[FieldOffset(Offset = "0x34")]
		private bool _preserveAspect;

		[FieldOffset(Offset = "0x35")]
		[Token(Token = "0x40037E3")]
		[SerializeField]
		private bool _fillCenter;

		[SerializeField]
		[Token(Token = "0x40037E4")]
		[FieldOffset(Offset = "0x38")]
		private Image.FillMethod _fillMethod;

		[SerializeField]
		[Token(Token = "0x40037E5")]
		[FieldOffset(Offset = "0x3C")]
		private float _fillAmout;

		[SerializeField]
		[Token(Token = "0x40037E6")]
		[FieldOffset(Offset = "0x40")]
		private bool _fillClockwise;

		[Token(Token = "0x40037E7")]
		[SerializeField]
		[FieldOffset(Offset = "0x44")]
		private int _fillOrigin;

		[Token(Token = "0x17000A0F")]
		public Color color
		{
			[Address(RVA = "0x674C60", Offset = "0x673460", Length = "0xB")]
			[Token(Token = "0x6005B46")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x17000A10")]
		public Sprite sprite
		{
			[Token(Token = "0x6005B47")]
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A11")]
		public Material materal
		{
			[Token(Token = "0x6005B48")]
			[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A12")]
		public Image.Type type
		{
			[Token(Token = "0x6005B49")]
			[Address(RVA = "0x597020", Offset = "0x595820", Length = "0x4")]
			get
			{
				return default(Image.Type);
			}
		}

		[Token(Token = "0x17000A13")]
		public bool preserveAspect
		{
			[Address(RVA = "0x7256E0", Offset = "0x723EE0", Length = "0x5")]
			[Token(Token = "0x6005B4A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000A14")]
		public bool fillCenter
		{
			[Address(RVA = "0x4E2200", Offset = "0x4E0A00", Length = "0x5")]
			[Token(Token = "0x6005B4B")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000A15")]
		public Image.FillMethod fillMethod
		{
			[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
			[Token(Token = "0x6005B4C")]
			get
			{
				return default(Image.FillMethod);
			}
		}

		[Token(Token = "0x17000A16")]
		public float fillAmout
		{
			[Token(Token = "0x6005B4D")]
			[Address(RVA = "0xDA9CA0", Offset = "0xDA84A0", Length = "0x6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000A17")]
		public bool fillClockwise
		{
			[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
			[Token(Token = "0x6005B4E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000A18")]
		public int fillOrigin
		{
			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0x782D10", Offset = "0x781510", Length = "0x4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6005B50")]
		[Address(RVA = "0xDC2000", Offset = "0xDC0800", Length = "0x125")]
		public virtual void CopyTo(Image image)
		{
		}

		[Token(Token = "0x6005B51")]
		[Address(RVA = "0x659BD0", Offset = "0x6583D0", Length = "0x2B")]
		public ImageSettings()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000AA1")]
	private struct CustomColorBlock
	{
		[SerializeField]
		[Token(Token = "0x40037E8")]
		[FieldOffset(Offset = "0x0")]
		private float m_ColorMultiplier;

		[Token(Token = "0x40037E9")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private Color m_DisabledColor;

		[Token(Token = "0x40037EA")]
		[SerializeField]
		[FieldOffset(Offset = "0x14")]
		private float m_FadeDuration;

		[SerializeField]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40037EB")]
		private Color m_HighlightedColor;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40037EC")]
		[SerializeField]
		private Color m_NormalColor;

		[Token(Token = "0x40037ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color m_PressedColor;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40037EE")]
		[SerializeField]
		private Color m_SelectedColor;

		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40037EF")]
		[SerializeField]
		private Color m_DisabledHighlightedColor;

		[Token(Token = "0x17000A19")]
		public float colorMultiplier
		{
			[Token(Token = "0x6005B52")]
			[Address(RVA = "0x7F7960", Offset = "0x7F6160", Length = "0x5")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6005B53")]
			[Address(RVA = "0x7F7BB0", Offset = "0x7F63B0", Length = "0x5")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1A")]
		public Color disabledColor
		{
			[Address(RVA = "0xCC8D60", Offset = "0xCC7560", Length = "0xB")]
			[Token(Token = "0x6005B54")]
			get
			{
				return default(Color);
			}
			[Address(RVA = "0xCC8D70", Offset = "0xCC7570", Length = "0x8")]
			[Token(Token = "0x6005B55")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1B")]
		public float fadeDuration
		{
			[Address(RVA = "0x474E90", Offset = "0x473690", Length = "0x6")]
			[Token(Token = "0x6005B56")]
			get
			{
				return default(float);
			}
			[Address(RVA = "0xDB0180", Offset = "0xDAE980", Length = "0x6")]
			[Token(Token = "0x6005B57")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1C")]
		public Color highlightedColor
		{
			[Address(RVA = "0x8CE340", Offset = "0x8CCB40", Length = "0xB")]
			[Token(Token = "0x6005B58")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6005B59")]
			[Address(RVA = "0xBC95F0", Offset = "0xBC7DF0", Length = "0x8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1D")]
		public Color normalColor
		{
			[Address(RVA = "0x48C820", Offset = "0x48B020", Length = "0xB")]
			[Token(Token = "0x6005B5A")]
			get
			{
				return default(Color);
			}
			[Address(RVA = "0x48C7E0", Offset = "0x48AFE0", Length = "0x8")]
			[Token(Token = "0x6005B5B")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1E")]
		public Color pressedColor
		{
			[Token(Token = "0x6005B5C")]
			[Address(RVA = "0x48C780", Offset = "0x48AF80", Length = "0xB")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6005B5D")]
			[Address(RVA = "0x48CC80", Offset = "0x48B480", Length = "0x8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1F")]
		public Color selectedColor
		{
			[Token(Token = "0x6005B5E")]
			[Address(RVA = "0x60E270", Offset = "0x60CA70", Length = "0xB")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6005B5F")]
			[Address(RVA = "0xBEE580", Offset = "0xBECD80", Length = "0x8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A20")]
		public Color disabledHighlightedColor
		{
			[Token(Token = "0x6005B60")]
			[Address(RVA = "0xBEE560", Offset = "0xBECD60", Length = "0xB")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6005B61")]
			[Address(RVA = "0xBEEA80", Offset = "0xBED280", Length = "0x8")]
			set
			{
			}
		}

		[Address(RVA = "0xDBDA50", Offset = "0xDBC250", Length = "0x11A")]
		[Token(Token = "0x6005B62")]
		public static implicit operator ColorBlock(CustomColorBlock item)
		{
			return default(ColorBlock);
		}
	}

	[Serializable]
	[Token(Token = "0x2000AA2")]
	private struct CustomSpriteState
	{
		[Token(Token = "0x40037F0")]
		[SerializeField]
		[FieldOffset(Offset = "0x0")]
		private Sprite m_DisabledSprite;

		[SerializeField]
		[Token(Token = "0x40037F1")]
		[FieldOffset(Offset = "0x8")]
		private Sprite m_HighlightedSprite;

		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40037F2")]
		private Sprite m_PressedSprite;

		[SerializeField]
		[Token(Token = "0x40037F3")]
		[FieldOffset(Offset = "0x18")]
		private Sprite m_SelectedSprite;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40037F4")]
		[SerializeField]
		private Sprite m_DisabledHighlightedSprite;

		[Token(Token = "0x17000A21")]
		public Sprite disabledSprite
		{
			[Token(Token = "0x6005B63")]
			[Address(RVA = "0x5BCC50", Offset = "0x5BB450", Length = "0x4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B64")]
			[Address(RVA = "0x5BCBA0", Offset = "0x5BB3A0", Length = "0x8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A22")]
		public Sprite highlightedSprite
		{
			[Token(Token = "0x6005B65")]
			[Address(RVA = "0x65E770", Offset = "0x65CF70", Length = "0x5")]
			get
			{
				return null;
			}
			[Address(RVA = "0xDBECE0", Offset = "0xDBD4E0", Length = "0xC")]
			[Token(Token = "0x6005B66")]
			set
			{
			}
		}

		[Token(Token = "0x17000A23")]
		public Sprite pressedSprite
		{
			[Token(Token = "0x6005B67")]
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B68")]
			[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A24")]
		public Sprite selectedSprite
		{
			[Token(Token = "0x6005B69")]
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B6A")]
			[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A25")]
		public Sprite disabledHighlightedSprite
		{
			[Token(Token = "0x6005B6B")]
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B6C")]
			[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
			set
			{
			}
		}

		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0xDBEC70", Offset = "0xDBD470", Length = "0x69")]
		public static implicit operator SpriteState(CustomSpriteState item)
		{
			return default(SpriteState);
		}
	}

	[Serializable]
	[Token(Token = "0x2000AA3")]
	private class CustomAnimationTriggers
	{
		[SerializeField]
		[Token(Token = "0x40037F5")]
		[FieldOffset(Offset = "0x10")]
		private string m_DisabledTrigger;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40037F6")]
		[SerializeField]
		private string m_HighlightedTrigger;

		[SerializeField]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40037F7")]
		private string m_NormalTrigger;

		[SerializeField]
		[Token(Token = "0x40037F8")]
		[FieldOffset(Offset = "0x28")]
		private string m_PressedTrigger;

		[SerializeField]
		[Token(Token = "0x40037F9")]
		[FieldOffset(Offset = "0x30")]
		private string m_SelectedTrigger;

		[Token(Token = "0x40037FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string m_DisabledHighlightedTrigger;

		[Token(Token = "0x17000A26")]
		public string disabledTrigger
		{
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			[Token(Token = "0x6005B6F")]
			get
			{
				return null;
			}
			[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
			[Token(Token = "0x6005B70")]
			set
			{
			}
		}

		[Token(Token = "0x17000A27")]
		public string highlightedTrigger
		{
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			[Token(Token = "0x6005B71")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B72")]
			[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A28")]
		public string normalTrigger
		{
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			[Token(Token = "0x6005B73")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B74")]
			[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A29")]
		public string pressedTrigger
		{
			[Token(Token = "0x6005B75")]
			[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B76")]
			[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A2A")]
		public string selectedTrigger
		{
			[Token(Token = "0x6005B77")]
			[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B78")]
			[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A2B")]
		public string disabledHighlightedTrigger
		{
			[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
			[Token(Token = "0x6005B79")]
			get
			{
				return null;
			}
			[Address(RVA = "0x45EEF0", Offset = "0x45D6F0", Length = "0xC")]
			[Token(Token = "0x6005B7A")]
			set
			{
			}
		}

		[Address(RVA = "0xDBC740", Offset = "0xDBAF40", Length = "0xE1")]
		[Token(Token = "0x6005B6E")]
		public CustomAnimationTriggers()
		{
		}

		[Address(RVA = "0xDBC830", Offset = "0xDBB030", Length = "0xAE")]
		[Token(Token = "0x6005B7B")]
		public static implicit operator AnimationTriggers(CustomAnimationTriggers item)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000AA4")]
	private class TextSettings
	{
		[SerializeField]
		[Token(Token = "0x40037FB")]
		[FieldOffset(Offset = "0x10")]
		private Color _color;

		[Token(Token = "0x40037FC")]
		[SerializeField]
		[FieldOffset(Offset = "0x20")]
		private Font _font;

		[SerializeField]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40037FD")]
		private FontStyleOverride _style;

		[SerializeField]
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40037FE")]
		private float _sizeMultiplier;

		[SerializeField]
		[Token(Token = "0x40037FF")]
		[FieldOffset(Offset = "0x30")]
		private float _lineSpacing;

		[Token(Token = "0x17000A2C")]
		public Color color
		{
			[Address(RVA = "0x674C60", Offset = "0x673460", Length = "0xB")]
			[Token(Token = "0x6005B7C")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x17000A2D")]
		public Font font
		{
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			[Token(Token = "0x6005B7D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A2E")]
		public FontStyleOverride style
		{
			[Token(Token = "0x6005B7E")]
			[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
			get
			{
				return default(FontStyleOverride);
			}
		}

		[Token(Token = "0x17000A2F")]
		public float sizeMultiplier
		{
			[Address(RVA = "0x9BCDA0", Offset = "0x9BB5A0", Length = "0x6")]
			[Token(Token = "0x6005B7F")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000A30")]
		public float lineSpacing
		{
			[Address(RVA = "0x46DDA0", Offset = "0x46C5A0", Length = "0x6")]
			[Token(Token = "0x6005B80")]
			get
			{
				return default(float);
			}
		}

		[Address(RVA = "0xDCA6A0", Offset = "0xDC8EA0", Length = "0x39")]
		[Token(Token = "0x6005B81")]
		public TextSettings()
		{
		}
	}

	[Token(Token = "0x2000AA5")]
	private enum FontStyleOverride
	{
		[Token(Token = "0x4003801")]
		Default,
		[Token(Token = "0x4003802")]
		Normal,
		[Token(Token = "0x4003803")]
		Bold,
		[Token(Token = "0x4003804")]
		Italic,
		[Token(Token = "0x4003805")]
		BoldAndItalic
	}

	[SerializeField]
	[Token(Token = "0x4000EC8")]
	[FieldOffset(Offset = "0x18")]
	private ImageSettings _mainWindowBackground;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EC9")]
	private ImageSettings _popupWindowBackground;

	[Token(Token = "0x4000ECA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ImageSettings _areaBackground;

	[SerializeField]
	[Token(Token = "0x4000ECB")]
	[FieldOffset(Offset = "0x30")]
	private SelectableSettings _selectableSettings;

	[Token(Token = "0x4000ECC")]
	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	private SelectableSettings _buttonSettings;

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000ECD")]
	private SelectableSettings _inputGridFieldSettings;

	[SerializeField]
	[Token(Token = "0x4000ECE")]
	[FieldOffset(Offset = "0x48")]
	private ScrollbarSettings _scrollbarSettings;

	[SerializeField]
	[Token(Token = "0x4000ECF")]
	[FieldOffset(Offset = "0x50")]
	private SliderSettings _sliderSettings;

	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000ED0")]
	private ImageSettings _invertToggle;

	[Token(Token = "0x4000ED1")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private Color _invertToggleDisabledColor;

	[Token(Token = "0x4000ED2")]
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	private ImageSettings _calibrationBackground;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000ED3")]
	[SerializeField]
	private ImageSettings _calibrationValueMarker;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000ED4")]
	[SerializeField]
	private ImageSettings _calibrationRawValueMarker;

	[SerializeField]
	[Token(Token = "0x4000ED5")]
	[FieldOffset(Offset = "0x88")]
	private ImageSettings _calibrationZeroMarker;

	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000ED6")]
	private ImageSettings _calibrationCalibratedZeroMarker;

	[SerializeField]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000ED7")]
	private ImageSettings _calibrationDeadzone;

	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000ED8")]
	private TextSettings _textSettings;

	[SerializeField]
	[Token(Token = "0x4000ED9")]
	[FieldOffset(Offset = "0xA8")]
	private TextSettings _buttonTextSettings;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000EDA")]
	[SerializeField]
	private TextSettings _inputGridFieldTextSettings;

	[Address(RVA = "0xDCA6E0", Offset = "0xDC8EE0", Length = "0x6E")]
	[Token(Token = "0x600133F")]
	public void Apply(ThemedElement.ElementInfo[] elementInfo)
	{
	}

	[Token(Token = "0x6001340")]
	[Address(RVA = "0xDCB080", Offset = "0xDC9880", Length = "0x37E")]
	private void Apply(string themeClass, Component component)
	{
	}

	[Address(RVA = "0xDCAC20", Offset = "0xDC9420", Length = "0x2A4")]
	[Token(Token = "0x6001341")]
	private void Apply(string themeClass, Selectable item)
	{
	}

	[Token(Token = "0x6001342")]
	[Address(RVA = "0xDCA940", Offset = "0xDC9140", Length = "0x2DE")]
	private void Apply(string themeClass, Image item)
	{
	}

	[Address(RVA = "0xDCA750", Offset = "0xDC8F50", Length = "0x1E1")]
	[Token(Token = "0x6001343")]
	private void Apply(string themeClass, Text item)
	{
	}

	[Token(Token = "0x6001344")]
	[Address(RVA = "0xDCAED0", Offset = "0xDC96D0", Length = "0x1A1")]
	private void Apply(string themeClass, UIImageHelper item)
	{
	}

	[Address(RVA = "0xDCB400", Offset = "0xDC9C00", Length = "0x4")]
	[Token(Token = "0x6001345")]
	private static FontStyle GetFontStyle(FontStyleOverride style)
	{
		return default(FontStyle);
	}

	[Address(RVA = "0x5C16E0", Offset = "0x5BFEE0", Length = "0x7")]
	[Token(Token = "0x6001346")]
	public ThemeSettings()
	{
	}
}
