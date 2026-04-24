namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

public class ScaleOption : OptionGeneric<ScaleSource, Property>
{
	internal class Property
	{
		public Vector3 scale; //Field offset: 0x10

		public Property() { }

	}


	public ScaleOption() { }

	protected virtual Property DefaultValue(Localization localization) { }

	protected virtual void OnApply(ScaleSource source, Localization localization) { }

}

