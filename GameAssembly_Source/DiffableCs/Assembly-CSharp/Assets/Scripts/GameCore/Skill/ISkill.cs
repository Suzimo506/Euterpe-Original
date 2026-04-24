namespace Assets.Scripts.GameCore.Skill;

public interface ISkill
{

	public string uid
	{
		 get { } //Length: 0
	}

	public void Apply() { }

	public string get_uid() { }

}

