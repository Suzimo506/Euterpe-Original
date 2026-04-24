namespace PeroTools2.GeneralLocalization;

public abstract class SourceGeneric : Source
{
	public T target; //Field offset: 0x0

	protected SourceGeneric`1() { }

	public virtual void Default(Localization localiation) { }

	protected override T DefaultSource(Localization localiation) { }

	public virtual object GetSourceTarget() { }

}

