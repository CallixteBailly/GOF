namespace GOF.Template.Method;

public abstract class DataAccessor
{
    public abstract void Connect();
    public abstract void Select();
    public abstract void Process(int top);
    public abstract void Disconnect();

    public void Run(int top)
    {
        Connect();
        Select();
        Process(top);
        Disconnect();
    }
}
