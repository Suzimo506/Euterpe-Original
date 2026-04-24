namespace Rewired.Utils;

public class MathTools
{
	private const float wmcDLeRoXAspdupQdtOGdcCybSNG = 1E-10; //Field offset: 0x0
	private const double DeYuuRIGgGGUvJOeAhFXjzAWlmXH = 1E-10; //Field offset: 0x0
	private const float keomNFcsACgxNagAbTUxKMqVgWLEb = 0.0001; //Field offset: 0x0
	public const float PI = 3.1415927; //Field offset: 0x0
	public const float Infinity = ∞; //Field offset: 0x0
	public const float NegativeInfinity = -∞; //Field offset: 0x0
	public const float Deg2Rad = 0.017453292; //Field offset: 0x0
	public const float Rad2Deg = 57.29578; //Field offset: 0x0
	public const float Epsilon = 1E-45; //Field offset: 0x0

	public MathTools() { }

	public static double Abs(double value) { }

	public static float Abs(float value) { }

	public static sbyte Abs(sbyte value) { }

	public static int Abs(int value) { }

	public static short Abs(short value) { }

	public static long Abs(long value) { }

	public static float Acos(float value) { }

	public static bool AngleIsBetween(float angle, float min, float max) { }

	public static bool AngleIsNear(float angle, float targetAngle, float threshold) { }

	public static bool Approximately(float a, float b) { }

	public static bool ApproximatelyZero(float a) { }

	public static float Asin(float value) { }

	public static float Atan(float value) { }

	public static float Atan2(float y, float x) { }

	public static float BooleanToSign(bool b) { }

	public static float Ceil(float value) { }

	public static int CeilToInt(float value) { }

