using Assignment2;

internal class Array : ICalc2
{
    private int[] _array;
     

    public Array(int[] array)
    {
        _array = array;
    }

    public int CountDistinct()
    {
        int count = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (_array[i] == _array[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                count++;
            }
        }
        return count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (var item in _array)
        {
            
            if (item == valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
}