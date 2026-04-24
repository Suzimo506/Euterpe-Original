namespace Antlr3.Runtime.PCL.Output;

public interface IOutputStream
{

	public void ReportProgress(double progress, string key, string message) { }

	public void Write(string text) { }

	public void WriteLine() { }

	public void WriteLine(string text) { }

	public void WriteLine(object someObject) { }

}

