namespace nn.hid;

[Flags]
public enum NpadAttribute
{
	None = 0,
	IsConnected = 1,
	IsWired = 2,
	IsLeftConnected = 4,
	IsLeftWired = 8,
	IsRightConnected = 16,
	IsRightWired = 32,
}

