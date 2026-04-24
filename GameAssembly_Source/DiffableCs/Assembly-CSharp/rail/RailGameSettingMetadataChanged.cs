namespace rail;

public class RailGameSettingMetadataChanged : EventBase
{
	public List<RailKeyValue> key_values; //Field offset: 0x30
	public RailGameSettingMetadataChangedSource source; //Field offset: 0x38

	public RailGameSettingMetadataChanged() { }

}

