namespace Rewired.Utils.Classes.Data;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct Float2x : IEquatable<Float2x>
{
	public const int Length = 2; //Field offset: 0x0
	private static Func<Float2x, Float2x, Float2x> _additionDelegate; //Field offset: 0x0
	private static Func<Float2x, Float2x, Float2x> _subtractionDelegate; //Field offset: 0x8
	private static Func<Float2x, Float2x, Float2x> _multiplicationDelegate; //Field offset: 0x10
	private static Func<Float2x, Float2x, Float2x> _divisionDelegate; //Field offset: 0x18
	public float a; //Field offset: 0x0
	public float b; //Field offset: 0x4

	public float Item
	{
		 get { } //Length: 130
		 set { } //Length: 148
	}

	public static Float2x Zero
	{
		 get { } //Length: 15
	}

	public Float2x(float unnamed_param_0, float unnamed_param_1) { }

	public static Float2x Add(Float2x value1, Float2x value2) { }

	public Float2x Clone() { }

	public static Float2x Clone(Float2x obj) { }

	public static Float2x Divide(Float2x value1, Float2x value2) { }

	public override bool Equals(Float2x other) { }

	public virtual bool Equals(object obj) { }

	public float get_Item(int index) { }

	public static Float2x get_Zero() { }

	public static Func<Float2x, Float2x, Float2x> GetAdditionDelegate() { }

	public static Func<Float2x, Float2x, Float2x> GetDivisionDelegate() { }

	public virtual int GetHashCode() { }

	public static Func<Float2x, Float2x, Float2x> GetMultiplicationDelegate() { }

	public static Func<Float2x, Float2x, Float2x> GetSubtractionDelegate() { }

	public static Float2x Multiply(Float2x value1, Float2x value2) { }

	public static Float2x op_Addition(Float2x value1, float value2) { }

	public static Float2x op_Addition(Float2x value1, Float2x value2) { }

	public static Float2x op_Division(Float2x value1, float value2) { }

	public static Float2x op_Division(Float2x value1, Float2x value2) { }

	public static Vector2 op_Implicit(Float2x obj) { }

	public static Float2x op_Implicit(Vector2 obj) { }

	public static Float2x op_Multiply(Float2x value1, Float2x value2) { }

	public static Float2x op_Multiply(Float2x value1, float value2) { }

	public static Float2x op_Subtraction(Float2x value1, Float2x value2) { }

	public static Float2x op_Subtraction(Float2x value1, float value2) { }

	public void set_Item(int index, float value) { }

	public static Float2x Subtract(Float2x value1, Float2x value2) { }

	public virtual string ToString() { }

}

