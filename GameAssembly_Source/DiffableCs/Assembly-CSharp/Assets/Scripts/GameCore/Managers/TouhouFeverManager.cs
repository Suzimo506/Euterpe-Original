namespace Assets.Scripts.GameCore.Managers;

public class TouhouFeverManager : AbstractFeverManager
{
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static readonly decimal touhou_fever_time; //Field offset: 0x0
	protected DBTouhou m_DbTouhou; //Field offset: 0x60

	private static TouhouFeverManager() { }

	public TouhouFeverManager() { }

	public virtual void AddFever(ref MusicData md) { }

	public virtual void AddFever(int value) { }

	public virtual void AwakeInit() { }

	protected virtual void FeverEnd() { }

	public virtual float GetFeverNormalize() { }

	public virtual bool InvokeFever() { }

	public virtual void Release() { }

	public virtual void StartInit() { }

}

