namespace Rewired;

public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid; //Field offset: 0x656E0
	public const int elementId_wheel = 0; //Field offset: 0x6572A
	public const int elementId_brake = 2; //Field offset: 0x65730
	public const int elementId_clutch = 3; //Field offset: 0x6576C
	public const int elementId_shiftUp = 5; //Field offset: 0x65770
	public const int elementId_wheelButton1 = 6; //Field offset: 0x657D9
	public const int elementId_wheelButton3 = 8; //Field offset: 0x657E0
	public const int elementId_wheelButton4 = 9; //Field offset: 0x6585E
	public const int elementId_wheelButton6 = 11; //Field offset: 0x65860
	public const int elementId_wheelButton7 = 12; //Field offset: 0x6589E
	public const int elementId_wheelButton9 = 14; //Field offset: 0x658A0
	public const int elementId_wheelButton10 = 15; //Field offset: 0x65928
	public const int elementId_consoleButton2 = 17; //Field offset: 0x65930
	public const int elementId_consoleButton3 = 18; //Field offset: 0x6597A
	public const int elementId_consoleButton5 = 20; //Field offset: 0x65980
	public const int elementId_consoleButton6 = 21; //Field offset: 0x659CC
	public const int elementId_consoleButton8 = 23; //Field offset: 0x659D0
	public const int elementId_consoleButton9 = 24; //Field offset: 0x65A0E
	public const int elementId_shifter1 = 26; //Field offset: 0x65A10
	public const int elementId_shifter2 = 27; //Field offset: 0x65A3C
	public const int elementId_shifter4 = 29; //Field offset: 0x65A40
	public const int elementId_shifter5 = 30; //Field offset: 0x65A7C
	public const int elementId_shifter7 = 32; //Field offset: 0x65A80
	public const int elementId_shifter8 = 33; //Field offset: 0x65AC7
	public const int elementId_shifter10 = 35; //Field offset: 0x65AD0
	public const int elementId_reverseGear = 44; //Field offset: 0x65B0E
	public const int elementId_start = 37; //Field offset: 0x65B10
	public const int elementId_systemButton = 38; //Field offset: 0x65B5A
	public const int elementId_dPadUp = 39; //Field offset: 0x65B60
	public const int elementId_dPadRight = 40; //Field offset: 0x65B9C
	public const int elementId_dPadLeft = 42; //Field offset: 0x65BA0
	public const int elementId_dPad = 45; //Field offset: 0x65BDE
	public const int elementId_wheelButton5 = 10; //Field offset: 0x2C927A8
	public const int elementId_shifter6 = 31; //Field offset: 0x2C927B4
	public const int elementId_consoleButton10 = 25; //Field offset: 0x2C927B4
	public const int elementId_consoleButton4 = 19; //Field offset: 0x2C927B4
	public const int elementId_wheelButton8 = 13; //Field offset: 0x2C927B4
	public const int elementId_select = 36; //Field offset: 0x2C927B4
	public const int elementId_horn = 43; //Field offset: 0x2C927B4
	public const int elementId_shiftDown = 4; //Field offset: 0x2C927B4
	public const int elementId_accelerator = 1; //Field offset: 0x2C927B4
	public const int elementId_dPadDown = 41; //Field offset: 0x2C927B4
	public const int elementId_shifter3 = 28; //Field offset: 0x2C927B4
	public const int elementId_consoleButton7 = 22; //Field offset: 0x2C927B4
	public const int elementId_shifter9 = 34; //Field offset: 0x2C927BC
	public const int elementId_consoleButton1 = 16; //Field offset: 0x2C927BC
	public const int elementId_wheelButton2 = 7; //Field offset: 0x2C927BC

	private override IControllerTemplateAxis Rewired.IRacingWheelTemplate.accelerator
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IRacingWheelTemplate.brake
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IRacingWheelTemplate.clutch
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton9
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateDPad Rewired.IRacingWheelTemplate.dPad
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.horn
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.reverseGear
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.select
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftDown
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter9
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftUp
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.start
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.systemButton
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IRacingWheelTemplate.wheel
	{
		private get { } //Length: 58
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton1
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton10
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton2
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton3
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton4
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton5
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton6
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton7
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton8
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton9
	{
		private get { } //Length: 61
	}

	private static RacingWheelTemplate() { }

	public RacingWheelTemplate(object payload) { }

	private override IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_accelerator() { }

	private override IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_brake() { }

	private override IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_clutch() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton1() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton10() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton2() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton3() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton4() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton5() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton6() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton7() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton8() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton9() { }

	private override IControllerTemplateDPad Rewired.IRacingWheelTemplate.get_dPad() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_horn() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_reverseGear() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_select() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftDown() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter1() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter10() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter2() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter3() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter4() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter5() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter6() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter7() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter8() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter9() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftUp() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_start() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_systemButton() { }

	private override IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_wheel() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton1() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton10() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton2() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton3() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton4() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton5() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton6() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton7() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton8() { }

	private override IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton9() { }

}

