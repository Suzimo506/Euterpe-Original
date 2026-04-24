namespace Rewired.Utils.Classes.Data;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct Float4x : IEquatable<Float4x>
{
	public const int Length = 4; //Field offset: 0x0
	private static Func<Float4x, Float4x, Float4x> _additionDelegate; //Field offset: 0x0
	private static Func<Float4x, Float4x, Float4x> _subtractionDelegate; //Field offset: 0x8
	private static Func<Float4x, Float4x, Float4x> _multiplicationDelegate; //Field offset: 0x10
	private static Func<Float4x, Float4x, Float4x> _divisionDelegate; //Field offset: 0x18
	public float a; //Field offset: 0x0
	public float b; //Field offset: 0x4
	public float c; //Field offset: 0x8
	public float d; //Field offset: 0xC

	public float Item
	{
		 get { } //Length: 172
		 set { } //Length: 200
	}

	public static Float4x Zero
	{
		 get { } //Length: 10
	}

	public Float4x(float unnamed_param_0, float unnamed_param_1, float unnamed_param_2, float unnamed_param_3) { }

	public static Float4x Add(Float4x value1, Float4x value2) { }

	public Float4x Clone() { }

	public static Float4x Clone(Float4x obj) { }

	public static Float4x Divide(Float4x value1, Float4x value2) { }

	public override bool Equals(Float4x other) { }

	public virtual bool Equals(object obj) { }

	public float get_Item(int index) { }

	public static Float4x get_Zero() { }

	public static Func<Float4x, Float4x, Float4x> GetAdditionDelegate() { }

	public static Func<Float4x, Float4x, Float4x> GetDivisionDelegate() { }

	public virtual int GetHashCode() { }

	public static Func<Float4x, Float4x, Float4x> GetMultiplicationDelegate() { }

	public static Func<Float4x, Float4x, Float4x> GetSubtractionDelegate() { }

	public static Float4x Multiply(Float4x value1, Float4x value2) { }

	public static Float4x op_Addition(Float4x value1, float value2) { }

	public static Float4x op_Addition(Float4x value1, Float4x value2) { }

	public static Float4x op_Division(Float4x value1, float value2) { }

	public static Float4x op_Division(Float4x value1, Float4x value2) { }

	public static Vector4 op_Implicit(Float4x obj) { }

	public static Float4x op_Implicit(Vector4 obj) { }

	public static Float4x op_Multiply(Float4x value1, Float4x value2) { }

	public static Float4x op_Multiply(Float4x value1, float value2) { }

	public static Float4x op_Subtraction(Float4x value1, Float4x value2) { }

	public static Float4x op_Subtraction(Float4x value1, float value2) { }

	public void set_Item(int index, float value) { }

	public static Float4x Subtract(Float4x value1, Float4x value2) { }

	public virtual string ToString() { }

}

