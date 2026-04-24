namespace Assets.Scripts.GameCore.Managers;

[Obsolete]
public class FeverManager
{
	private static FeverManager m_Instance; //Field offset: 0x0
	[CompilerGenerated]
	private int <feverCount>k__BackingField; //Field offset: 0x10
	private float m_FeverValue; //Field offset: 0x14
	private bool m_IsActivateFever; //Field offset: 0x18
	public bool isAutoFever; //Field offset: 0x19
	[CompilerGenerated]
	private bool <isManualFeverEnable>k__BackingField; //Field offset: 0x1A

	public private int feverCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public static FeverManager Instance
	{
		 get { } //Length: 288
	}

	public private bool isManualFeverEnable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static FeverManager() { }

	public FeverManager() { }

	public void AddFever(float value) { }

	[CompilerGenerated]
	public int get_feverCount() { }

	public static FeverManager get_Instance() { }

	[CompilerGenerated]
	public bool get_isManualFeverEnable() { }

	public float GetFeverRate() { }

	public bool GetIsAutoFever() { }

	public float GetWholeFever() { }

	public void InitGameKernel() { }

	public void InvokeFever() { }

	public bool IsGod() { }

	public bool IsOnFeverState() { }

	public void ResetFever() { }

	[CompilerGenerated]
	private void set_feverCount(int value) { }

	[CompilerGenerated]
	private void set_isManualFeverEnable(bool value) { }

}