	public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max) { }

	public static byte Clamp(byte value, byte min, byte max) { }

	public static sbyte Clamp(sbyte value, sbyte min, sbyte max) { }

	public static short Clamp(short value, short min, short max) { }

	public static ushort Clamp(ushort value, ushort min, ushort max) { }

	public static int Clamp(int value, int min, int max) { }

	public static uint Clamp(uint value, uint min, uint max) { }

	public static long Clamp(long value, long min, long max) { }

	public static ulong Clamp(ulong value, ulong min, ulong max) { }

	public static float Clamp(float value, float min, float max) { }

	public static Vector2 Clamp(Vector2 value, float min, float max) { }

	public static double Clamp(double value, double min, double max) { }

	public static Vector2 Clamp(Vector3 value, float min, float max) { }

	public static Vector2 Clamp(Vector3 value, Vector3 min, Vector3 max) { }

	public static float Clamp01(float value) { }

	public static float ClampAngle360(float angle) { }

	public static float Cos(float value) { }

	public static float Cross(Vector2 a, Vector2 b) { }

	private static bool CvzyVWGDlzVXffPfxSCIXvIISVat(Vector2 unnamed_param_0, Vector2 unnamed_param_1, Vector2 unnamed_param_2, Vector2 unnamed_param_3, out Vector2 unnamed_param_4) { }

	public static float DeltaAngle(float current, float target) { }

	public static float Exp(float power) { }

	public static float Floor(float value) { }

	public static int FloorToInt(float value) { }

	public static bool GetOffsetToContainRect(Rect container, Rect child, out Vector2 offset) { }

	public static int IntPow(int x, uint pow) { }

	public static bool IsEven(int value) { }

	public static bool IsExactlyEqual(double a, double b) { }

	public static bool IsExactlyEqual(float a, float b) { }

	public static bool IsLessMagnitudeOrEqual(double a, double b) { }

	public static bool IsLessMagnitudeOrEqual(float a, float b) { }

	public static bool IsLessMagnitudeOrEqual(ulong a, ulong b) { }

	public static bool IsLessMagnitudeOrEqual(long a, long b) { }

	public static bool IsLessMagnitudeOrEqual(uint a, uint b) { }

	public static bool IsLessMagnitudeOrEqual(int a, int b) { }

	public static bool IsLessMagnitudeOrEqual(ushort a, ushort b) { }

	public static bool IsLessMagnitudeOrEqual(short a, short b) { }

	public static bool IsLessMagnitudeOrEqual(sbyte a, sbyte b) { }

	public static bool IsLessMagnitudeOrEqual(byte a, byte b) { }

	public static bool IsMoreMagnitudeOrEqual(double a, double b) { }

	public static bool IsMoreMagnitudeOrEqual(ulong a, ulong b) { }

	public static bool IsMoreMagnitudeOrEqual(long a, long b) { }

	public static bool IsMoreMagnitudeOrEqual(uint a, uint b) { }

	public static bool IsMoreMagnitudeOrEqual(int a, int b) { }

	public static bool IsMoreMagnitudeOrEqual(ushort a, ushort b) { }

	public static bool IsMoreMagnitudeOrEqual(short a, short b) { }

	public static bool IsMoreMagnitudeOrEqual(byte a, byte b) { }

	public static bool IsMoreMagnitudeOrEqual(sbyte a, sbyte b) { }

	public static bool IsMoreMagnitudeOrEqual(float a, float b) { }

	public static bool IsNear(float value, float targetValue, float threshold) { }

	public static bool IsNear(float value, float targetValue) { }

	public static bool IsNearOrWholeNumber(float value, out int number) { }

	public static bool IsNearOrWholeNumber(float value, out int number, float threshold) { }

	public static bool IsNearOrWholeNumber(float value, float threshold) { }

	public static bool IsNearOrWholeNumber(float value) { }

	public static bool IsNearZero(float value) { }

	public static bool IsNearZero(float value, float threshold) { }

	public static bool IsZero(float value) { }

	public static bool IsZero(float value, float threshold) { }

	public static bool IsZero(double value) { }

	public static bool IsZero(double value, double threshold) { }

	public static bool LineIntersectsRect(Vector2 point1, Vector2 point2, Rect rect, out float sqrMagnitude) { }

	public static bool LineSegementsIntersect(Vector2 line1p1, Vector2 line1p2, Vector2 line2p1, Vector2 line2p2, out Vector2 intersection, bool collinearIntersects = false) { }

	public static float Log(float value, float p) { }

	public static float Log(float value) { }

	public static float Log10(float value) { }

	public static uint Max(uint a, uint b) { }

	public static long Max(long a, long b) { }

	public static ulong Max(ulong a, ulong b) { }

	public static int Max(int a, int b) { }

	public static ushort Max(ushort a, ushort b) { }

	public static double Max(double a, double b) { }

	public static short Max(short a, short b) { }

	public static byte Max(byte a, byte b) { }

	public static sbyte Max(sbyte a, sbyte b) { }

	public static float Max(float a, float b) { }

	public static Vector2 MaxMagnitude(Vector2 a, Vector2 b) { }

	public static float MaxMagnitude(float a, float b) { }

	public static Vector3 MaxMagnitude(Vector3 a, Vector3 b) { }

	public static double MaxMagnitude(double a, double b) { }

	public static long MaxMagnitude(long a, long b) { }

	public static ulong MaxMagnitude(ulong a, ulong b) { }

	public static uint MaxMagnitude(uint a, uint b) { }

	public static int MaxMagnitude(int a, int b) { }

	public static ushort MaxMagnitude(ushort a, ushort b) { }

	public static short MaxMagnitude(short a, short b) { }

	public static byte MaxMagnitude(byte a, byte b) { }

	public static sbyte MaxMagnitude(sbyte a, sbyte b) { }

	public static sbyte Min(sbyte a, sbyte b) { }

	public static double Min(double a, double b) { }

	public static float Min(float a, float b) { }

	public static byte Min(byte a, byte b) { }

	public static ushort Min(ushort a, ushort b) { }

	public static short Min(short a, short b) { }

	public static ulong Min(ulong a, ulong b) { }

	public static long Min(long a, long b) { }

	public static uint Min(uint a, uint b) { }

	public static int Min(int a, int b) { }

	public static ulong MinMagnitude(ulong a, ulong b) { }

	public static float MinMagnitude(float a, float b) { }

	public static Vector3 MinMagnitude(Vector3 a, Vector3 b) { }

	public static Vector2 MinMagnitude(Vector2 a, Vector2 b) { }

	public static double MinMagnitude(double a, double b) { }

	public static int MinMagnitude(int a, int b) { }

	public static long MinMagnitude(long a, long b) { }

	public static uint MinMagnitude(uint a, uint b) { }

	public static ushort MinMagnitude(ushort a, ushort b) { }

	public static short MinMagnitude(short a, short b) { }

	public static byte MinMagnitude(byte a, byte b) { }

	public static sbyte MinMagnitude(sbyte a, sbyte b) { }

	public static float Multiply(Vector2 a, Vector2 b) { }

	public static float Pow(float value, float p) { }

	public static bool RectContains(Rect rect, Vector2 pos, float rotation = 0) { }

	public static bool RectContains(Rect container, Rect child) { }

	public static float Repeat(float t, float length) { }

	public static float ReverseAngleRotationDirection(float angle) { }

	public static Vector2 RotateLocalPoint(Vector2 point, float angle) { }

	public static Vector2 RotateWorldPoint(Vector2 point, Vector2 center, float angle) { }

	public static float Round(float value) { }

	public static float RoundOffIfNearWholeNumber(float value) { }

	public static float RoundOffIfNearWholeNumber(float value, float threshold) { }

	public static int RoundToInt(float value) { }

	public static uint RoundUpToPowerOf2(uint value) { }

	public static int Sign(int value) { }

	public static float Sign(float value) { }

	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	public static bool SignToBoolean(float sign) { }

	public static float Sin(float value) { }

	public static Vector2 SnapVectorToNearestAngle(Vector2 vector, float angle) { }

	public static float Sqrt(float value) { }

	public static float Tan(float value) { }

	internal static bool tEIfBOfhuIVAgasCbjpyBCljAcbD(int unnamed_param_0, int unnamed_param_1) { }

	public static Rect TransformRect(Rect fromRect, Transform from, Transform to) { }

	public static Matrix4x4 TransformTo(Transform from, Transform to) { }

	public static float ValueInNewRange(float oldValue, float oldMin, float oldMax, float newMin, float newMax) { }

	public static int ValueInNewRange(int oldValue, int oldMin, int oldMax, int newMin, int newMax) { }

}

