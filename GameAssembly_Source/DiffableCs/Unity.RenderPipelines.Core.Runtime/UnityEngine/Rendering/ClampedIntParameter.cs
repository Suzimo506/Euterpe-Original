namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ClampedIntParameter : IntParameter
{
	public int min; //Field offset: 0x20
	public int max; //Field offset: 0x24

	public virtual int value
	{
		 get { } //Length: 4
		 set { } //Length: 127
	}

	public ClampedIntParameter(int value, int min, int max, bool overrideState = false) { }

	public virtual int get_value() { }

	public virtual void set_value(int value) { }

}

