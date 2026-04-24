namespace Unity.Jobs.LowLevel.Unsafe;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeType]
public static class JobsUtility
{
	internal struct JobScheduleParameters
	{
		public JobHandle Dependency; //Field offset: 0x0
		public int ScheduleMode; //Field offset: 0x10
		public IntPtr ReflectionData; //Field offset: 0x18
		public IntPtr JobDataPtr; //Field offset: 0x20

	}


}

