namespace Assets.Scripts.GameCore.Managers;

public abstract class AbstractFeverManager : BaseManager, IPause
{
	protected decimal m_InvokeTime; //Field offset: 0x10
	protected decimal m_InvokeEndTime; //Field offset: 0x20
	protected bool m_IsPause; //Field offset: 0x30
	protected Looper m_FeverLooper; //Field offset: 0x38
	protected bool m_InvokeFever; //Field offset: 0x40
	protected int m_FeverValue; //Field offset: 0x44
	[CompilerGenerated]
	private int <InvokeFeverCount>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsAutoFever>k__BackingField; //Field offset: 0x4C
	protected int m_MaxFaverValue; //Field offset: 0x50
	protected string m_FeverAudio; //Field offset: 0x58

	public decimal feverEndTime
	{
		 get { } //Length: 11
	}

	public decimal feverStartTime
	{
		 get { } //Length: 11
	}

	public override int feverValue
	{
		 get { } //Length: 4
	}

	public int InvokeFeverCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsActivateFever
	{
		 get { } //Length: 118
	}

	public bool IsAutoFever
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsFeverGod
	{
		 get { } //Length: 91
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public bool IsTouhouConvert
	{
		 get { } //Length: 7
	}

	protected AbstractFeverManager() { }

	public override void AddFever(int value) { }

	public override void AddFever(ref MusicData md) { }

	public virtual void AwakeInit() { }

	private void Clean() { }

	protected override void FeverEnd() { }

	public decimal get_feverEndTime() { }

	public decimal get_feverStartTime() { }

	public override int get_feverValue() { }

	[CompilerGenerated]
	public int get_InvokeFeverCount() { }

	public bool get_IsActivateFever() { }

	[CompilerGenerated]
	public bool get_IsAutoFever() { }

	public bool get_IsFeverGod() { }

	public override bool get_IsGlobal() { }

	public bool get_IsTouhouConvert() { }

	public override float GetFeverNormalize() { }

	public override bool InvokeFever() { }

	public override void Pause(bool pauseCorountine) { }

	protected override void PlayFeverAudio() { }

	public virtual void Release() { }

	public override void Resume() { }

	[CompilerGenerated]
	protected void set_InvokeFeverCount(int value) { }

	[CompilerGenerated]
	protected void set_IsAutoFever(bool value) { }

}

