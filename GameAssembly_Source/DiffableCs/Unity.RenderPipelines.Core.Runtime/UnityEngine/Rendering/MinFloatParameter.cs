namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class MinFloatParameter : FloatParameter
{
	public float min; //Field offset: 0x20

	public virtual float value
	{
		 get { } //Length: 6
		 set { } //Length: 119
	}

	public MinFloatParameter(float value, float min, bool overrideState = false) { }

	public virtual float get_value() { }

	public virtual void set_value(float value) { }

}

