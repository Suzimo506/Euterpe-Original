namespace Spine;

public static class MathUtils
{
	public const float PI = 3.1415927; //Field offset: 0x64900
	public const float PI2 = 6.2831855; //Field offset: 0x6494A
	public const float DegRad = 0.017453292; //Field offset: 0x64950
	private static Random random; //Field offset: 0x6497C
	public const float RadDeg = 57.295776; //Field offset: 0x2C927B4

	private static MathUtils() { }

	public static float Atan2(float y, float x) { }

	public static float Clamp(float value, float min, float max) { }

	public static float Cos(float radians) { }

	public static float CosDeg(float degrees) { }

	public static float RandomTriangle(float min, float max) { }

	public static float RandomTriangle(float min, float max, float mode) { }

	public static float Sin(float radians) { }

	public static float SinDeg(float degrees) { }

}

