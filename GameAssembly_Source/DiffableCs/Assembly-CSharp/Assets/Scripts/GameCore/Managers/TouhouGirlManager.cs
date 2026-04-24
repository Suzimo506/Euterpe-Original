namespace Assets.Scripts.GameCore.Managers;

public class TouhouGirlManager : AbstractGirlManager
{

	public TouhouGirlManager() { }

	public virtual void AutoPlay(TimeNodeOrder tno, ref decimal ts, ref bool oneHint) { }

	public virtual void AwakeInit() { }

	public virtual void Hurt() { }

	private void OnTouhouFever(object sender, object rev, Object[] pars) { }

	public virtual void PlayLongEndAnimator(bool isAir) { }

	public virtual void PlayLongPressAnimator(bool isPress, bool isAir) { }

	public virtual void PlayRandomHitNothingAnim() { }

	public virtual void Release() { }

}

