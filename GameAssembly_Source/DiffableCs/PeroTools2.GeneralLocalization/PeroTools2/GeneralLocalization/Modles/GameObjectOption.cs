namespace PeroTools2.GeneralLocalization.Modles;

public class GameObjectOption : OptionGeneric<GameObjectSource, Boolean>
{

	public GameObjectOption() { }

	protected virtual void OnApply(GameObjectSource source, Localization localization) { }

}

