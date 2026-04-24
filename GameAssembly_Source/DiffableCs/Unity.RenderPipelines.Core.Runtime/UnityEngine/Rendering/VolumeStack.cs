namespace UnityEngine.Rendering;

public sealed class VolumeStack : IDisposable
{
	internal Dictionary<Type, VolumeComponent> components; //Field offset: 0x10

	internal VolumeStack() { }

	public override void Dispose() { }

	public T GetComponent() { }

	public VolumeComponent GetComponent(Type type) { }

	internal void Reload(IEnumerable<Type> baseTypes) { }

}

