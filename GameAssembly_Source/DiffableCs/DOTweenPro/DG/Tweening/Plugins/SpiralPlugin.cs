namespace DG.Tweening.Plugins;

public class SpiralPlugin : ABSTweenPlugin<Vector3, Vector3, SpiralOptions>
{
	public static readonly Vector3 DefaultDirection; //Field offset: 0x2C927BC

	private static SpiralPlugin() { }

	public SpiralPlugin() { }

	public virtual Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 value) { }

	public virtual void EvaluateAndApply(SpiralOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public static ABSTweenPlugin<Vector3, Vector3, SpiralOptions> Get() { }

	public virtual float GetSpeedBasedDuration(SpiralOptions options, float unitsXSecond, Vector3 changeValue) { }

	public virtual void Reset(TweenerCore<Vector3, Vector3, SpiralOptions> t) { }

	public virtual void SetChangeValue(TweenerCore<Vector3, Vector3, SpiralOptions> t) { }

	public virtual void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore<Vector3, Vector3, SpiralOptions> t) { }

}

