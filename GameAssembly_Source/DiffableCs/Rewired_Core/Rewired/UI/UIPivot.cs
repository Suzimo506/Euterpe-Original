namespace Rewired.UI;

public struct UIPivot
{
	public float min; //Field offset: 0x0
	public float max; //Field offset: 0x4

	public static UIPivot BottomCenter
	{
		 get { } //Length: 22
	}

	public static UIPivot BottomLeft
	{
		 get { } //Length: 17
	}

	public static UIPivot BottomRight
	{
		 get { } //Length: 22
	}

	public static UIPivot MiddleCenter
	{
		 get { } //Length: 22
	}

	public static UIPivot MiddleLeft
	{
		 get { } //Length: 22
	}

	public static UIPivot MiddleRight
	{
		 get { } //Length: 27
	}

	public static UIPivot TopCenter
	{
		 get { } //Length: 27
	}

	public static UIPivot TopLeft
	{
		 get { } //Length: 22
	}

	public static UIPivot TopRight
	{
		 get { } //Length: 27
	}

	public UIPivot(float unnamed_param_0, float unnamed_param_1) { }

	public static UIPivot get_BottomCenter() { }

	public static UIPivot get_BottomLeft() { }

	public static UIPivot get_BottomRight() { }

	public static UIPivot get_MiddleCenter() { }

	public static UIPivot get_MiddleLeft() { }

	public static UIPivot get_MiddleRight() { }

	public static UIPivot get_TopCenter() { }

	public static UIPivot get_TopLeft() { }

	public static UIPivot get_TopRight() { }

	public static Vector2 op_Implicit(UIPivot x) { }

	public static UIPivot op_Implicit(Vector2 x) { }

}

