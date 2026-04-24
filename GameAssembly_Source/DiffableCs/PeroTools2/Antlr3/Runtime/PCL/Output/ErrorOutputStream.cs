namespace Antlr3.Runtime.PCL.Output;

internal class ErrorOutputStream : IOutputStream
{

	public ErrorOutputStream() { }

	public override void ReportProgress(double progress, string key, string message) { }

	public override void Write(string text) { }

	public override void WriteLine() { }

	public override void WriteLine(string text) { }

	public override void WriteLine(object someObject) { }

}

