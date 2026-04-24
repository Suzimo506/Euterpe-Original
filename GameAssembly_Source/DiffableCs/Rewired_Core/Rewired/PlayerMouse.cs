namespace Rewired;

public sealed class PlayerMouse : PlayerController, IPlayerController, IPlayerMouse, IMouseInputSource
{
	internal sealed class Definition : Definition
	{
		public bool defaultToCenter; //Field offset: 0x20
		public bool clampToMovementArea; //Field offset: 0x21
		public ScreenRect movementArea; //Field offset: 0x24
		public MovementAreaUnit movementAreaUnit; //Field offset: 0x34
		public float pointerSpeed; //Field offset: 0x38
		public bool useHardwarePointerPosition; //Field offset: 0x3C

		internal Definition() { }

	}

	internal static class Factory
	{

		public static PlayerMouse Create() { }

		public static PlayerMouse Create(Definition definition) { }

		private static PlayerMouse iubCQMAjMIuecaDNoukJTrSXGONC(int unnamed_param_0, int unnamed_param_1) { }

	}

	internal enum MovementAreaUnit
	{
		Screen = 0,
		Pixel = 1,
	}

	[CompilerGenerated]
	private sealed class NktGZcPKexQGwVWfgsROzypyQsZH
	{
		public static readonly NktGZcPKexQGwVWfgsROzypyQsZH <>9; //Field offset: 0x0
		public static Predicate<Axis> <>9__18_0; //Field offset: 0x8
		public static Predicate<Axis> <>9__18_1; //Field offset: 0x10

		private static NktGZcPKexQGwVWfgsROzypyQsZH() { }

		public NktGZcPKexQGwVWfgsROzypyQsZH() { }

		internal bool kyDgLlKHABWZszMCkJiUFCcSfeAgA(Axis unnamed_param_0) { }

		internal bool SzUzCoLqHqemCEjXLHVmAeHCnwTMc(Axis unnamed_param_0) { }

	}

	internal const bool zMrfSkhkmlecKbyoELKzbPjFlVoWc = True; //Field offset: 0x0
	internal const string kMRjoZkUocvjdujHrciHIXHFkHyb = "Left Button"; //Field offset: 0x0
	internal const string vzSWTItHrVzxorGreQBeavAHILZi = "Wheel Vertical"; //Field offset: 0x0
	internal const string kKlUZFfpreGwoKooUEtzxJviFKFv = "Wheel Horizontal"; //Field offset: 0x0
	internal const string VPRlhzISFqGjdYrDEmcDVlHnDiVc = "Wheel"; //Field offset: 0x0
	internal const string XlMfalaocwkaGeQJEmbygWSgfgvBB = "Vertical"; //Field offset: 0x0
	internal const string oZbGBuwiAfhzffBpAVmEjUzLUSXJA = "Horizontal"; //Field offset: 0x0
	internal const string vSSfjfhvQzSlaedmiKzizgGAmrkXA = "Right Button"; //Field offset: 0x0
	internal const string BHGnacgJgIllgxmyxfRsjqKWNljX = "Movement"; //Field offset: 0x0
	private const int VeqaYxfFPEbYiGAnHmcFlKVHZDEmc = 3; //Field offset: 0x0
	internal static readonly ScreenRect ePXEQglqoehiuBwPTOcWjsAUBRZf; //Field offset: 0x0
	internal const MovementAreaUnit yQfvumvSAdpVeYsxLNDKIVelWRqU = 0; //Field offset: 0x0
	internal const bool LRiIbPqlmIxwsRHsTKETSQwMeapC = True; //Field offset: 0x0
	internal const bool KgbTiDmkVBjnUNfwJgvzJwDaXUvq = True; //Field offset: 0x0
	internal const float HhUwKyBGhLtBUwNKKKdhsswxJtGm = 1; //Field offset: 0x0
	private const int FmPHoSzjbTXVzcHZzNoYIXabCTsT = 3; //Field offset: 0x0
	internal const string NdTIFBksFwcidzVcvNOenOZRWWVH = "Middle Button"; //Field offset: 0x0
	private readonly int gqkRUMQcCjRsskysdJmQDhUUaSqZ; //Field offset: 0x70
	private readonly int AKOsGngBHVMyRlkIXjZgOAeifoKhA; //Field offset: 0x74
	private readonly int uGhfDDlcmroFWadLNDKotuyCTGqr; //Field offset: 0x78
	private readonly int iZyClQikbDnZhUZoQqyEujqvvhQU; //Field offset: 0x7C
	private readonly int MRTdViFMzcypjmuJjpnPPQTNSNbf; //Field offset: 0x80
	private readonly int NujewYbtLLnSrstBjtATtZEgZMfy; //Field offset: 0x84
	private bool cDDXSlfBrfNTplrjRlCbOGucqMIF; //Field offset: 0x88
	private Vector2 ttdChzyJgrYtJCFYvafPdBdBmUcbb; //Field offset: 0x8C
	private Vector2 qJtvQDRbMyLpphlrPsWvUxIemDIM; //Field offset: 0x94
	private Vector2 KqlcUABzJlwGsVQVlqTnzTxAENJF; //Field offset: 0x9C
	private Vector2 UUobQKJMgrcPFbyCMLsEXuTcVGkJ; //Field offset: 0xA4
	private Vector2 JUyjpQsgNBsalDjOtJNKoSHfxkpf; //Field offset: 0xAC
	private float DZNbsASltAZnyrSXxGarstTUKajo; //Field offset: 0xB4
	private bool EUPJoJGnbXorIkCKEMvYfLKthRPjA; //Field offset: 0xB8
	private Action<Vector2> gEbhMJHTiPtsqHAPovNTqmDEOHeT; //Field offset: 0xC0
	private bool nUkFpcYIQcBbmgDrgbAZDqTGeXcdA; //Field offset: 0xC8
	private ScreenRect eNimyDcYlfGPxPMEbKFKmlfflcmD; //Field offset: 0xCC
	private bool uQrNSHcRfjUdjebLRQlAYtRlxLbi; //Field offset: 0xDC
	private MovementAreaUnit HtCCjlbpFAMSEcasVhEsZAMuiKlq; //Field offset: 0xE0

