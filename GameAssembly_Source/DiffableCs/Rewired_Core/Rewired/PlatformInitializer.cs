namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal abstract class PlatformInitializer
{

	protected PlatformInitializer() { }

	public abstract IElementIdentifierTool CreateTool(string inputSourceString) { }

	public abstract object Initialize(IConfigVars_Internal configVars) { }

}

