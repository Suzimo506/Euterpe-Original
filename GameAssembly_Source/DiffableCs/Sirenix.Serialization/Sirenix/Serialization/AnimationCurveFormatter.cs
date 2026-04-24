namespace Sirenix.Serialization;

public class AnimationCurveFormatter : MinimalBaseFormatter<AnimationCurve>
{
	private static readonly Serializer<Keyframe[]> KeyframeSerializer; //Field offset: 0x0
	private static readonly Serializer<WrapMode> WrapModeSerializer; //Field offset: 0x8

	private static AnimationCurveFormatter() { }

	public AnimationCurveFormatter() { }

	protected virtual AnimationCurve GetUninitializedObject() { }

	protected virtual void Read(ref AnimationCurve value, IDataReader reader) { }

	protected virtual void Write(ref AnimationCurve value, IDataWriter writer) { }

}

