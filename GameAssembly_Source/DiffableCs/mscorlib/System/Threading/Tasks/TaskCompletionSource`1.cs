namespace System.Threading.Tasks;

public class TaskCompletionSource
{
	private readonly Task<TResult> m_task; //Field offset: 0x0

	public Task<TResult> Task
	{
		 get { } //Length: 5
	}

	public TaskCompletionSource`1(TaskCreationOptions creationOptions) { }

	public TaskCompletionSource`1(object state, TaskCreationOptions creationOptions) { }

	public Task<TResult> get_Task() { }

	public void SetResult(TResult result) { }

	private void SpinUntilCompleted() { }

	public bool TrySetResult(TResult result) { }

}

