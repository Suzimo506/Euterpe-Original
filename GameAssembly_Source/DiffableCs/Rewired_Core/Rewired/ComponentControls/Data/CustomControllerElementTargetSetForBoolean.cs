namespace Rewired.ComponentControls.Data;

[CustomClassObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CustomControllerElementTargetSetForBoolean : CustomControllerElementTargetSet
{
	private const int AACEUGTXvLhOtLNrUCNxbYpyVUsdA = 1; //Field offset: 0x0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTarget _target; //Field offset: 0x10

	internal virtual CustomControllerElementTarget Item
	{
		internal get { } //Length: 101
	}

	public CustomControllerElementTarget target
	{
		 get { } //Length: 5
	}

	internal virtual int targetCount
	{
		internal get { } //Length: 6
	}

	internal CustomControllerElementTargetSetForBoolean() { }

	internal CustomControllerElementTargetSetForBoolean(CustomControllerElementTarget unnamed_param_0) { }

	internal virtual void ClearElementCaches() { }

	internal virtual CustomControllerElementTarget get_Item(int index) { }

	public CustomControllerElementTarget get_target() { }

	internal virtual int get_targetCount() { }

}

