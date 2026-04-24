namespace Assets.Scripts.Graphics;

public class NoDrawingRayCast : Graphic
{

	public NoDrawingRayCast() { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	public virtual void SetMaterialDirty() { }

	public virtual void SetVerticesDirty() { }

}

