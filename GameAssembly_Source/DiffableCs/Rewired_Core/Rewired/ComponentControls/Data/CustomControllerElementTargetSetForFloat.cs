namespace Rewired.ComponentControls.Data;

[CustomClassObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet
{
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _splitValue; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTarget _target; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTarget _positiveTarget; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTarget _negativeTarget; //Field offset: 0x28

	internal virtual CustomControllerElementTarget Item
	{
		internal get { } //Length: 187
	}

	public CustomControllerElementTarget negativeTarget
	{
		 get { } //Length: 5
	}

	public CustomControllerElementTarget positiveTarget
	{
		 get { } //Length: 5
	}

	public bool splitValue
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public CustomControllerElementTarget target
	{
		 get { } //Length: 5
	}

	internal virtual int targetCount
	{
		internal get { } //Length: 11
	}

	internal CustomControllerElementTargetSetForFloat() { }

	internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget unnamed_param_0) { }

	internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget unnamed_param_0, CustomControllerElementTarget unnamed_param_1) { }

	internal virtual void ClearElementCaches() { }

	internal virtual CustomControllerElementTarget get_Item(int index) { }

	public CustomControllerElementTarget get_negativeTarget() { }

	public CustomControllerElementTarget get_positiveTarget() { }

	public bool get_splitValue() { }

	public CustomControllerElementTarget get_target() { }

	internal virtual int get_targetCount() { }

	public void set_splitValue(bool value) { }

}

