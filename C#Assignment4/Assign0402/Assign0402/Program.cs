using System;
class MyList<T>
{
    T Add;
    T DeleteAt;
    int count;
    List<T> list;
    public MyList(int maxLength)
    {
        count = maxLength;
        List<T> ts = new List<T>();
    }

    public void add(T element)
    {
        this.Add = element;

    }

    public bool remove(T element)
    {
        return this.remove(element);
        
    }

    public bool contains(T element)
    {
        return this.contains(element);
        
    }

    public void clear()
    {
        this.clear();
    }

    public void insertAt(T element, int index)
    {
        this.insertAt(element, index);
    }

    public void deleteAt(int inidex)
    {
        this.deleteAt(inidex);
    }

    public bool find(int index)
    {
        return this.find(index);
    }

}