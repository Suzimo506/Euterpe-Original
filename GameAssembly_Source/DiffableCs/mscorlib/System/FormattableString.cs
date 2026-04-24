namespace System;

public abstract class FormattableString
{

	public abstract int ArgumentCount
	{
		 get { } //Length: 0
	}

	public abstract string Format
	{
		 get { } //Length: 0
	}

	public abstract int get_ArgumentCount() { }

	public abstract string get_Format() { }

	public abstract object GetArgument(int index) { }

	public abstract Object[] GetArguments() { }

}

