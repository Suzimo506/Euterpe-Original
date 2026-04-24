namespace Sirenix.OdinInspector.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ConfigManager : MonoBehaviour
{
	internal enum SomeEnum
	{
		Text = 0,
		Color = 1,
		Image = 2,
		Children = 3,
	}

	internal enum SomeEnum1
	{
		English = 0,
		Chinese = 1,
		Japanese = 2,
	}

	public SomeEnum PropertyType; //Field offset: 0x18
	public Component text; //Field offset: 0x20
	public Component color; //Field offset: 0x28
	public Component image; //Field offset: 0x30
	public GameObject children; //Field offset: 0x38
	public string English; //Field offset: 0x40
	public Font englishFont; //Field offset: 0x48
	public string Chinese; //Field offset: 0x50
	public Font chinieseFont; //Field offset: 0x58
	public string Japanese; //Field offset: 0x60
	public Font japaneseFont; //Field offset: 0x68
	public Color color1; //Field offset: 0x70
	public Color color2; //Field offset: 0x80
	public Color color3; //Field offset: 0x90
	public Sprite sprite1; //Field offset: 0xA0
	public Sprite sprite2; //Field offset: 0xA8
	public Sprite sprite3; //Field offset: 0xB0
	public GameObject perfab1; //Field offset: 0xB8
	public GameObject perfab2; //Field offset: 0xC0
	public GameObject perfab3; //Field offset: 0xC8
	public SomeEnum1 WideEnumField; //Field offset: 0xD0

	public ConfigManager() { }

	private void Setup() { }

}

