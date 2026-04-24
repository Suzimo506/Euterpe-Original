namespace Assets.Scripts.UI.Panels;

public abstract class AbstractTabItemGenerics : AbstractTabItem
{
	protected T m_GenericsParent; //Field offset: 0x0

	protected AbstractTabItemGenerics`1() { }

	public virtual void InitItem(AbstractTabContainer parent, List<GameObject> selectedObjects, int index) { }

}

