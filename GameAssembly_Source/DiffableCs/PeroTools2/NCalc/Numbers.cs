namespace NCalc;

public class Numbers
{

	public Numbers() { }

	public static object Add(object a, object b, EvaluateOptions options) { }

	public static object AddChecked(object a, object b, EvaluateOptions options) { }

	private static object ConvertIfBoolean(object input) { }

	private static object ConvertIfString(object s) { }

	private static object ConvertTo(object value, TypeCode toType) { }

	private static TypeCode ConvertToHighestPrecision(ref object a, ref object b) { }

	public static object Divide(object a, object b, EvaluateOptions options) { }

	public static object Max(object a, object b) { }

	public static object Min(object a, object b) { }

	public static object Modulo(object a, object b) { }

	public static object Multiply(object a, object b, EvaluateOptions options) { }

	public static object MultiplyChecked(object a, object b, EvaluateOptions options) { }

	public static object Soustract(object a, object b, EvaluateOptions options) { }

	public static object SoustractChecked(object a, object b, EvaluateOptions options) { }

	private static Nullable<Int32> TypeCodeBitSize(TypeCode typeCode, out bool floatingPoint) { }

}

