namespace Rewired.ComponentControls.Data;

[CustomClassObfuscation]
public class CustomControllerElementTarget
{
	[CustomObfuscation]
	public enum ValueRange
	{
		Full = 0,
		Positive = 1,
		Negative = 2,
	}

	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementSelector _element; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	private ValueRange _valueRange; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Pole _valueContribution; //Field offset: 0x1C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _invert; //Field offset: 0x20

	public CustomControllerElementSelector element
	{
		 get { } //Length: 5
	}

	public bool invert
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Pole valueContribution
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	internal ValueRange valueRange
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal CustomControllerElementTarget() { }

	internal CustomControllerElementTarget(CustomControllerElementSelector unnamed_param_0) { }

	internal void ClearElementCaches() { }

	public CustomControllerElementSelector get_element() { }

	public bool get_invert() { }

	public Pole get_valueContribution() { }

	internal ValueRange get_valueRange() { }

	public void set_invert(bool value) { }

	public void set_valueContribution(Pole value) { }

	internal void set_valueRange(ValueRange value) { }

}

