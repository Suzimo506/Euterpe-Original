namespace Rewired;

public sealed class InputLayout
{
	[CustomObfuscation]
	[SerializeField]
	private string _name; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	private string _descriptiveName; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private int _id; //Field offset: 0x20

	public internal string descriptiveName
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal int id
	{
		 get { } //Length: 4
		internal set { } //Length: 4
	}

	public internal string name
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public InputLayout() { }

	public InputLayout(InputLayout unnamed_param_0) { }

	public InputLayout Clone() { }

	internal void FMGZevJqvRRmnTSSJuVBRJiDdbHGA(string unnamed_param_0) { }

	public string get_descriptiveName() { }

	public int get_id() { }

	public string get_name() { }

	internal void KyvbRlfYYXPzrDbOConEVpBYBOPj(int unnamed_param_0) { }

	internal void rKELzcKdPKjgXiRmMKLIZvlrcQUeA(string unnamed_param_0) { }

}

