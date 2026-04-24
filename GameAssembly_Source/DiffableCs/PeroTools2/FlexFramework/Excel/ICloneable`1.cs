namespace FlexFramework.Excel;

public interface ICloneable
{

	public T DeepClone() { }

	public T ShallowClone() { }

}

