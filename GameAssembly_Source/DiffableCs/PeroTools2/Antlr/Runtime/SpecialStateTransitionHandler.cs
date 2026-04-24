namespace Antlr.Runtime;

public sealed class SpecialStateTransitionHandler : MulticastDelegate
{

	public SpecialStateTransitionHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(DFA dfa, int s, IIntStream input, AsyncCallback callback, object object) { }

	public override int EndInvoke(IAsyncResult result) { }

	public override int Invoke(DFA dfa, int s, IIntStream input) { }

}

