namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class NoInterpMinIntParameter : VolumeParameter<Int32>
{
	public int min; //Field offset: 0x20

	public virtual int value
	{
		 get { } //Length: 4
		 set { } //Length: 111
	}

	public NoInterpMinIntParameter(int value, int min, bool overrideState = false) { }

	public virtual int get_value() { }

	public virtual void set_value(int value) { }

}

