namespace PeroTools2.GeneralLocalization.Modles;

public class FontAssetOption : OptionGeneric<FontAssetSource, FontAsset>
{

	public FontAssetOption() { }

	protected virtual FontAsset DefaultValue(Localization localization) { }

	protected virtual void OnApply(FontAssetSource source, Localization localization) { }

}