	public override event Action<Vector2> ScreenPositionChangedEvent
	{
		 add { } //Length: 239
		 remove { } //Length: 127
	}

	public bool clampToMovementArea
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public override bool defaultToCenter
	{
		 get { } //Length: 158
		 set { } //Length: 7
	}

	public override Button leftButton
	{
		 get { } //Length: 197
	}

	public override Button middleButton
	{
		 get { } //Length: 203
	}

	public override ScreenRect movementArea
	{
		 get { } //Length: 169
		 set { } //Length: 11
	}

	public override MovementAreaUnit movementAreaUnit
	{
		 get { } //Length: 157
		 set { } //Length: 7
	}

	public override float pointerSpeed
	{
		 get { } //Length: 160
		 set { } //Length: 181
	}

	private override bool Rewired.UI.IMouseInputSource.enabled
	{
		private get { } //Length: 7
	}

	private override bool Rewired.UI.IMouseInputSource.locked
	{
		private get { } //Length: 3
	}

	private override Vector2 Rewired.UI.IMouseInputSource.screenPosition
	{
		private get { } //Length: 25
	}

	private override Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta
	{
		private get { } //Length: 25
	}

	private override Vector2 Rewired.UI.IMouseInputSource.wheelDelta
	{
		private get { } //Length: 138
	}

	public override Button rightButton
	{
		 get { } //Length: 203
	}

	public override Vector2 screenPosition
	{
		 get { } //Length: 297
		 set { } //Length: 8
	}

	public override Vector2 screenPositionDelta
	{
		 get { } //Length: 297
	}

	public override Vector2 screenPositionPrev
	{
		 get { } //Length: 297
	}

	public override bool useHardwarePointerPosition
	{
		 get { } //Length: 158
		 set { } //Length: 188
	}

	public override MouseWheel wheel
	{
		 get { } //Length: 224
	}

	public override MouseAxis xAxis
	{
		 get { } //Length: 272
	}

	public override MouseAxis yAxis
	{
		 get { } //Length: 272
	}

	private static PlayerMouse() { }

	private PlayerMouse(Definition unnamed_param_0) { }

	public override void add_ScreenPositionChangedEvent(Action<Vector2> value) { }

	protected virtual void ClearVars() { }

	public bool get_clampToMovementArea() { }

	public override bool get_defaultToCenter() { }

	public override Button get_leftButton() { }

	public override Button get_middleButton() { }

	public override ScreenRect get_movementArea() { }

	public override MovementAreaUnit get_movementAreaUnit() { }

	public override float get_pointerSpeed() { }

	public override Button get_rightButton() { }

	public override Vector2 get_screenPosition() { }

	public override Vector2 get_screenPositionDelta() { }

	public override Vector2 get_screenPositionPrev() { }

	public override bool get_useHardwarePointerPosition() { }

	public override MouseWheel get_wheel() { }

	public override MouseAxis get_xAxis() { }

	public override MouseAxis get_yAxis() { }

	private void GUyqaMXiMpaCeBJyDqommIQotfZNA() { }

	private static float nmwEPRvShhHYwfPKkyLXqqjVUoFf(Axis unnamed_param_0, float unnamed_param_1, float unnamed_param_2) { }

	private ScreenRect OkWOooONJJWjSkygNWcKhwZVWDck() { }

	public override void remove_ScreenPositionChangedEvent(Action<Vector2> value) { }

	private override bool Rewired.UI.IMouseInputSource.get_enabled() { }

	private override bool Rewired.UI.IMouseInputSource.get_locked() { }

	private override Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }

	private override Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }

	private override Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }

	private override bool Rewired.UI.IMouseInputSource.GetButton(int button) { }

	private override bool Rewired.UI.IMouseInputSource.GetButtonDown(int button) { }

	private override bool Rewired.UI.IMouseInputSource.GetButtonUp(int button) { }

	public void set_clampToMovementArea(bool value) { }

	public void set_defaultToCenter(bool value) { }

	public override void set_movementArea(ScreenRect value) { }

	public override void set_movementAreaUnit(MovementAreaUnit value) { }

	public void set_pointerSpeed(float value) { }

	public void set_screenPosition(Vector2 value) { }

	public void set_useHardwarePointerPosition(bool value) { }

	private void umjHdDjelBiEHWATGJvASZCYpIsT(Vector2 unnamed_param_0) { }

	protected virtual bool Update(UpdateLoopType updateLoop) { }

	protected virtual void UpdateFinished() { }

}

