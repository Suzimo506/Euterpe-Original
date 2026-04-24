namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class SteamActionSet
{
	public readonly string name; //Field offset: 0x10
	public readonly ulong handle; //Field offset: 0x18
	public readonly Dictionary<String, SteamAction> actions; //Field offset: 0x20

	public SteamActionSet(string unnamed_param_0, ulong unnamed_param_1) { }

	public void AddAction(SteamAction action) { }

}

