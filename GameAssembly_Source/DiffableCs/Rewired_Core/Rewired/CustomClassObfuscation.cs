namespace Rewired;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal sealed class CustomClassObfuscation : Attribute
{
	public bool renamePubIntMembers; //Field offset: 0x10
	public bool renamePrivateMembers; //Field offset: 0x11

	public CustomClassObfuscation() { }

}

