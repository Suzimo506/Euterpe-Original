namespace ZenFulcrum.EmbeddedBrowser;

public interface IPendingPromise : IRejectable
{

	public void Resolve(PromisedT value) { }

}

