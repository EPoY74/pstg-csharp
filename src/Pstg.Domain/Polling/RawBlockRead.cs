using Pstg.Domain.Modbus;

namespace Pstg.Domain.Polling;

public sealed class RawBlockRead
{
    public Guid Id { get; init; }
    public Guid PollRunnId { get; init; }
    public ModbusFunctionCode FunctionCode { get; init; }
    public ushort StartAdress { get; init; }
    public ushort RegisterCount { get; init; }
    public IReadOnlyList<ushort> Registers { get; private set; } = Array.Empty<ushort>();
    public bool IsSuccess { get; private set; }
    public string? ErrorMessage {get; private set; }
    public int DurationMs { get; private set; }

    public void CompliteSuccessfully(IReadOnlyList<ushort> registers, int durationsMs)
    {
        Registers = registers;
        DurationMs = durationsMs;
        IsSuccess = true;
        ErrorMessage = null;

    }

    public void CompleteWithError(string errorMessage, int durationsMs)
    {
        Registers = Array.Empty<ushort>();
        DurationMs = durationsMs;
        IsSuccess = false;
        ErrorMessage = errorMessage;

    }


     
}