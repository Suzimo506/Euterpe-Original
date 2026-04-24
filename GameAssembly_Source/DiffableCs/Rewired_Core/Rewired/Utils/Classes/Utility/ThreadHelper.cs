namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal class ThreadHelper : IDisposable
{
	private const uint VGEtVbOdIMFuDpmEimNhYPFNAqKx = 750; //Field offset: 0x0
	private readonly Stopwatch noNALiiiuMOSuYtYkChputGVDJsT; //Field offset: 0x10
	private Thread RGAphbpbCqeugHasBTBezxmIfFqb; //Field offset: 0x18
	private ManualResetEvent bnPEzeahhDtdNbOZthRZIKHVvtyTA; //Field offset: 0x20
	private ManualResetEvent kyjEQvMCxZjqVBrkylFksfyVOEVC; //Field offset: 0x28
	private AutoResetEvent lTiTHjcORfEyyxHqcpuptXniwqLp; //Field offset: 0x30
	private bool BnJOPVyayHrATwLdCAzqaxaXPNDtA; //Field offset: 0x38
	private bool QjIUfbvsMrCvJcuNQEHSNMyBanOn; //Field offset: 0x39
	private int uoABHWapPAueeCNVwLYBaMRDeXRM; //Field offset: 0x3C
	private bool CqtpnofORsfSQiSfoYElNCLbWvaB; //Field offset: 0x40
	private int VqaBRKBbvbkzYbLdsCKIdNTsPKQw; //Field offset: 0x44
	private long qfKuZlYVEwxPDaXWFbrVynBPDejj; //Field offset: 0x48
	private bool KZrKKETQwxkEvRPZzfUFnDNSUbpG; //Field offset: 0x50
	private int RQADjrCuTHIStxkBGfKbNhTqrAkT; //Field offset: 0x54
	private long UhwqLZfpCwLVVARFssovOLQKlaPr; //Field offset: 0x58
	private uint cqpPMVXwNumFFOswSywKCRmpKhFp; //Field offset: 0x60
	private readonly object tHaFZqvOseUaAEDLGdWfUtHgmCSu; //Field offset: 0x68
	private Queue<Action> zLmvWVraeYWFkVHJCccXdAhVorWCA; //Field offset: 0x70
	private Queue<Action> ERsJOyjVJLqDNgiXjqbSvrapsJcE; //Field offset: 0x78
	private bool kxGGXAvXhQpslGgFLBHCVeJygbrfA; //Field offset: 0x80
	private Action DTofJQdzRUqdFxVvoEBuHoAdSaJqA; //Field offset: 0x88
	[CompilerGenerated]
	private Action aWKbdEbshEAkgfdNMwIXjtALFeRpA; //Field offset: 0x90
	[CompilerGenerated]
	private Action gItrlGWRQQMPJCbAhVrbGswaFpPx; //Field offset: 0x98
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0xA0

	private event Action _ThreadPreStopEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event Action _ThreadStartedEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public event Action ThreadPreStopEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event Action ThreadStartedEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event Action ThreadUpdateEvent
	{
		 add { } //Length: 127
		 remove { } //Length: 127
	}

	public int fixedTimeStepFPS
	{
		 get { } //Length: 4
		 set { } //Length: 35
	}

	public bool isRunning
	{
		 get { } //Length: 5
	}

	public bool isStopped
	{
		 get { } //Length: 50
	}

	public uint tick
	{
		 get { } //Length: 4
	}

	public int timeoutMS
	{
		 get { } //Length: 4
		 set { } //Length: 35
	}

	public bool useFixedTimeStep
	{
		 get { } //Length: 5
	}

	public bool useHighPrecitionTimer
	{
		 get { } //Length: 20
		 set { } //Length: 16
	}

	private ThreadHelper(int unnamed_param_0, bool unnamed_param_1, int unnamed_param_2) { }

	private ThreadHelper(int unnamed_param_0) { }

	private ThreadHelper() { }

	public void add_ThreadPreStopEvent(Action value) { }

	public void add_ThreadStartedEvent(Action value) { }

	public void add_ThreadUpdateEvent(Action value) { }

	[CompilerGenerated]
	private void ALydAgRuWCVbkOtPynRvIgsGHsQO(Action unnamed_param_0) { }

	private void azkYkhYdUYrAOHMgvEhWfTcsaZBvA() { }

	public static ThreadHelper Create(bool fixedTimeStep = false, int fixedTimeStepFPS = 100, bool useHighPrecisionTimer = false, int timeoutMS = 0) { }

	public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, int timeoutMS = 0) { }

	public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, bool useHighPrecisionTimer = false, int timeoutMS = 0) { }

	private void CTvhiBiqBSOTLZzxPOvfFKNsdBrj() { }

	[CompilerGenerated]
	private void ddNeirGcDfevABtbRDwRHRzwFXHuA(Action unnamed_param_0) { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void DUHhhlNpokgoLDuLiwFFScEEKOTGA(object unnamed_param_0) { }

	public bool EnqueueAction(Action action) { }

	protected virtual void Finalize() { }

	public int get_fixedTimeStepFPS() { }

	public bool get_isRunning() { }

	public bool get_isStopped() { }

	public uint get_tick() { }

	public int get_timeoutMS() { }

	public bool get_useFixedTimeStep() { }

	public bool get_useHighPrecitionTimer() { }

	public bool InvokeActionSync(Action action) { }

	[CompilerGenerated]
	private void lcrfhiEXTghxFNoRikoKaheDLCTZB(Action unnamed_param_0) { }

	private void LmOQyZfKjURQelBxJuErhrWtbpgi() { }

	public void remove_ThreadPreStopEvent(Action value) { }

	public void remove_ThreadStartedEvent(Action value) { }

	public void remove_ThreadUpdateEvent(Action value) { }

	public void ResetTimeout() { }

	public void set_fixedTimeStepFPS(int value) { }

	public void set_timeoutMS(int value) { }

	public void set_useHighPrecitionTimer(bool value) { }

	public bool Start(bool wait) { }

	public void Stop(bool wait) { }

	private void UQfymezRIJkTZoJEqHeDWNvHwUmS() { }

	public void WaitForActionQueueToFinish() { }

	[CompilerGenerated]
	private void XPfiywXoVEEvhuBFXketfzCaaaoR(Action unnamed_param_0) { }

}

