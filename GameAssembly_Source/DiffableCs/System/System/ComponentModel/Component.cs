namespace System.ComponentModel;

[ClassInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DesignerCategory]
public class Component : MarshalByRefObject
{
	private static readonly object EventDisposed; //Field offset: 0x2C927BC

	protected override bool CanRaiseEvents
	{
		 get { } //Length: 3
	}

	internal bool CanRaiseEventsInternal
	{
		internal get { } //Length: 17
	}

	private static Component() { }

	protected override bool get_CanRaiseEvents() { }

	internal bool get_CanRaiseEventsInternal() { }

}

