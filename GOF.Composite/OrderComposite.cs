﻿
internal abstract class OrderComposite
{
    protected string name;
    // Constructor
    public OrderComposite(string name)
    {
        this.name = name;
    }
    public abstract void Add(OrderComposite c);
    public abstract void Remove(OrderComposite c);
    public abstract void Display(int depth);
}