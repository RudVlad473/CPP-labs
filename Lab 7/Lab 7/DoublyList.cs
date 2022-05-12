using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DoublyNode<T>
{
    public DoublyNode(T data)
    {
        Data = data;
    }
    public T Data { get; set; }
    public DoublyNode<T> Previous { get; set; }
    public DoublyNode<T> Next { get; set; }
}

public class DoublyLinkedList<T> : IEnumerable<T> where T: IComparable<T>  
{
    DoublyNode<T> head; 
    DoublyNode<T> tail;
    int count;

    // добавление элемента
    public void Add(T data)
    {
        DoublyNode<T> node = new DoublyNode<T>(data);

        if (head == null)
            head = node;
        else
        {
            tail.Next = node;
            node.Previous = tail;
        }
        tail = node;
        count++;
    }
    public void AddFirst(T data)
    {
        DoublyNode<T> node = new DoublyNode<T>(data);
        DoublyNode<T> temp = head;
        node.Next = temp;
        head = node;
        if (count == 0)
            tail = head;
        else
            temp.Previous = node;
        count++;
    }
    // удаление
    public bool Remove(T data)
    {
        DoublyNode<T> current = head;

        
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                break;
            }
            current = current.Next;
        }
        if (current != null)
        {
            
            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                
                tail = current.Previous;
            }

           
            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                
                head = current.Next;
            }
            count--;
            return true;
        }
        return false;
    }

    public int Count { get { return count; } }
    public bool IsEmpty { get { return count == 0; } }

    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public bool Contains(T data)
    {
        DoublyNode<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;
            current = current.Next;
        }
        return false;
    }

    public void Sort()
    {
        if (head == null) return;

        int sublistSize = 1;
        int mergeCount;

        var m_head = head;
        do
        {
            var firstList = head;
            var origin = head;
            m_head = null;
            DoublyNode<T> tail = null;

            mergeCount = 0;
            while (firstList != null)
            {
                mergeCount++;
                var secondList = firstList;
                int firstListSize = 0;
                for (int i = 0; i < sublistSize && secondList != null; i++)
                {
                    firstListSize++;
                    secondList = secondList.Next == origin ? null : secondList.Next;
                }

                var secondListSize = sublistSize;
                while (firstListSize > 0 || (secondListSize > 0 && secondList != null))
                {
                    DoublyNode<T> current;
                    if (firstListSize != 0 && 
                        ((secondListSize == 0 || secondList == null) 
                        || firstList.Data.CompareTo(secondList.Data) == -1))
                    {
                        current = firstList; 
                        firstList = firstList.Next; 
                        firstListSize--;
                        if (firstList == origin) firstList = null;
                    }
                    else
                    {
                        current = secondList; 
                        secondList = secondList.Next; 
                        secondListSize--;
                        if (secondList == origin) secondList = null;
                    }

                    if (tail != null)
                        tail.Next = current;
                    else
                        head = current;

                    current.Previous = tail;
                    tail = current;
                }
                firstList = secondList;
            }
            tail.Next = head;
            head.Previous = tail;
            sublistSize *= 2;
        } while (mergeCount > 1);
        head = m_head;
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        DoublyNode<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    public IEnumerable<T> BackEnumerator()
    {
        DoublyNode<T> current = tail;
        while (current != null)
        {
            yield return current.Data;
            current = current.Previous;
        }
    }

    public DoublyNode<T>? this[int i]
    {
        get
        {
            if (i < 0 || i >= count)
                throw new ArgumentException("\n\tВыход за пределы структуры");

            var temp = head;
            for (int j = 0; j < i; j++ )
            {
                temp = temp.Next;
            }
            return temp;
        }
        set
        {
            var temp = head;
            for (int j = 0; j < i; j++)
            {
                temp = temp.Next;
            }
            temp.Data = value.Data;
        }
    }

    public System.Collections.IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}




