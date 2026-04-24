namespace Rewired.Utils.Classes.Data;

public struct ScreenRect
{
	public float xMin; //Field offset: 0x0
	public float yMin; //Field offset: 0x4
	public float width; //Field offset: 0x8
	public float height; //Field offset: 0xC

	public Vector2 center
	{
		 get { } //Length: 71
	}

	public float xMax
	{
		 get { } //Length: 10
		 set { } //Length: 10
	}

	public float yMax
	{
		 get { } //Length: 11
		 set { } //Length: 11
	}

	public ScreenRect(float unnamed_param_0, float unnamed_param_1, float unnamed_param_2, float unnamed_param_3) { }

	public Vector2 get_center() { }

	public float get_xMax() { }

	public float get_yMax() { }

	public static Rect op_Implicit(ScreenRect o) { }

	public static ScreenRect op_Implicit(Rect o) { }

	public void set_xMax(float value) { }

	public void set_yMax(float value) { }

	public virtual string ToString() { }

}

