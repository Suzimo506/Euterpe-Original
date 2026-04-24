namespace rail;

public interface IRailTextInputHelper
{

	public void GetTextInputContent(out string content) { }

	public RailResult HideTextInputWindow() { }

	public RailResult ShowTextInputWindow(RailTextInputWindowOption options) { }

}

