//Type is in global namespace

[ExecuteInEditMode]
public class VerticalTxt : BaseMeshEffect
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float spacing; //Field offset: 0x20
	private float lineSpacing; //Field offset: 0x24
	private float textSpacing; //Field offset: 0x28
	private float xOffset; //Field offset: 0x2C
	private float yOffset; //Field offset: 0x30

	public VerticalTxt() { }

	public virtual void ModifyMesh(VertexHelper helper) { }

	private void modifyText(VertexHelper helper, int i, int charYPos, int charXPos) { }

}

