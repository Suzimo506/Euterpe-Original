namespace Assets.Scripts.Database;

public class FailBarrageLocalConfig : BaseDataObject
{
	public int index; //Field offset: 0x20
	public String[] barrages; //Field offset: 0x28

	public FailBarrageLocalConfig() { }

}

