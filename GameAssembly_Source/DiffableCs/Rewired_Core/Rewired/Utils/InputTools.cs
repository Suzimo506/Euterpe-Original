namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class InputTools
{

	public static Vector2 ApplyRadialDeadZone(float xValue, float yValue, float deadzone) { }

	public static void ApplyRadialSensitivity(ref Vector2 value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) { }

	public static float ApplySensitivity(float value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) { }

	public static float AxisToDigitalValue(float value) { }

	public static float AxisToDigitalValue(float value, float threshold) { }

	public static void CompareLastActiveController(Controller controller, ref Controller lastController, ref double lastTime) { }

	public static string FormatHardwareIdentifierString(string str) { }

	public static float GetCalibratedAxisValue(float value, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) { }

	public static float GetCalibratedAxisValueClamped(float value, float zero, float min, float max, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) { }

	public static bool HandleForced4WayHatsOnUnknownControllers(int direction, ref HatType hatType) { }

	public static AxisRange InvertAxisRange(AxisRange axisRange) { }

	public static bool IsMappableControllerElementType(object type) { }

	public static bool IsMappableType(ControllerElementType type) { }

	public static bool IsMappableType(ControllerTemplateElementType type) { }

	public static float TransformAxis2DComponentValue(float value, float zero, float min, float max) { }

	private static bool vfqplJgJNlALaKfORLZEMCrXxDGqA(AnimationCurve unnamed_param_0) { }

}

