namespace Rewired.Utils.Classes.Data;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct Float3x : IEquatable<Float3x>
{
	public const int Length = 3; //Field offset: 0x0
	private static Func<Float3x, Float3x, Float3x> _additionDelegate; //Field offset: 0x0
	private static Func<Float3x, Float3x, Float3x> _subtractionDelegate; //Field offset: 0x8
	private static Func<Float3x, Float3x, Float3x> _multiplicationDelegate; //Field offset: 0x10
	private static Func<Float3x, Float3x, Float3x> _divisionDelegate; //Field offset: 0x18
	public float a; //Field offset: 0x0
	public float b; //Field offset: 0x4
	public float c; //Field offset: 0x8

	public float Item
	{
		 get { } //Length: 151
		 set { } //Length: 174
	}

	public static Float3x Zero
	{
		 get { } //Length: 12
	}

	public Float3x(float unnamed_param_0, float unnamed_param_1, float unnamed_param_2) { }

	public static Float3x Add(Float3x value1, Float3x value2) { }

	public Float3x Clone() { }

	public static Float3x Clone(Float3x obj) { }

	public static Float3x Divide(Float3x value1, Float3x value2) { }

	public override bool Equals(Float3x other) { }

	public virtual bool Equals(object obj) { }

	public float get_Item(int index) { }

	public static Float3x get_Zero() { }

	public static Func<Float3x, Float3x, Float3x> GetAdditionDelegate() { }

	public static Func<Float3x, Float3x, Float3x> GetDivisionDelegate() { }

	public virtual int GetHashCode() { }

	public static Func<Float3x, Float3x, Float3x> GetMultiplicationDelegate() { }

	public static Func<Float3x, Float3x, Float3x> GetSubtractionDelegate() { }

	public static Float3x Multiply(Float3x value1, Float3x value2) { }

	public static Float3x op_Addition(Float3x value1, float value2) { }

	public static Float3x op_Addition(Float3x value1, Float3x value2) { }

	public static Float3x op_Division(Float3x value1, float value2) { }

	public static Float3x op_Division(Float3x value1, Float3x value2) { }

	public static Vector3 op_Implicit(Float3x obj) { }

	public static Float3x op_Implicit(Vector3 obj) { }

	public static Float3x op_Multiply(Float3x value1, Float3x value2) { }

	public static Float3x op_Multiply(Float3x value1, float value2) { }

	public static Float3x op_Subtraction(Float3x value1, Float3x value2) { }

	public static Float3x op_Subtraction(Float3x value1, float value2) { }

	public void set_Item(int index, float value) { }

	public static Float3x Subtract(Float3x value1, Float3x value2) { }

	public virtual string ToString() { }

}

