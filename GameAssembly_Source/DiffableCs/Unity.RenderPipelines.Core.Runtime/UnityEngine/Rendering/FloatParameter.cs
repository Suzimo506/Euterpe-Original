namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FloatParameter : VolumeParameter<Single>
{

	public FloatParameter(float value, bool overrideState = false) { }

	public virtual void Interp(float from, float to, float t) { }

}

