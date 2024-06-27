namespace Generics1;

public class MyStack<T>
{
    private List<T> elements;

    public MyStack()
    {
        elements = new List<T>();
    }

    // Method to get the count of elements in the stack
    public int Count()
    {
        return elements.Count;
    }

    // Method to pop an element from the stack
    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Invalid stack, Stack is empty");
        }

        // Get the last element
        T value = elements[elements.Count - 1];
        // Remove the last element
        elements.RemoveAt(elements.Count - 1);
        // Return the popped element
        return value;
    }

    // Method to push an element onto the stack
    public void Push(T item)
    {
        elements.Add(item);
    }
}
