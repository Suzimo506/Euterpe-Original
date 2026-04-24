namespace PeroTools2.GeneralLocalization.Modles;

public abstract class LocalizeSheetOptionBase : OptionGeneric<TSource, EmptyValue<TSource, TComp>>
{
	internal struct EmptyValue
	{

	}


	protected LocalizeSheetOptionBase`2() { }

	protected abstract void OnApply(TSource source, string text) { }

	protected virtual void OnApply(TSource source, Localization localization) { }

}

