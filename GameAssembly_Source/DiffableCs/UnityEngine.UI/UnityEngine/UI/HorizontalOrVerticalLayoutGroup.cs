namespace UnityEngine.UI;

[ExecuteAlways]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
{
	[SerializeField]
	protected float m_Spacing; //Field offset: 0x58
	[SerializeField]
	protected bool m_ChildForceExpandWidth; //Field offset: 0x5C
	[SerializeField]
	protected bool m_ChildForceExpandHeight; //Field offset: 0x5D
	[SerializeField]
	protected bool m_ChildControlWidth; //Field offset: 0x5E
	[SerializeField]
	protected bool m_ChildControlHeight; //Field offset: 0x5F
	[SerializeField]
	protected bool m_ChildScaleWidth; //Field offset: 0x60
	[SerializeField]
	protected bool m_ChildScaleHeight; //Field offset: 0x61

	public bool childControlHeight
	{
		 get { } //Length: 5
		 set { } //Length: 76
	}

	public bool childControlWidth
	{
		 get { } //Length: 5
		 set { } //Length: 76
	}

	public bool childForceExpandHeight
	{
		 get { } //Length: 5
		 set { } //Length: 76
	}

	public bool childForceExpandWidth
	{
		 get { } //Length: 5
		 set { } //Length: 76
	}

	public bool childScaleHeight
	{
		 get { } //Length: 5
		 set { } //Length: 76
	}

	public bool childScaleWidth
	{
		 get { } //Length: 5
		 set { } //Length: 76
	}

	public float spacing
	{
		 get { } //Length: 6
		 set { } //Length: 76
	}

	protected HorizontalOrVerticalLayoutGroup() { }

	protected void CalcAlongAxis(int axis, bool isVertical) { }

	public bool get_childControlHeight() { }

	public bool get_childControlWidth() { }

	public bool get_childForceExpandHeight() { }

	public bool get_childForceExpandWidth() { }

	public bool get_childScaleHeight() { }

	public bool get_childScaleWidth() { }

	public float get_spacing() { }

	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	public void set_childControlHeight(bool value) { }

	public void set_childControlWidth(bool value) { }

	public void set_childForceExpandHeight(bool value) { }

	public void set_childForceExpandWidth(bool value) { }

	public void set_childScaleHeight(bool value) { }

	public void set_childScaleWidth(bool value) { }

	public void set_spacing(float value) { }

	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

}

