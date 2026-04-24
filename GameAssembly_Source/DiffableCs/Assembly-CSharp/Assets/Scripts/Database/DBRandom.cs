namespace Assets.Scripts.Database;

public class DBRandom : BaseDatabase
{
	internal enum RandomType
	{
		Loading = 0,
		Count = 1,
	}

	private PeroRandom[] m_PeroRandoms; //Field offset: 0x10

	public DBRandom() { }

	public virtual void AwakeInit() { }

	public void InitDatabase() { }

	public int Next(RandomType randomType) { }

	public virtual void Release() { }

	public void Reset(RandomType randomType) { }

	private void ResetAll() { }

	public void Shuffle(RandomType randomType) { }

}

