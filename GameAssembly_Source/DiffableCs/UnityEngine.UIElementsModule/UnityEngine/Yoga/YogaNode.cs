namespace UnityEngine.Yoga;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class YogaNode
{
	internal IntPtr _ygNode; //Field offset: 0x10
	private MeasureFunction _measureFunction; //Field offset: 0x18
	private BaselineFunction _baselineFunction; //Field offset: 0x20

	public float LayoutHeight
	{
		 get { } //Length: 52
	}

	public float LayoutWidth
	{
		 get { } //Length: 52
	}

	public float LayoutX
	{
		 get { } //Length: 52
	}

	public float LayoutY
	{
		 get { } //Length: 52
	}

	public static float BaselineInternal(YogaNode node, float width, float height) { }

	public float get_LayoutHeight() { }

	public float get_LayoutWidth() { }

	public float get_LayoutX() { }

	public float get_LayoutY() { }

	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

}

