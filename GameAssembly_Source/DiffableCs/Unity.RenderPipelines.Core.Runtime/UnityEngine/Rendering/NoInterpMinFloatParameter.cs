namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class NoInterpMinFloatParameter : VolumeParameter<Single>
{
	public float min; //Field offset: 0x20

	public virtual float value
	{
		 get { } //Length: 6
		 set { } //Length: 119
	}

	public NoInterpMinFloatParameter(float value, float min, bool overrideState = false) { }

	public virtual float get_value() { }

	public virtual void set_value(float value) { }

}

