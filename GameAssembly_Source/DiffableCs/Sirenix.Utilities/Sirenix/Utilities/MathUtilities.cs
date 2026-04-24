namespace Sirenix.Utilities;

[Extension]
public static class MathUtilities
{
	private const float ZERO_TOLERANCE = 1E-06; //Field offset: 0x0

	[Extension]
	public static Vector3 Abs(Vector3 v) { }

	public static float Bounce(float value) { }

	public static float BounceEaseInFastOut(float t) { }

	[Extension]
	public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max) { }

	[Extension]
	public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max) { }

	public static float ClampWrapAngle(float angle, float min, float max) { }

	public static int ComputeByteArrayHash(Byte[] data) { }

	public static double DiscardLeastSignificantDecimal(double v) { }

	public static float EaseInElastic(float value, float amplitude = 0.25, float length = 0.6) { }

	public static float EaseInOut(float t) { }

	public static float EaseOutElastic(float value, float amplitude = 0.25, float length = 0.6) { }

	public static float Fract(float value) { }

	public static Vector2 Fract(Vector2 value) { }

	public static Vector3 Fract(Vector3 value) { }

	private static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }

	public static float Hermite(float start, float end, float t) { }

	public static float Hermite01(float t) { }

	public static Vector2 InfiniteLineIntersect(Vector2 ps1, Vector2 pe1, Vector2 ps2, Vector2 pe2) { }

	public static Vector3 InterpolatePoints(Vector3[] path, float t) { }

	public static Vector2 LerpUnclamped(Vector2 from, Vector2 to, float amount) { }

	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float amount) { }

	public static float LinearStep(float a, float b, float t) { }

	public static float LineDistToPlane(Vector3 planeOrigin, Vector3 planeNormal, Vector3 lineOrigin, Vector3 lineDirectionNormalized) { }

	public static bool LineIntersectsLine(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2, out Vector2 intersection) { }

	public static float PointDistanceToLine(Vector3 point, Vector3 a, Vector3 b) { }

	[Extension]
	public static Vector3 Pow(Vector3 v, float p) { }

	public static float RayDistToPlane(Ray ray, Plane plane) { }

	public static Vector2 RotatePoint(Vector2 point, Vector2 around, float degrees) { }

	public static Vector2 RotatePoint(Vector2 point, float degrees) { }

	public static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	[Extension]
	public static Vector3 Sign(Vector3 v) { }

	public static float SmoothStep(float a, float b, float t) { }

	public static float StackHermite(float start, float end, float t, int count) { }

	public static float StackHermite01(float t, int count) { }

	public static double Wrap(double value, double min, double max) { }

	public static float Wrap(float value, float min, float max) { }

	public static int Wrap(int value, int min, int max) { }

}

