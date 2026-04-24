namespace Assets.Scripts.PeroTools.Commons;

public static class MathUtils
{

	public static double Abs(double a) { }

	public static float Abs(float a) { }

	public static int Abs(int a) { }

	public static int C36to10(string xStart) { }

	public static int C36to10S(char xChar) { }

	public static float Ceil(float value, int num) { }

	public static float Clamp(float value, float min, float max) { }

	public static int Clamp(int value, int min, int max) { }

	public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max) { }

	public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max) { }

	public static float ClampNormalize(float value, float min, float max) { }

	public static int DecimalToInt(decimal value, decimal magnifyingPower) { }

	public static double Distance(double start, double end) { }

	public static double Distance(Vector2 start, Vector2 end) { }

	public static double Distance(Vector3 start, Vector3 end) { }

	public static int FloatToInt(float value, float magnifyingPower) { }

	public static float Floor(float value, int num) { }

	public static bool InRange(ref decimal value, ref decimal left, ref decimal right, bool IncudeEqual) { }

	public static bool InRange(int value, int left, int right, bool IncudeEqual) { }

	public static bool InRange(DateTime now, DateTime from, DateTime to, bool ignoreYear, bool includeToday = true) { }

	public static bool InRange(ref Vector2 outVec, ref Vector2 inVec) { }

	public static bool InRange(float value, float left, float right, bool IncudeEqual) { }

	public static bool IsInRect(Rect rect, Vector2 pos) { }

	public static bool IsPointInTrapezoid(Vector2[] polygon, float x, float y) { }

	public static float Lerp(float a, float b, float t) { }

	public static int LongToInt(long value) { }

	public static float Normalize(float value, float min, float max) { }

	public static float Round(float value, int num) { }

	public static float RoundX(float value, int num) { }

}

