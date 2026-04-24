namespace rail;

public class RailVoiceCaptureSpecification
{
	public EnumRailVoiceCaptureChannel channels; //Field offset: 0x10
	public uint samples_per_second; //Field offset: 0x14
	public uint bits_per_sample; //Field offset: 0x18
	public EnumRailVoiceCaptureFormat capture_format; //Field offset: 0x1C

	public RailVoiceCaptureSpecification() { }

}

