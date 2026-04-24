using Cpp2ILInjected;
using UnityEngine;

namespace Sirenix.OdinInspector.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0x37150", Offset = "0x36550")]
[Token(Token = "0x200045C")]
public class ConfigManager : MonoBehaviour
{
	[Token(Token = "0x2000B24")]
	public enum SomeEnum
	{
		[Token(Token = "0x400395A")]
		Text,
		[Token(Token = "0x400395B")]
		Color,
		[Token(Token = "0x400395C")]
		Image,
		[Token(Token = "0x400395D")]
		Children
	}

	[Token(Token = "0x2000B25")]
	public enum SomeEnum1
	{
		[Token(Token = "0x400395F")]
		English,
		[Token(Token = "0x4003960")]
		Chinese,
		[Token(Token = "0x4003961")]
		Japanese
	}

	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0x18")]
	public SomeEnum PropertyType;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017AF")]
	public Component text;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017B0")]
	public Component color;

	[Token(Token = "0x40017B1")]
	[FieldOffset(Offset = "0x30")]
	public Component image;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40017B2")]
	public GameObject children;

	[Token(Token = "0x40017B3")]
	[FieldOffset(Offset = "0x40")]
	public string English;

	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0x48")]
	public Font englishFont;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017B5")]
	public string Chinese;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017B6")]
	public Font chinieseFont;

	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0x60")]
	public string Japanese;

	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0x68")]
	public Font japaneseFont;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40017B9")]
	public Color color1;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40017BA")]
	public Color color2;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40017BB")]
	public Color color3;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40017BC")]
	public Sprite sprite1;

	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0xA8")]
	public Sprite sprite2;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40017BE")]
	public Sprite sprite3;

	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject perfab1;

	[Token(Token = "0x40017C0")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject perfab2;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40017C1")]
	public GameObject perfab3;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40017C2")]
	public SomeEnum1 WideEnumField;

	[Token(Token = "0x6003293")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Setup()
	{
	}

	[Token(Token = "0x6003294")]
	[Address(RVA = "0x61EDD0", Offset = "0x61D5D0", Length = "0xF4")]
	public ConfigManager()
	{
	}
}
