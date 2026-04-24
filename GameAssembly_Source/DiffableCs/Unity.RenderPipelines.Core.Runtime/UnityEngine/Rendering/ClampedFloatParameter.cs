namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ClampedFloatParameter : FloatParameter
{
	public float min; //Field offset: 0x20
	public float max; //Field offset: 0x24

	public virtual float value
	{
		 get { } //Length: 6
		 set { } //Length: 141
	}

	public ClampedFloatParameter(float value, float min, float max, bool overrideState = false) { }

	public virtual float get_value() { }

	public virtual void set_value(float value) { }

}

