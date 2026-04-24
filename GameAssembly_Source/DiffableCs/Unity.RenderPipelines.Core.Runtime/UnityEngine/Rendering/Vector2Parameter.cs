namespace UnityEngine.Rendering;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Vector2Parameter : VolumeParameter<Vector2>
{

	public Vector2Parameter(Vector2 value, bool overrideState = false) { }

	public virtual void Interp(Vector2 from, Vector2 to, float t) { }

}

