namespace rail;

public class IRailTextInputHelperImpl : RailObject, IRailTextInputHelper
{

	internal IRailTextInputHelperImpl(IntPtr cPtr) { }

	protected virtual void Finalize() { }

	public override void GetTextInputContent(out string content) { }

	public override RailResult HideTextInputWindow() { }

	public override RailResult ShowTextInputWindow(RailTextInputWindowOption options) { }

}

