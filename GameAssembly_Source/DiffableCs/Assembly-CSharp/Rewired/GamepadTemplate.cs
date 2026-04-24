namespace Rewired;

public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
{
	public const int elementId_leftStickX = 0; //Field offset: 0x65310
	public const int elementId_leftStickY = 1; //Field offset: 0x6534E
	public const int elementId_rightStickY = 3; //Field offset: 0x65350
	public const int elementId_actionBottomRow1 = 4; //Field offset: 0x653AD
	public const int elementId_actionBottomRow2 = 5; //Field offset: 0x653B0
	public const int elementId_b = 5; //Field offset: 0x653EE
	public const int elementId_c = 6; //Field offset: 0x653F0
	public const int elementId_actionTopRow1 = 7; //Field offset: 0x6542C
	public const int elementId_actionTopRow2 = 8; //Field offset: 0x65430
	public const int elementId_y = 8; //Field offset: 0x6546E
	public const int elementId_z = 9; //Field offset: 0x65470
	public const int elementId_leftShoulder1 = 10; //Field offset: 0x65493
	public const int elementId_leftShoulder2 = 11; //Field offset: 0x654A0
	public const int elementId_leftTrigger = 11; //Field offset: 0x654CC
	public const int elementId_rightBumper = 12; //Field offset: 0x654D0
	public const int elementId_rightShoulder2 = 13; //Field offset: 0x6552D
	public const int elementId_center1 = 14; //Field offset: 0x65530
	public const int elementId_back = 14; //Field offset: 0x655B8
	public const int elementId_start = 15; //Field offset: 0x655C0
	public const int elementId_center3 = 16; //Field offset: 0x6560A
	public const int elementId_leftStickButton = 17; //Field offset: 0x65610
	public const int elementId_rightStickButton = 18; //Field offset: 0x6564E
	public const int elementId_dPadRight = 20; //Field offset: 0x65650
	public const int elementId_dPadDown = 21; //Field offset: 0x65697
	public const int elementId_leftStick = 23; //Field offset: 0x656A0
	public const int elementId_rightStick = 24; //Field offset: 0x656DC
	public const int elementId_guide = 16; //Field offset: 0x2C927B4
	public const int elementId_dPadUp = 19; //Field offset: 0x2C927B4
	public static readonly Guid typeGuid; //Field offset: 0x2C927B4
	public const int elementId_rightShoulder1 = 12; //Field offset: 0x2C927B4
	public const int elementId_leftBumper = 10; //Field offset: 0x2C927B4
	public const int elementId_actionTopRow3 = 9; //Field offset: 0x2C927B4
	public const int elementId_x = 7; //Field offset: 0x2C927B4
	public const int elementId_actionBottomRow3 = 6; //Field offset: 0x2C927B4
	public const int elementId_rightStickX = 2; //Field offset: 0x2C927B4
	public const int elementId_dPad = 25; //Field offset: 0x2C927B4
	public const int elementId_rightTrigger = 13; //Field offset: 0x2C927BC
	public const int elementId_a = 4; //Field offset: 0x2C927BC
	public const int elementId_dPadLeft = 22; //Field offset: 0x2C927BC
	public const int elementId_center2 = 15; //Field offset: 0x2C927BC

	private override IControllerTemplateButton Rewired.IGamepadTemplate.a
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.b
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.back
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.c
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.center1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.center2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.center3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateDPad Rewired.IGamepadTemplate.dPad
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.guide
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.leftBumper
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.leftShoulder1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IGamepadTemplate.leftShoulder2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThumbStick Rewired.IGamepadTemplate.leftStick
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IGamepadTemplate.leftTrigger
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.rightBumper
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.rightShoulder1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IGamepadTemplate.rightShoulder2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThumbStick Rewired.IGamepadTemplate.rightStick
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IGamepadTemplate.rightTrigger
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.start
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.x
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.y
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IGamepadTemplate.z
	{
		private get { } //Length: 61
	}

	private static GamepadTemplate() { }

	public GamepadTemplate(object payload) { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_a() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow1() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow2() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow3() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow1() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow2() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow3() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_b() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_back() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_c() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_center1() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_center2() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_center3() { }

	private override IControllerTemplateDPad Rewired.IGamepadTemplate.get_dPad() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_guide() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_leftBumper() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_leftShoulder1() { }

	private override IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftShoulder2() { }

	private override IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_leftStick() { }

	private override IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftTrigger() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_rightBumper() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_rightShoulder1() { }

	private override IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightShoulder2() { }

	private override IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_rightStick() { }

	private override IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightTrigger() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_start() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_x() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_y() { }

	private override IControllerTemplateButton Rewired.IGamepadTemplate.get_z() { }

}

