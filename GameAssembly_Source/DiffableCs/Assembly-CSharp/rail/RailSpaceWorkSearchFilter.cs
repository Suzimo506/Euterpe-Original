namespace rail;

public class RailSpaceWorkSearchFilter
{
	public string search_text; //Field offset: 0x10
	public bool match_all_required_tags; //Field offset: 0x18
	public List<RailKeyValue> required_metadata; //Field offset: 0x20
	public bool match_all_required_metadata; //Field offset: 0x28
	public List<String> required_tags; //Field offset: 0x30
	public List<RailKeyValue> excluded_metadata; //Field offset: 0x38
	public List<String> excluded_tags; //Field offset: 0x40

	public RailSpaceWorkSearchFilter() { }

}

