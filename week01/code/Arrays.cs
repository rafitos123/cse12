public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        //COMMENTS
        //first -> create an array of doubles that is the size of length
        //second -> fill the array with multiples of number using a for loop.  
        //The first element should be number, the second should be number * 2, the third should be number * 3, etc
        //return the array of multiples of number

        var multiples = new double[length];
        for (var i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //COMMENTS
        //first -> create a new list of integers that is the same size as data
        //second -> fill the new list with the values from data but in the correct rotated position using a for loop
        //(i + amount) % data.Count will give the correct index in the new list for the value at index i in data
        //third -> clear the data list and add all the values from the new list back into data using the AddRange method

        List<int> rotated = new List<int>(new int[data.Count]);
        for (var i = 0; i < data.Count; i++)
        {
            var newIndex = (i + amount) % data.Count;
            rotated[newIndex] = data[i];
        }

        data.Clear();
        data.AddRange(rotated);    
    }
}
