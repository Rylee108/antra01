using System

class Mystack<T>
{
    int Count;
    int top;
    int Push;
    T[] stack;

    public Mystack(int MaxEements)
    {
        Count = MaxEements;
        stack = new T[MaxEements];
    }
    public void push(T element)
    {
        top = top + 1;
        stack[top] = element;
    }

    public T pop()
    {
        T removeElement;
        T temp = default(T);

        if (!(top <= 0))
        {
            removeElement = stack[top];
            top = top - 1;
            return removeElement;
        }
        return temp;
    }
}
