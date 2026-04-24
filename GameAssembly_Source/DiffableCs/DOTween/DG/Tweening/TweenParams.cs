namespace DG.Tweening;

public class TweenParams
{
	public static readonly TweenParams Params; //Field offset: 0x0
	internal object id; //Field offset: 0x10
	internal object target; //Field offset: 0x18
	internal UpdateType updateType; //Field offset: 0x20
	internal bool isIndependentUpdate; //Field offset: 0x24
	internal TweenCallback onStart; //Field offset: 0x28
	internal TweenCallback onPlay; //Field offset: 0x30
	internal TweenCallback onRewind; //Field offset: 0x38
	internal TweenCallback onUpdate; //Field offset: 0x40
	internal TweenCallback onStepComplete; //Field offset: 0x48
	internal TweenCallback onComplete; //Field offset: 0x50
	internal TweenCallback onKill; //Field offset: 0x58
	internal TweenCallback<Int32> onWaypointChange; //Field offset: 0x60
	internal bool isRecyclable; //Field offset: 0x68
	internal bool isSpeedBased; //Field offset: 0x69
	internal bool autoKill; //Field offset: 0x6A
	internal int loops; //Field offset: 0x6C
	internal LoopType loopType; //Field offset: 0x70
	internal float delay; //Field offset: 0x74
	internal bool isRelative; //Field offset: 0x78
	internal Ease easeType; //Field offset: 0x7C
	internal EaseFunction customEase; //Field offset: 0x80
	internal float easeOvershootOrAmplitude; //Field offset: 0x88
	internal float easePeriod; //Field offset: 0x8C

	private static TweenParams() { }

	public TweenParams() { }

	public TweenParams Clear() { }

	public TweenParams OnComplete(TweenCallback action) { }

	public TweenParams OnKill(TweenCallback action) { }

	public TweenParams OnPlay(TweenCallback action) { }

	public TweenParams OnRewind(TweenCallback action) { }

	public TweenParams OnStart(TweenCallback action) { }

	public TweenParams OnStepComplete(TweenCallback action) { }

	public TweenParams OnUpdate(TweenCallback action) { }

	public TweenParams OnWaypointChange(TweenCallback<Int32> action) { }

	public TweenParams SetAutoKill(bool autoKillOnCompletion = true) { }

	public TweenParams SetDelay(float delay) { }

	public TweenParams SetEase(EaseFunction customEase) { }

	public TweenParams SetEase(AnimationCurve animCurve) { }

	public TweenParams SetEase(Ease ease, Nullable<Single> overshootOrAmplitude = null, Nullable<Single> period = null) { }

	public TweenParams SetId(object id) { }

	public TweenParams SetLoops(int loops, Nullable<LoopType> loopType = null) { }

	public TweenParams SetRecyclable(bool recyclable = true) { }

	public TweenParams SetRelative(bool isRelative = true) { }

	public TweenParams SetSpeedBased(bool isSpeedBased = true) { }

	public TweenParams SetTarget(object target) { }

	public TweenParams SetUpdate(bool isIndependentUpdate) { }

	public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false) { }

}

