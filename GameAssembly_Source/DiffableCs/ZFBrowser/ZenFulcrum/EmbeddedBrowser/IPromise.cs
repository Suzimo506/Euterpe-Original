namespace ZenFulcrum.EmbeddedBrowser;

public interface IPromise
{

	public IPromise Catch(Action<Exception> onRejected) { }

	public void Done(Action onResolved, Action<Exception> onRejected) { }

	public void Done(Action onResolved) { }

	public void Done() { }

	public IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved, Action<Exception> onRejected) { }

	public IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved) { }

	public IPromise Then(Func<IPromise> onResolved) { }

	public IPromise Then(Action onResolved) { }

	public IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected) { }

	public IPromise Then(Action onResolved, Action<Exception> onRejected) { }

	public IPromise ThenAll(Func<IEnumerable`1<IPromise>> chain) { }

	public IPromise<IEnumerable`1<ConvertedT>> ThenAll(Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public IPromise<ConvertedT> ThenRace(Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public IPromise ThenRace(Func<IEnumerable`1<IPromise>> chain) { }

	public IPromise ThenSequence(Func<IEnumerable`1<Func`1<IPromise>>> chain) { }

	public IEnumerator ToWaitFor(bool abortOnFail = false) { }

	public IPromise WithName(string name) { }

}

