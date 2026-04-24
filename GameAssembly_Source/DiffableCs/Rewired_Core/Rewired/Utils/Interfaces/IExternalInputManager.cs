namespace Rewired.Utils.Interfaces;

public interface IExternalInputManager
{

	public void Deinitialize() { }

	public object Initialize(Platform platform, object configVars) { }

}

