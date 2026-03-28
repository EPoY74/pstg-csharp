namespace Pstg.Domain.Modbus;

/// <summary>
/// One polling cycle for a station
/// </summary>
public sealed class PollRun
{
    public Guid Id { get; init; }
    public Guid StationId { get; init; }
    public DateTimeOffset StartedAtUtc { get; init; }
    public DateTimeOffset? FinishedAtUtc { get; private set; }
    public bool IsSuccess { get; private set; }
    public string? ErrorMessage { get; private set; }

    public void CompleteSuccessfully(DateTimeOffset finishedAtUtc)
    {
        FinishedAtUtc = finishedAtUtc;
        IsSuccess = true;
        ErrorMessage = null;
    }

    public void CompleteWithError(DateTimeOffset finishedAtUtc, string errorMessage)
    {
        FinishedAtUtc = finishedAtUtc;
        IsSuccess = false;
        ErrorMessage = null;
    }

}