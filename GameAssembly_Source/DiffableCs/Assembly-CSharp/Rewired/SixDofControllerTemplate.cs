namespace Rewired;

public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid; //Field offset: 0x6764C
	public const int elementId_positionY = 2; //Field offset: 0x67670
	public const int elementId_positionZ = 0; //Field offset: 0x676CD
	public const int elementId_rotationY = 5; //Field offset: 0x676D0
	public const int elementId_rotationZ = 4; //Field offset: 0x676FC
	public const int elementId_throttle1MinDetent = 50; //Field offset: 0x67700
	public const int elementId_throttle2Axis = 7; //Field offset: 0x6779D
	public const int elementId_extraAxis1 = 8; //Field offset: 0x677A0
	public const int elementId_extraAxis2 = 9; //Field offset: 0x677CC
	public const int elementId_extraAxis4 = 11; //Field offset: 0x677D0
	public const int elementId_button1 = 12; //Field offset: 0x677FC
	public const int elementId_button3 = 14; //Field offset: 0x67800
	public const int elementId_button4 = 15; //Field offset: 0x6782C
	public const int elementId_button6 = 17; //Field offset: 0x67830
	public const int elementId_button7 = 18; //Field offset: 0x6786E
	public const int elementId_button9 = 20; //Field offset: 0x678B0
	public const int elementId_button10 = 21; //Field offset: 0x678DC
	public const int elementId_button12 = 23; //Field offset: 0x678E0
	public const int elementId_button13 = 24; //Field offset: 0x67932
	public const int elementId_button15 = 26; //Field offset: 0x67940
	public const int elementId_button16 = 27; //Field offset: 0x679ED
	public const int elementId_button18 = 29; //Field offset: 0x679F0
	public const int elementId_button19 = 30; //Field offset: 0x67A2E
	public const int elementId_button21 = 55; //Field offset: 0x67A30
	public const int elementId_button22 = 56; //Field offset: 0x67A5C
	public const int elementId_button24 = 58; //Field offset: 0x67A60
	public const int elementId_button25 = 59; //Field offset: 0x67A9E
	public const int elementId_button27 = 61; //Field offset: 0x67AE0
	public const int elementId_button28 = 62; //Field offset: 0x67B0C
	public const int elementId_button30 = 64; //Field offset: 0x67B10
	public const int elementId_button31 = 65; //Field offset: 0x67B3F
	public const int elementId_hat1Up = 32; //Field offset: 0x67B40
	public const int elementId_hat1UpRight = 33; //Field offset: 0x67B6C
	public const int elementId_hat1DownRight = 35; //Field offset: 0x67B90
	public const int elementId_hat1Down = 36; //Field offset: 0x67BF6
	public const int elementId_hat1Left = 38; //Field offset: 0x67C00
	public const int elementId_hat1UpLeft = 39; //Field offset: 0x67C3E
	public const int elementId_hat2UpRight = 41; //Field offset: 0x67C60
	public const int elementId_hat2Right = 42; //Field offset: 0x67C8C
	public const int elementId_hat2Down = 44; //Field offset: 0x67CB0
	public const int elementId_hat2DownLeft = 45; //Field offset: 0x67CDC
	public const int elementId_hat2UpLeft = 47; //Field offset: 0x67CE0
	public const int elementId_hat1 = 48; //Field offset: 0x67D1E
	public const int elementId_throttle1 = 52; //Field offset: 0x67D20
	public const int elementId_throttle2 = 53; //Field offset: 0x67DAB
	public const int elementId_hat2 = 49; //Field offset: 0x2C927B4
	public const int elementId_hat2Left = 46; //Field offset: 0x2C927B4
	public const int elementId_hat2Up = 40; //Field offset: 0x2C927B4
	public const int elementId_hat2DownRight = 43; //Field offset: 0x2C927B4
	public const int elementId_button5 = 16; //Field offset: 0x2C927B4
	public const int elementId_button32 = 66; //Field offset: 0x2C927B4
	public const int elementId_button8 = 19; //Field offset: 0x2C927B4
	public const int elementId_button2 = 13; //Field offset: 0x2C927B4
	public const int elementId_button29 = 63; //Field offset: 0x2C927B4
	public const int elementId_button26 = 60; //Field offset: 0x2C927B4
	public const int elementId_button23 = 57; //Field offset: 0x2C927B4
	public const int elementId_button20 = 31; //Field offset: 0x2C927B4
	public const int elementId_positionX = 1; //Field offset: 0x2C927B4
	public const int elementId_hat1Right = 34; //Field offset: 0x2C927B4
	public const int elementId_button11 = 22; //Field offset: 0x2C927B4
	public const int elementId_throttle1Axis = 6; //Field offset: 0x2C927B4
	public const int elementId_button14 = 25; //Field offset: 0x2C927B4
	public const int elementId_extraAxis3 = 10; //Field offset: 0x2C927B4
	public const int elementId_button17 = 28; //Field offset: 0x2C927BC
	public const int elementId_rotationX = 3; //Field offset: 0x2C927BC
	public const int elementId_throttle2MinDetent = 51; //Field offset: 0x2C927BC
	public const int elementId_stick = 54; //Field offset: 0x2C927BC
	public const int elementId_hat1DownLeft = 37; //Field offset: 0x2C927FC

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button11
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button12
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button13
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button14
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button15
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button16
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button17
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button18
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button19
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button20
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button21
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button22
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button23
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button24
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button25
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button26
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button27
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button28
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button29
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button30
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button31
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button32
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.button9
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.stick
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle2
	{
		private get { } //Length: 61
	}

	private static SixDofControllerTemplate() { }

	public SixDofControllerTemplate(object payload) { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button1() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button10() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button11() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button12() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button13() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button14() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button15() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button16() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button17() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button18() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button19() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button2() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button20() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button21() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button22() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button23() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button24() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button25() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button26() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button27() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button28() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button29() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button3() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button30() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button31() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button32() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button4() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button5() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button6() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button7() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button8() { }

	private override IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button9() { }

	private override IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis1() { }

	private override IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis2() { }

	private override IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis3() { }

	private override IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis4() { }

	private override IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat1() { }

	private override IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat2() { }

	private override IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.get_stick() { }

	private override IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle1() { }

	private override IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle2() { }

}

