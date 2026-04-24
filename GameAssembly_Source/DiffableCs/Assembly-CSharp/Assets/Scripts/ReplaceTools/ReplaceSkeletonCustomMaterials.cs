namespace Assets.Scripts.ReplaceTools;

public class ReplaceSkeletonCustomMaterials : AbstractReplace
{
	public SkeletonRendererCustomMaterials skeletonCustomMaterials; //Field offset: 0x10
	public bool enable; //Field offset: 0x18

	public ReplaceSkeletonCustomMaterials() { }

	public virtual void Replace(int index) { }

}

