namespace Rewired.Platforms.Custom;

public abstract class CustomInputSource : IDisposable
{
	internal sealed class Axis : Element
	{
		public float value; //Field offset: 0x10

		public Axis() { }

	}

	internal sealed class Button : Element
	{
		public bool value; //Field offset: 0x10

		public Button() { }

	}

	internal abstract class Controller
	{
		protected bool _isConnected; //Field offset: 0x10
		protected string _deviceName; //Field offset: 0x18
		protected string _customName; //Field offset: 0x20

		public string customName
		{
			 get { } //Length: 5
		}

		public string deviceName
		{
			 get { } //Length: 5
		}

		public bool isConnected
		{
			 get { } //Length: 5
			 set { } //Length: 9
		}

		protected Controller(string unnamed_param_0) { }

		public void Connect() { }

		public void Disconnect() { }

		public string get_customName() { }

		public string get_deviceName() { }

		public bool get_isConnected() { }

		public void set_isConnected(bool value) { }

		public abstract void Update() { }

	}

	internal abstract class Element
	{

		protected Element() { }

	}

	internal abstract class Joystick : Controller
	{
		private Nullable<Int64> tnWCjMACGAgixSLAynTroefoaxSwA; //Field offset: 0x28
		private int ofEtASleDvqxmgvOAXqcNpgNSqnG; //Field offset: 0x38
		private readonly Axis[] zEpEITeaPBUpoVlrlWXwKvrwrmIC; //Field offset: 0x40
		private readonly Button[] PpoIcwcfCemRCmKZmtstWxZCnkFM; //Field offset: 0x48
		private readonly ReadOnlyCollection<Axis> hFCjqlcoEzaovnUKoVwkHuinNvPV; //Field offset: 0x50
		private readonly ReadOnlyCollection<Button> iEoieboUCWUNVNIsfwSmUskrCjfp; //Field offset: 0x58
		private bool VQnljTjdFWfLnCyAAWvTulfMmNRBb; //Field offset: 0x60
		private Extension nRoSBeYeBUIcRWgPPLAPcrPQGDq; //Field offset: 0x68

		public IList<Axis> Axes
		{
			 get { } //Length: 5
		}

		public int axisCount
		{
			 get { } //Length: 26
		}

		public int buttonCount
		{
			 get { } //Length: 26
		}

		public IList<Button> Buttons
		{
			 get { } //Length: 5
		}

		public Extension extension
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public bool supportsVibration
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public Nullable<Int64> systemId
		{
			 get { } //Length: 11
			 set { } //Length: 8
		}

		public int unityId
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public Joystick(string unnamed_param_0, Nullable<Int64> unnamed_param_1, int unnamed_param_2, int unnamed_param_3, int unnamed_param_4) { }

		public IList<Axis> get_Axes() { }

		public int get_axisCount() { }

		public int get_buttonCount() { }

		public IList<Button> get_Buttons() { }

		public Extension get_extension() { }

		public bool get_supportsVibration() { }

		public Nullable<Int64> get_systemId() { }

		public int get_unityId() { }

		public override float GetAxisValue(int index) { }

		public override bool GetButtonValue(int index) { }

		public void set_extension(Extension value) { }

		public void set_supportsVibration(bool value) { }

		protected void set_systemId(Nullable<Int64> value) { }

		protected void set_unityId(int value) { }

	}

	private readonly InputSource jGUDvFCazEKefEYQZTaoQWqkOKQfA; //Field offset: 0x10
	private readonly List<Joystick> oeykZlJibvAEFsJVDymoBvdidszd; //Field offset: 0x18
	private readonly ReadOnlyCollection<Joystick> VoFcqZtofhUNBZvEyLddRVMbQxAF; //Field offset: 0x20
	private bool DCsoiUtpACiFjKyXtgXFJrlUgEWxA; //Field offset: 0x28
	[CompilerGenerated]
	private Action eHONpUrTELbYznCiuLAwudMWxtKs; //Field offset: 0x30
	[CompilerGenerated]
	private Action BtBTbcctCGRCByajlgNgAJfJAtyrA; //Field offset: 0x38
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x40

	private event Action BtBTbcctCGRCByajlgNgAJfJAtyrA
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	internal event Action eAqnTIrSauVVkAiwXAdjddFTKyV
	{
		internal add { } //Length: 158
		internal remove { } //Length: 158
	}

	private event Action eHONpUrTELbYznCiuLAwudMWxtKs
	{
		[CompilerGenerated]
		private add { } //Length: 247
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	internal event Action LRDAlasPfPBVDGWyZGLAQtcoCoHJA
	{
		internal add { } //Length: 247
		internal remove { } //Length: 158
	}

	internal InputSource cfzcHryyyqeSjrzQGsKAQMVeyMcl
	{
		internal get { } //Length: 4
	}

	public abstract bool isReady
	{
		 get { } //Length: 0
	}

	public bool useApproximateMatching
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public CustomInputSource(int unnamed_param_0) { }

	public void AddJoystick(Joystick joystick) { }

	internal void bQUYZrIcwSRDLsudQAqWVsNowqSI(Action unnamed_param_0) { }

	internal Joystick[] CtqutMjTWBjDRoILXLKKjKRPGeEZ() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public abstract bool get_isReady() { }

	public bool get_useApproximateMatching() { }

	public IList<Joystick> GetJoysticks() { }

	internal void JQcyFVbVclcNmUFdhLKLnGNxBqnz(Action unnamed_param_0) { }

	[CompilerGenerated]
	private void MaejzUJzFqDjKmPFZDUfaDoHliOO(Action unnamed_param_0) { }

	protected override void OnJoystickConnected() { }

	protected override void OnJoystickDisconnected() { }

	internal void OVkOejUlTsCtGOvwCbFMSWyRfWXf(Action unnamed_param_0) { }

	internal InputSource QaOYMKiLDelFNZBTRjobHnqZMPLM() { }

	public void RemoveJoystick(Joystick joystick) { }

	[CompilerGenerated]
	private void rZcSDSNRWrFdrhONpJOQWSPRBrN(Action unnamed_param_0) { }

	protected void set_useApproximateMatching(bool value) { }

	public abstract void Update() { }

	internal void vKbbGkAbFFqiGghkyBrDpnAXbCVOA(Action unnamed_param_0) { }

	[CompilerGenerated]
	private void zFEPcaoAXWEErSuKZfwJgIugYSVSA(Action unnamed_param_0) { }

	[CompilerGenerated]
	private void zqHMyyFbhiFwYflTbKzViEGZJQDPA(Action unnamed_param_0) { }

}

