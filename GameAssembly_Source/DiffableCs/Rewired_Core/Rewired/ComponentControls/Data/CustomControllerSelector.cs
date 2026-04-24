namespace Rewired.ComponentControls.Data;

[CustomClassObfuscation]
public sealed class CustomControllerSelector
{
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _findUsingSourceId; //Field offset: 0x10
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _sourceId; //Field offset: 0x14
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _findUsingTag; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _tag; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _findInPlayer; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _playerId; //Field offset: 0x2C

	public bool findInPlayer
	{
		 get { } //Length: 5
		 set { } //Length: 9
	}

	public bool findUsingSourceId
	{
		 get { } //Length: 5
		 set { } //Length: 9
	}

	public bool findUsingTag
	{
		 get { } //Length: 5
		 set { } //Length: 9
	}

	public int playerId
	{
		 get { } //Length: 4
		 set { } //Length: 9
	}

	public int sourceId
	{
		 get { } //Length: 4
		 set { } //Length: 33
	}

	public string tag
	{
		 get { } //Length: 5
		 set { } //Length: 57
	}

	public CustomControllerSelector() { }

	public bool get_findInPlayer() { }

	public bool get_findUsingSourceId() { }

	public bool get_findUsingTag() { }

	public int get_playerId() { }

	public int get_sourceId() { }

	public string get_tag() { }

	internal CustomController GetCustomController() { }

	private void GGUFBODifwtqRTAdHQHNIcUblmBKc() { }

	public void set_findInPlayer(bool value) { }

	public void set_findUsingSourceId(bool value) { }

	public void set_findUsingTag(bool value) { }

	public void set_playerId(int value) { }

	public void set_sourceId(int value) { }

	public void set_tag(string value) { }

}

