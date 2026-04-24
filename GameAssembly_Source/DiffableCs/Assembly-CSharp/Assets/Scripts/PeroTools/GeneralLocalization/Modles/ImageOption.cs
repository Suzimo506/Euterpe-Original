namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

public class ImageOption : OptionGeneric<ImageSource, Sprite>
{

	public ImageOption() { }

	protected virtual void OnApply(ImageSource source, Localization localization) { }

}

