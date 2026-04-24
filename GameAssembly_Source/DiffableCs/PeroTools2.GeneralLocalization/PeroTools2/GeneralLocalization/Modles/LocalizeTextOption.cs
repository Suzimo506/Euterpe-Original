namespace PeroTools2.GeneralLocalization.Modles;

public sealed class LocalizeTextOption : LocalizeSheetOptionBase<LocalizeTextSource, Text>
{

	public LocalizeTextOption() { }

	protected virtual void OnApply(LocalizeTextSource source, string text) { }

}

