namespace DG.Tweening.Core;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class ABSAnimationComponent : MonoBehaviour
{
	public UpdateType updateType; //Field offset: 0x18
	public bool isSpeedBased; //Field offset: 0x1C
	public bool hasOnStart; //Field offset: 0x1D
	public bool hasOnPlay; //Field offset: 0x1E
	public bool hasOnUpdate; //Field offset: 0x1F
	public bool hasOnStepComplete; //Field offset: 0x20
	public bool hasOnComplete; //Field offset: 0x21
	public bool hasOnTweenCreated; //Field offset: 0x22
	public bool hasOnRewind; //Field offset: 0x23
	public UnityEvent onStart; //Field offset: 0x28
	public UnityEvent onPlay; //Field offset: 0x30
	public UnityEvent onUpdate; //Field offset: 0x38
	public UnityEvent onStepComplete; //Field offset: 0x40
	public UnityEvent onComplete; //Field offset: 0x48
	public UnityEvent onTweenCreated; //Field offset: 0x50
	public UnityEvent onRewind; //Field offset: 0x58
	public Tween tween; //Field offset: 0x60

	protected ABSAnimationComponent() { }

	public abstract void DOComplete() { }

	public abstract void DOKill() { }

	public abstract void DOPause() { }

	public abstract void DOPlay() { }

	public abstract void DOPlayBackwards() { }

	public abstract void DOPlayForward() { }

	public abstract void DORestart() { }

	public abstract void DORestart(bool fromHere) { }

	public abstract void DORewind() { }

	public abstract void DOTogglePause() { }

}

