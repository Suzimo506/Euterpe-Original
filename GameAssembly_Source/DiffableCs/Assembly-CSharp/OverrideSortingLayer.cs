//Type is in global namespace

public class OverrideSortingLayer : Action
{
	public Transform target; //Field offset: 0x10
	public string layerName; //Field offset: 0x18
	public int sortingOrder; //Field offset: 0x20

	public OverrideSortingLayer() { }

	[CompilerGenerated]
	private void <Execute>b__3_0(Renderer r) { }

	public virtual void Execute() { }

}

