using System.Threading.Channels;

namespace DiffieDumper.Saver;

public class SaverQueue
{
    private readonly Channel<SaverQueueEntry> _queue;

    public SaverQueue(int capacity)
    {
        _queue = Channel.CreateBounded<SaverQueueEntry>(new BoundedChannelOptions(capacity)
        {
            FullMode = BoundedChannelFullMode.Wait
        });
    }

    public async ValueTask EnqueueAsync(SaverQueueEntry entry)
    {
        if (entry is null)
        {
            throw new ArgumentNullException(nameof(entry));
        }

        await _queue.Writer.WriteAsync(entry);
    }

    public async ValueTask<SaverQueueEntry> DequeueAsync(CancellationToken cancellationToken)
    {
        return await _queue.Reader.ReadAsync(cancellationToken);
    }
}