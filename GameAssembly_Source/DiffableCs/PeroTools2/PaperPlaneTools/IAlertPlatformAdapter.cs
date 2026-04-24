namespace PaperPlaneTools;

public interface IAlertPlatformAdapter
{

	public void Dismiss() { }

	public void HandleEvent(string name, string value) { }

	public void SetOnDismiss(Action action) { }

	public void Show(Alert alert) { }

}

