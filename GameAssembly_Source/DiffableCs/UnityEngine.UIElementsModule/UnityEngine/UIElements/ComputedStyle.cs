namespace UnityEngine.UIElements;

internal struct ComputedStyle
{
	private VisualElement m_Element; //Field offset: 0x0

	public StyleEnum<DisplayStyle> display
	{
		 get { } //Length: 166
	}

	private InheritedStylesData inheritedStylesData
	{
		private get { } //Length: 29
	}

	public StyleEnum<Overflow> overflow
	{
		 get { } //Length: 166
	}

	private VisualElementStylesData stylesData
	{
		private get { } //Length: 29
	}

	public StyleEnum<Visibility> visibility
	{
		 get { } //Length: 221
	}

	public StyleEnum<DisplayStyle> get_display() { }

	private InheritedStylesData get_inheritedStylesData() { }

	public StyleEnum<Overflow> get_overflow() { }

	private VisualElementStylesData get_stylesData() { }

	public StyleEnum<Visibility> get_visibility() { }

}

