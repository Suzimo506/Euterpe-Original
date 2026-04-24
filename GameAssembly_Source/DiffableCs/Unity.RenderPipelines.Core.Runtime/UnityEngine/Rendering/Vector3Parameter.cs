namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Vector3Parameter : VolumeParameter<Vector3>
{

	public Vector3Parameter(Vector3 value, bool overrideState = false) { }

	public virtual void Interp(Vector3 from, Vector3 to, float t) { }

}

