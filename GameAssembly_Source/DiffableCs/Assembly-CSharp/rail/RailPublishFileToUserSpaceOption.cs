namespace rail;

public class RailPublishFileToUserSpaceOption
{
	public RailKeyValue key_value; //Field offset: 0x10
	public string description; //Field offset: 0x18
	public List<String> tags; //Field offset: 0x20
	public EnumRailSpaceWorkShareLevel level; //Field offset: 0x28
	public string version; //Field offset: 0x30
	public string preview_path_filename; //Field offset: 0x38
	public EnumRailSpaceWorkType type; //Field offset: 0x40
	public string space_work_name; //Field offset: 0x48

	public RailPublishFileToUserSpaceOption() { }

}

