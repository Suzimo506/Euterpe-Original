namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

public class PositionOption : OptionGeneric<PositionSource, Property>
{
	internal class Property
	{
		public Vector3 position; //Field offset: 0x10

		public Property() { }

	}


	public PositionOption() { }

	protected virtual Property DefaultValue(Localization localization) { }

	protected virtual void OnApply(PositionSource source, Localization localization) { }

}

