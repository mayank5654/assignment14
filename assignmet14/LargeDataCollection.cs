using System;

class LargeDataCollection : IDisposable
{
    private int[] data; // Internal array to hold data

    // Property to get the length of the collection

    public int Length
    {
        get { return data.Length; }
    }

    // Constructor to initialize the collection with initial data
    public LargeDataCollection(int[] initialData)
    {
        
        data = initialData;
    }


    // Implement logic to add an element to the collection
    // For demonstration purposes, appending the element to the end
    public void AddElement(int element)
    {
        Array.Resize(ref data, data.Length + 1);
        data[data.Length - 1] = element;
    }

    // Implement logic to remove an element from the collection
    // For demonstration purposes, removing the first occurrence of the element
    public void RemoveElement(int element)
    {
        
        int index = Array.IndexOf(data, element);
        if (index != -1)
        {
            for (int i = index; i < data.Length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            Array.Resize(ref data, data.Length - 1);
        }
    }

    // Implement logic to access an element at a specific index
    // For demonstration purposes, returning the element at the specified index
    public int GetElement(int index)
    {
        
        return data[index];
    }

    // Implement Dispose method to release resources and free up memory
    // Set the internal data structure to null
    public void Dispose()
    {
       
        data = null;
    }
}