namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class IntParameter : VolumeParameter<Int32>
{

	public IntParameter(int value, bool overrideState = false) { }

	public virtual void Interp(int from, int to, float t) { }

}

