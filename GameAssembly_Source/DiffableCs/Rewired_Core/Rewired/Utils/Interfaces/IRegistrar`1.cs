namespace Rewired.Utils.Interfaces;

public interface IRegistrar
{

	public void Deregister(T registrant) { }

	public void Register(T registrant) { }

}

