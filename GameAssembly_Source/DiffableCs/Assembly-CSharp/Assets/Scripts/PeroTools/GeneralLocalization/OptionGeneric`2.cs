namespace Assets.Scripts.PeroTools.GeneralLocalization;

public abstract class OptionGeneric : Option
{
	public TValue value; //Field offset: 0x0

	protected OptionGeneric`2() { }

	public virtual void Apply(Localization localization) { }

	public virtual void Default(Localization localization) { }

	protected override TValue DefaultValue(Localization localization) { }

	protected abstract void OnApply(TSource source, Localization localization) { }

}

