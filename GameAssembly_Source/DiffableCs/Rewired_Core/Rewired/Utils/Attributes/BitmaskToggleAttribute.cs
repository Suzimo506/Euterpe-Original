namespace Rewired.Utils.Attributes;

public class BitmaskToggleAttribute : PropertyAttribute
{
	public Type propType; //Field offset: 0x10
	public bool showNone; //Field offset: 0x18
	public bool showAll; //Field offset: 0x19

	public BitmaskToggleAttribute(Type unnamed_param_0) { }

}

