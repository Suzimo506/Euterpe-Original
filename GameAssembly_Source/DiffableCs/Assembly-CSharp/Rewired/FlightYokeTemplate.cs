namespace Rewired;

public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid; //Field offset: 0x66D4A
	public const int elementId_yokeZ = 1; //Field offset: 0x66D50
	public const int elementId_leftPaddle = 59; //Field offset: 0x66D7C
	public const int elementId_lever1Axis = 2; //Field offset: 0x66D80
	public const int elementId_lever1MinDetent = 64; //Field offset: 0x66DBE
	public const int elementId_lever2MinDetent = 65; //Field offset: 0x66DC0
	public const int elementId_lever3Axis = 4; //Field offset: 0x66DFC
	public const int elementId_lever4Axis = 5; //Field offset: 0x66E00
	public const int elementId_lever4MinDetent = 67; //Field offset: 0x66E5A
	public const int elementId_lever5MinDetent = 68; //Field offset: 0x66E60
	public const int elementId_leftGripButton1 = 7; //Field offset: 0x66F64
	public const int elementId_leftGripButton3 = 9; //Field offset: 0x66F70
	public const int elementId_leftGripButton4 = 10; //Field offset: 0x66FCD
	public const int elementId_leftGripButton6 = 12; //Field offset: 0x66FD0
	public const int elementId_rightGripButton1 = 13; //Field offset: 0x66FFC
	public const int elementId_rightGripButton3 = 15; //Field offset: 0x67000
	public const int elementId_rightGripButton4 = 16; //Field offset: 0x67066
	public const int elementId_rightGripButton6 = 18; //Field offset: 0x67070
	public const int elementId_centerButton1 = 19; //Field offset: 0x670AE
	public const int elementId_centerButton3 = 21; //Field offset: 0x670B0
	public const int elementId_centerButton4 = 22; //Field offset: 0x670DC
	public const int elementId_centerButton6 = 24; //Field offset: 0x670E0
	public const int elementId_centerButton7 = 25; //Field offset: 0x6711C
	public const int elementId_wheel1Up = 53; //Field offset: 0x67120
	public const int elementId_wheel1Down = 54; //Field offset: 0x6716A
	public const int elementId_wheel2Up = 56; //Field offset: 0x67170
	public const int elementId_wheel2Down = 57; //Field offset: 0x671DB
	public const int elementId_leftGripHatUp = 27; //Field offset: 0x671E0
	public const int elementId_leftGripHatUpRight = 28; //Field offset: 0x6721E
	public const int elementId_leftGripHatDownRight = 30; //Field offset: 0x67220
	public const int elementId_leftGripHatDown = 31; //Field offset: 0x6724C
	public const int elementId_leftGripHatLeft = 33; //Field offset: 0x67250
	public const int elementId_leftGripHatUpLeft = 34; //Field offset: 0x6728C
	public const int elementId_rightGripHatUpRight = 36; //Field offset: 0x672B0
	public const int elementId_rightGripHatRight = 37; //Field offset: 0x67316
	public const int elementId_rightGripHatDown = 39; //Field offset: 0x67320
	public const int elementId_rightGripHatDownLeft = 40; //Field offset: 0x6737D
	public const int elementId_rightGripHatUpLeft = 42; //Field offset: 0x67380
	public const int elementId_consoleButton1 = 43; //Field offset: 0x673AC
	public const int elementId_consoleButton3 = 45; //Field offset: 0x673B0
	public const int elementId_consoleButton4 = 46; //Field offset: 0x673D9
	public const int elementId_consoleButton6 = 48; //Field offset: 0x673E0
	public const int elementId_consoleButton7 = 49; //Field offset: 0x67449
	public const int elementId_consoleButton9 = 51; //Field offset: 0x67450
	public const int elementId_consoleButton10 = 52; //Field offset: 0x6749A
	public const int elementId_mode2 = 62; //Field offset: 0x674A0
	public const int elementId_mode3 = 63; //Field offset: 0x674DE
	public const int elementId_lever1 = 70; //Field offset: 0x674E0
	public const int elementId_lever2 = 71; //Field offset: 0x67549
	public const int elementId_lever4 = 73; //Field offset: 0x67550
	public const int elementId_lever5 = 74; //Field offset: 0x675A2
	public const int elementId_rightGripHat = 76; //Field offset: 0x675B0
	public const int elementId_rightGripButton2 = 14; //Field offset: 0x2C927B4
	public const int elementId_centerButton5 = 23; //Field offset: 0x2C927B4
	public const int elementId_lever3MinDetent = 66; //Field offset: 0x2C927B4
	public const int elementId_mode1 = 61; //Field offset: 0x2C927B4
	public const int elementId_lever2Axis = 3; //Field offset: 0x2C927B4
	public const int elementId_centerButton8 = 26; //Field offset: 0x2C927B4
	public const int elementId_rightPaddle = 60; //Field offset: 0x2C927B4
	public const int elementId_rotateYoke = 0; //Field offset: 0x2C927B4
	public const int elementId_yoke = 69; //Field offset: 0x2C927B4
	public const int elementId_consoleButton5 = 47; //Field offset: 0x2C927B4
	public const int elementId_leftGripHat = 75; //Field offset: 0x2C927B4
	public const int elementId_consoleButton2 = 44; //Field offset: 0x2C927B4
	public const int elementId_centerButton2 = 20; //Field offset: 0x2C927B4
	public const int elementId_leftGripHatRight = 29; //Field offset: 0x2C927B4
	public const int elementId_leftGripHatDownLeft = 32; //Field offset: 0x2C927B4
	public const int elementId_rightGripHatUp = 35; //Field offset: 0x2C927B4
	public const int elementId_wheel1Press = 55; //Field offset: 0x2C927B4
	public const int elementId_lever3 = 72; //Field offset: 0x2C927BC
	public const int elementId_leftGripButton5 = 11; //Field offset: 0x2C927BC
	public const int elementId_leftGripButton2 = 8; //Field offset: 0x2C927BC
	public const int elementId_consoleButton8 = 50; //Field offset: 0x2C927BC
	public const int elementId_wheel2Press = 58; //Field offset: 0x2C927BC
	public const int elementId_rightGripHatLeft = 41; //Field offset: 0x2C927BC
	public const int elementId_lever5Axis = 6; //Field offset: 0x2C927BC
	public const int elementId_rightGripButton5 = 17; //Field offset: 0x2C927FC
	public const int elementId_rightGripHatDownRight = 38; //Field offset: 0x2C927FC

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton9
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IFlightYokeTemplate.leftGripHat
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.leftPaddle
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.mode1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.mode2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.mode3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IFlightYokeTemplate.rightGripHat
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.rightPaddle
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Down
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Press
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Up
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Down
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Press
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Up
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateYoke Rewired.IFlightYokeTemplate.yoke
	{
		private get { } //Length: 61
	}

	private static FlightYokeTemplate() { }

	public FlightYokeTemplate(object payload) { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton1() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton2() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton3() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton4() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton5() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton6() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton7() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton8() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton1() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton10() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton2() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton3() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton4() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton5() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton6() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton7() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton8() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton9() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton1() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton2() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton3() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton4() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton5() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton6() { }

	private override IControllerTemplateHat Rewired.IFlightYokeTemplate.get_leftGripHat() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftPaddle() { }

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever1() { }

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever2() { }

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever3() { }

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever4() { }

	private override IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever5() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode1() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode2() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode3() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton1() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton2() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton3() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton4() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton5() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton6() { }

	private override IControllerTemplateHat Rewired.IFlightYokeTemplate.get_rightGripHat() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightPaddle() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Down() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Press() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Up() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Down() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Press() { }

	private override IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Up() { }

	private override IControllerTemplateYoke Rewired.IFlightYokeTemplate.get_yoke() { }

}

