namespace ZenFulcrum.EmbeddedBrowser;

public interface IPromise
{

	public PromisedT Value
	{
		 get { } //Length: 0
	}

	public IPromise<PromisedT> Catch(Action<Exception> onRejected) { }

	public void Done(Action<PromisedT> onResolved, Action<Exception> onRejected) { }

	public void Done(Action<PromisedT> onResolved) { }

	public void Done() { }

	public PromisedT get_Value() { }

	public IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected) { }

	public IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved) { }

	public IPromise Then(Func<PromisedT, IPromise> onResolved) { }

	public IPromise<PromisedT> Then(Action<PromisedT> onResolved) { }

	public IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved, Action<Exception> onRejected) { }

	public IPromise<PromisedT> Then(Action<PromisedT> onResolved, Action<Exception> onRejected) { }

	public IPromise<ConvertedT> Then(Func<PromisedT, ConvertedT> transform) { }

	public IPromise<IEnumerable`1<ConvertedT>> ThenAll(Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public IPromise ThenAll(Func<PromisedT, IEnumerable`1<IPromise>> chain) { }

	public IPromise ThenRace(Func<PromisedT, IEnumerable`1<IPromise>> chain) { }

	public IPromise<ConvertedT> ThenRace(Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public IEnumerator ToWaitFor(bool abortOnFail = false) { }

	[Obsolete]
	public IPromise<ConvertedT> Transform(Func<PromisedT, ConvertedT> transform) { }

	public IPromise<PromisedT> WithName(string name) { }

}

