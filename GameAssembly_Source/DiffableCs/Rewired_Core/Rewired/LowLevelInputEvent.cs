namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal struct LowLevelInputEvent
{
	private const int mrFblBbwPMzusaEtodRhOnLMZITHA = 4; //Field offset: 0x0
	public const int byteIndex_elementsStart = 12; //Field offset: 0x0
	public const int byteIndex_id = 0; //Field offset: 0x0
	private const int VNOBsxegYUEqurffmwtYomjQmclgA = 4; //Field offset: 0x0
	private const int wxlWMNtXMRdctKJmtnokOJAGuVev = 4; //Field offset: 0x0
	public const int byteIndex_timestamp = 4; //Field offset: 0x0
	public const int buttonsPerPage = 32; //Field offset: 0x0
	private const int DFgIyoeuWZFyJxIUyqIIoOuLVYZW = 12; //Field offset: 0x0
	private const int EXOXKdKBTbdKIdIFnMNbJKceymYUA = 8; //Field offset: 0x0
	public const int bytesPerButtonPage = 4; //Field offset: 0x0
	public IntPtr _buffer; //Field offset: 0x0
	private int yFLfGoVnJCWdeWgzyKzAnyrBMpmT; //Field offset: 0x8
	private int TshEvKgeTSbAhQpxLCDjEaXdzmKT; //Field offset: 0xC
	private int bMWUdVcbaRUQKxqfXXruqPutnJrS; //Field offset: 0x10
	private int cbPulzVXVZDmcjaqXRSiybMbBFry; //Field offset: 0x14
	private int ATEnwGpbHDUksVTGOfuCypCqeAujA; //Field offset: 0x18
	private int KxRsnrZzHohrqvMOuGxzVGLwqoas; //Field offset: 0x1C

	public int axisCount
	{
		 get { } //Length: 4
	}

	public int buttonCount
	{
		 get { } //Length: 4
	}

	public int byteIndex_axesStart
	{
		 get { } //Length: 4
	}

	public int byteIndex_buttonsStart
	{
		 get { } //Length: 4
	}

	public int byteIndex_hatsStart
	{
		 get { } //Length: 4
	}

	public bool isValid
	{
		 get { } //Length: 54
	}

	public LowLevelInputEvent(IntPtr unnamed_param_0, int unnamed_param_1, int unnamed_param_2, int unnamed_param_3) { }

	public int get_axisCount() { }

	public int get_buttonCount() { }

	public int get_byteIndex_axesStart() { }

	public int get_byteIndex_buttonsStart() { }

	public int get_byteIndex_hatsStart() { }

	public bool get_isValid() { }

	public float GetAxisValue(int index) { }

	public int GetButtonsBitMask(int startButtonIndex) { }

	public bool GetButtonValue(int index) { }

	public uint GetId() { }

	public static int GetReportSize(int buttonCount, int axisCount, int hatCount) { }

	public double GetTimestamp() { }

	public void SetAxisValue(int index, float value) { }

	public void SetButtonsBitMask(int bitMask, int startButtonIndex) { }

	public void SetId(uint id) { }

	public void SetTimestamp(double value) { }

}

