namespace System.ComponentModel;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Designer(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DesignerCategory]
[TypeConverter]
public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
{
	private static readonly object EventDisposed; //Field offset: 0x0
	private ISite site; //Field offset: 0x10
	private EventHandlerList events; //Field offset: 0x18

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[DesignerSerializationVisibility(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override ISite Site
	{
		 get { } //Length: 5
	}

	private static MarshalByValueComponent() { }

	public MarshalByValueComponent() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public override ISite get_Site() { }

	public override object GetService(Type service) { }

	public virtual string ToString() { }

}

