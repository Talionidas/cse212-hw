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

        //We beed a loop to iterate through the given lenght of the number in question, in this case i amount
        //Within this loop we need to calculate the multiple of the selected number for each slot
        //Each of these newly calculated multiples need to be stored in the array
        //upon completion of the loop the finished array should be showed.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
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

        //We need to figure out where the list needs to be split - that point will be data.Count - amount
        //Create a list with the values from the split pointto the end of the original list which will then move to the front after the rotation.
        //Create a second list with all values from the start of the original list up to the split point.
        //Empty the original list so we can repopulate it
        //Add the first new list and then afterwards the second new list

        int splitPoint = data.Count - amount;

        List<int> endPortion = data.GetRange(splitPoint, amount);

        List<int> beginningPortion = data.GetRange(0, splitPoint);

        data.Clear();

        data.AddRange(endPortion);

        data.AddRange(beginningPortion);

    }
}
