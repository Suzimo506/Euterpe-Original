namespace Rewired.ComponentControls.Data;

[CustomClassObfuscation]
public sealed class CustomControllerElementSelector
{
	[CustomObfuscation]
	internal enum ElementType
	{
		Axis = 0,
		Button = 1,
	}

	[CustomObfuscation]
	internal enum SelectorType
	{
		Name = 0,
		Index = 1,
		Id = 2,
	}

	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ElementType _elementType; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private SelectorType _selectorType; //Field offset: 0x14
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _elementName; //Field offset: 0x18
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _elementIndex; //Field offset: 0x20
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _elementId; //Field offset: 0x24
	[HideInInspector]
	private int wdHfFBjyDBoYtujMPBTAUanzuSht; //Field offset: 0x28
	[HideInInspector]
	private int mBKruxIlXeNBHWMmDHHJdVBpmmgaA; //Field offset: 0x2C

	public int elementId
	{
		 get { } //Length: 4
		 set { } //Length: 17
	}

	public int elementIndex
	{
		 get { } //Length: 4
		 set { } //Length: 17
	}

	public string elementName
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public ElementType elementType
	{
		 get { } //Length: 4
		 set { } //Length: 17
	}

	public bool isAssigned
	{
		 get { } //Length: 143
	}

	public SelectorType selectorType
	{
		 get { } //Length: 4
		 set { } //Length: 17
	}

	public CustomControllerElementSelector() { }

	public void ClearCache() { }

	public int get_elementId() { }

	public int get_elementIndex() { }

	public string get_elementName() { }

	public ElementType get_elementType() { }

	public bool get_isAssigned() { }

	public SelectorType get_selectorType() { }

	public int GetElementIndex(CustomController customController) { }

	public string GetSelectorFormattedString() { }

	private IList<ControllerElementIdentifier> joNRTlYOWLctsNOGxjyUxYsxHMQi(CustomController unnamed_param_0, ElementType unnamed_param_1) { }

	public void set_elementId(int value) { }

	public void set_elementIndex(int value) { }

	public void set_elementName(string value) { }

	public void set_elementType(ElementType value) { }

	public void set_selectorType(SelectorType value) { }

}

