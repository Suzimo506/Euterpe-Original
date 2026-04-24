namespace Rewired;

public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid; //Field offset: 0x65BE0
	public const int elementId_stickX = 0; //Field offset: 0x65C27
	public const int elementId_stickRotate = 2; //Field offset: 0x65C30
	public const int elementId_stickMiniStick1X = 78; //Field offset: 0x65CA5
	public const int elementId_stickMiniStick1Press = 80; //Field offset: 0x65CB0
	public const int elementId_stickMiniStick2X = 81; //Field offset: 0x65CFA
	public const int elementId_stickMiniStick2Press = 83; //Field offset: 0x65D00
	public const int elementId_stickTrigger = 3; //Field offset: 0x65D3E
	public const int elementId_stickPinkyButton = 5; //Field offset: 0x65D40
	public const int elementId_stickPinkyTrigger = 154; //Field offset: 0x65D7E
	public const int elementId_stickButton2 = 7; //Field offset: 0x65D80
	public const int elementId_stickButton3 = 8; //Field offset: 0x65DBC
	public const int elementId_stickButton5 = 10; //Field offset: 0x65DC0
	public const int elementId_stickButton6 = 11; //Field offset: 0x65E53
	public const int elementId_stickButton8 = 13; //Field offset: 0x65E60
	public const int elementId_stickButton9 = 14; //Field offset: 0x65EAA
	public const int elementId_stickBaseButton1 = 18; //Field offset: 0x65EB0
	public const int elementId_stickBaseButton2 = 19; //Field offset: 0x65EEE
	public const int elementId_stickBaseButton4 = 21; //Field offset: 0x65EF0
	public const int elementId_stickBaseButton5 = 22; //Field offset: 0x65F78
	public const int elementId_stickBaseButton7 = 24; //Field offset: 0x65F80
	public const int elementId_stickBaseButton8 = 25; //Field offset: 0x65FAC
	public const int elementId_stickBaseButton10 = 27; //Field offset: 0x65FB0
	public const int elementId_stickBaseButton11 = 161; //Field offset: 0x65FF7
	public const int elementId_stickHat1Up = 28; //Field offset: 0x66000
	public const int elementId_stickHat1UpRight = 29; //Field offset: 0x6604A
	public const int elementId_stickHat1DownRight = 31; //Field offset: 0x66050
	public const int elementId_stickHat1Down = 32; //Field offset: 0x660F1
	public const int elementId_stickHat1Left = 34; //Field offset: 0x66100
	public const int elementId_stickHat1Up_Left = 35; //Field offset: 0x6613E
	public const int elementId_stickHat2Up_right = 37; //Field offset: 0x66140
	public const int elementId_stickHat2Right = 38; //Field offset: 0x6616C
	public const int elementId_stickHat2Down = 40; //Field offset: 0x66170
	public const int elementId_stickHat2Down_Left = 41; //Field offset: 0x661B7
	public const int elementId_stickHat2Up_Left = 43; //Field offset: 0x661C0
	public const int elementId_stickHat3Up = 84; //Field offset: 0x66207
	public const int elementId_stickHat3Right = 86; //Field offset: 0x66210
	public const int elementId_stickHat3Down_Right = 87; //Field offset: 0x6624E
	public const int elementId_stickHat3Down_Left = 89; //Field offset: 0x66250
	public const int elementId_stickHat3Left = 90; //Field offset: 0x6627C
	public const int elementId_stickHat4Up = 92; //Field offset: 0x66280
	public const int elementId_stickHat4Up_Right = 93; //Field offset: 0x662CA
	public const int elementId_stickHat4Down_Right = 95; //Field offset: 0x662D0
	public const int elementId_stickHat4Down = 96; //Field offset: 0x66317
	public const int elementId_stickHat4Left = 98; //Field offset: 0x66320
	public const int elementId_stickHat4Up_Left = 99; //Field offset: 0x6634C
	public const int elementId_mode2 = 45; //Field offset: 0x66350
	public const int elementId_mode3 = 46; //Field offset: 0x6639F
	public const int elementId_throttle2Axis = 155; //Field offset: 0x663A0
	public const int elementId_throttle1MinDetent = 166; //Field offset: 0x663E7
	public const int elementId_throttleButton1 = 50; //Field offset: 0x663F0
	public const int elementId_throttleButton2 = 51; //Field offset: 0x6642E
	public const int elementId_throttleButton4 = 53; //Field offset: 0x66430
	public const int elementId_throttleButton5 = 54; //Field offset: 0x66459
	public const int elementId_throttleButton7 = 56; //Field offset: 0x66460
	public const int elementId_throttleButton8 = 57; //Field offset: 0x664DC
	public const int elementId_throttleButton10 = 59; //Field offset: 0x664E0
	public const int elementId_throttleBaseButton1 = 60; //Field offset: 0x6650C
	public const int elementId_throttleBaseButton3 = 62; //Field offset: 0x66510
	public const int elementId_throttleBaseButton4 = 63; //Field offset: 0x66579
	public const int elementId_throttleBaseButton6 = 65; //Field offset: 0x66580
	public const int elementId_throttleBaseButton7 = 66; //Field offset: 0x665CF
	public const int elementId_throttleBaseButton9 = 68; //Field offset: 0x665D0
	public const int elementId_throttleBaseButton10 = 69; //Field offset: 0x66611
	public const int elementId_throttleBaseButton12 = 133; //Field offset: 0x66620
	public const int elementId_throttleBaseButton13 = 134; //Field offset: 0x66674
	public const int elementId_throttleBaseButton15 = 136; //Field offset: 0x66680
	public const int elementId_throttleSlider1 = 70; //Field offset: 0x666BE
	public const int elementId_throttleSlider3 = 72; //Field offset: 0x666C0
	public const int elementId_throttleSlider4 = 73; //Field offset: 0x666FE
	public const int elementId_throttleDial2 = 142; //Field offset: 0x66700
	public const int elementId_throttleDial3 = 143; //Field offset: 0x66730
	public const int elementId_throttleMiniStickX = 75; //Field offset: 0x66730
	public const int elementId_throttleMiniStickY = 76; //Field offset: 0x6676E
	public const int elementId_throttleWheel1Forward = 145; //Field offset: 0x66770
	public const int elementId_throttleWheel1Back = 146; //Field offset: 0x667BF
	public const int elementId_throttleWheel2Forward = 148; //Field offset: 0x667C0
	public const int elementId_throttleWheel2Back = 149; //Field offset: 0x667EF
	public const int elementId_throttleWheel3Forward = 151; //Field offset: 0x667F0
	public const int elementId_throttleWheel3Back = 152; //Field offset: 0x66837
	public const int elementId_throttleHat1Up = 100; //Field offset: 0x66840
	public const int elementId_throttleHat1Up_Right = 101; //Field offset: 0x66887
	public const int elementId_throttleHat1Down_Right = 103; //Field offset: 0x66890
	public const int elementId_throttleHat1Down = 104; //Field offset: 0x668CE
	public const int elementId_throttleHat1Left = 106; //Field offset: 0x668D0
	public const int elementId_throttleHat1Up_Left = 107; //Field offset: 0x668FC
	public const int elementId_throttleHat2Up_Right = 109; //Field offset: 0x66900
	public const int elementId_throttleHat2Right = 110; //Field offset: 0x6692C
	public const int elementId_throttleHat2Down = 112; //Field offset: 0x66930
	public const int elementId_throttleHat2Down_Left = 113; //Field offset: 0x6695C
	public const int elementId_throttleHat2Up_Left = 115; //Field offset: 0x66960
	public const int elementId_throttleHat3Up = 116; //Field offset: 0x669A7
	public const int elementId_throttleHat3Right = 118; //Field offset: 0x669D0
	public const int elementId_throttleHat3Down_Right = 119; //Field offset: 0x66A0E
	public const int elementId_throttleHat3Down_Left = 121; //Field offset: 0x66A10
	public const int elementId_throttleHat3Left = 122; //Field offset: 0x66A3C
	public const int elementId_throttleHat4Up = 124; //Field offset: 0x66A40
	public const int elementId_throttleHat4Up_Right = 125; //Field offset: 0x66A6C
	public const int elementId_throttleHat4Down_Right = 127; //Field offset: 0x66A70
	public const int elementId_throttleHat4Down = 128; //Field offset: 0x66ACE
	public const int elementId_throttleHat4Left = 130; //Field offset: 0x66AD0
	public const int elementId_throttleHat4Up_Left = 131; //Field offset: 0x66B50
	public const int elementId_rightPedal = 169; //Field offset: 0x66B50
	public const int elementId_slidePedals = 170; //Field offset: 0x66B8E
	public const int elementId_stickMiniStick1 = 172; //Field offset: 0x66B90
	public const int elementId_stickMiniStick2 = 173; //Field offset: 0x66BBC
	public const int elementId_stickHat2 = 175; //Field offset: 0x66BC0
	public const int elementId_stickHat3 = 176; //Field offset: 0x66C0A
	public const int elementId_throttle1 = 178; //Field offset: 0x66C10
	public const int elementId_throttle2 = 179; //Field offset: 0x66C83
	public const int elementId_throttleHat1 = 181; //Field offset: 0x66C90
	public const int elementId_throttleHat2 = 182; //Field offset: 0x66CBC
	public const int elementId_throttleHat4 = 184; //Field offset: 0x66CC0
	public const int elementId_throttleWheel1Press = 147; //Field offset: 0x2C927B4
	public const int elementId_throttleButton3 = 52; //Field offset: 0x2C927B4
	public const int elementId_stickButton1 = 6; //Field offset: 0x2C927B4
	public const int elementId_stickHat3Down = 88; //Field offset: 0x2C927B4
	public const int elementId_stickButton4 = 9; //Field offset: 0x2C927B4
	public const int elementId_throttleHat3Up_Left = 123; //Field offset: 0x2C927B4
	public const int elementId_stickButton10 = 15; //Field offset: 0x2C927B4
	public const int elementId_throttleHat4Right = 126; //Field offset: 0x2C927B4
	public const int elementId_throttle1Axis = 49; //Field offset: 0x2C927B4
	public const int elementId_stickBaseButton3 = 20; //Field offset: 0x2C927B4
	public const int elementId_mode1 = 44; //Field offset: 0x2C927B4
	public const int elementId_stickBaseButton9 = 26; //Field offset: 0x2C927B4
	public const int elementId_stick = 171; //Field offset: 0x2C927B4
	public const int elementId_stickHat1Right = 30; //Field offset: 0x2C927B4
	public const int elementId_stickHat1 = 174; //Field offset: 0x2C927B4
	public const int elementId_stickHat4Right = 94; //Field offset: 0x2C927B4
	public const int elementId_stickHat4 = 177; //Field offset: 0x2C927B4
	public const int elementId_stickHat2Up = 36; //Field offset: 0x2C927B4
	public const int elementId_stickHat2Down_Right = 39; //Field offset: 0x2C927B4
	public const int elementId_stickHat3Up_Left = 91; //Field offset: 0x2C927B4
	public const int elementId_stickTriggerStage2 = 4; //Field offset: 0x2C927B4
	public const int elementId_stickMiniStick2Y = 82; //Field offset: 0x2C927B4
	public const int elementId_throttleHat3Down = 120; //Field offset: 0x2C927B4
	public const int elementId_throttleButton6 = 55; //Field offset: 0x2C927B4
	public const int elementId_throttleHat2Left = 114; //Field offset: 0x2C927B4
	public const int elementId_throttleBaseButton8 = 67; //Field offset: 0x2C927B4
	public const int elementId_throttleHat1Down_Left = 105; //Field offset: 0x2C927B4
	public const int elementId_throttleBaseButton2 = 61; //Field offset: 0x2C927B4
	public const int elementId_throttleSlider2 = 71; //Field offset: 0x2C927B4
	public const int elementId_throttleHat2Up = 108; //Field offset: 0x2C927B4
	public const int elementId_throttleHat3 = 183; //Field offset: 0x2C927B4
	public const int elementId_throttleWheel2Press = 150; //Field offset: 0x2C927B4
	public const int elementId_throttleDial4 = 144; //Field offset: 0x2C927B4
	public const int elementId_throttleHat2Down_Right = 111; //Field offset: 0x2C927B4
	public const int elementId_throttleMiniStickPress = 77; //Field offset: 0x2C927B4
	public const int elementId_throttleDial1 = 74; //Field offset: 0x2C927B4
	public const int elementId_throttleBaseButton11 = 132; //Field offset: 0x2C927B4
	public const int elementId_stickHat4Down_Left = 97; //Field offset: 0x2C927BC
	public const int elementId_stickHat1DownLeft = 33; //Field offset: 0x2C927BC
	public const int elementId_throttleWheel3Press = 153; //Field offset: 0x2C927BC
	public const int elementId_throttleBaseButton14 = 135; //Field offset: 0x2C927BC
	public const int elementId_stickHat2Left = 42; //Field offset: 0x2C927BC
	public const int elementId_stickHat3Up_Right = 85; //Field offset: 0x2C927BC
	public const int elementId_throttleHat1Right = 102; //Field offset: 0x2C927BC
	public const int elementId_stickBaseButton6 = 23; //Field offset: 0x2C927BC
	public const int elementId_throttleHat4Down_Left = 129; //Field offset: 0x2C927BC
	public const int elementId_throttleBaseButton5 = 64; //Field offset: 0x2C927BC
	public const int elementId_stickButton7 = 12; //Field offset: 0x2C927BC
	public const int elementId_throttle2MinDetent = 167; //Field offset: 0x2C927BC
	public const int elementId_throttleButton9 = 58; //Field offset: 0x2C927BC
	public const int elementId_stickY = 1; //Field offset: 0x2C927BC
	public const int elementId_stickMiniStick1Y = 79; //Field offset: 0x2C927BC
	public const int elementId_throttleHat3Up_Right = 117; //Field offset: 0x2C927BC
	public const int elementId_stickBaseButton12 = 162; //Field offset: 0x2C927BC
	public const int elementId_leftPedal = 168; //Field offset: 0x2C927DC
	public const int elementId_throttleMiniStick = 180; //Field offset: 0x2C927FC

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.leftPedal
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.mode1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.mode2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.mode3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.rightPedal
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.slidePedals
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateStick Rewired.IHOTASTemplate.stick
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton11
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton12
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton9
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickButton9
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IHOTASTemplate.stickHat1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IHOTASTemplate.stickHat2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IHOTASTemplate.stickHat3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IHOTASTemplate.stickHat4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyButton
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyTrigger
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickTrigger
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.stickTriggerStage2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton11
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton12
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton13
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton14
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton15
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton9
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton9
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateThumbStick Rewired.IHOTASTemplate.throttleMiniStick
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Back
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Forward
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Press
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Back
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Forward
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Press
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Back
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Forward
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Press
	{
		private get { } //Length: 61
	}

	private static HOTASTemplate() { }

	public HOTASTemplate(object payload) { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_leftPedal() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_mode1() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_mode2() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_mode3() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_rightPedal() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_slidePedals() { }

	private override IControllerTemplateStick Rewired.IHOTASTemplate.get_stick() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton1() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton10() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton11() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton12() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton2() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton3() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton4() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton5() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton6() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton7() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton8() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton9() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton1() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton10() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton2() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton3() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton4() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton5() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton6() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton7() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton8() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton9() { }

	private override IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat1() { }

	private override IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat2() { }

	private override IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat3() { }

	private override IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat4() { }

	private override IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick1() { }

	private override IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick2() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyButton() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyTrigger() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTrigger() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTriggerStage2() { }

	private override IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle1() { }

	private override IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle2() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton1() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton10() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton11() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton12() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton13() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton14() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton15() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton2() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton3() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton4() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton5() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton6() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton7() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton8() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton9() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton1() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton10() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton2() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton3() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton4() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton5() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton6() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton7() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton8() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton9() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial1() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial2() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial3() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial4() { }

	private override IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat1() { }

	private override IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat2() { }

	private override IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat3() { }

	private override IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat4() { }

	private override IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_throttleMiniStick() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider1() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider2() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider3() { }

	private override IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider4() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Back() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Forward() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Press() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Back() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Forward() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Press() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Back() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Forward() { }

	private override IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Press() { }

}

